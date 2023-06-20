# ReadWriteMemory
C#/VB.NET easy and usefully ReadWriteMemory functions for noobs developers
Developed by omertrans156

## **Demo**
Updated full detailed codes in Demo project. Included a Ammo Hack for Assault Cube

## Usage/Examples
https://memoryhackers.org/konular/readwritememory-library-v3-0-pointer-scanner-imkani-var.274348/#post-5564917
```csharp
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
```

## **Memory.cs**:
WriteByte() <br>
WriteArrayBytes() <br>
WriteShort() <br>
WriteInteger() <br>
WriteLong() <br>
WriteFloat() <br>
WriteDouble() <br>
WriteString() <br>
WriteBool() <br>
ReadByte() <br>
ReadByteAllProcesses() <br>
ReadArrayBytes() <br>
ReadArrayBytesAllProcesses() <br>
ReadShort() <br>
ReadShortAllProcesses() <br>
ReadInteger() <br>
ReadIntegerAllProcesses() <br>
ReadLong() <br>
ReadLongAllProcesses() <br>
ReadFloat() <br>
ReadFloatAllProcesses() <br>
ReadDouble() <br>
ReadDoubleAllProcesses() <br>
ReadString()  <br>
ReadStringAllProcesses()  <br>
ReadBool() <br>
ReadBoolAllProcesses() <br>

## **Pattern.cs**:
Scan() <br>
ScanAllProcess() <br>
ScanWithModule() <br>
ScanWithModuleStr() <br>

## Feedback
If you have any feedback, please contact us at omertrans505@proton.me
