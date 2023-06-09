using omertrans156.ReadWriteMemory.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using static omertrans156.ReadWriteMemory.Utility.MemoryUtility;

namespace omertrans156.ReadWriteMemory.Extensions
{
    public static class ObjectExtensions
    {
        public static object ToData(this byte[] input, DataTypeSize data)
        {
            switch (data)
            {
                case DataTypeSize.Byte:
                    return input[0];
                case DataTypeSize.Short:
                    return BitConverter.ToInt16(input, 0);
                case DataTypeSize.Int:
                    return BitConverter.ToInt32(input, 0);
                case DataTypeSize.Long:
                    return BitConverter.ToInt64(input, 0);
                case DataTypeSize.Float:
                    return BitConverter.ToSingle(input, 0);
                case DataTypeSize.Double:
                    return BitConverter.ToDouble(input, 0);
                case DataTypeSize.Bool:
                    return BitConverter.ToBoolean(input, 0);
                default:
                    throw new ArgumentException("Unknown data type");
            }
        }
        public static byte ToInt8(this object input)
        {
            return Convert.ToByte(input);
        }
        public static byte[] ToArrayInt8(this object[] input)
        {
            List<byte> list = new List<byte>();
            foreach (object o in input)
                list.Add((byte)o);
            return list.ToArray();
        }
        public static short ToInt16(this object input)
        {
            return Convert.ToInt16(input);
        }
        public static short[] ToArrayInt16(this object[] input)
        {
            /*List<short> list = new List<short>();
            foreach (object o in input)
            {
                if (o is byte[] byteArray && byteArray.Length >= 2)
                {
                    short value = BitConverter.ToInt16(byteArray, 0);
                    list.Add(value);
                }
                else
                {
                    // Uyumsuz tür için gerekli hata işleme veya atama yapılabilir.
                    // Örneğin, hata fırlatılabilir veya yerine geçerli bir değer atanabilir.
                }
            }
            return list.ToArray();*/
            List<short> list = new List<short>();
            foreach (object o in input)
                list.Add(BitConverter.ToInt16((byte[])o, 0));
            return list.ToArray();
        }
        public static int ToInt32(this object input)
        {
            return Convert.ToInt32(input);
        }
        public static int[] ToArrayInt32(this object[] input)
        {
            List<int> list = new List<int>();
            foreach (object o in input)
                list.Add(BitConverter.ToInt32((byte[])o, 0));
            return list.ToArray();
        }
        public static long ToInt64(this object input)
        {
            return Convert.ToInt64(input);
        }
        public static long[] ToArrayInt64(this object[] input)
        {
            List<long> list = new List<long>();
            foreach (object o in input)
                list.Add(BitConverter.ToInt64((byte[])o, 0));
            return list.ToArray();
        }
        public static float ToFloat(this object input)
        {
            return Convert.ToSingle(input);
        }
        public static float[] ToArrayFloat(this object[] input)
        {
            List<float> list = new List<float>();
            foreach (object o in input)
                list.Add(BitConverter.ToSingle((byte[])o, 0));
            return list.ToArray();
        }
        public static double ToDouble(this object input)
        {
            return Convert.ToDouble(input);
        }
        public static double[] ToArrayDouble(this object[] input)
        {
            List<double> list = new List<double>();
            foreach (object o in input)
                list.Add(BitConverter.ToDouble((byte[])o, 0));
            return list.ToArray();
        }
        public static bool ToBool(this object input)
        {
            return Convert.ToBoolean(input);
        }
        public static bool[] ToArrayBool(this object[] input)
        {
            List<bool> list = new List<bool>();
            foreach (object o in input)
                list.Add(BitConverter.ToBoolean((byte[])o, 0));
            return list.ToArray();
        }
        public static byte[] GenerateNumberSystem(this object input)
        {
            if (input is byte[] value)
                return value;
            if (!(input is string))
                throw new InvalidHexadecimalFormatException("'" + input + "' is not a hexadecimal string");

            string str = input.ToString().Replace(" ", "");
            byte[] val = new byte[str.ToString().Length / 2];
            for (int i = 0; i < str.ToString().Length; i += 2)
            {
                if (str.Length % 2 != 0)
                    throw new InvalidHexadecimalFormatException("hexadecimal is double only '" + input + "' -> " + input.ToString().Length);
                string byteString = str.Substring(i, 2);
                if (!new Regex("^[a-fA-F0-9]*$").IsMatch(byteString))
                    throw new InvalidHexadecimalFormatException("'" + byteString + "' at '" + input + "'");
                if (!(byteString.Length < 3))
                    throw new InvalidHexadecimalFormatException("'" + byteString + "' at '" + input + "'");

                byte byteValue = Convert.ToByte(byteString, 16);
                val[i / 2] = byteValue;
            }
            return val;
        }
    }
    public static class ByteExtensions
    {
        public static byte[] ToBytes(this byte value)
        {
            return new byte[] { value };
        }
        public static byte[] ToBytes(this short value)
        {
            return BitConverter.GetBytes(value);
        }
        public static byte[] ToBytes(this int value)
        {
            return BitConverter.GetBytes(value);
        }
        public static byte[] ToBytes(this long value)
        {
            return BitConverter.GetBytes(value);
        }
        public static byte[] ToBytes(this float value)
        {
            return BitConverter.GetBytes(value);
        }
        public static byte[] ToBytes(this double value)
        {
            return BitConverter.GetBytes(value);
        }
        public static byte[] ToBytes(this bool value)
        {
            return BitConverter.GetBytes(value);
        }
        public static byte[] ToBytes(this string value, Encoding Type)
        {
            return Type.GetBytes(value);
        }
    }
    public static class StringExtensions
    {
        public static int ToInt(this string input)
        {
            return int.Parse(input);
        }

        public static int ToInt(this string input, string format)
        {
            if (format == "X")
            {
                return int.Parse(input, System.Globalization.NumberStyles.HexNumber);
            }

            return int.Parse(input);
        }
        public static string ToString(this byte[] value, Encoding Type)
        {
            return Type.GetString(value);
        }
        public static string[] ToString(this byte[][] value, Encoding Type)
        {
            List<string> list = new List<string>();
            foreach (var val in value)
                list.Add(Type.GetString(val));
            return list.ToArray();
        }
    }
}
