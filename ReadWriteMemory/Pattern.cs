﻿
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using omertrans156.ReadWriteMemory.Exceptions;
using omertrans156.ReadWriteMemory.Utility;
using static omertrans156.ReadWriteMemory.Win32.Native;
using Console = omertrans156.ReadWriteMemory.Debug.Console;

namespace omertrans156.ReadWriteMemory
{
    public class Pattern
    {
        /// <summary>
        /// Scans the memory of a process for a specified pattern and returns a list of memory addresses where the pattern is found.
        /// example:
        /// <example>
        /// <code>
        /// List<IntPtr> ListOfAddresses = Pattern.Scan("ac_client.exe", "FF ?? FF 4E");
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="Process">The process to scan the memory of. It can be of type System.Diagnostics.Process, System.Diagnostics.Process[], int (Process ID), or string (Process Name).</param>
        /// <param name="pattern">The pattern to search for in the memory.</param>
        /// <returns>A list of memory addresses where the specified pattern is found.</returns>
        public static List<IntPtr> Scan(object Process, string pattern)
        {
            MultiProcess process = new MultiProcess(Process);
            if (process.Processes.Length >= 2)
                throw new TooManyProcessesException("Pattern Scan");

            IntPtr processHandle = process.Processes[0].Handle;
            List<IntPtr> foundAddresses = ScanAsRange(processHandle, pattern, new IntPtr(0), new IntPtr(0));
            return foundAddresses;
        }
        /// <summary>
        /// Scans the memory of all processes for a specified pattern and returns a list of arrays, where each array contains process information and memory addresses where the pattern is found.
        /// example:
        /// <example>
        /// <code>
        /// List<IntPtr[]> ListOfAddressesPerProcesses = Pattern.ScanAllProcess("ac_client.exe", "FF ?? FF 4E");
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="Process">The process to scan the memory of. It can be of type System.Diagnostics.Process[] or string (Process Name).</param>
        /// <param name="pattern">The pattern to search for in the memory.</param>
        /// <returns>A list of arrays, where each array contains process information and memory addresses where the specified pattern is found.</returns>
        public static List<IntPtr[]> ScanAllProcess(object Process, string pattern)
        {
            MultiProcess process = new MultiProcess(Process);
            List<IntPtr[]> foundAddresses = new List<IntPtr[]>();
            foreach (var proc in process.Processes)
            {
                IntPtr processHandle = proc.Handle;
                List<IntPtr> foundAddr = ScanAsRange(processHandle, pattern, new IntPtr(0), new IntPtr(0));
                foundAddresses.Add(foundAddr.ToArray());
            }
            return foundAddresses;
        }
        /// <summary>
        /// Scans the memory of a specified process within the specified address range for a given pattern and returns a list of memory addresses where the pattern is found.
        /// example:
        /// <example>
        /// <code>
        /// List<IntPtr> ListOfAddresses = Pattern.Scan("ac_client.exe", "FF ?? FF 4E", 0x570000, 0x580000);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="Process">The process to scan the memory of. It can be of type System.Diagnostics.Process, System.Diagnostics.Process[], int (Process ID), or string (Process Name).</param>
        /// <param name="pattern">The pattern to search for in the memory.</param>
        /// <param name="startAddress">The starting memory address to begin the scan.</param>
        /// <param name="endAddress">The ending memory address to end the scan.</param>
        /// <returns>A list of memory addresses where the specified pattern is found within the specified address range.</returns>
        public static List<IntPtr> Scan(object Process, string pattern, long startAddress, long endAddress)
        {
            MultiProcess process = new MultiProcess(Process);
            if (process.Processes.Length >= 2)
                throw new TooManyProcessesException("Pattern Scan");

            IntPtr processHandle = process.Processes[0].Handle;
            List<IntPtr> foundAddresses = ScanAsRange(processHandle, pattern, new IntPtr(startAddress), new IntPtr(endAddress));
            return foundAddresses;
        }
        /// <summary>
        /// Scans the memory of all processes for a specified pattern and returns a list of arrays, where each array contains process information and memory addresses where the pattern is found.
        /// example:
        /// <example>
        /// <code>
        /// List<IntPtr[]> ListOfAddressesPerProcesses = Pattern.ScanAllProcess("ac_client.exe", "FF ?? FF 4E", 0x570000, 0x580000);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="Process">The process to scan the memory of. It can be of type System.Diagnostics.Process[], or string (Process Name).</param>
        /// <param name="pattern">The pattern to search for in the memory.</param>
        /// <param name="startAddress">The starting memory address to begin the scan.</param>
        /// <param name="endAddress">The ending memory address to end the scan.</param>
        /// <returns>A list of memory addresses where the specified pattern is found within the specified address range.</returns>
        public static List<IntPtr[]> ScanAllProcess(object Process, string pattern, long startAddress, long endAddress)
        {
            MultiProcess process = new MultiProcess(Process);
            List<IntPtr[]> foundAddresses = new List<IntPtr[]>();
            foreach (var proc in process.Processes)
            {
                IntPtr processHandle = proc.Handle;
                List<IntPtr> foundAddr = ScanAsRange(processHandle, pattern, new IntPtr(startAddress), new IntPtr(endAddress));
                foundAddresses.Add(foundAddr.ToArray());
            }
            return foundAddresses;
        }
        /// <summary>
        /// Scans the memory of a specified process within the memory range of a specific module for a given pattern and returns a list of memory addresses where the pattern is found.
        /// example:
        /// <example>
        /// <code>
        /// Process proc = Process.GetProcessesByName("ac_client")[0];
        /// List<IntPtr> ListOfAddressesModuleOnly = Pattern.ScanWithModule(proc, "FF ?? FF 4E", proc.MainModule);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="Process">The process to scan the memory of. It can be of type System.Diagnostics.Process, System.Diagnostics.Process[], int (Process ID), or string (Process Name).</param>
        /// <param name="pattern">The pattern to search for in the memory.</param>
        /// <param name="module">The module within which the memory scan should be performed.</param>
        /// <returns>A list of memory addresses where the specified pattern is found within the memory range of the specified module.</returns>
        public static List<IntPtr> ScanWithModule(object Process, string pattern, ProcessModule module)
        {
            MultiProcess process = new MultiProcess(Process);
            if (process.Processes.Length >= 2)
                throw new TooManyProcessesException("Pattern Scan");

            IntPtr processHandle = process.Processes[0].Handle;
            List<IntPtr> foundAddresses = ScanAsRange(processHandle, pattern, module.BaseAddress, new IntPtr(module.BaseAddress.ToInt64() + module.ModuleMemorySize));
            return foundAddresses;
        }
        /// <summary>
        /// Scans the memory of a specified process within the memory range of a specific module for a given pattern and returns a list of memory addresses where the pattern is found.
        /// example:
        /// <example>
        /// <code>
        /// Process proc = Process.GetProcessesByName("ac_client")[0];
        /// List<string> ListOfAddressesModuleOnly = Pattern.ScanWithModuleStr(proc, "FF ?? FF 4E", proc.MainModule);
        /// </code>
        /// output:
        /// ac_client.exe+17D757
        /// </example>
        /// </summary>
        /// <param name="Process">The process to scan the memory of. It can be of type System.Diagnostics.Process, System.Diagnostics.Process[], int (Process ID), or string (Process Name).</param>
        /// <param name="pattern">The pattern to search for in the memory.</param>
        /// <param name="module">The module within which the memory scan should be performed.</param>
        /// <returns>A list of memory addresses where the specified pattern is found within the memory range of the specified module.</returns>
        public static List<string> ScanWithModuleStr(object Process, string pattern, ProcessModule module)
        {
            List<IntPtr> foundAddresses = ScanWithModule(Process, pattern, module);
            List<string> foundAddressesWithModule = new List<string>();
            foreach (var adr in foundAddresses)
                foundAddressesWithModule.Add(module.ModuleName + "+" + (adr.ToInt32()-module.BaseAddress.ToInt32()).ToString("X"));
            return foundAddressesWithModule;
        }
        private static List<IntPtr> ScanAsRange(IntPtr processHandle, string pattern, IntPtr startAddress, IntPtr endAddress)
        {
            Stopwatch kronometre = new Stopwatch();
            kronometre.Start();
            List<IntPtr> foundAddresses = new List<IntPtr>();
            IntPtr currentAddress = startAddress;
            Console.WriteLine("Set: {0}-{1} size {2}", startAddress.ToString("X"), endAddress.ToString("X"), (endAddress.ToInt64() - startAddress.ToInt64()).ToString("X"));
            while (true)
            {
                if (endAddress != IntPtr.Zero && currentAddress.ToInt64() >= endAddress.ToInt64())
                    break;
                if (VirtualQueryEx(processHandle, currentAddress, out MEMORY_BASIC_INFORMATION memInfo, (uint)Marshal.SizeOf(typeof(MEMORY_BASIC_INFORMATION))) == 0)
                    break;

                if (memInfo.BaseAddress.ToInt64() < startAddress.ToInt64())
                    memInfo.BaseAddress = startAddress;
                if ((memInfo.BaseAddress.ToInt64() + memInfo.RegionSize.ToInt64()) > endAddress.ToInt64())
                    memInfo.RegionSize = new IntPtr((endAddress.ToInt64() - startAddress.ToInt64()));
                string val1 = memInfo.BaseAddress.ToString("X");
                string val2 = IntPtr.Add(memInfo.BaseAddress, memInfo.RegionSize.ToInt32()).ToString("X");
                string val3 = memInfo.RegionSize.ToString("X");
                Console.Write("Cur: {0}-{1} size {2,8}", val1, val2, val3);
                if (memInfo.State == MEM_COMMIT && memInfo.Protect != PAGE_NOACCESS)
                {
                    List<IntPtr> moduleAddresses = ScanNow(processHandle, memInfo.BaseAddress, memInfo.RegionSize, pattern);
                    if (moduleAddresses.Count != 0)
                        Console.WriteLine("\tFound Count {0} pointer {1}", moduleAddresses.Count, moduleAddresses[0].ToString("X"));
                    else
                        Console.WriteLine("\tNo Found");
                    foundAddresses.AddRange(moduleAddresses);
                }
                else
                    Console.WriteLine("\tBlocked by " + ToPAGE(memInfo.Protect) + " " + ToMEM(memInfo.State));

                currentAddress = IntPtr.Add(memInfo.BaseAddress, (int)memInfo.RegionSize);
            }
            kronometre.Stop();
            System.Console.WriteLine("Geçen süre: {0}", kronometre.Elapsed);
            return foundAddresses;
        }
        private static List<IntPtr> ScanNow(IntPtr processHandle, IntPtr baseAddress, IntPtr regionSize, string pattern)
        {
            int[] patternBytes = ParsePattern(pattern);
            byte[] buffer = new byte[regionSize.ToInt32()];
            ReadProcessMemory(processHandle, baseAddress, buffer, buffer.Length, out _);
            List<IntPtr> addresses = ScanAlgoritmasi(buffer, patternBytes, baseAddress);
            return addresses;
        }
        public static int[] ParsePattern(string pattern)
        {
            var bytes = pattern.Split(' ');
            int[] intlist = new int[bytes.Length];

            for (int i = 0; i < intlist.Length; i++)
            {
                if (bytes[i] == "??" || bytes[i] == "?" || bytes[i] == "XX" || bytes[i] == "X")
                    intlist[i] = -1;
                else
                    intlist[i] = int.Parse(bytes[i], NumberStyles.HexNumber);
            }
            return intlist;
        }
        private static List<IntPtr> ScanAlgoritmasi(byte[] buffer, int[] pattern, IntPtr baseAddress)
        {
            var intlist = pattern;
            var results = new List<IntPtr>();
            for (int a = 0; a < buffer.Length; a++)
            {
                for (int b = 0; b < intlist.Length; b++)
                {
                    if ((a + b) >= buffer.Length)
                        break;
                    if (intlist[b] != -1 && intlist[b] != buffer[a + b])
                        break;
                    if (b + 1 == intlist.Length)
                    {
                        results.Add(new IntPtr(baseAddress.ToInt32()+a));
                    }
                }
            }
            return results;
        }
    }
}
