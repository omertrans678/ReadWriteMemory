using omertrans156.ReadWriteMemory.Extensions;
using omertrans156.ReadWriteMemory.Utility;
using System.Text;

namespace omertrans156.ReadWriteMemory
{
    /// <summary>
    /// <p>
    /// C#/VB.NET easy and usefully ReadWriteMemory functions for noobs developers <br/>
    /// Developed by omertrans156 <br/>
    /// github.com/omertrans678/ReadWriteMemory <br/>
    /// </p>
    /// </summary>
    /// <param name="https://github.com/omertrans678/ReadWriteMemory/">/</param>
    /// <exception cref="Exceptions.FailedReadMemoryException">Failed to Reading Memory API. error code is indicated.</exception>
    /// <exception cref="Exceptions.FailedWriteMemoryException">Failed to Writing Memory API. error code is indicated.</exception>
    /// <exception cref="Exceptions.InvalidHexadecimalFormatException">Invalid entered hexadecimal string value.</exception>
    /// <exception cref="Exceptions.InvalidPointerException">Invalid entered pointer value.</exception>
    /// <exception cref="Exceptions.InvalidProcessIdException">Invalid process ID: 0</exception>
    /// <exception cref="Exceptions.InvalidValueException">Invalid entered value format.</exception>
    /// <exception cref="Exceptions.InvalidVariableTypeException">Invalid entered process variable.</exception>
    /// <exception cref="Exceptions.ModuleNameMissingException">Multi-processes Read Memory is ModuleName+Pointer only.</exception>
    /// <exception cref="Exceptions.ModuleNotFoundException">Not found entered module name.</exception>
    /// <exception cref="Exceptions.OpenProcessFailedException">Failed to open process.</exception>
    /// <exception cref="Exceptions.PointerNotFoundAfterOffsetException">Pointer not found after offset calculated.</exception>
    /// <exception cref="Exceptions.ProcessNullException">Process variable is null.</exception>
    /// <exception cref="Exceptions.TooManyModulesException">Too may modules result after SearchModule method.</exception>
    /// <exception cref="Exceptions.TooManyProcessesException">Too many processes using Read Memory.</exception>

    public class Memory
    {
        #region Byte
        /// <summary>
        /// Writes a byte value to a specified memory address in a process. <br/>
        /// example:
        /// <example>
        /// <code>
        /// Memory.WriteByte("ac_client.exe", "ac_client.exe+FFFFFF", 0x9A, offset[]);
        /// </code>
        /// </example>
        /// </summary>
        /// 
        /// <param name="Process">The process on which to perform the memory write operation. Accepts types: <br/>
        ///     <see cref="System.Diagnostics.Process"/>,<br/>
        ///     <see cref="System.Diagnostics.Process[]"/>,<br/>
        ///     <see cref="string"/> (ProcessName),<br/>
        ///     <see cref="int"/> (ProcessID).
        /// </param>
        /// <param name="Pointer">The pointer to the memory location. Accepts types: <br/>
        ///     <see cref="int"/> (Pointer),<br/>
        ///     <see cref="string"/> (ModuleName+Pointer).
        /// </param>
        /// <param name="Value">The value to write to the memory location. Accepts types: <br/>
        ///     <see cref="byte"/>,<br/>
        ///     <see cref="string"/> (value).
        /// </param>
        /// <param name="Offset">An optional offset to obtain the pointer directly. Accepts type: <br/>
        ///     <see cref="params"/> <see cref="array"/> <see cref="byte"/>.
        /// </param>
        public static void WriteByte(object Process, object Pointer, object Value, params int[] Offset)
        {
            MemoryUtility.Write(new Process(Process), Pointer, Value.ToInt8().ToBytes(), MemoryUtility.DataTypeSize.Byte, Offset);
        }
        /// <summary>
        /// Reads a byte value from the specified memory address in a process.
        /// example:
        /// <example>
        /// <code>
        /// byte value = Memory.ReadByte("ac_client.exe", "ac_client.exe+FFFFFF", offset[]);
        /// </code>
        /// </example>
        /// </summary>
        /// 
        /// <param name="Process">The process on which to perform the memory write operation. Accepts types: <br/>
        ///     <see cref="System.Diagnostics.Process"/>,<br/>
        ///     <see cref="string"/> (ProcessName),<br/>
        ///     <see cref="int"/> (ProcessID).
        /// </param>
        /// <param name="Pointer">The pointer to the memory location. Accepts types: <br/>
        ///     <see cref="int"/> (Pointer),<br/>
        ///     <see cref="string"/> (ModuleName+Pointer).
        /// </param>
        /// <param name="Offset">An optional offset to obtain the pointer directly. Accepts type: <br/>
        ///     <see cref="params"/> <see cref="array"/> <see cref="byte"/>.
        /// </param>
        /// <returns>The byte value read from the memory address.</returns>
        public static byte ReadByte(object Process, object Pointer, params int[] Offset)
        {
            return MemoryUtility.Read(new Process(Process), Pointer, MemoryUtility.DataTypeSize.Byte, Offset).ToInt8();
        }
        /// <summary>
        /// Reads a byte from the specified memory address per all processes.
        /// example:
        /// <example>
        /// <code>
        /// byte[] valuePerProcess = Memory.ReadByteAllProcess("ac_client.exe", "ac_client.exe+FFFFFF", offset[]);
        /// </code>
        /// </example>
        /// </summary>
        /// 
        /// <param name="Process">The process on which to perform the memory write operation. Accepts types: <br/>
        ///     <see cref="System.Diagnostics.Process[]"/>,<br/>
        ///     <see cref="string"/> (ProcessName),<br/>
        /// </param>
        /// <param name="Pointer">The pointer to the memory location. Accepts types: <br/>
        ///     <see cref="int"/> (Pointer),<br/>
        ///     <see cref="string"/> (ModuleName+Pointer).
        /// </param>
        /// <param name="Offset">An optional offset to obtain the pointer directly. Accepts type: <br/>
        ///     <see cref="params"/> <see cref="array"/> <see cref="byte"/>.
        /// </param>
        /// <returns>An array of bytes read from the memory address in each process.</returns>
        public static byte[] ReadByteAllProcess(object Process, string Pointer, params int[] Offset)
        {
            return MemoryUtility.ReadA(new Process(Process), Pointer, MemoryUtility.DataTypeSize.Byte, Offset).ToArrayInt8();
        }
        #endregion
        #region Array Bytes
        /// <summary>
        /// Writes an array of bytes to a specified memory address in a process.
        /// example:
        /// <example>
        /// <code>
        /// Memory.WriteArrayBytes("ac_client.exe", "ac_client.exe+FFFFFF", "FF FF FF", offset[]);
        /// </code>
        /// </example>
        /// </summary>
        /// 
        /// <param name="Process">The process on which to perform the memory write operation. Accepts types: <br/>
        ///     <see cref="System.Diagnostics.Process"/>,<br/>
        ///     <see cref="System.Diagnostics.Process[]"/>,<br/>
        ///     <see cref="string"/> (ProcessName),<br/>
        ///     <see cref="int"/> (ProcessID).
        /// </param>
        /// <param name="Pointer">The pointer to the memory location. Accepts types: <br/>
        ///     <see cref="int"/> (Pointer),<br/>
        ///     <see cref="string"/> (ModuleName+Pointer).
        /// </param>
        /// <param name="Value">The value to write to the memory location. Accepts types: <br/>
        ///     <see cref="byte[]"/>,<br/>
        ///     <see cref="string"/> (hexadecimal string).
        /// </param>
        /// <param name="Offset">An optional offset to obtain the pointer directly. Accepts type: <br/>
        ///     <see cref="params"/> <see cref="array"/> <see cref="byte"/>.
        /// </param>
        public static void WriteArrayBytes(object Process, object Pointer, object Value, params int[] Offset)
        {
            MemoryUtility.Write(new Process(Process), Pointer, Value.GenerateNumberSystem(), MemoryUtility.DataTypeSize.ArrayBytes, Offset);
        }
        /// <summary>
        /// Reads an array of bytes from a specified memory address in a process.
        /// example:
        /// <example>
        /// <code>
        /// byte[] value = Memory.ReadArrayBytes("ac_client.exe", "ac_client.exe+FFFFFF", 10, offset[]);
        /// </code>
        /// </example>
        /// </summary>
        /// 
        /// <param name="Process">The process on which to perform the memory write operation. Accepts types: <br/>
        ///     <see cref="System.Diagnostics.Process"/>,<br/>
        ///     <see cref="string"/> (ProcessName),<br/>
        ///     <see cref="int"/> (ProcessID).
        /// </param>
        /// <param name="Pointer">The pointer to the memory location. Accepts types: <br/>
        ///     <see cref="int"/> (Pointer),<br/>
        ///     <see cref="string"/> (ModuleName+Pointer).
        /// </param>
        /// <param name="Length">The length of the byte array to read.</param>
        /// <param name="Offset">An optional offset to obtain the pointer directly. Accepts type: <br/>
        ///     <see cref="params"/> <see cref="array"/> <see cref="byte"/>.
        /// </param>
        /// <returns>An array of bytes read from the specified memory address.</returns>
        public static byte[] ReadArrayBytes(object Process, object Pointer, int Length, params int[] Offset)
        {
            return MemoryUtility.ReadC(new Process(Process), Pointer, Length, MemoryUtility.DataTypeSize.ArrayBytes, Offset);
        }
        /// <summary>
        /// Reads an array of bytes from the specified memory address per all processes.
        /// example:
        /// <example>
        /// <code>
        /// byte[][] arrayOfBytesPerProcess = Memory.ReadArrayBytesAllProcess("ac_client.exe", "ac_client.exe+FFFFFF", 10, offset[]);
        /// </code>
        /// </example>
        /// </summary>
        /// 
        /// <param name="Process">The process on which to perform the memory write operation. Accepts types: <br/>
        ///     <see cref="System.Diagnostics.Process[]"/>,<br/>
        ///     <see cref="string"/> (ProcessName),<br/>
        /// </param>
        /// <param name="Pointer">The pointer to the memory location. Accepts types: <br/>
        ///     <see cref="int"/> (Pointer),<br/>
        ///     <see cref="string"/> (ModuleName+Pointer).
        /// </param>
        /// <param name="Length">The length of the byte array to read.</param>
        /// <param name="Offset">An optional offset to obtain the pointer directly. Accepts type: <br/>
        ///     <see cref="params"/> <see cref="array"/> <see cref="byte"/>.
        /// </param>
        /// <returns>An array of bytes read from the memory address in each process.</returns>
        public static byte[][] ReadArrayBytesAllProcess(object Process, string Pointer, int Length, params int[] Offset)
        {
            return MemoryUtility.ReadCA(new Process(Process), Pointer, Length, MemoryUtility.DataTypeSize.ArrayBytes, Offset);
        }
        #endregion
        #region Short
        /// <summary>
        /// Writes a short (Int16) value to a specified memory address in a process. <br/>
        /// example:
        /// <example>
        /// <code>
        /// Memory.WriteShort("ac_client.exe", "ac_client.exe+FFFFFF", 123, offset[]);
        /// </code>
        /// </example>
        /// </summary>
        /// 
        /// <param name="Process">The process on which to perform the memory write operation. Accepts types: <br/>
        ///     <see cref="System.Diagnostics.Process"/>,<br/>
        ///     <see cref="System.Diagnostics.Process[]"/>,<br/>
        ///     <see cref="string"/> (ProcessName),<br/>
        ///     <see cref="int"/> (ProcessID).
        /// </param>
        /// <param name="Pointer">The pointer to the memory location. Accepts types: <br/>
        ///     <see cref="int"/> (Pointer),<br/>
        ///     <see cref="string"/> (ModuleName+Pointer).
        /// </param>
        /// <param name="Value">The value to write to the memory location. Accepts types: <br/>
        ///     <see cref="short"/>,<br/>
        ///     <see cref="string"/> (short value).
        /// </param>
        /// <param name="Offset">An optional offset to obtain the pointer directly. Accepts type: <br/>
        ///     <see cref="params"/> <see cref="array"/> <see cref="byte"/>.
        /// </param>

        public static void WriteShort(object Process, object Pointer, object Value, params int[] Offset)
        {
            MemoryUtility.Write(new Process(Process), Pointer, Value.ToInt16().ToBytes(), MemoryUtility.DataTypeSize.Short, Offset);
        }
        /// <summary>
        /// Reads a short (Int16) value from the specified memory address in a process.
        /// example:
        /// <example>
        /// <code>
        /// short value = Memory.ReadShort("ac_client.exe", "ac_client.exe+FFFFFF", offset[]);
        /// </code>
        /// </example>
        /// </summary>
        /// 
        /// <param name="Process">The process on which to perform the memory write operation. Accepts types: <br/>
        ///     <see cref="System.Diagnostics.Process"/>,<br/>
        ///     <see cref="string"/> (ProcessName),<br/>
        ///     <see cref="int"/> (ProcessID).
        /// </param>
        /// <param name="Pointer">The pointer to the memory location. Accepts types: <br/>
        ///     <see cref="int"/> (Pointer),<br/>
        ///     <see cref="string"/> (ModuleName+Pointer).
        /// </param>
        /// <param name="Offset">An optional offset to obtain the pointer directly. Accepts type: <br/>
        ///     <see cref="params"/> <see cref="array"/> <see cref="byte"/>.
        /// </param>
        /// <returns>The short value read from the memory address.</returns>
        public static short ReadShort(object Process, object Pointer, params int[] Offset)
        {
            return MemoryUtility.Read(new Process(Process), Pointer, MemoryUtility.DataTypeSize.Short, Offset).ToInt16();
        }
        /// <summary>
        /// Reads a byte from the specified memory address per all processes.
        /// example:
        /// <example>
        /// <code>
        /// short[] valuePerProcess = Memory.ReadShort("ac_client.exe", "ac_client.exe+FFFFFF", offset[]);
        /// </code>
        /// </example>
        /// </summary>
        /// 
        /// <param name="Process">The process on which to perform the memory write operation. Accepts types: <br/>
        ///     <see cref="System.Diagnostics.Process[]"/>,<br/>
        ///     <see cref="string"/> (ProcessName),<br/>
        /// </param>
        /// <param name="Pointer">The pointer to the memory location. Accepts types: <br/>
        ///     <see cref="int"/> (Pointer),<br/>
        ///     <see cref="string"/> (ModuleName+Pointer).
        /// </param>
        /// <param name="Offset">An optional offset to obtain the pointer directly. Accepts type: <br/>
        ///     <see cref="params"/> <see cref="array"/> <see cref="byte"/>.
        /// </param>
        /// <returns>An short read from the memory address in each process.</returns>
        public static short[] ReadShort(object Process, string Pointer, params int[] Offset)
        {
            return MemoryUtility.ReadA(new Process(Process), Pointer, MemoryUtility.DataTypeSize.Short, Offset).ToArrayInt16();
        }
        #endregion
        #region Integer
        /// <summary>
        /// Writes a Integer (Int32) value to a specified memory address in a process. <br/>
        /// example:
        /// <example>
        /// <code>
        /// Memory.WriteInteger("ac_client.exe", "ac_client.exe+FFFFFF", 123, offset[]);
        /// </code>
        /// </example>
        /// </summary>
        /// 
        /// <param name="Process">The process on which to perform the memory write operation. Accepts types: <br/>
        ///     <see cref="System.Diagnostics.Process"/>,<br/>
        ///     <see cref="System.Diagnostics.Process[]"/>,<br/>
        ///     <see cref="string"/> (ProcessName),<br/>
        ///     <see cref="int"/> (ProcessID).
        /// </param>
        /// <param name="Pointer">The pointer to the memory location. Accepts types: <br/>
        ///     <see cref="int"/> (Pointer),<br/>
        ///     <see cref="string"/> (ModuleName+Pointer).
        /// </param>
        /// <param name="Value">The value to write to the memory location. Accepts types: <br/>
        ///     <see cref="int"/>,<br/>
        ///     <see cref="string"/> (int value).
        /// </param>
        /// <param name="Offset">An optional offset to obtain the pointer directly. Accepts type: <br/>
        ///     <see cref="params"/> <see cref="array"/> <see cref="byte"/>.
        /// </param>
        public static void WriteInteger(object Process, object Pointer, object Value, params int[] Offset)
        {
            MemoryUtility.Write(new Process(Process), Pointer, Value.ToInt32().ToBytes(), MemoryUtility.DataTypeSize.Int, Offset);
        }
        /// <summary>
        /// Reads a int (Int32) value from the specified memory address in a process.
        /// example:
        /// <example>
        /// <code>
        /// int value = Memory.ReadInteger("ac_client.exe", "ac_client.exe+FFFFFF", offset[]);
        /// </code>
        /// </example>
        /// </summary>
        /// 
        /// <param name="Process">The process on which to perform the memory write operation. Accepts types: <br/>
        ///     <see cref="System.Diagnostics.Process"/>,<br/>
        ///     <see cref="string"/> (ProcessName),<br/>
        ///     <see cref="int"/> (ProcessID).
        /// </param>
        /// <param name="Pointer">The pointer to the memory location. Accepts types: <br/>
        ///     <see cref="int"/> (Pointer),<br/>
        ///     <see cref="string"/> (ModuleName+Pointer).
        /// </param>
        /// <param name="Offset">An optional offset to obtain the pointer directly. Accepts type: <br/>
        ///     <see cref="params"/> <see cref="array"/> <see cref="byte"/>.
        /// </param>
        /// <returns>The int value read from the memory address.</returns>
        public static int ReadInteger(object Process, object Pointer, params int[] Offset)
        {
            return MemoryUtility.Read(new Process(Process), Pointer, MemoryUtility.DataTypeSize.Int, Offset).ToInt32();
        }
        /// <summary>
        /// Reads a int from the specified memory address per all processes.
        /// example:
        /// <example>
        /// <code>
        /// int[] valuePerProcess = Memory.ReadInteger("ac_client.exe", "ac_client.exe+FFFFFF", offset[]);
        /// </code>
        /// </example>
        /// </summary>
        /// 
        /// <param name="Process">The process on which to perform the memory write operation. Accepts types: <br/>
        ///     <see cref="System.Diagnostics.Process[]"/>,<br/>
        ///     <see cref="string"/> (ProcessName),<br/>
        /// </param>
        /// <param name="Pointer">The pointer to the memory location. Accepts types: <br/>
        ///     <see cref="int"/> (Pointer),<br/>
        ///     <see cref="string"/> (ModuleName+Pointer).
        /// </param>
        /// <param name="Offset">An optional offset to obtain the pointer directly. Accepts type: <br/>
        ///     <see cref="params"/> <see cref="array"/> <see cref="byte"/>.
        /// </param>
        /// <returns>An int read from the memory address in each process.</returns>
        public static int[] ReadInteger(object Process, string Pointer, params int[] Offset)
        {
            return MemoryUtility.ReadA(new Process(Process), Pointer, MemoryUtility.DataTypeSize.Int, Offset).ToArrayInt32();
        }
        #endregion
        #region Long
        /// <summary>
        /// Writes a long (Int64) value to a specified memory address in a process. <br/>
        /// example:
        /// <example>
        /// <code>
        /// Memory.WriteLong("ac_client.exe", "ac_client.exe+FFFFFF", 123, offset[]);
        /// </code>
        /// </example>
        /// </summary>
        /// 
        /// <param name="Process">The process on which to perform the memory write operation. Accepts types: <br/>
        ///     <see cref="System.Diagnostics.Process"/>,<br/>
        ///     <see cref="System.Diagnostics.Process[]"/>,<br/>
        ///     <see cref="string"/> (ProcessName),<br/>
        ///     <see cref="int"/> (ProcessID).
        /// </param>
        /// <param name="Pointer">The pointer to the memory location. Accepts types: <br/>
        ///     <see cref="int"/> (Pointer),<br/>
        ///     <see cref="string"/> (ModuleName+Pointer).
        /// </param>
        /// <param name="Value">The value to write to the memory location. Accepts types: <br/>
        ///     <see cref="long"/>,<br/>
        ///     <see cref="string"/> (long value).
        /// </param>
        /// <param name="Offset">An optional offset to obtain the pointer directly. Accepts type: <br/>
        ///     <see cref="params"/> <see cref="array"/> <see cref="byte"/>.
        /// </param>
        public static void WriteLong(object Process, object Pointer, object Value, params int[] Offset)
        {
            MemoryUtility.Write(new Process(Process), Pointer, Value.ToInt64().ToBytes(), MemoryUtility.DataTypeSize.Int, Offset);
        }
        /// <summary>
        /// Reads a long (Int64) value from the specified memory address in a process.
        /// example:
        /// <example>
        /// <code>
        /// long value = Memory.ReadLong("ac_client.exe", "ac_client.exe+FFFFFF", offset[]);
        /// </code>
        /// </example>
        /// </summary>
        /// 
        /// <param name="Process">The process on which to perform the memory write operation. Accepts types: <br/>
        ///     <see cref="System.Diagnostics.Process"/>,<br/>
        ///     <see cref="string"/> (ProcessName),<br/>
        ///     <see cref="int"/> (ProcessID).
        /// </param>
        /// <param name="Pointer">The pointer to the memory location. Accepts types: <br/>
        ///     <see cref="int"/> (Pointer),<br/>
        ///     <see cref="string"/> (ModuleName+Pointer).
        /// </param>
        /// <param name="Offset">An optional offset to obtain the pointer directly. Accepts type: <br/>
        ///     <see cref="params"/> <see cref="array"/> <see cref="byte"/>.
        /// </param>
        /// <returns>The long value read from the memory address.</returns>
        public static long ReadLong(object Process, object Pointer, params int[] Offset)
        {
            return MemoryUtility.Read(new Process(Process), Pointer, MemoryUtility.DataTypeSize.Long, Offset).ToInt64();
        }
        /// <summary>
        /// Reads a long from the specified memory address per all processes.
        /// example:
        /// <example>
        /// <code>
        /// long[] valuePerProcess = Memory.ReadLong("ac_client.exe", "ac_client.exe+FFFFFF", offset[]);
        /// </code>
        /// </example>
        /// </summary>
        /// 
        /// <param name="Process">The process on which to perform the memory write operation. Accepts types: <br/>
        ///     <see cref="System.Diagnostics.Process[]"/>,<br/>
        ///     <see cref="string"/> (ProcessName),<br/>
        /// </param>
        /// <param name="Pointer">The pointer to the memory location. Accepts types: <br/>
        ///     <see cref="int"/> (Pointer),<br/>
        ///     <see cref="string"/> (ModuleName+Pointer).
        /// </param>
        /// <param name="Offset">An optional offset to obtain the pointer directly. Accepts type: <br/>
        ///     <see cref="params"/> <see cref="array"/> <see cref="byte"/>.
        /// </param>
        /// <returns>An long read from the memory address in each process.</returns>
        public static long[] ReadLong(object Process, string Pointer, params int[] Offset)
        {
            return MemoryUtility.ReadA(new Process(Process), Pointer, MemoryUtility.DataTypeSize.Long, Offset).ToArrayInt64();
        }
        #endregion
        #region Float
        /// <summary>
        /// Writes a float (Single) value to a specified memory address in a process. <br/>
        /// example:
        /// <example>
        /// <code>
        /// Memory.WriteFloat("ac_client.exe", "ac_client.exe+FFFFFF", 1.10, offset[]);
        /// </code>
        /// </example>
        /// </summary>
        /// 
        /// <param name="Process">The process on which to perform the memory write operation. Accepts types: <br/>
        ///     <see cref="System.Diagnostics.Process"/>,<br/>
        ///     <see cref="System.Diagnostics.Process[]"/>,<br/>
        ///     <see cref="string"/> (ProcessName),<br/>
        ///     <see cref="int"/> (ProcessID).
        /// </param>
        /// <param name="Pointer">The pointer to the memory location. Accepts types: <br/>
        ///     <see cref="int"/> (Pointer),<br/>
        ///     <see cref="string"/> (ModuleName+Pointer).
        /// </param>
        /// <param name="Value">The value to write to the memory location. Accepts types: <br/>
        ///     <see cref="float"/>,<br/>
        ///     <see cref="string"/> (float value).
        /// </param>
        /// <param name="Offset">An optional offset to obtain the pointer directly. Accepts type: <br/>
        ///     <see cref="params"/> <see cref="array"/> <see cref="byte"/>.
        /// </param>
        public static void WriteFloat(object Process, object Pointer, object Value, params int[] Offset)
        {
            MemoryUtility.Write(new Process(Process), Pointer, Value.ToFloat().ToBytes(), MemoryUtility.DataTypeSize.Float, Offset);
        }
        /// <summary>
        /// Reads a float (Single) value from the specified memory address in a process.
        /// example:
        /// <example>
        /// <code>
        /// float value = Memory.ReadFloat("ac_client.exe", "ac_client.exe+FFFFFF", offset[]);
        /// </code>
        /// </example>
        /// </summary>
        /// 
        /// <param name="Process">The process on which to perform the memory write operation. Accepts types: <br/>
        ///     <see cref="System.Diagnostics.Process"/>,<br/>
        ///     <see cref="string"/> (ProcessName),<br/>
        ///     <see cref="int"/> (ProcessID).
        /// </param>
        /// <param name="Pointer">The pointer to the memory location. Accepts types: <br/>
        ///     <see cref="int"/> (Pointer),<br/>
        ///     <see cref="string"/> (ModuleName+Pointer).
        /// </param>
        /// <param name="Offset">An optional offset to obtain the pointer directly. Accepts type: <br/>
        ///     <see cref="params"/> <see cref="array"/> <see cref="byte"/>.
        /// </param>
        /// <returns>The float value read from the memory address.</returns>
        public static float ReadFloat(object Process, object Pointer, params int[] Offset)
        {
            return MemoryUtility.Read(new Process(Process), Pointer, MemoryUtility.DataTypeSize.Float, Offset).ToFloat();
        }
        /// <summary>
        /// Reads a float from the specified memory address per all processes.
        /// example:
        /// <example>
        /// <code>
        /// float[] valuePerProcess = Memory.ReadFloat("ac_client.exe", "ac_client.exe+FFFFFF", offset[]);
        /// </code>
        /// </example>
        /// </summary>
        /// 
        /// <param name="Process">The process on which to perform the memory write operation. Accepts types: <br/>
        ///     <see cref="System.Diagnostics.Process[]"/>,<br/>
        ///     <see cref="string"/> (ProcessName),<br/>
        /// </param>
        /// <param name="Pointer">The pointer to the memory location. Accepts types: <br/>
        ///     <see cref="int"/> (Pointer),<br/>
        ///     <see cref="string"/> (ModuleName+Pointer).
        /// </param>
        /// <param name="Offset">An optional offset to obtain the pointer directly. Accepts type: <br/>
        ///     <see cref="params"/> <see cref="array"/> <see cref="byte"/>.
        /// </param>
        /// <returns>An float read from the memory address in each process.</returns>
        public static float[] ReadFloat(object Process, string Pointer, params int[] Offset)
        {
            return MemoryUtility.ReadA(new Process(Process), Pointer, MemoryUtility.DataTypeSize.Float, Offset).ToArrayFloat();
        }
        #endregion
        #region Double
        /// <summary>
        /// Writes a double (Double) value to a specified memory address in a process. <br/>
        /// example:
        /// <example>
        /// <code>
        /// Memory.WriteDouble("ac_client.exe", "ac_client.exe+FFFFFF", 1.20, offset[]);
        /// </code>
        /// </example>
        /// </summary>
        /// 
        /// <param name="Process">The process on which to perform the memory write operation. Accepts types: <br/>
        ///     <see cref="System.Diagnostics.Process"/>,<br/>
        ///     <see cref="System.Diagnostics.Process[]"/>,<br/>
        ///     <see cref="string"/> (ProcessName),<br/>
        ///     <see cref="int"/> (ProcessID).
        /// </param>
        /// <param name="Pointer">The pointer to the memory location. Accepts types: <br/>
        ///     <see cref="int"/> (Pointer),<br/>
        ///     <see cref="string"/> (ModuleName+Pointer).
        /// </param>
        /// <param name="Value">The value to write to the memory location. Accepts types: <br/>
        ///     <see cref="double"/>,<br/>
        ///     <see cref="string"/> (double value).
        /// </param>
        /// <param name="Offset">An optional offset to obtain the pointer directly. Accepts type: <br/>
        ///     <see cref="params"/> <see cref="array"/> <see cref="byte"/>.
        /// </param>
        public static void WriteDouble(object Process, object Pointer, object Value, params int[] Offset)
        {
            MemoryUtility.Write(new Process(Process), Pointer, Value.ToDouble().ToBytes(), MemoryUtility.DataTypeSize.Double, Offset);
        }
        /// <summary>
        /// Reads a double (Double) value from the specified memory address in a process.
        /// example:
        /// <example>
        /// <code>
        /// double value = Memory.ReadDouble("ac_client.exe", "ac_client.exe+FFFFFF", offset[]);
        /// </code>
        /// </example>
        /// </summary>
        /// 
        /// <param name="Process">The process on which to perform the memory write operation. Accepts types: <br/>
        ///     <see cref="System.Diagnostics.Process"/>,<br/>
        ///     <see cref="string"/> (ProcessName),<br/>
        ///     <see cref="int"/> (ProcessID).
        /// </param>
        /// <param name="Pointer">The pointer to the memory location. Accepts types: <br/>
        ///     <see cref="int"/> (Pointer),<br/>
        ///     <see cref="string"/> (ModuleName+Pointer).
        /// </param>
        /// <param name="Offset">An optional offset to obtain the pointer directly. Accepts type: <br/>
        ///     <see cref="params"/> <see cref="array"/> <see cref="byte"/>.
        /// </param>
        /// <returns>The double value read from the memory address.</returns>
        public static double ReadDouble(object Process, object Pointer, params int[] Offset)
        {
            return MemoryUtility.Read(new Process(Process), Pointer, MemoryUtility.DataTypeSize.Double, Offset).ToDouble();
        }
        /// <summary>
        /// Reads a double from the specified memory address per all processes.
        /// example:
        /// <example>
        /// <code>
        /// double[] valuePerProcess = Memory.ReadDouble("ac_client.exe", "ac_client.exe+FFFFFF", offset[]);
        /// </code>
        /// </example>
        /// </summary>
        /// 
        /// <param name="Process">The process on which to perform the memory write operation. Accepts types: <br/>
        ///     <see cref="System.Diagnostics.Process[]"/>,<br/>
        ///     <see cref="string"/> (ProcessName),<br/>
        /// </param>
        /// <param name="Pointer">The pointer to the memory location. Accepts types: <br/>
        ///     <see cref="int"/> (Pointer),<br/>
        ///     <see cref="string"/> (ModuleName+Pointer).
        /// </param>
        /// <param name="Offset">An optional offset to obtain the pointer directly. Accepts type: <br/>
        ///     <see cref="params"/> <see cref="array"/> <see cref="byte"/>.
        /// </param>
        /// <returns>An double read from the memory address in each process.</returns>
        public static double[] ReadDouble(object Process, string Pointer, params int[] Offset)
        {
            return MemoryUtility.ReadA(new Process(Process), Pointer, MemoryUtility.DataTypeSize.Double, Offset).ToArrayDouble();
        }
        #endregion
        #region Bool
        /// <summary>
        /// Writes a Bool value to a specified memory address in a process. <br/>
        /// example:
        /// <example>
        /// <code>
        /// Memory.WriteBool("ac_client.exe", "ac_client.exe+FFFFFF", true, offset[]);
        /// </code>
        /// </example>
        /// </summary>
        /// 
        /// <param name="Process">The process on which to perform the memory write operation. Accepts types: <br/>
        ///     <see cref="System.Diagnostics.Process"/>,<br/>
        ///     <see cref="System.Diagnostics.Process[]"/>,<br/>
        ///     <see cref="string"/> (ProcessName),<br/>
        ///     <see cref="int"/> (ProcessID).
        /// </param>
        /// <param name="Pointer">The pointer to the memory location. Accepts types: <br/>
        ///     <see cref="int"/> (Pointer),<br/>
        ///     <see cref="string"/> (ModuleName+Pointer).
        /// </param>
        /// <param name="Value">The value to write to the memory location. Accepts types: <br/>
        ///     <see cref="bool"/>,<br/>
        ///     <see cref="string"/> (short value).
        /// </param>
        /// <param name="Offset">An optional offset to obtain the pointer directly. Accepts type: <br/>
        ///     <see cref="params"/> <see cref="array"/> <see cref="byte"/>.
        /// </param>
        public static void WriteBool(object Process, object Pointer, object Value, params int[] Offset)
        {
            MemoryUtility.Write(new Process(Process), Pointer, Value.ToBool().ToBytes(), MemoryUtility.DataTypeSize.Bool, Offset);
        }
        /// <summary>
        /// Reads a Bool value from the specified memory address in a process.
        /// example:
        /// <example>
        /// <code>
        /// bool value = Memory.ReadBool("ac_client.exe", "ac_client.exe+FFFFFF", offset[]);
        /// </code>
        /// </example>
        /// </summary>
        /// 
        /// <param name="Process">The process on which to perform the memory write operation. Accepts types: <br/>
        ///     <see cref="System.Diagnostics.Process"/>,<br/>
        ///     <see cref="string"/> (ProcessName),<br/>
        ///     <see cref="int"/> (ProcessID).
        /// </param>
        /// <param name="Pointer">The pointer to the memory location. Accepts types: <br/>
        ///     <see cref="int"/> (Pointer),<br/>
        ///     <see cref="string"/> (ModuleName+Pointer).
        /// </param>
        /// <param name="Offset">An optional offset to obtain the pointer directly. Accepts type: <br/>
        ///     <see cref="params"/> <see cref="array"/> <see cref="byte"/>.
        /// </param>
        /// <returns>The short value read from the memory address.</returns>
        public static bool ReadBool(object Process, object Pointer, params int[] Offset)
        {
            return MemoryUtility.Read(new Process(Process), Pointer, MemoryUtility.DataTypeSize.Bool, Offset).ToBool();
        }
        /// <summary>
        /// Reads a bool from the specified memory address per all processes.
        /// example:
        /// <example>
        /// <code>
        /// bool[] valuePerProcess = Memory.ReadBool("ac_client.exe", "ac_client.exe+FFFFFF", offset[]);
        /// </code>
        /// </example>
        /// </summary>
        /// 
        /// <param name="Process">The process on which to perform the memory write operation. Accepts types: <br/>
        ///     <see cref="System.Diagnostics.Process[]"/>,<br/>
        ///     <see cref="string"/> (ProcessName),<br/>
        /// </param>
        /// <param name="Pointer">The pointer to the memory location. Accepts types: <br/>
        ///     <see cref="int"/> (Pointer),<br/>
        ///     <see cref="string"/> (ModuleName+Pointer).
        /// </param>
        /// <param name="Offset">An optional offset to obtain the pointer directly. Accepts type: <br/>
        ///     <see cref="params"/> <see cref="array"/> <see cref="byte"/>.
        /// </param>
        /// <returns>An bool read from the memory address in each process.</returns>
        public static bool[] ReadBool(object Process, string Pointer, params int[] Offset)
        {
            return MemoryUtility.ReadA(new Process(Process), Pointer, MemoryUtility.DataTypeSize.Bool, Offset).ToArrayBool();
        }
        #endregion

        #region String
        /// <summary>
        /// Writes a string value to a specified memory address in a process.
        /// example:
        /// <example>
        /// <code>
        /// Memory.WriteString("ac_client.exe", "ac_client.exe+FFFFFF", "Hello", System.Text.Encoding.Unicode, offset[]);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="Process">The process to write the string value to. It can be of type System.Diagnostics.Process, System.Diagnostics.Process[], int (Process ID), or string (Process Name).</param>
        /// <param name="Pointer">The memory address to write the string value to. It can be of type int (Pointer) or string (Module Name + Pointer).</param>
        /// <param name="Value">The string value to write.</param>
        /// <param name="Type">The encoding type to use for converting the string value to bytes. If not specified, the default encoding will be used.</param>
        /// <param name="Offset">Optional offsets to calculate the final memory address.</param>
        public static void WriteString(object Process, object Pointer, string Value, Encoding Type = null, params int[] Offset)
        {
            MemoryUtility.Write(new Process(Process), Pointer, Value.ToBytes(Type ?? Encoding.UTF8), MemoryUtility.DataTypeSize.String, Offset);
        }
        /// <summary>
        /// Reads a string value from a specified memory address in a process.
        /// example:
        /// <example>
        /// <code>
        /// string value = Memory.ReadString("ac_client.exe", "ac_client.exe+FFFFFF", 10, offset[]);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="Process">The process to read the string value from. It can be of type System.Diagnostics.Process, System.Diagnostics.Process[], int (Process ID), or string (Process Name).</param>
        /// <param name="Pointer">The memory address to read the string value from. It can be of type int (Pointer) or string (Module Name + Pointer).</param>
        /// <param name="Length">The length of the string to read.</param>
        /// <param name="Offset">Optional offsets to calculate the final memory address.</param>
        /// <returns>The string value read from the specified memory address.</returns>
        public static string ReadString(object Process, object Pointer, int Length, params int[] Offset)
        {
            return MemoryUtility.ReadC(new Process(Process), Pointer, Length, MemoryUtility.DataTypeSize.String, Offset).ToString(Encoding.UTF8);
        }
        /// <summary>
        /// Reads a string value from a specified memory address in a process using the specified encoding.
        /// example:
        /// <example>
        /// <code>
        /// string value = Memory.ReadString("ac_client.exe", "ac_client.exe+FFFFFF", 10, System.Text.Encoding.Unicode, offset[]);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="Process">The process to read the string value from. It can be of type System.Diagnostics.Process, System.Diagnostics.Process[], int (Process ID), or string (Process Name).</param>
        /// <param name="Pointer">The memory address to read the string value from. It can be of type int (Pointer) or string (Module Name + Pointer).</param>
        /// <param name="Length">The length of the string to read.</param>
        /// <param name="Type">The encoding type to be used for reading the string. If not specified, the default encoding will be used.</param>
        /// <param name="Offset">Optional offsets to calculate the final memory address.</param>
        /// <returns>The string value read from the specified memory address.</returns>
        public static string ReadString(object Process, object Pointer, int Length, Encoding Type = null, params int[] Offset)
        {
            return MemoryUtility.ReadC(new Process(Process), Pointer, Length, MemoryUtility.DataTypeSize.String, Offset).ToString(Type ?? Encoding.UTF8);
        }
        /// <summary>
        /// Reads a string value from the specified memory address in all processes running on the system using the specified encoding.
        /// example:
        /// <example>
        /// <code>
        /// string[] valuePerProcesses = Memory.ReadString("ac_client.exe", "ac_client.exe+FFFFFF", 10, System.Text.Encoding.Unicode, offset[]);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="Process">The process or processes to read the string value from. It can be of type System.Diagnostics.Process, System.Diagnostics.Process[], int (Process ID), or string (Process Name).</param>
        /// <param name="Pointer">The memory address to read the string value from. It can be of type int (Pointer) or string (Module Name + Pointer).</param>
        /// <param name="Length">The length of the string to read.</param>
        /// <param name="Type">The encoding type to be used for reading the string. If not specified, the default encoding will be used.</param>
        /// <param name="Offset">Optional offsets to calculate the final memory address.</param>
        /// <returns>An array of string values read from the specified memory address in all processes.</returns>
        public static string[] ReadStringAllProcess(object Process, object Pointer, int Length, Encoding Type = null, params int[] Offset)
        {
            return MemoryUtility.ReadCA(new Process(Process), Pointer, Length, MemoryUtility.DataTypeSize.String, Offset).ToString(Type ?? Encoding.UTF8);
        }
        #endregion
    }
}
