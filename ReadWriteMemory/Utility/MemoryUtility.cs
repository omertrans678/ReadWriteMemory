using omertrans156.ReadWriteMemory.Exceptions;
using omertrans156.ReadWriteMemory.Extensions;
using omertrans156.ReadWriteMemory.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Console = omertrans156.ReadWriteMemory.Debug.Console;
namespace omertrans156.ReadWriteMemory.Utility
{
    public class MemoryUtility
    {
        public enum DataTypeSize
        {
            ArrayBytes = 1,
            Byte = 2,
            Short = 3,
            Int = 4,
            Long = 5,
            Float = 6,
            Double = 7,
            Bool = 8,
            String = 9
        }

        internal static void Write(Utility.Process Process, object PointerOrModuleNamePointer, byte[] Value, DataTypeSize Data, params int[] WithOffset)
        {
            foreach (var proc in Process.Processes)
            {
                int Pointer = PointerGenerate(proc, PointerOrModuleNamePointer, WithOffset);
                WriteFunc(proc, Pointer, Value, Data.GetSize(Value.Length));
            }
            Process.Dispose();
        }
        internal static object Read(Utility.Process Process, object PointerOrModuleNamePointer, DataTypeSize Data, params int[] WithOffset)
        {
            if (Process.Processes.Length >= 2)
                throw new TooManyProcessesException();
            int Pointer = PointerGenerate(Process.Processes[0], PointerOrModuleNamePointer, WithOffset);
            byte[] readbytes = ReadFunc(Process.Processes[0], Pointer, Data.GetSize());
            Process.Dispose();
            return readbytes.ToData(Data);
        }
        internal static byte[] ReadC(Utility.Process Process, object PointerOrModuleNamePointer, int lenght, DataTypeSize Data, params int[] WithOffset)
        {
            if (Process.Processes.Length >= 2)
                throw new TooManyProcessesException();
            int Pointer = PointerGenerate(Process.Processes[0], PointerOrModuleNamePointer, WithOffset);
            byte[] readbytes = ReadFunc(Process.Processes[0], Pointer, Data.GetSize(lenght));
            Process.Dispose();
            return readbytes;
        }
        internal static byte[][] ReadCA(Utility.Process Process, object ModuleNameAndPointer, int lenght, DataTypeSize Data, params int[] WithOffset)
        {
            List<byte[]> data = new List<byte[]>();
            foreach (var proc in Process.Processes)
            {
                int Pointer = PointerGenerate(proc, ModuleNameAndPointer, WithOffset);
                byte[] readbytes = ReadFunc(Process.Processes[0], Pointer, Data.GetSize(lenght));
                data.Add(readbytes);
            }
            Process.Dispose();
            return data.ToArray();
        }
        internal static object[] ReadA(Utility.Process Process, string ModuleNameAndPointer, DataTypeSize Data, params int[] WithOffset)
        {
            List<object> data = new List<object>();
            foreach (var proc in Process.Processes)
            {
                int Pointer = PointerGenerate(proc, ModuleNameAndPointer, WithOffset);
                byte[] readbytes = ReadFunc(proc, Pointer, Data.GetSize());
                data.Add(readbytes);
            }
            Process.Dispose();
            return data.ToArray();
        }
        private static int PointerGenerate(System.Diagnostics.Process proc, object PointerOrModuleNamePointer, int[] WithOffset = null)
        {
            int Pointer;
            if (PointerOrModuleNamePointer is string ModuleNamePointer)
                Pointer = PointerBasedOnModuleName(proc, ModuleNamePointer);
            else if (PointerOrModuleNamePointer is int pointer)
                Pointer = pointer;
            else
                throw new InvalidPointerException(PointerOrModuleNamePointer);

            if (WithOffset != null)
                Pointer = PointerBasedOnOffset(proc, Pointer, WithOffset);
            if (Pointer == 0)
                throw new PointerNotFoundAfterOffsetException();
            return Pointer;
        }
        private static int PointerBasedOnOffset(System.Diagnostics.Process proc, int Pointer, int[] Offset)
        {
            IntPtr handle = proc.Handle;
            int pointer = Pointer;
            Console.WriteLine("PID: " + proc.Id + "(" + proc.Id.ToString("X") + ")" + " Pointer: " + pointer.ToString("X"));
            foreach (var off in Offset)
            {
                int oldPointer = pointer;
                Console.Write(oldPointer.ToString("X") + " -> \t");
                Native.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                Console.Write("[" + pointer.ToString("X") + "+" + off.ToString("X") + "] -> ");
                pointer += off;
            }
            Console.WriteLine("return Pointer: " + pointer.ToString("X"));
            return pointer;
        }
        private static int PointerBasedOnModuleName(System.Diagnostics.Process proc, string ModuleNameAndPointer)
        {
            int ModuleBaseAdr = SearchModule(proc, ModuleNameAndPointer.Split('+').First().Replace("\"", "")).BaseAddress.ToInt32();
            int Pointer = ModuleNameAndPointer.Split('+').Last().ToInt("X");
            //Console.WriteLine("ModuleBaseAdr: " + ModuleBaseAdr.ToString("X") + " Pointer: " + Pointer.ToString("X"));
            Pointer += ModuleBaseAdr;
            //Console.WriteLine("return Total (Module+Pointer) pointer: " + Pointer.ToString("X"));
            return Pointer;
        }
        private static bool WriteFunc(System.Diagnostics.Process proc, int Pointer, byte[] Value, int size = 4)
        {
            IntPtr handle = proc.Handle;
            Native.MemoryProtection newProtection = Native.MemoryProtection.ExecuteReadWrite;
            bool Is64Bit = Environment.Is64BitOperatingSystem && (Native.IsWow64Process(handle, out bool retVal) && !retVal);
            Native.VirtualProtectEx2(handle, (UIntPtr)Pointer, (IntPtr)(Is64Bit ? 8 : 4), newProtection, out Native.MemoryProtection OldMemProt);
            bool flag = Native.WriteProcessMemory(handle, Pointer, Value, (uint)size, 0);
            Native.VirtualProtectEx2(handle, (UIntPtr)Pointer, (IntPtr)(Is64Bit ? 8 : 4), OldMemProt, out _);

            if (!flag)
                throw new FailedWriteMemoryException();
            return flag;
        }
        private static byte[] ReadFunc(System.Diagnostics.Process proc, int Pointer, int Lenght)
        {
            IntPtr handle = proc.Handle;
            byte[] ReadBytes = new byte[Lenght];
            bool errorstats = Native.ReadProcessMemoryByte(handle, Pointer, ReadBytes, (UIntPtr)Lenght, IntPtr.Zero);

            if (!errorstats)
                throw new FailedReadMemoryException();
            return ReadBytes;
        }
        public static ProcessModule SearchModule(System.Diagnostics.Process proc, string TargetModuleName)
        {
            //Search Starts With 'file'
            ProcessModule[] modules = proc.Modules.Cast<ProcessModule>()
            .Where(module => module.ModuleName.StartsWith(TargetModuleName))
            .ToArray();
            if (modules.Length == 0)
                throw new ModuleNotFoundException(TargetModuleName);
            if (modules.Length >= 2)
                throw new TooManyModulesException();
            return modules[0];
        }

    }
}
