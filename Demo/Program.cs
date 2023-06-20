using System;
using System.Diagnostics;
using static omertrans156.ReadWriteMemory.Utility.MemoryUtility;
using static omertrans156.ReadWriteMemory.Memory;
using static omertrans156.ReadWriteMemory.Pattern;
using System.Text;
using System.Collections.Generic;

namespace Demo
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("! Assault Cube Trainer with ReadWriteMemory !");
            Console.WriteLine("Credit omertrans156");

            // game değişkenine Uygulama bilgisi atanıyor.
            Process game = Process.GetProcessesByName("ac_client")[0];
            /*
            SearchModule(): ac_client modulu bilgisi al

            module:     Oyunun Module base adresi kullanılarak çekilecek.
            pointer:    Pointer
            value:      Değer
            offset:     Offset
            */

            int module = SearchModule(game,"ac_client").BaseAddress.ToInt32();
            int pointer = 0x0017D848;
            int value = 999;
            int[] offset = { 0x40, 0xA50, 0x184 };
            WriteInteger(game, module + pointer , value, offset);
            Console.WriteLine("[+] Write Ammo Hack Actived");

            Console.Write("[+] Read Ammo count: ");
            int ammoCount = ReadInteger(game, module + pointer, offset);
            Console.WriteLine(ammoCount);

            Console.WriteLine("Done. paused");
            Console.ReadKey();

            // Gelişmiş kullanımları

            // Read or Write without any variable. '0x' for offset
            WriteInteger("ac_client.exe", "ac_client.exe+0017D848", 999, 0x40, 0xA50, 0x184);
            ReadInteger("ac_client.exe", "ac_client.exe+0017D848", 0x40, 0xA50, 0x184);

            // Read or Write without offset
            WriteInteger("ac_client.exe", "ac_client.exe+0017D848", 999);
            ReadInteger("ac_client.exe", "ac_client.exe+0017D848");

            // Read or Write All Process. 
            WriteInteger("ac_client.exe", "ac_client.exe+0017D848", 999, offset);
            ReadIntegerAllProcesses("ac_client.exe", "ac_client.exe+0017D848", offset);

            // Read or Write with PID
            WriteInteger(1234, "ac_client.exe+0017D848", 999, offset);
            ReadInteger(1234, "ac_client.exe+0017D848", offset);

            // Read or Write with Process and Process[]
            Process[] games = Process.GetProcessesByName("ac_client");
            WriteInteger(games, "ac_client.exe+0017D848", 999, offset);
            ReadInteger(games, "ac_client.exe+0017D848", offset);

            // Write string
            WriteString(game, module + pointer, "Hi World", offset); //Write default as Encoding.UTF8
            WriteString(game, module + pointer, "Hi World", Encoding.Unicode, offset); //Write as Encoding.Unicode

            // Read string
            ReadString(game, module + pointer, 12, offset); //Read with 12 length default as Encoding.UTF8
            ReadString(game, module + pointer, 12, Encoding.Unicode, offset); //Read with 12 length as Encoding.Unicode

            // AoB/Pattern/Signature Scan
            // IntPtr is a pointer.
            List<IntPtr> listOfBaseAddr = new List<IntPtr>();
            // do not forget add this code: using static omertrans156.ReadWriteMemory.Pattern;

            // Scan all
            listOfBaseAddr = Scan(game, "F6 C4 41 75 6E 80 3D ?? ?? ?? ?? 00");

            // Scan as Range StartAdress is 0x00000 and EndAddress is 0xFFFFFF
            listOfBaseAddr = Scan(game, "F6 C4 41 75 6E 80 3D ?? ?? ?? ?? 00", 0x00000, 0xFFFFFF);

            // Scan with Module
            ProcessModule module2 = game.MainModule;
            listOfBaseAddr = ScanWithModule(game, "F6 C4 41 75 6E 80 3D ?? ?? ?? ?? 00", module2);

            // Scan with Module convert to String output: ac_client.exe+12345
            string[] ModuleAndPointer = ScanWithModuleStr(game, "F6 C4 41 75 6E 80 3D ?? ?? ?? ?? 00", module2).ToArray();

            // Scan all processes
            List<IntPtr[]> listOfAddressPerProcesses = ScanAllProcess("ac_client.exe", "F6 C4 41 75 6E 80 3D ?? ?? ?? ?? 00");

            // Scan a address and active the hack
            int pointer2 = Scan(game, "F6 C4 41 75 6E 80 3D ?? ?? ?? ?? 00")[0].ToInt32();
            WriteInteger(game, pointer2, 999);
        }
    }
}
