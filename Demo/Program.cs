using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using omertrans156.ReadWriteMemory;
using omertrans156.ReadWriteMemory.Extensions;

namespace Demo
{
    internal class Program
    {
        static void Main()
        {
            Process game = Process.GetProcessesByName("ac_client")[0];
            int ac_clientmodule = game.MainModule.BaseAddress.ToInt32();

            // Usage
            Memory.WriteInteger(game, ac_clientmodule + 0x0017E0A8, 9102448);
            int val1 = Memory.ReadInteger(game, ac_clientmodule + 0x0017E0A8);
            Console.WriteLine("Value1: " + val1);
            int[] val2 = Memory.ReadInteger("ac_client", "ac_client.exe+0017E0A8");
            foreach (int val in val2) { Console.WriteLine(val); }
            
            // Pattern/AoB Scan
            string pattern =
            "41 73 73 ?? 75 6C 74 43 75 62 65 20 31 2E 33 2E 30 2E 32 5C 62 69 6E 5F 77 69 6E 33 32 5C 61 63 5F 63 6C 69 65 6E 74 2E 65 78 65 00 00 00 00 00 00 00"; // Aranacak desen (pattern)
            List<string> adresler = Pattern.ScanWithModuleStr(Process.GetProcessesByName("ac_client")[0].Id, pattern, Process.GetProcessesByName("ac_client")[0].MainModule);
            foreach (var adr in adresler)
            {
                Console.WriteLine(adr);
            }
            Console.WriteLine("paused");
            Console.ReadKey();
        }
    }
}
