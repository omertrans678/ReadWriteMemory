using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace omertrans156.Native
{
    class Write
    {
        [DllImport("kernel32")]
        public static extern bool IsWow64Process(IntPtr hProcess, out bool lpSystemInfo);
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);
        [DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "ReadProcessMemory", ExactSpelling = true, SetLastError = true)]
        public static extern int ReadProcessMemory(IntPtr Handle, int Pointer, ref int Value, int Size = 4, int Bytes = 0);

        [DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory")]
        public static extern bool ReadProcessMemoryByte(IntPtr hProcess, int lpBaseAddress, [Out] byte[] lpBuffer, UIntPtr nSize, IntPtr lpNumberOfBytesRead);


        [DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "WriteProcessMemory", ExactSpelling = true, SetLastError = true)]
        public static extern bool WriteProcessMemory2(IntPtr ProcessHandle, int Pointer, ref int Value, int Size = 4, int Bytes = 0);
        [DllImport("kernel32.dll")]
        public static extern bool WriteProcessMemory(IntPtr hProcess, int lpBaseAddress, byte[] lpBuffer, uint nSize, uint lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        public static extern bool VirtualProtectEx(IntPtr hProcess, IntPtr lpAddress, UIntPtr dwSize, uint flNewProtect, out uint lpflOldProtect);



        [DllImport("kernel32.dll", EntryPoint = "VirtualProtectEx")]
        public static extern bool VirtualProtectEx2(IntPtr hProcess, UIntPtr lpAddress,
            IntPtr dwSize, MemoryProtection flNewProtect, out MemoryProtection lpflOldProtect);
        [Flags]
        public enum MemoryProtection : uint
        {
            Execute = 0x10,
            ExecuteRead = 0x20,
            ExecuteReadWrite = 0x40,
            ExecuteWriteCopy = 0x80,
            NoAccess = 0x01,
            ReadOnly = 0x02,
            ReadWrite = 0x04,
            WriteCopy = 0x08,
            GuardModifierflag = 0x100,
            NoCacheModifierflag = 0x200,
            WriteCombineModifierflag = 0x400
        }


    }
}
