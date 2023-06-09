using System;
using System.Runtime.InteropServices;

namespace omertrans156.ReadWriteMemory.Win32
{
    internal class Native
    {
        [DllImport("kernel32")]
        public static extern bool IsWow64Process(IntPtr hProcess, out bool lpSystemInfo);
        [DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "ReadProcessMemory", ExactSpelling = true, SetLastError = true)]
        public static extern int ReadProcessMemory(IntPtr Handle, int Pointer, ref int Value, int Size = 4, int Bytes = 0);

        [DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory", SetLastError = true)]
        public static extern bool ReadProcessMemoryByte(IntPtr hProcess, int lpBaseAddress, [Out] byte[] lpBuffer, UIntPtr nSize, IntPtr lpNumberOfBytesRead);
        [DllImport("kernel32.dll")]
        public static extern bool WriteProcessMemory(IntPtr hProcess, int lpBaseAddress, byte[] lpBuffer, uint nSize, uint lpNumberOfBytesWritten);

        #region VirtualProtectEx
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


        //AoB scan
        [StructLayout(LayoutKind.Sequential)]
        public struct MEMORY_BASIC_INFORMATION
        {
            public IntPtr BaseAddress;          // Bellek bölgesinin başlangıç adresini temsil eder.
            public IntPtr AllocationBase;       // Bellek ayrıldığında atanan başlangıç adresini temsil eder.
            public uint AllocationProtect;      // Belleğin ayrıldığı koruma düzeyini temsil eder.
            public IntPtr RegionSize;           // Bellek bölgesinin boyutunu temsil eder.
            public uint State;                  // Bellek bölgesinin durumunu temsil eder (örn. MEM_COMMIT, MEM_RESERVE).
            public uint Protect;                // Bellek bölgesinin koruma düzeyini temsil eder (örn. PAGE_READONLY, PAGE_READWRITE).
            public uint Type;                   // Bellek bölgesinin tipini temsil eder (örn. MEM_PRIVATE, MEM_MAPPED).
        }
        #endregion

        #region OpenProcess
        [DllImport("kernel32.dll", EntryPoint = "OpenProcess", SetLastError = true)]
        public static extern IntPtr OpenProcess(ProcessAccessFlags processAccess, bool bInheritHandle, int processId);
        // ProcessAccessFlags numaralandırma türü, belleğe erişim sağlamak için kullanılan işlem erişim bayraklarını temsil eder.
        // İşte bazı yaygın kullanılan işlem erişim bayrakları ve değerleri:

        // - All: Tüm erişim bayraklarını temsil eder. Değer: 0x001F0FFF

        // Diğer yaygın işlem erişim bayrakları:
        // - Terminate: İşlemi sonlandırma erişim bayrağını temsil eder. Değer: 0x00000001
        // - CreateThread: İşlem için yeni bir iş parçacığı oluşturma erişim bayrağını temsil eder. Değer: 0x00000002
        // - VMOperation: Bellek operasyonu erişim bayrağını temsil eder. Değer: 0x00000008
        // - VMRead: Bellek okuma erişim bayrağını temsil eder. Değer: 0x00000010
        // - VMWrite: Bellek yazma erişim bayrağını temsil eder. Değer: 0x00000020
        // - DupHandle: İşlem kolu çoğaltma erişim bayrağını temsil eder. Değer: 0x00000040
        // - SetInformation: Bilgi ayarlama erişim bayrağını temsil eder. Değer: 0x00000200
        // - QueryInformation: Bilgi sorgulama erişim bayrağını temsil eder. Değer: 0x00000400
        // - Synchronize: Senkronize erişim bayrağını temsil eder. Değer: 0x00100000

        // ProcessAccessFlags numaralandırma türü, işlem erişim bayraklarını daha kolay kullanmanıza ve anlamanıza yardımcı olur.
        // İlgili işlem erişim bayrağını belirtmek için bu numaralandırmayı kullanabilirsiniz.
        public enum ProcessAccessFlags : uint
        {
            All = 0x001F0FFF,
            Terminate = 0x00000001,
            CreateThread = 0x00000002,
            VMOperation = 0x00000008,
            VMRead = 0x00000010,
            VMWrite = 0x00000020,
            DupHandle = 0x00000040,
            SetInformation = 0x00000200,
            QueryInformation = 0x00000400,
            Synchronize = 0x00100000
        }

        #endregion

        #region VirtualQueryEx
        // https://learn.microsoft.com/en-us/windows/win32/api/memoryapi/nf-memoryapi-virtualquery 
        [DllImport("kernel32.dll")]
        public static extern uint VirtualQueryEx(IntPtr hProcess, IntPtr lpAddress, out MEMORY_BASIC_INFORMATION lpBuffer, uint dwLength);

        // https://learn.microsoft.com/en-us/windows/win32/api/winnt/ns-winnt-memory_basic_information
        public const uint MEM_COMMIT = 0x1000;          // Bellek ayrıldığında kullanılan sabit
        public const uint MEM_RESERVE = 0x2000;         // Bellek rezerve edildiğinde kullanılan sabit
        public const uint MEM_RELEASE = 0x8000;         // Bellek serbest bırakıldığında kullanılan sabit

        public const uint PAGE_NOACCESS = 0x01;         // Sayfa erişilemez olduğunda kullanılan sabit
        public const uint PAGE_READONLY = 0x02;         // Sayfa salt okunur olduğunda kullanılan sabit
        public const uint PAGE_READWRITE = 0x04;        // Sayfa okuma/yazma iznine sahip olduğunda kullanılan sabit
        public const uint PAGE_EXECUTE = 0x10;          // Sayfa yürütülebilir olduğunda kullanılan sabit
        public const uint PAGE_EXECUTE_READ = 0x20;     // Sayfa yürütülebilir ve salt okunur olduğunda kullanılan sabit
        public const uint PAGE_EXECUTE_READWRITE = 0x40;// Sayfa yürütülebilir ve okuma/yazma iznine sahip olduğunda kullanılan sabit
        public const uint PAGE_GUARD = 0x100;           // Sayfa korumalı olduğunda kullanılan sabit
        public const uint PAGE_NOCACHE = 0x200;         // Sayfa önbelleğe alınmaz olduğunda kullanılan sabit
        public static string ToPAGE(uint value)
        {
            switch (value)
            {
                case 0x01:
                    return "PAGE_NOACCESS";
                case 0x02:
                    return "PAGE_READONLY";
                case 0x04:
                    return "PAGE_READWRITE";
                case 0x10:
                    return "PAGE_EXECUTE";
                case 0x20:
                    return "PAGE_EXECUTE_READ";
                case 0x40:
                    return "PAGE_EXECUTE_READWRITE";
                case 0x100:
                    return "PAGE_GUARD";
                case 0x200:
                    return "PAGE_NOCACHE";
                default:
                    return "Unknown code: " + value.ToString("X");
            }
        }
        public static string ToMEM(uint value)
        {
            switch (value)
            {
                case MEM_COMMIT:
                    return "MEM_COMMIT";
                case MEM_RESERVE:
                    return "MEM_RESERVE";
                case MEM_RELEASE:
                    return "MEM_RELEASE";
                default:
                    return "Unknown";
            }
        }

        #endregion

        [DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "ReadProcessMemory", ExactSpelling = true, SetLastError = true)]
        public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead);

    }
}
