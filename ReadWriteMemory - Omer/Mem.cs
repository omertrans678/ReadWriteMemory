using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using omertrans156.Native;

namespace omertrans156
{
    /// <summary>
    /// <p>
    /// Omertrans156 tarafından geliştirilen Read Write Memory Fonksiyonları listesi. <br/>
    /// <code> 
    /// <seealso cref="WriteByte(int, int, byte, int[])"/> <br/> 
    /// <seealso cref="WriteByte(int, int, byte[], int[])"/> <br/>
    /// <seealso cref="WriteByte(int, int, string, Mem.NumberSystem, int[])"/> <br/>
    /// <seealso cref="WriteByte(int, int, string[], Mem.NumberSystem, int[])"/> <br/>
    /// <seealso cref="WriteByte(string, int, byte, int[])"/> <br/>
    /// <seealso cref="WriteByte(string, int, byte[], int[])"/> <br/>
    /// <seealso cref="WriteByte(string, int, string, Mem.NumberSystem, int[])"/> <br/>
    /// <seealso cref="WriteByte(string, int, string[], Mem.NumberSystem, int[])"/> <br/>
    /// <seealso cref="WriteShort(int, int, int, int[])"/> <br/>
    /// <seealso cref="WriteShort(int, int, string, int[])"/> <br/>
    /// <seealso cref="WriteShort(string, int, int, int[])"/> <br/>
    /// <seealso cref="WriteShort(string, int, string, int[])"/> <br/>
    /// <seealso cref="WriteInteger(int, int, int, int[])"/> <br/>
    /// <seealso cref="WriteInteger(int, int, string, int[])"/> <br/>
    /// <seealso cref="WriteInteger(string, int, int, int[])"/> <br/>
    /// <seealso cref="WriteInteger(string, int, string, int[])"/> <br/>
    /// <seealso cref="WriteLong(int, int, int, int[])"/> <br/>
    /// <seealso cref="WriteLong(int, int, string, int[])"/> <br/>
    /// <seealso cref="WriteLong(string, int, int, int[])"/> <br/>
    /// <seealso cref="WriteLong(string, int, string, int[])"/> <br/>
    /// <seealso cref="WriteFloat(int, int, float, int[])"/> <br/>
    /// <seealso cref="WriteFloat(int, int, string, int[])"/> <br/>
    /// <seealso cref="WriteFloat(string, int, float, int[])"/> <br/>
    /// <seealso cref="WriteFloat(string, int, string, int[])"/> <br/>
    /// <seealso cref="WriteDouble(int, int, double, int[])"/> <br/>
    /// <seealso cref="WriteDouble(int, int, string, int[])"/> <br/>
    /// <seealso cref="WriteDouble(string, int, double, int[])"/> <br/>
    /// <seealso cref="WriteDouble(string, int, string, int[])"/> <br/>
    /// <seealso cref="WriteBool(int, int, bool, int[])"/> <br/>
    /// <seealso cref="WriteBool(int, int, string, int[])"/> <br/>
    /// <seealso cref="WriteBool(string, int, bool, int[])"/> <br/>
    /// <seealso cref="WriteBool(string, int, string, int[])"/> <br/>
    /// <seealso cref="WriteString(int, int, string, System.Text.Encoding, int[])"/> <br/>
    /// <seealso cref="WriteString(string, int, string, System.Text.Encoding, int[])"/> <br/>
    /// <seealso cref="ReadByte(int, int, int, int[])"/> <br/>
    /// <seealso cref="ReadByte(int, int, int, Mem.NumberSystem, int[])"/> <br/>
    /// <seealso cref="ReadByte(int, uint, int, int[])"/> <br/>
    /// <seealso cref="ReadByte(int, uint, int, Mem.NumberSystem, int[])"/> <br/>
    /// <seealso cref="ReadByte(string, int, int, int[])"/> <br/>
    /// <seealso cref="ReadByte(string, int, int, Mem.NumberSystem, int[])"/> <br/>
    /// <seealso cref="ReadByte(string, uint, int, int[])"/> <br/>
    /// <seealso cref="ReadByte(string, uint, int, Mem.NumberSystem, int[])"/> <br/>
    /// <seealso cref="ReadShort(int, int, int[])"/> <br/>
    /// <seealso cref="ReadShort(int, uint, int[])"/> <br/>
    /// <seealso cref="ReadShort(string, int, int[])"/> <br/>
    /// <seealso cref="ReadShort(string, int, int[])"/> <br/>
    /// <seealso cref="ReadShort(string, uint, int[])"/> <br/>
    /// <seealso cref="ReadInteger(int, int, int[])"/> <br/>
    /// <seealso cref="ReadInteger(int, uint, int[])"/> <br/>
    /// <seealso cref="ReadInteger(string, int, int[])"/> <br/>
    /// <seealso cref="ReadInteger(string, uint, int[])"/> <br/>
    /// <seealso cref="ReadLong(int, int, int[])"/> <br/>
    /// <seealso cref="ReadLong(int, uint, int[])"/> <br/>
    /// <seealso cref="ReadLong(string, int, int[])"/> <br/>
    /// <seealso cref="ReadLong(string, uint, int[])"/> <br/>
    /// <seealso cref="ReadFloat(int, int, int[])"/> <br/>
    /// <seealso cref="ReadFloat(int, uint, int[])"/> <br/>
    /// <seealso cref="ReadFloat(string, int, int[])"/> <br/>
    /// <seealso cref="ReadFloat(string, uint, int[])"/> <br/>
    /// <seealso cref="ReadDouble(int, int, int[])"/> <br/>
    /// <seealso cref="ReadDouble(int, uint, int[])"/> <br/>
    /// <seealso cref="ReadDouble(string, int, int[])"/> <br/>
    /// <seealso cref="ReadDouble(string, uint, int[])"/> <br/>
    /// <seealso cref="ReadString(int, int, int, System.Text.Encoding, int[])"/> <br/>
    /// <seealso cref="ReadString(string, int, int, System.Text.Encoding, int[])"/> <br/>
    /// <seealso cref="ReadBool(int, int, int[])"/> <br/>
    /// <seealso cref="ReadBool(int, uint, int[])"/> <br/>
    /// <seealso cref="ReadBool(string, int, int[])"/> <br/>
    /// <seealso cref="ReadBool(string, uint, int[])"/> <br/>
    /// </code>
    /// </p>
    /// </summary>
    public class Mem
    {
        /*
            CheckProcess()
        0 - Sorunu yok.
        1 - PID: 0'dır.
        2 - Process null'dır.
        3 - 'Yanıt vermiyor' hatası.
        4 - OpenProcess başarısız.
        5 - 64bit desteklenmez. 64bit destekli bir kitaplık gelecek.
        6 - Byte fonksiyonu için value dönüştürülmez.
        7 - Yazma başarısız.
        8 - Maksimum value aştı. Yazma başarısız.
        9 - Value geçerisizdir.
        10 - Özel hata oluştu.
        11 - Erişim engellendi. (Win32Exception)
        12 - Uygulama bulunamadı. (ArgumentException)
        13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (InvalidOperationException)
        14 - Uzak bir bilgisayarda bir uygulama erişmez. (NotSupportedException)
        */
        private static bool CheckProcess(int PID, out int errorcode)
        {
            try
            {
                if (PID <= 0)
                {
                    errorcode = 1;
                    return false;
                }
                Process Process = Process.GetProcessById(PID);
                if (Process == null)
                {
                    errorcode = 2;
                    return false;
                }
                if (!Process.Responding)
                {
                    errorcode = 3;
                    return false;
                }
                IntPtr openhandle = Write.OpenProcess(0x1F0FFF, true, PID);
                if (openhandle == IntPtr.Zero)
                {
                    errorcode = 4;
                    return false;
                }
                if (Environment.Is64BitOperatingSystem && (Write.IsWow64Process(Process.Handle, out bool retVal) && !retVal))
                {
                    errorcode = 5;
                }
            }
            catch (NotSupportedException)
            {
                errorcode = 14;
                return false;
            }
            catch (InvalidOperationException)
            {
                errorcode = 13;
                return false;
            }
            catch (ArgumentException)
            {
                errorcode = 12;
                return false;
            }
            catch (Win32Exception)
            {
                errorcode = 11;
                return false;
            }
            catch (Exception)
            {
                errorcode = 10;
                return false;
            }
            // bitti.
            errorcode = 0;
            return true;
        }
        /// <summary>
        /// <p> 
        ///     Value ayarlabilmek için sayı sistemi kodu kullanın. <br/> <br/> 
        ///     <see cref="NumberSystem.Binary"/>'da Sadece 0 ve 1 sayı sistemidir. Örnek: 1100 1001 0110 <br/>
        ///     <see cref="NumberSystem.Hexadecimal"/>'da 0'den F'e arası sayı sistemidir. Örnek: A3 C4 9C B5 <br/>
        ///     <see cref="NumberSystem.Octal"/>'da 0'den 8'e arası sayı sistemidir. Örnek: 1445044 <br/>
        ///     <see cref="NumberSystem.Decimal"/>'da 0'den 9'a arası sayı sistemidir. Örnek: 125 35 254 105
        /// </p>
        /// </summary>
        public enum NumberSystem 
        {
            /// <summary>
            ///  2-bit tabanlı sadece 0 ve 1 rakamları olan Binary (ikili) sayı sistemidir. <br/>
            ///  girilen value en fazla 8 basamaklı olmalıdır. <br/>
            ///  Kullanımı: <br/>
            ///   <see cref="Mem.NumberSystem.Binary"/>
            /// </summary>
            Binary = 1,
            /// <summary>
            ///  8-bit tabanlı 0-7 arası rakamları olan Octal (Oktallı) sayı sistemidir. <br/>
            ///  girilen value en fazla 3 basamaklı ve maksimum sayı 377 olmalıdır.<br/>
            ///  Kullanımı: <br/>
            ///   <see cref="Mem.NumberSystem.Octal"/>
            /// </summary>
            Octal = 2,
            /// <summary>
            ///  10-bit tabanlı 0-9 arası rakamları olan Decimal (Onlu) sayı sistemidir. <br/>
            ///  girilen value en fazla 3 basamaklı ve maksimum sayı 255 olmalıdır.<br/>
            ///  Kullanımı: <br/>
            ///   <see cref="Mem.NumberSystem.Decimal"/>
            /// </summary>
            Decimal = 3,
            /// <summary>
            ///  16-bit tabanlı 0 ile 9 arasında sayıları, A-F arasındaki harfler olan Hexadecimal (Onlu) sayı sistemidir. <br/>
            ///  girilen value en fazla 2 basamaklı ve maksimum sayı FF olmalıdır.<br/>
            ///  Kullanımı: <br/>
            ///  <see cref="Mem.NumberSystem.Hexadecimal"/>
            /// </summary>
            Hexadecimal = 4
        }
        private static byte[] ConvertNumberSystem(NumberSystem type, string value)
        {
            if (NumberSystem.Binary == type)
            {
                string[] Value  = value.Split(' ');
                byte[] topla = new byte[Value.Length];
                Regex rgx = new Regex("^[0-1]*$");
                foreach (var item in Value)
                {
                    if (!rgx.IsMatch(item))
                        return null;
                    if (!(item.Length < 9))
                        return null;
                }
                for (int i = 0; i < Value.Length; i++)
                {
                    topla[i] = Convert.ToByte(Convert.ToInt32(Value[i], 2));
                }
                return topla;
            }
            else if (NumberSystem.Octal == type)
            {
                string[] Value = value.Split(' ');
                byte[] topla = new byte[Value.Length];
                Regex rgx = new Regex("^[0-7]*$");
                foreach (var item in Value)
                {
                    if (!rgx.IsMatch(item))
                        return null;
                    if (!(item.Length < 4))
                        return null;
                    if (!(Convert.ToInt32(item) < 378))
                        return null;
                }
                for (int i = 0; i < Value.Length; i++)
                {
                    topla[i] = Convert.ToByte(Convert.ToInt32(Value[i], 8));
                }
                return topla;
                //return Convert.ToByte(Convert.ToInt32(value, 8));
            }
            else if (NumberSystem.Decimal == type)
            {
                string[] Value = value.Split(' ');
                byte[] topla = new byte[Value.Length];
                Regex rgx = new Regex("^[0-9]*$");
                foreach (var item in Value)
                {
                    item.PadLeft(3, '0');
                    if (!rgx.IsMatch(item))
                        return null;
                    if (!(Convert.ToInt32(item) < 256))
                        return null;
                }
                for (int i = 0; i < Value.Length; i++)
                {
                    topla[i] = Convert.ToByte(Convert.ToInt32(Value[i], 10));
                }
                return topla;
                //return Convert.ToByte(value);
            }
            else if (NumberSystem.Hexadecimal == type)
            {
                string[] Value = value.Split(' ');
                byte[] topla = new byte[Value.Length];
                Regex rgx = new Regex("^[a-fA-F0-9]*$");
                foreach (var item in Value)
                {
                    if (!rgx.IsMatch(item))
                        return null;
                    if (!(item.Length < 3))
                        return null;
                }
                for (int i = 0; i < Value.Length; i++)
                {
                    topla[i] = Convert.ToByte(Convert.ToInt32(Value[i], 16));
                }
                return topla;
                //return Convert.ToByte(Convert.ToInt32(value, 16));
            }
            return null;
        }
        private static string WriteByteFunc(IntPtr handle, int Pointer, byte[] Value)
        {
            Write.VirtualProtectEx(handle, (IntPtr)Pointer, (UIntPtr)Value.Length, 0x40 /* rw */, out uint flNewProtect);
            bool flag = Write.WriteProcessMemory(handle, Pointer, Value, (uint)Value.Length, 0u);
            Write.VirtualProtectEx(handle, (IntPtr)Pointer, (UIntPtr)Value.Length, flNewProtect, out _);
            if (flag == false)
            {
                return "7";
            }
            return "0";
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156 <br/>
        ///     8-bit tabanlı byte (1 Bytes) veri maksimum değer 256'dır.
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     WriteByte(PID, Module + Pointer, Value, Mem.NumberSystem, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     WriteByte(PID, Module + Pointer, Value, Mem.NumberSystem);</code><br/>
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="PID"/>'te erişilecek uygulama kimliği numarası<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri<br/>
        ///<paramref name="Value"/>'nde string için değer girin.<br/>
        ///<paramref name="Type"/>'de value ayarlanacak numara sistemi seçin. (Hexadecimal için Mem.NumberSystem.Hexadecimal)<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string WriteByte(int PID, int Pointer, string Value, NumberSystem Type, params int[] Offset)
        {
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;
            byte[] value = ConvertNumberSystem(Type, Value);
            if (value == null)
                return "6";
            int pointer = Pointer;

            // Bellek yaz.
            if (Offset == null)
            {
                string durumu = WriteByteFunc(handle, pointer, value);
                if (durumu == "7")
                {
                    return durumu;
                }
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                string durumu = WriteByteFunc(handle, pointer, value);
                if (durumu == "7")
                {
                    return durumu;
                }
            }

            return basarisiz.ToString();
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     8-bit tabanlı byte (1 Bytes) veri maksimum değer 256'dır.
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     WriteByte("Game.exe", Module + Pointer, Value, Mem.NumberSystem, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     WriteByte("Game.exe", Module + Pointer, Value, Mem.NumberSystem);</code><br/>
        ///     NOT: Yanlız bir uygulama erişebilir. Birden fazla uygulamaları erişmez.
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="ProcessName"/>'te erişilecek uygulama adı<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri<br/>
        ///<paramref name="Value"/>'nde string için değer girin.<br/>
        ///<paramref name="Type"/>'de value ayarlanacak numara sistemi seçin. (Hexadecimal için Mem.NumberSystem.Hexadecimal)<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string WriteByte(string ProcessName, int Pointer, string Value, NumberSystem Type, params int[] Offset)
        {
            string uygadi = ProcessName;
            if (ProcessName.Contains(".exe"))
                uygadi = uygadi.Replace(".exe", "");
            int PID = Process.GetProcessesByName(uygadi)[0].Id;
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;
            byte[] value = ConvertNumberSystem(Type, Value);
            if (value == null)
                return "6";
            int pointer = Pointer;

            // Bellek yaz.
            if (Offset == null)
            {
                string durumu = WriteByteFunc(handle, pointer, value);
                if (durumu == "7")
                {
                    return durumu;
                }
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                string durumu = WriteByteFunc(handle, pointer, value);
                if (durumu == "7")
                {
                    return durumu;
                }
            }

            return basarisiz.ToString();
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     8-bit tabanlı byte (1 Bytes) veri maksimum değer 256'dır.
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     WriteByte(PID, Module + Pointer, ByteValue, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     WriteByte(PID, Module + Pointer, ByteValue);</code><br/>
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="PID"/>'te erişilecek uygulama kimliği numarası<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri<br/>
        ///<paramref name="Value"/>'nde byte için bir değeri girin.<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string WriteByte(int PID, int Pointer, byte Value, params int[] Offset)
        {
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;
            byte[] value = new byte[1] {Value};
            if (value == null)
                return "6";
            int pointer = Pointer;

            // Bellek yaz.
            if (Offset == null)
            {
                string durumu = WriteByteFunc(handle, pointer, value);
                if (durumu == "7")
                {
                    return durumu;
                }
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                string durumu = WriteByteFunc(handle, pointer, value);
                if (durumu == "7")
                {
                    return durumu;
                }
            }
            return basarisiz.ToString();
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     8-bit tabanlı byte (1 Bytes) veri maksimum değer 256'dır.
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     WriteByte("Game.exe", Module + Pointer, ByteValue, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     WriteByte("Game.exe", Module + Pointer, ByteValue);</code><br/>
        ///     NOT: Yanlız bir uygulama erişebilir. Birden fazla uygulamaları erişmez.
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="ProcessName"/>'te erişilecek uygulama adı<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri<br/>
        ///<paramref name="Value"/>'nde byte için bir değeri girin.<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string WriteByte(string ProcessName, int Pointer, byte Value, params int[] Offset)
        {
            string uygadi = ProcessName;
            if (ProcessName.Contains(".exe"))
                uygadi = uygadi.Replace(".exe", "");
            int PID = Process.GetProcessesByName(uygadi)[0].Id;
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;
            byte[] value = new byte[1] { Value };
            if (value == null)
                return "6";
            int pointer = Pointer;

            // Bellek yaz.
            if (Offset == null)
            {
                string durumu = WriteByteFunc(handle, pointer, value);
                if (durumu == "7")
                {
                    return durumu;
                }
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                string durumu = WriteByteFunc(handle, pointer, value);
                if (durumu == "7")
                {
                    return durumu;
                }
            }
            return basarisiz.ToString();
        }
        private static byte[] ConvertNumberSystemString(NumberSystem type, string[] Value)
        { //
            if (NumberSystem.Binary == type)
            {
                Regex rgx = new Regex("^[0-1]*$");
                foreach (var item in Value)
                {
                    if (!rgx.IsMatch(item))
                        return null;
                    if (!(item.Length < 9))
                        return null;
                }

                byte[] topla = new byte[Value.Length];
                for (int i = 0; i < Value.Length; i++)
                {
                    topla[i] = Convert.ToByte(Convert.ToInt16(Value[i], 2));
                }
                return topla;
            }else if (NumberSystem.Octal == type)
            {
                Regex rgx = new Regex("^[0-7]*$");
                foreach (var item in Value)
                {
                    if (!rgx.IsMatch(item))
                        return null;
                    if (!(item.Length < 4))
                        return null;
                    if (!(Convert.ToInt32(item) < 378))
                        return null;
                }
                byte[] topla = new byte[Value.Length];
                for (int i = 0; i < Value.Length; i++)
                {
                    topla[i] = Convert.ToByte(Convert.ToInt32(Value[i], 8));
                }
                return topla;
            }
            else if (NumberSystem.Decimal == type)
            {
                Regex rgx = new Regex("^[0-9]*$");
                foreach (var item in Value)
                {
                    if (!rgx.IsMatch(item))
                        return null;
                    if (!(Convert.ToInt32(item) < 256))
                        return null;
                }

                byte[] topla = new byte[Value.Length];
                for (int i = 0; i < Value.Length; i++)
                {
                    topla[i] = Convert.ToByte(Convert.ToInt32(Value[i], 10));
                }
                return topla;
                //return Convert.ToByte(value);
            }
            else if (NumberSystem.Hexadecimal == type)
            {
                Regex rgx = new Regex("^[a-fA-F0-9]*$");
                foreach (var item in Value)
                {
                    if (!rgx.IsMatch(item))
                        return null;
                    if (!(item.Length < 3))
                        return null;
                }
                byte[] topla = new byte[Value.Length];
                for (int i = 0; i < Value.Length; i++)
                {
                    topla[i] = Convert.ToByte(Convert.ToInt32(Value[i], 16));
                }
                return topla;
            }
            return null;
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     8-bit tabanlı byte (1 Bytes) veri maksimum değer 256'dır.
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     WriteByte(PID, Module + Pointer, Value[], Mem.NumberSystem,  Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     WriteByte(PID, Module + Pointer, Value[], Mem.NumberSystem);</code><br/>
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="PID"/>'te erişilecek uygulama kimliği numarası<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri<br/>
        ///<paramref name="Value"/>'nde string array dizi için değer girin. (string[] Value = {"AA","BB","CC"}<br/>
        ///<paramref name="Type"/>'de value ayarlanacak numara sistemi seçin. (Hexadecimal için Mem.NumberSystem.Hexadecimal)<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string WriteByte(int PID, int Pointer, string[] Value, NumberSystem Type, params int[] Offset)
        {
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;
            byte[] value = ConvertNumberSystemString(Type, Value);
            if (value == null)
                return "6";
            int pointer = Pointer;

            // Bellek yaz.
            if (Offset == null)
            {
                string durumu = WriteByteFunc(handle, pointer, value);
                if (durumu == "7")
                {
                    return durumu;
                }
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                string durumu = WriteByteFunc(handle, pointer, value);
                if (durumu == "7")
                {
                    return durumu;
                }
            }
            return basarisiz.ToString();
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     8-bit tabanlı byte (1 Bytes) veri maksimum değer 256'dır.
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     WriteByte("Game.exe", Module + Pointer, Value[], Mem.NumberSystem, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     WriteByte("Game.exe", Module + Pointer, Value[], Mem.NumberSystem);</code><br/>
        ///     NOT: Yanlız bir uygulama erişebilir. Birden fazla uygulamaları erişmez.
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="ProcessName"/>'te erişilecek uygulama adı<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri<br/>
        ///<paramref name="Value"/>'nde string array dizi için hexadecimal vb.. değeri girip NumberSystem kullanın. (string[] Value = {"AA","BB","CC"}<br/>
        ///<paramref name="Type"/>'de value ayarlanacak numara sistemi seçin. (Hexadecimal için Mem.NumberSystem.Hexadecimal)<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string WriteByte(string ProcessName, int Pointer, string[] Value, NumberSystem Type, params int[] Offset)
        {
            string uygadi = ProcessName;
            if (ProcessName.Contains(".exe"))
                uygadi = uygadi.Replace(".exe", "");
            int PID = Process.GetProcessesByName(uygadi)[0].Id;
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;
            byte[] value = ConvertNumberSystemString(Type, Value);
            if (value == null)
                return "6";
            int pointer = Pointer;

            // Bellek yaz.
            if (Offset == null)
            {
                string durumu = WriteByteFunc(handle, pointer, value);
                if (durumu == "7")
                {
                    return durumu;
                }
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                string durumu = WriteByteFunc(handle, pointer, value);
                if (durumu == "7")
                {
                    return durumu;
                }
            }
            return basarisiz.ToString();
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     8-bit tabanlı byte (1 Bytes) veri maksimum değer 256'dır.
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     WriteByte(PID, Module + Pointer, Value[], Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     WriteByte(PID, Module + Pointer, Value[]);</code><br/>
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="PID"/>'te erişilecek uygulama kimlik numarası<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri<br/>
        ///<paramref name="Value"/>'nde byte array dizi için değer girin. (byte[] Value = {0x1A, 154, 0x4B}<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string WriteByte(int PID, int Pointer, byte[] Value, params int[] Offset)
        {
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;
            byte[] value = Value;
            if (value == null)
                return "6";
            int pointer = Pointer;

            // Bellek yaz.
            if (Offset == null)
            {
                string durumu = WriteByteFunc(handle, pointer, value);
                if (durumu == "7")
                {
                    return durumu;
                }
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                string durumu = WriteByteFunc(handle, pointer, value);
                if (durumu == "7")
                {
                    return durumu;
                }
            }
            return basarisiz.ToString();
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     8-bit tabanlı byte (1 Bytes) veri maksimum değer 256'dır.
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     WriteByte("Game.exe", Module + Pointer, Value[], Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     WriteByte("Game.exe", Module + Pointer, Value[]);</code><br/>
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="ProcessName"/>'te erişilecek uygulama adı<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri<br/>
        ///<paramref name="Value"/>'nde byte array dizi için değeri girin. (byte[] Value = new byte[3] = {0x1A, 154, 0x4B}<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string WriteByte(string ProcessName, int Pointer, byte[] Value, params int[] Offset)
        {
            string uygadi = ProcessName;
            if (ProcessName.Contains(".exe"))
                uygadi = uygadi.Replace(".exe", "");
            int PID = Process.GetProcessesByName(uygadi)[0].Id;
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;
            byte[] value = Value;
            if (value == null)
                return "6";
            int pointer = Pointer;

            // Bellek yaz.
            if (Offset == null)
            {
                string durumu = WriteByteFunc(handle, pointer, value);
                if (durumu == "7")
                {
                    return durumu;
                }
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                string durumu = WriteByteFunc(handle, pointer, value);
                if (durumu == "7")
                {
                    return durumu;
                }
            }
            return basarisiz.ToString();
        }
        //-------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     16-bit tabanlı short (2 Bytes) veri maksimum değer 65535'dır.
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     WriteShort(PID, Module + Pointer, Value, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     WriteShort(PID, Module + Pointer, Value);</code><br/>
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="PID"/>'te erişilecek uygulama kimliği numarası<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri<br/>
        ///<paramref name="Value"/>'nde metin için sayısal değeri girin.<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Maksimum value aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string WriteShort(int PID, int Pointer, string Value, params int[] Offset)
        {
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            if (!int.TryParse(Value, out _))
            {
                return "6";
            }

            byte[] value = new byte[2];
            if (Convert.ToInt64(Value) > short.MaxValue)
                return "8"; //Maksimum aştı.
            value[0] = (byte)(Convert.ToInt32(Value) % 256);
            value[1] = (byte)(Convert.ToInt32(Value) / 256);
            if (value == null)
                return "6";
            int pointer = Pointer;

            // Bellek yaz.
            if (Offset == null)
            {
                if (!WriteFunc(handle, pointer, value, 2))
                    return "7";
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                if (!WriteFunc(handle, pointer, value, 2))
                    return "7";
            }

            return basarisiz.ToString();
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     16-bit tabanlı short (2 Bytes) veri maksimum değer 65535'dır.
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     WriteShort("Game.exe", Module + Pointer, Value, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     WriteShort("Game.exe", Module + Pointer, Value);</code><br/>
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="ProcessName"/>'te erişilecek uygulama adı<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri<br/>
        ///<paramref name="Value"/>'nde metin için sayısal değeri girin.<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Maksimum value aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string WriteShort(string ProcessName, int Pointer, string Value, params int[] Offset)
        {
            string uygadi = ProcessName;
            if (ProcessName.Contains(".exe"))
                uygadi = uygadi.Replace(".exe", "");
            int basarisiz;
            int PID = Process.GetProcessesByName(uygadi)[0].Id;
            if (!CheckProcess(PID, out basarisiz))
            {
                return basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle; 
            
            if (!int.TryParse(Value, out _))
            {
                return "6";
            }

            if (Convert.ToInt64(Value) > short.MaxValue)
                return "8"; 
            byte[] value = new byte[2];
            value[0] = (byte)(Convert.ToInt32(Value) % 256);
            value[1] = (byte)(Convert.ToInt32(Value) / 256);
            if (value == null)
                return "6";
            int pointer = Pointer;

            // Bellek yaz.
            if (Offset == null)
            {
                if (!WriteFunc(handle, pointer, value, 2))
                    return "7";
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                if (!WriteFunc(handle, pointer, value, 2))
                    return "7";
            }
            return basarisiz.ToString();
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     16-bit tabanlı short (2 Bytes) veri maksimum değer 65535'dır.
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     WriteShort(PID, Module + Pointer, Value, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     WriteShort(PID, Module + Pointer, Value);</code><br/>
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="PID"/>'te erişilecek uygulama kimliği numarası<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri<br/>
        ///<paramref name="Value"/>'nde short için sayısal değeri girin.<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Maksimum value aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string WriteShort(int PID, int Pointer, int Value, params int[] Offset)
        {
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            if (Convert.ToInt64(Value) > short.MaxValue)
                return "8"; //Maksimum aştı.
            byte[] value = new byte[2];
            value[0] = (byte)(Value % 256);
            value[1] = (byte)(Value / 256);
            if (value == null)
                return "6";
            int pointer = Pointer;

            // Bellek yaz.
            if (Offset == null)
            {
                if (!WriteFunc(handle, pointer, value, 2))
                    return "7";
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                if (!WriteFunc(handle, pointer, value, 2))
                    return "7";
            }

            return basarisiz.ToString();
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     16-bit tabanlı short (2 Bytes) veri maksimum değer 65535'dır.
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     WriteShort("Game.exe", Module + Pointer, Value, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     WriteShort("Game.exe", Module + Pointer, Value);</code><br/>
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="ProcessName"/>'te erişilecek uygulama adı<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri<br/>
        ///<paramref name="Value"/>'nde short için sayısal değeri girin.<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Maksimum value aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string WriteShort(string ProcessName, int Pointer, int Value, params int[] Offset)
        {
            string uygadi = ProcessName;
            if (ProcessName.Contains(".exe"))
                uygadi = uygadi.Replace(".exe", "");
            int basarisiz;
            int PID = Process.GetProcessesByName(uygadi)[0].Id;
            if (!CheckProcess(PID, out basarisiz))
            {
                return basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;
            if (Convert.ToInt64(Value) > short.MaxValue)
                return "8"; //Maksimum aştı.
            byte[] value = new byte[2];
            value[0] = (byte)(Value % 256);
            value[1] = (byte)(Value / 256);
            if (value == null)
                return "6";
            int pointer = Pointer;

            // Bellek yaz.
            if (Offset == null)
            {
                if (!WriteFunc(handle, pointer, value, 2))
                    return "7";
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                if (!WriteFunc(handle, pointer, value, 2))
                    return "7";
            }

            return basarisiz.ToString();
        }
        //-------------------------------------------------------------------------------------------------------------
        private static bool WriteFunc(IntPtr handle, int Pointer, byte[] Value, int size = 4)
        {
            Write.MemoryProtection newProtection = Write.MemoryProtection.ExecuteReadWrite;
            Write.MemoryProtection OldMemProt = 0x00;
            bool Is64Bit = Environment.Is64BitOperatingSystem && (Write.IsWow64Process(handle, out bool retVal) && !retVal);
            Write.VirtualProtectEx2(handle, (UIntPtr)Pointer, (IntPtr)(Is64Bit ? 8 : 4), newProtection, out OldMemProt);
            bool flag = Write.WriteProcessMemory(handle, Pointer, Value, (uint)size, 0);
            Write.VirtualProtectEx2(handle, (UIntPtr)Pointer, (IntPtr)(Is64Bit ? 8 : 4), OldMemProt, out _);
            return flag;
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     32-bit tabanlı int (4 Bytes) veri maksimum değer 2147483647'dır.
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     WriteInteger(PID, Module + Pointer, Value, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     WriteInteger(PID, Module + Pointer, Value);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="PID"/>'te uygulama çalışan kimliği numarası <br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri <br/>
        ///<paramref name="Value"/>'nde string için sayısal değer girin. <br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string WriteInteger(int PID, int Pointer, string Value, params int[] Offset)
        {
            // Uygulama kontrol et.
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return basarisiz.ToString();
            }

            // Uygulama bilgi al
            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            // Value sayısal mı?
            if (!int.TryParse(Value, out _))
            {
                return "6";
            }

            //int value = Convert.ToInt32(Value);
            byte[] value = BitConverter.GetBytes(Convert.ToInt32(Value));
            int pointer = Pointer;

            // Value kontrol et.
            if (Convert.ToInt64(Value) > Int32.MaxValue)
                return "8"; //Maksimum aştı.
            // Bellek yaz.
            if (Offset == null)
            {
                if (!WriteFunc(handle, pointer, value, 4))
                    return "7";
                //Write.WriteProcessMemory2(handle, pointer, ref value, 4, 0);
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer,ref pointer, 4, 0);
                    pointer += off;
                }
                if (!WriteFunc(handle, pointer, value, 4))
                    return "7";
                //Write.WriteProcessMemory2(handle, pointer, ref value, 4, 0);
            }
            // Bitti.
            return basarisiz.ToString();
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     32-bit tabanlı int (4 Bytes) veri maksimum değer 2147483647'dır.
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     WriteInteger("Game.exe", Module + Pointer, Value, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     WriteInteger("Game.exe", Module + Pointer, Value);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="ProcessName"/>'te erişilecek uygulama adı<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri <br/>
        ///<paramref name="Value"/>'nde string için sayısal değer girin. <br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string WriteInteger(string ProcessName, int Pointer, string Value, params int[] Offset)
        {
            // Uygulama kontrol et.
            int basarisiz;
            string procname = ProcessName;
            if (ProcessName.Contains(".exe"))
                procname = procname.Replace(".exe", "");

            int PID = Process.GetProcessesByName(procname)[0].Id;
            if (!CheckProcess(PID, out basarisiz))
            {
                return basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            if (!int.TryParse(Value, out _))
            {
                return "6";
            }

            byte[] value = BitConverter.GetBytes(Convert.ToInt32(Value));
            int pointer = Pointer;

            if (Convert.ToInt64(Value) > Int32.MaxValue)
                return "8";

            // Bellek yaz.
            if (Offset == null)
            {
                if (!WriteFunc(handle, pointer, value, 4))
                    return "7";
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                if (!WriteFunc(handle, pointer, value, 4))
                    return "7";
                //Write.WriteProcessMemory2(handle, pointer, ref value, 4, 0);
            }
            return basarisiz.ToString();
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     32-bit tabanlı int (4 Bytes) veri maksimum değer 2147483647'dır.
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     WriteInteger(PID, Module + Pointer, Value, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     WriteInteger(PID, Module + Pointer, Value);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="PID"/>'te erişilecek uygulama kimliği numarası<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri <br/>
        ///<paramref name="Value"/>'nde int için sayısal değer girin. <br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string WriteInteger(int PID, int Pointer, int Value, params int[] Offset)
        {
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;
            byte[] value = BitConverter.GetBytes(Value);
            int pointer = Pointer;

            if (Convert.ToInt64(Value) > Int32.MaxValue)
                return "8"; 

            // Bellek yaz.
            if (Offset == null)
            {
                if (!WriteFunc(handle, pointer, value, 4))
                    return "7";
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                if (!WriteFunc(handle, pointer, value, 4))
                    return "7";
                //Write.WriteProcessMemory2(handle, pointer, ref value, 4, 0);
            }
            return basarisiz.ToString();
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     32-bit tabanlı int (4 Bytes) veri maksimum değer 2147483647'dır.
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     WriteInteger("Game.exe", Module + Pointer, Value, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     WriteInteger("Game.exe", Module + Pointer, Value);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="ProcessName"/>'te erişilecek uygulama adı<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri <br/>
        ///<paramref name="Value"/>'nde int için sayısal değer girin. <br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string WriteInteger(string ProcessName, int Pointer, int Value, params int[] Offset)
        {
            int basarisiz;
            string procname = ProcessName;
            if (ProcessName.Contains(".exe"))
                procname = procname.Replace(".exe", "");

            int PID = Process.GetProcessesByName(procname)[0].Id;
            if (!CheckProcess(PID, out basarisiz))
            {
                return basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;
            byte[] value = BitConverter.GetBytes(Value);
            int pointer = Pointer;

            if (Convert.ToInt64(Value) > Int32.MaxValue)
                return "8";

            // Bellek yaz.
            if (Offset == null)
            {
                if (!WriteFunc(handle, pointer, value, 4))
                    return "7";
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                if (!WriteFunc(handle, pointer, value, 4))
                    return "7";
            }
            return basarisiz.ToString();
        }
        //-------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     64-bit tabanlı long (8 Bytes) veri maksimum değer 9,223,372,036,854,775,807'dır.
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     WriteLong(PID, Module + Pointer, Value, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     WriteLong(PID, Module + Pointer, Value);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="PID"/>'te erişilecek uygulama kimliği numarası<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri <br/>
        ///<paramref name="Value"/>'nde string için sayısal değer girin. <br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string WriteLong(int PID, int Pointer, string Value, params int[] Offset)
        {
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            if (!long.TryParse(Value, out _))
            {
                return "6" + " : " + Value;
            }

            if (Convert.ToInt64(Value) > Int64.MaxValue)
                return "8";

            byte[] value = BitConverter.GetBytes(Convert.ToInt64(Value));
            int pointer = Pointer;

            if (Offset == null)
            {
                if (!WriteFunc(handle, pointer, value, 8))
                    return "7";
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                if (!WriteFunc(handle, pointer, value, 8))
                    return "7";
            }
            return basarisiz.ToString();
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     64-bit tabanlı long (8 Bytes) veri maksimum değer 9,223,372,036,854,775,807'dır.
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     WriteLong("Game.exe", Module + Pointer, Value, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     WriteLong("Game.exe", Module + Pointer, Value);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="ProcessName"/>'te erişilecek uygulama adı<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri <br/>
        ///<paramref name="Value"/>'nde string için sayısal değer girin. <br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string WriteLong(string ProcessName, int Pointer, string Value, params int[] Offset)
        {
            int basarisiz;
            string procname = ProcessName;
            if (ProcessName.Contains(".exe"))
                procname = procname.Replace(".exe", "");
            int PID = Process.GetProcessesByName(procname)[0].Id;
            if (!CheckProcess(PID, out basarisiz))
            {
                return basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            if (!long.TryParse(Value, out _))
            {
                return "6" + " : " + Value;
            }

            if (Convert.ToInt64(Value) > Int64.MaxValue)
                return "8";

            byte[] value = BitConverter.GetBytes(Convert.ToInt64(Value));
            int pointer = Pointer;

            if (Offset == null)
            {
                if (!WriteFunc(handle, pointer, value, 8))
                    return "7";
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                if (!WriteFunc(handle, pointer, value, 8))
                    return "7";
            }
            return basarisiz.ToString();
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     64-bit tabanlı long (8 Bytes) veri maksimum değer 9,223,372,036,854,775,807'dır.
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     WriteLong(PID, Module + Pointer, Value, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     WriteLong(PID, Module + Pointer, Value);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="PID"/>'te erişilecek uygulama kimliği numarası <br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri <br/>
        ///<paramref name="Value"/>'nde long için sayısal değer girin. <br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string WriteLong(int PID, int Pointer, int Value, params int[] Offset)
        {
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            if (Convert.ToInt64(Value) > Int64.MaxValue)
                return "8";

            byte[] value = BitConverter.GetBytes(Convert.ToInt64(Value));
            int pointer = Pointer;

            if (Offset == null)
            {
                if (!WriteFunc(handle, pointer, value, 8))
                    return "7";
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                if (!WriteFunc(handle, pointer, value, 8))
                    return "7";
            }
            return basarisiz.ToString();
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     64-bit tabanlı long (8 Bytes) veri maksimum değer 9,223,372,036,854,775,807'dır.
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     WriteLong("Game.exe", Module + Pointer, Value, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     WriteLong("Game.exe", Module + Pointer, Value);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="ProcessName"/>'te erişilecek uygulama adı<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri <br/>
        ///<paramref name="Value"/>'nde long için sayısal değer girin. <br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string WriteLong(string ProcessName, int Pointer, int Value, params int[] Offset)
        {
            int basarisiz;
            string procname = ProcessName;
            if (ProcessName.Contains(".exe"))
                procname = procname.Replace(".exe", "");
            int PID = Process.GetProcessesByName(procname)[0].Id;
            if (!CheckProcess(PID, out basarisiz))
            {
                return basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            if (Convert.ToInt64(Value) > Int64.MaxValue)
                return "8";

            byte[] value = BitConverter.GetBytes(Convert.ToInt64(Value));
            int pointer = Pointer;

            if (Offset == null)
            {
                if (!WriteFunc(handle, pointer, value, 8))
                    return "7";
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                if (!WriteFunc(handle, pointer, value, 8))
                    return "7";
            }
            return basarisiz.ToString();
        }
        //-------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     32-bit tabanlı float (4 Bytes) veri maksimum değer 3.402823466E+38'dır.
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     WriteFloat(PID, Module + Pointer, Value, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     WriteFloat(PID, Module + Pointer, Value);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="PID"/>'te erişilecek uygulama kimliği numarası<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri <br/>
        ///<paramref name="Value"/>'nde float için decimal yada hexadecimal değer girin. <br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string WriteFloat(int PID, int Pointer, string Value, params int[] Offset)
        {
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            if (!float.TryParse(Value, out _))
            {
                return "6";
            }
            if (Convert.ToSingle(Value) > Single.MaxValue)
                return "8";

            byte[] value = BitConverter.GetBytes(Convert.ToSingle(Value));
            int pointer = Pointer;

            if (Offset == null)
            {
                if (!WriteFunc(handle, pointer, value, 4))
                    return "7";
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                if (!WriteFunc(handle, pointer, value, 4))
                    return "7";
            }
            return basarisiz.ToString();
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     32-bit tabanlı float (4 Bytes) veri maksimum değer 3.402823466E+38'dır.
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     WriteFloat("Game.exe", Module + Pointer, Value, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     WriteFloat("Game.exe", Module + Pointer, Value);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="ProcessName"/>'te erişilecek uygulama adı<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri <br/>
        ///<paramref name="Value"/>'nde float için decimal yada hexadecimal değer girin. <br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string WriteFloat(string ProcessName, int Pointer, string Value, params int[] Offset)
        {
            int basarisiz;
            string procname = ProcessName;
            if (ProcessName.Contains(".exe"))
                procname = procname.Replace(".exe", "");
            int PID = Process.GetProcessesByName(procname)[0].Id;
            if (!CheckProcess(PID, out basarisiz))
            {
                return basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            if (!float.TryParse(Value, out _))
            {
                return "6";
            }
            if (Convert.ToSingle(Value) > Single.MaxValue)
                return "8";

            byte[] value = BitConverter.GetBytes(Convert.ToSingle(Value));
            int pointer = Pointer;

            if (Offset == null)
            {
                if (!WriteFunc(handle, pointer, value, 4))
                    return "7";
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                if (!WriteFunc(handle, pointer, value, 4))
                    return "7";
            }
            return basarisiz.ToString();
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     32-bit tabanlı float (4 Bytes) veri maksimum değer 3.402823466E+38'dır.
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     WriteFloat(PID, Module + Pointer, Value, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     WriteFloat(PID, Module + Pointer, Value);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="PID"/>'te erişilecek uygulama kimliği numarası<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri <br/>
        ///<paramref name="Value"/>'nde float için decimal yada hexadecimal değer girin. <br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string WriteFloat(int PID, int Pointer, float Value, params int[] Offset)
        {
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;


            if (Value > Single.MaxValue)
                return "8";

            byte[] value = BitConverter.GetBytes(Value);
            int pointer = Pointer;

            if (Offset == null)
            {
                if (!WriteFunc(handle, pointer, value, 4))
                    return "7";
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                if (!WriteFunc(handle, pointer, value, 4))
                    return "7";
            }
            return basarisiz.ToString();
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     32-bit tabanlı float (4 Bytes) veri maksimum değer 3.402823466E+38'dır.
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     WriteFloat("Game.exe", Module + Pointer, Value, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     WriteFloat("Game.exe", Module + Pointer, Value);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="ProcessName"/>'te erişilecek uygulama adı<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri <br/>
        ///<paramref name="Value"/>'nde float için decimal yada hexadecimal değer girin. <br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string WriteFloat(string ProcessName, int Pointer, float Value, params int[] Offset)
        {
            int basarisiz;
            string procname = ProcessName;
            if (ProcessName.Contains(".exe"))
                procname = procname.Replace(".exe", "");
            int PID = Process.GetProcessesByName(procname)[0].Id;
            if (!CheckProcess(PID, out basarisiz))
            {
                return basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;


            if (Value > Single.MaxValue)
                return "8";

            byte[] value = BitConverter.GetBytes(Value);
            int pointer = Pointer;

            if (Offset == null)
            {
                if (!WriteFunc(handle, pointer, value, 4))
                    return "7";
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                if (!WriteFunc(handle, pointer, value, 4))
                    return "7";
            }
            return basarisiz.ToString();
        }
        //-------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     64-bit tabanlı double (8 Bytes) veri maksimum değer 1.7976931348623158E+308'dır.
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     WriteDouble(PID, Module + Pointer, Value, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     WriteDouble(PID, Module + Pointer, Value);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="PID"/>'te erişilecek uygulama kimliği numarası<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri <br/>
        ///<paramref name="Value"/>'nde double için hexadecimal yada decimal değer girin. <br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string WriteDouble(int PID, int Pointer, string Value, params int[] Offset)
        {
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            if (!double.TryParse(Value, out _))
            {
                return "6";
            }
            if (Convert.ToDouble(Value) > Double.MaxValue)
                return "8";

            byte[] value = BitConverter.GetBytes(Convert.ToDouble(Value));
            int pointer = Pointer;

            if (Offset == null)
            {
                if (!WriteFunc(handle, pointer, value, 8))
                    return "7";
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                if (!WriteFunc(handle, pointer, value, 8))
                    return "7";
            }
            return basarisiz.ToString();
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     64-bit tabanlı double (8 Bytes) veri maksimum değer 1.7976931348623158E+308'dır.
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     WriteDouble("Game.exe", Module + Pointer, Value, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     WriteDouble("Game.exe", Module + Pointer, Value);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="ProcessName"/>'te erişilecek uygulama adı<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri <br/>
        ///<paramref name="Value"/>'nde double için hexadecimal yada decimal değer girin. <br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string WriteDouble(string ProcessName, int Pointer, string Value, params int[] Offset)
        {
            int basarisiz;
            string procname = ProcessName;
            if (ProcessName.Contains(".exe"))
                procname = procname.Replace(".exe", "");
            int PID = Process.GetProcessesByName(procname)[0].Id;
            if (!CheckProcess(PID, out basarisiz))
            {
                return basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            if (!double.TryParse(Value, out _))
            {
                return "6";
            }
            if (Convert.ToDouble(Value) > Double.MaxValue)
                return "8";

            byte[] value = BitConverter.GetBytes(Convert.ToDouble(Value));
            int pointer = Pointer;

            if (Offset == null)
            {
                if (!WriteFunc(handle, pointer, value, 8))
                    return "7";
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                if (!WriteFunc(handle, pointer, value, 8))
                    return "7";
            }
            return basarisiz.ToString();
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     64-bit tabanlı double (8 Bytes) veri maksimum değer 1.7976931348623158E+308'dır.
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     WriteDouble(PID, Module + Pointer, Value, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     WriteDouble(PID, Module + Pointer, Value);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="PID"/>'te erişilecek uygulama kimliği numarası<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri <br/>
        ///<paramref name="Value"/>'nde double için hexadecimal yada decimal değer girin. <br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string WriteDouble(int PID, int Pointer, double Value, params int[] Offset)
        {
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            if (Value > Double.MaxValue)
                return "8";

            byte[] value = BitConverter.GetBytes(Value);
            int pointer = Pointer;

            if (Offset == null)
            {
                if (!WriteFunc(handle, pointer, value, 8))
                    return "7";
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                if (!WriteFunc(handle, pointer, value, 8))
                    return "7";
            }
            return basarisiz.ToString();
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     64-bit tabanlı double (8 Bytes) veri maksimum değer 1.7976931348623158E+308'dır.
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     WriteDouble("Game.exe", Module + Pointer, Value, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     WriteDouble("Game.exe", Module + Pointer, Value);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="ProcessName"/>'te erişilecek uygulama adı<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri <br/>
        ///<paramref name="Value"/>'nde double için hexadecimal yada decimal değer girin. <br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string WriteDouble(string ProcessName, int Pointer, double Value, params int[] Offset)
        {
            int basarisiz;
            string procname = ProcessName;
            if (ProcessName.Contains(".exe"))
                procname = procname.Replace(".exe", "");
            int PID = Process.GetProcessesByName(procname)[0].Id;
            if (!CheckProcess(PID, out basarisiz))
            {
                return basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            if (Value > Double.MaxValue)
                return "8";

            byte[] value = BitConverter.GetBytes(Value);
            int pointer = Pointer;

            if (Offset == null)
            {
                if (!WriteFunc(handle, pointer, value, 8))
                    return "7";
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                if (!WriteFunc(handle, pointer, value, 8))
                    return "7";
            }
            return basarisiz.ToString();
        }
        //-------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     WriteString(PID, Module + Pointer, Value, System.Text.Encoding, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     WriteString(PID, Module + Pointer, Value, System.Text.Encoding);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="PID"/>'te erişilecek uygulama kimliği numarası<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri <br/>
        ///<paramref name="Value"/>'nde string metin değeri girin. <br/>
        ///<paramref name="Type"/>'nde metin kodlama türü kullanın (Varsayılan <see cref="System.Text.Encoding.UTF8"/>'tir.)
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string WriteString(int PID, int Pointer, string Value, System.Text.Encoding Type, params int[] Offset)
        {
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            byte[] value = Type.GetBytes(Value);
            int size = value.Length;
            int pointer = Pointer;

            if (Offset == null)
            {
                if (!WriteFunc(handle, pointer, value, size))
                    return "7";
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                if (!WriteFunc(handle, pointer, value, size))
                    return "7";
            }
            return basarisiz.ToString();
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     WriteString("Game.exe", Module + Pointer, Value, System.Text.Encoding, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     WriteString("Game.exe", Module + Pointer, Value, System.Text.Encoding);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="ProcessName"/>'te erişilecek uygulama adı<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri <br/>
        ///<paramref name="Value"/>'nde string metin değeri girin. <br/>
        ///<paramref name="Type"/>'nde metin kodlama türü kullanın (Varsayılan <see cref="System.Text.Encoding.UTF8"/>'tir.)
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string WriteString(string ProcessName, int Pointer, string Value, System.Text.Encoding Type, params int[] Offset)
        {
            int basarisiz;
            string procname = ProcessName;
            if (ProcessName.Contains(".exe"))
                procname = procname.Replace(".exe", "");
            int PID = Process.GetProcessesByName(procname)[0].Id;
            if (!CheckProcess(PID, out basarisiz))
            {
                return basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            byte[] value = Type.GetBytes(Value);
            int size = value.Length;
            int pointer = Pointer;

            if (Offset == null)
            {
                if (!WriteFunc(handle, pointer, value, size))
                    return "7";
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                if (!WriteFunc(handle, pointer, value, size))
                    return "7";
            }
            return basarisiz.ToString();
        }
        //-------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     WriteBool(PID, Module + Pointer, Value, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     WriteBool(PID, Module + Pointer, Value);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="PID"/>'te erişilecek uygulama kimliği numarası<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri <br/>
        ///<paramref name="Value"/>'nde string için true ve false metin olarak girin. <br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string WriteBool(int PID, int Pointer, string Value, params int[] Offset)
        {
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            if (!bool.TryParse(Value, out _))
            {
                return "6";
            }

            byte[] value = new byte[1];
            if (Value.ToLower() == "true")
            {
                value = BitConverter.GetBytes(Convert.ToBoolean(true));
            }
            else if (Value.ToLower() == "1")
            {
                value = BitConverter.GetBytes(Convert.ToBoolean(true));
            }
            else if (Value.ToLower() == "false")
            {
                value = BitConverter.GetBytes(Convert.ToBoolean(false));
            }
            else if (Value.ToLower() == "0")
            {
                value = BitConverter.GetBytes(Convert.ToBoolean(false));
            }
            else
            {
                return "6";
            }

            int pointer = Pointer;

            if (Offset == null)
            {
                if (!WriteFunc(handle, pointer, value, 1))
                    return "7";
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                if (!WriteFunc(handle, pointer, value, 1))
                    return "7";
            }
            return basarisiz.ToString();
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     WriteBool("Game.exe", Module + Pointer, Value, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     WriteBool("Game.exe", Module + Pointer, Value);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="ProcessName"/>'te erişilecek uygulama adı<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri <br/>
        ///<paramref name="Value"/>'nde string için true ve false metin olarak girin. <br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string WriteBool(string ProcessName, int Pointer, string Value, params int[] Offset)
        {
            int basarisiz;
            string procname = ProcessName;
            if (ProcessName.Contains(".exe"))
                procname = procname.Replace(".exe", "");
            int PID = Process.GetProcessesByName(procname)[0].Id;
            if (!CheckProcess(PID, out basarisiz))
            {
                return basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            if (!bool.TryParse(Value, out _))
            {
                return "6";
            }

            byte[] value = new byte[1];
            if (Value.ToLower() == "true")
            {
                value = BitConverter.GetBytes(Convert.ToBoolean(true));
            }
            else if (Value.ToLower() == "1")
            {
                value = BitConverter.GetBytes(Convert.ToBoolean(true));
            }
            else if (Value.ToLower() == "false")
            {
                value = BitConverter.GetBytes(Convert.ToBoolean(false));
            }
            else if (Value.ToLower() == "0")
            {
                value = BitConverter.GetBytes(Convert.ToBoolean(false));
            }
            else
            {
                return "6";
            }

            int pointer = Pointer;

            if (Offset == null)
            {
                if (!WriteFunc(handle, pointer, value, 1))
                    return "7";
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                if (!WriteFunc(handle, pointer, value, 1))
                    return "7";
            }
            return basarisiz.ToString();
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     WriteBool(PID, Module + Pointer, Value, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     WriteBool(PID, Module + Pointer, Value);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="PID"/>'te erişilecek uygulama kimliği numarası<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri <br/>
        ///<paramref name="Value"/>'nde bool için true ve false değeri girin. <br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string WriteBool(int PID, int Pointer, bool Value, params int[] Offset)
        {
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            byte[] value = BitConverter.GetBytes(Convert.ToBoolean(Value));

            int pointer = Pointer;

            if (Offset == null)
            {
                if (!WriteFunc(handle, pointer, value, 1))
                    return "7";
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                if (!WriteFunc(handle, pointer, value, 1))
                    return "7";
            }
            return basarisiz.ToString();
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     WriteBool("Game.exe", Module + Pointer, Value, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     WriteBool("Game.exe", Module + Pointer, Value);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="ProcessName"/>'te erişilecek uygulama adı<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri <br/>
        ///<paramref name="Value"/>'nde bool için true ve false değeri girin. <br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string WriteBool(string ProcessName, int Pointer, bool Value, params int[] Offset)
        {
            int basarisiz;
            string procname = ProcessName;
            if (ProcessName.Contains(".exe"))
                procname = procname.Replace(".exe", "");
            int PID = Process.GetProcessesByName(procname)[0].Id;
            if (!CheckProcess(PID, out basarisiz))
            {
                return basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            byte[] value = BitConverter.GetBytes(Convert.ToBoolean(Value));

            int pointer = Pointer;

            if (Offset == null)
            {
                if (!WriteFunc(handle, pointer, value, 1))
                    return "7";
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                if (!WriteFunc(handle, pointer, value, 1))
                    return "7";
            }
            return basarisiz.ToString();
        }
        //-------------------------------------------------------------------------------------------------------------
        private static string[] ConvertNumberSystemToArrayString(NumberSystem type, byte[] value)
        {
            if (NumberSystem.Binary == type)
            {
                string[] topla = new string[value.Length];
                for (int i = 0; i < value.Length; i++)
                {
                    topla[i] = Convert.ToString(value[i], 2).PadLeft(8, '0');
                }
                return topla;
            }
            else if (NumberSystem.Octal == type)
            {
                string[] topla = new string[value.Length];
                for (int i = 0; i < value.Length; i++)
                {
                    topla[i] = Convert.ToString(value[i], 8);
                }
                return topla;
            }
            else if (NumberSystem.Decimal == type)
            {
                string[] topla = new string[value.Length];
                for (int i = 0; i < value.Length; i++)
                {
                    topla[i] = Convert.ToString(value[i], 10);
                }
                return topla;
            }
            else if (NumberSystem.Hexadecimal == type)
            {
                string[] topla = new string[value.Length];
                for (int i = 0; i < value.Length; i++)
                {
                    topla[i] = Convert.ToString(value[i], 16).PadLeft(2, '0');
                    topla[i] = topla[i].ToUpper();
                }
                return topla;
            }
            return null;
        }
        private static string ConvertNumberSystemToString(NumberSystem type, byte[] value)
        {
            if (NumberSystem.Binary == type)
            {
                string topla = "";
                foreach (var item in value)
                {
                    topla += Convert.ToString(item, 2).PadLeft(8, '0') + " ";
                }
                return topla;
            }
            else if (NumberSystem.Octal == type)
            {
                string topla = "";
                for (int i = 0; i < value.Length; i++)
                {
                    topla += Convert.ToString(value[i], 8) + " ";
                }
                return topla;
            }
            else if (NumberSystem.Decimal == type)
            {
                string topla = "";
                for (int i = 0; i < value.Length; i++)
                {
                    topla += Convert.ToString(value[i], 10) + " ";
                }
                return topla;

            }
            else if (NumberSystem.Hexadecimal == type)
            {
                string topla = "";
                for (int i = 0; i < value.Length; i++)
                {
                    topla += Convert.ToString(value[i], 16).PadLeft(2, '0') +  " ";
                }
                return topla.ToUpper();
            }
            return null;
        }
        private static byte[] ReadByteFunc(IntPtr Handle, int Pointer, int Lenght)
        {
            byte[] ReadBytes = new byte[Lenght];
            Write.ReadProcessMemoryByte(Handle, Pointer, ReadBytes, (UIntPtr)Lenght, IntPtr.Zero);
            return ReadBytes;
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     string value = ReadByte(PID, Module + Pointer, Lenght, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     string value = ReadByte(PID, Module + Pointer, Lenght);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="PID"/>'te erişilecek uygulama kimliği numarası<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri <br/>
        ///<paramref name="Lenght"/>'te array dizi sayısı girin.<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string ReadByte(int PID, int Pointer, int Lenght, params int[] Offset)
        {
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return "R" + basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            int pointer = Pointer;

            if (Offset == null)
            {
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return ConvertNumberSystemToString(NumberSystem.Decimal, durumu);
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return ConvertNumberSystemToString(NumberSystem.Decimal, durumu);
            }
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     string value = ReadByte(PID, Module + Pointer, Lenght, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     string value = ReadByte(PID, Module + Pointer, Lenght);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="ProcessName"/>'te erişilecek uygulama adı<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri <br/>
        ///<paramref name="Lenght"/>'te array dizi sayısı girin.<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string ReadByte(string ProcessName, int Pointer, int Lenght, params int[] Offset)
        {
            int basarisiz;
            string procname = ProcessName;
            if (ProcessName.Contains(".exe"))
                procname = procname.Replace(".exe", "");
            int PID = Process.GetProcessesByName(procname)[0].Id;
            if (!CheckProcess(PID, out basarisiz))
            {
                return "R" + basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            int pointer = Pointer;

            if (Offset == null)
            {
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                string topla = "";
                foreach (var item in durumu)
                {
                    topla += " " + item;
                }
                return topla;
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                string topla = "";
                foreach (var item in durumu)
                {
                    topla += " " + item.ToString("X");
                }
                return topla;
            }
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     string value = ReadByte(PID, Module + Pointer, Lenght, Mem.NumberSystem, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     string value = ReadByte(PID, Module + Pointer, Lenght, Mem.NumberSystem);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="PID"/>'te erişilecek uygulama kimliği numarası<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri <br/>
        ///<paramref name="Lenght"/>'te array dizi sayısı girin.<br/>
        ///<paramref name="Type"/>'de value'nin numara sistemi seçin. (Hexadecimal için Mem.NumberSystem.Hexadecimal)<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string ReadByte(int PID, int Pointer, int Lenght, NumberSystem Type, params int[] Offset)
        {
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return "R" + basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            int pointer = Pointer;

            if (Offset == null)
            {
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return ConvertNumberSystemToString(Type, durumu);
               
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return ConvertNumberSystemToString(Type, durumu);
                //string topla = "";
                //foreach (var item in durumu)
                //{
                //    topla += Convert.ToString(item, 2);
                //}
                //return topla;
            }
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     string value = ReadByte(PID, Module + Pointer, Lenght, Mem.NumberSystem, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     string value = ReadByte(PID, Module + Pointer, Lenght, Mem.NumberSystem);</code><br/>
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="ProcessName"/>'te erişilecek uygulama adı<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri <br/>
        ///<paramref name="Lenght"/>'te array dizi sayısı girin.<br/>
        ///<paramref name="Type"/>'de value'nin numara sistemi seçin. (Hexadecimal için Mem.NumberSystem.Hexadecimal)<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string ReadByte(string ProcessName, int Pointer, int Lenght, NumberSystem Type, params int[] Offset)
        {
            int basarisiz;
            string procname = ProcessName;
            if (ProcessName.Contains(".exe"))
                procname = procname.Replace(".exe", "");
            int PID = Process.GetProcessesByName(procname)[0].Id;
            if (!CheckProcess(PID, out basarisiz))
            {
                return "R" + basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            int pointer = Pointer;

            if (Offset == null)
            {
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return ConvertNumberSystemToString(Type, durumu);

            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return ConvertNumberSystemToString(Type, durumu);
            }
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     byte[] value = ReadByte(PID, Module + Pointer, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     byte[] value = ReadByte(PID, Module + Pointer);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="PID"/>'te erişilecek uygulama kimliği numarası<br/>
        ///<paramref name="Poînter"/>'de Bellek bulunan Pointer değeri (Lütfen (uint)Pointer kullanın.)<br/>
        ///<paramref name="Lenght"/>'te array dizi sayısı girin.<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static byte[] ReadByte(int PID, uint Poînter, int Lenght, params int[] Offset)
        {
            int Pointer = (int)Poînter;
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return null;
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            int pointer = Pointer;

            if (Offset == null)
            {
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return durumu;
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return durumu;
            }
            return null;
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     byte[] value = ReadByte(PID, Module + Pointer, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     byte[] value = ReadByte(PID, Module + Pointer);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="ProcessName"/>'te erişilecek uygulama adı<br/>
        ///<paramref name="Poînter"/>'de Bellek bulunan Pointer değeri (Lütfen (uint)Pointer kullanın.)<br/>
        ///<paramref name="Lenght"/>'te array dizi sayısı girin.<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static byte[] ReadByte(string ProcessName, uint Poînter, int Lenght, params int[] Offset)
        {
            int Pointer = (int)Poînter;
            int basarisiz;
            string procname = ProcessName;
            if (ProcessName.Contains(".exe"))
                procname = procname.Replace(".exe", "");
            int PID = Process.GetProcessesByName(procname)[0].Id;
            if (!CheckProcess(PID, out basarisiz))
            {
                return null;
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            int pointer = Pointer;

            if (Offset == null)
            {
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return durumu;
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return durumu;
            }
            return null;
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     string[] value = ReadByte(PID, Module + Pointer, Lenght, Mem.NumberSystem Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     string[] value = ReadByte(PID, Module + Pointer, Lenght, Mem.NumberSystem);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="PID"/>'te erişilecek uygulama kimliği numarası<br/>
        ///<paramref name="Poînter"/>'de Bellek bulunan Pointer değeri (Lütfen (uint)Pointer kullanın.)<br/>
        ///<paramref name="Lenght"/>'te array dizi sayısı girin.<br/>
        ///<paramref name="Type"/>'de value'nin numara sistemi seçin. (Hexadecimal için Mem.NumberSystem.Hexadecimal)<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string[] ReadByte(int PID, uint Poînter, int Lenght, NumberSystem Type, params int[] Offset)
        {
            int Pointer = (int)Poînter;
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return null;
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            int pointer = Pointer;

            if (Offset == null)
            {
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return ConvertNumberSystemToArrayString(Type, durumu);
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return ConvertNumberSystemToArrayString(Type, durumu);
            }
            return null;
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     string[] value = ReadByte("Game.exe", Module + Pointer, Lenght, Mem.NumberSystem Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     string[] value = ReadByte("Game.exe", Module + Pointer, Lenght, Mem.NumberSystem);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="ProcessName"/>'te erişilecek uygulama adı<br/>
        ///<paramref name="Poînter"/>'de Bellek bulunan Pointer değeri (Lütfen (uint)Pointer kullanın.)<br/>
        ///<paramref name="Lenght"/>'te array dizi sayısı girin.<br/>
        ///<paramref name="Type"/>'de value'nin numara sistemi seçin. (Hexadecimal için Mem.NumberSystem.Hexadecimal)<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string[] ReadByte(string ProcessName, uint Poînter, int Lenght, NumberSystem Type, params int[] Offset)
        {
            int Pointer = (int)Poînter;
            int basarisiz;
            string procname = ProcessName;
            if (ProcessName.Contains(".exe"))
                procname = procname.Replace(".exe", "");
            int PID = Process.GetProcessesByName(procname)[0].Id;
            if (!CheckProcess(PID, out basarisiz))
            {
                return null;
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            int pointer = Pointer;

            if (Offset == null)
            {
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return ConvertNumberSystemToArrayString(Type, durumu);
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return ConvertNumberSystemToArrayString(Type, durumu);
            }
            return null;
        }
        //-------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     string value = ReadShort(PID, Module + Pointer, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     string value = ReadShort(PID, Module + Pointer);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="PID"/>'te erişilecek uygulama kimliği numarası<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri <br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string ReadShort(int PID, int Pointer, params int[] Offset)
        {
            int Lenght = 2;
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return "R" + basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            int pointer = Pointer;

            if (Offset == null)
            {
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToUInt16(durumu, 0).ToString();
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToUInt16(durumu, 0).ToString();
            }
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     string value = ReadShort("Game.exe", Module + Pointer, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     string value = ReadShort("Game.exe", Module + Pointer);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="ProcessName"/>'te erişilecek uygulama adı<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri <br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string ReadShort(string ProcessName, int Pointer, params int[] Offset)
        {
            int basarisiz;
            string procname = ProcessName;
            if (ProcessName.Contains(".exe"))
                procname = procname.Replace(".exe", "");
            int PID = Process.GetProcessesByName(procname)[0].Id;
            int Lenght = 2;
            if (!CheckProcess(PID, out basarisiz))
            {
                return "R" + basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            int pointer = Pointer;

            if (Offset == null)
            {
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToUInt16(durumu, 0).ToString();
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToUInt16(durumu, 0).ToString();
            }
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     short value = ReadShort(PID, Module + Pointer, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     short value = ReadShort(PID, Module + Pointer);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="PID"/>'te erişilecek uygulama kimliği numarası<br/>
        ///<paramref name="Poînter"/>'de Bellek bulunan Pointer değeri (Lütfen (uint)Pointer kullanın.)<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static short ReadShort(int PID, uint Poînter, params int[] Offset)
        {
            int Lenght = 2;
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return 0;
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            int pointer = (int)Poînter;

            if (Offset == null)
            {
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return (short)BitConverter.ToUInt16(durumu, 0);
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return (short)BitConverter.ToUInt16(durumu, 0);
            }
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     short value = ReadShort("Game.exe", Module + Pointer, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     short value = ReadShort("Game.exe", Module + Pointer);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="ProcessName"/>'te erişilecek uygulama adı<br/>
        ///<paramref name="Poînter"/>'de Bellek bulunan Pointer değeri (Lütfen (uint)Pointer kullanın.)<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static short ReadShort(string ProcessName, uint Poînter, params int[] Offset)
        {

            int Lenght = 2;
            string procname = ProcessName;
            if (ProcessName.Contains(".exe"))
                procname = procname.Replace(".exe", "");
            int PID = Process.GetProcessesByName(procname)[0].Id;
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return 0;
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            int pointer = (int)Poînter;

            if (Offset == null)
            {
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return (short)BitConverter.ToUInt16(durumu, 0);
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return (short)BitConverter.ToUInt16(durumu, 0);
            }
        }
        //-------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     string value = ReadInteger(PID, Module + Pointer, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     string value = ReadInteger(PID, Module + Pointer);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="PID"/>'te erişilecek uygulama kimliği numarası<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string ReadInteger(int PID, int Pointer, params int[] Offset)
        {
            int Lenght = 4;
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return "R" + basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            int pointer = Pointer;

            if (Offset == null)
            {
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToUInt32(durumu, 0).ToString();
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToUInt32(durumu, 0).ToString();
            }
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     string value = ReadInteger("Game.exe", Module + Pointer, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     string value = ReadInteger("Game.exe", Module + Pointer);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="ProcessName"/>'te erişilecek uygulama adı<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string ReadInteger(string ProcessName, int Pointer, params int[] Offset)
        {
            int basarisiz;
            string procname = ProcessName;
            if (ProcessName.Contains(".exe"))
                procname = procname.Replace(".exe", "");
            int PID = Process.GetProcessesByName(procname)[0].Id;
            int Lenght = 4;
            if (!CheckProcess(PID, out basarisiz))
            {
                return "R" + basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            int pointer = Pointer;

            if (Offset == null)
            {
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToUInt32(durumu, 0).ToString();
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToUInt32(durumu, 0).ToString();
            }
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     int value = ReadInteger(PID, Module + Pointer, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     int value = ReadInteger(PID, Module + Pointer);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="PID"/>'te erişilecek uygulama kimlik numarası<br/>
        ///<paramref name="Poînter"/>'de Bellek bulunan Pointer değeri (Lütfen (uint)Pointer kullanın.)<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static int ReadInteger(int PID, uint Poînter, params int[] Offset)
        {
            int Lenght = 4;
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return 0;
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            int pointer = (int)Poînter;

            if (Offset == null)
            {
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return (int)BitConverter.ToUInt32(durumu, 0);
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return (int)BitConverter.ToUInt32(durumu, 0);
            }
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     int value = ReadInteger("Game.exe", Module + Pointer, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     int value = ReadInteger("Game.exe", Module + Pointer);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="ProcessName"/>'te erişilecek uygulama adı<br/>
        ///<paramref name="Poînter"/>'de Bellek bulunan Pointer değeri (Lütfen (uint)Pointer kullanın.)<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static int ReadInteger(string ProcessName, uint Poînter, params int[] Offset)
        {
            int basarisiz;
            string procname = ProcessName;
            if (ProcessName.Contains(".exe"))
                procname = procname.Replace(".exe", "");
            int PID = Process.GetProcessesByName(procname)[0].Id;
            int Lenght = 4;
            if (!CheckProcess(PID, out basarisiz))
            {
                return 0;
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            int pointer = (int)Poînter;

            if (Offset == null)
            {
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return (int)BitConverter.ToUInt32(durumu, 0);
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return (int)BitConverter.ToUInt32(durumu, 0);
            }
        }
        //-------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     string value = ReadLong(PID, Module + Pointer, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     string value = ReadLong(PID, Module + Pointer);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="PID"/>'te erişilecek uygulama kimliği numarası<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string ReadLong(int PID, int Pointer, params int[] Offset)
        {
            int Lenght = 8;
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return "R" + basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            int pointer = Pointer;

            if (Offset == null)
            {
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToUInt64(durumu, 0).ToString();
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToUInt64(durumu, 0).ToString();
            }
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     string value = ReadLong("Game.exe", Module + Pointer, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     string value = ReadLong("Game.exe", Module + Pointer);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="ProcessName"/>'te erişilecek uygulama adı<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string ReadLong(string ProcessName, int Pointer, params int[] Offset)
        {
            int basarisiz;
            string procname = ProcessName;
            if (ProcessName.Contains(".exe"))
                procname = procname.Replace(".exe", "");
            int PID = Process.GetProcessesByName(procname)[0].Id;
            int Lenght = 8;
            if (!CheckProcess(PID, out basarisiz))
            {
                return "R" + basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            int pointer = Pointer;

            if (Offset == null)
            {
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToUInt64(durumu, 0).ToString();
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToUInt64(durumu, 0).ToString();
            }
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     long value = ReadLong(PID, Module + Pointer, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     long value = ReadLong(PID, Module + Pointer);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="PID"/>'te erişilecek uygulama kimliği numarası<br/>
        ///<paramref name="Poînter"/>'de Bellek bulunan Pointer değeri (Lütfen (uint)Pointer kullanın.)<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static long ReadLong(int PID, uint Poînter, params int[] Offset)
        {
            int basarisiz;
            int Lenght = 8;
            if (!CheckProcess(PID, out basarisiz))
            {
                return 0;
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            int pointer = (int)Poînter;

            if (Offset == null)
            {
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToInt64(durumu, 0);
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToInt64(durumu, 0);
            }
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     long value = ReadLong("Game.exe", Module + Pointer, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     long value = ReadLong("Game.exe", Module + Pointer);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="ProcessName"/>'te erişilecek uygulama adı<br/>
        ///<paramref name="Poînter"/>'de Bellek bulunan Pointer değeri (Lütfen (uint)Pointer kullanın.)<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static long ReadLong(string ProcessName, uint Poînter, params int[] Offset)
        {
            int basarisiz;
            string procname = ProcessName;
            if (ProcessName.Contains(".exe"))
                procname = procname.Replace(".exe", "");
            int PID = Process.GetProcessesByName(procname)[0].Id;
            int Lenght = 8;
            if (!CheckProcess(PID, out basarisiz))
            {
                return 0;
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            int pointer = (int)Poînter;

            if (Offset == null)
            {
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToInt64(durumu, 0);
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToInt64(durumu, 0);
            }
        }
        //-------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     string value = ReadFloat(PID, Module + Pointer, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     string value = ReadFloat(PID, Module + Pointer);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="PID"/>'te erişilecek uygulama kimliği<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string ReadFloat(int PID, int Pointer, params int[] Offset)
        {
            int Lenght = 4;
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return "R" + basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            int pointer = Pointer;

            if (Offset == null)
            {
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToSingle(durumu, 0).ToString();
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToSingle(durumu, 0).ToString();
            }
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     string value = ReadFloat("Game.exe", Module + Pointer, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     string value = ReadFloat("Game.exe", Module + Pointer);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="ProcessName"/>'te erişilecek uygulama adı<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string ReadFloat(string ProcessName, int Pointer, params int[] Offset)
        {
            int basarisiz;
            string procname = ProcessName;
            if (ProcessName.Contains(".exe"))
                procname = procname.Replace(".exe", "");
            int PID = Process.GetProcessesByName(procname)[0].Id;
            int Lenght = 4;
            if (!CheckProcess(PID, out basarisiz))
            {
                return "R" + basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            int pointer = Pointer;

            if (Offset == null)
            {
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToSingle(durumu, 0).ToString();
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToSingle(durumu, 0).ToString();
            }
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     string value = ReadFloat(PID, Module + Pointer, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     string value = ReadFloat(PID, Module + Pointer);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="PID"/>'te erişilecek uygulama kimliği numarası<br/>
        ///<paramref name="Poînter"/>'de Bellek bulunan Pointer değeri (Lütfen (uint)Pointer kullanın.)<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static float ReadFloat(int PID, uint Poînter, params int[] Offset)
        {
            int basarisiz;
            int Lenght = 4;
            if (!CheckProcess(PID, out basarisiz))
            {
                return 0;
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            int pointer = (int)Poînter;

            if (Offset == null)
            {
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToSingle(durumu, 0);
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToSingle(durumu, 0);
            }
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     float value = ReadFloat("Game.exe", Module + Pointer, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     float value = ReadFloat("Game.exe", Module + Pointer);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="ProcessName"/>'te erişilecek uygulama adı<br/>
        ///<paramref name="Poînter"/>'de Bellek bulunan Pointer değeri (Lütfen (uint)Pointer kullanın.)<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static float ReadFloat(string ProcessName, uint Poînter, params int[] Offset)
        {
            int basarisiz;
            string procname = ProcessName;
            if (ProcessName.Contains(".exe"))
                procname = procname.Replace(".exe", "");
            int PID = Process.GetProcessesByName(procname)[0].Id;
            int Lenght = 4;
            if (!CheckProcess(PID, out basarisiz))
            {
                return 0;
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            int pointer = (int)Poînter;

            if (Offset == null)
            {
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToSingle(durumu, 0);
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToSingle(durumu, 0);
            }
        }
        //-------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     string value = ReadFloat(PID, Module + Pointer, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     string value = ReadFloat(PID, Module + Pointer);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="PID"/>'te erişilecek uygulama kimliği<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string ReadDouble(int PID, int Pointer, params int[] Offset)
        {
            int Lenght = 8;
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return "R" + basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            int pointer = Pointer;

            if (Offset == null)
            {
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToDouble(durumu, 0).ToString();
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToDouble(durumu, 0).ToString();
            }
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     string value = ReadFloat("Game.exe", Module + Pointer, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     string value = ReadFloat("Game.exe", Module + Pointer);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="ProcessName"/>'te erişilecek uygulama adı<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string ReadDouble(string ProcessName, int Pointer, params int[] Offset)
        {
            int basarisiz;
            string procname = ProcessName;
            if (ProcessName.Contains(".exe"))
                procname = procname.Replace(".exe", "");
            int PID = Process.GetProcessesByName(procname)[0].Id;
            int Lenght = 8;
            if (!CheckProcess(PID, out basarisiz))
            {
                return "R" + basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            int pointer = Pointer;

            if (Offset == null)
            {
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToDouble(durumu, 0).ToString();
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToDouble(durumu, 0).ToString();
            }
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     string value = ReadFloat(PID, Module + Pointer, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     string value = ReadFloat(PID, Module + Pointer);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="PID"/>'te erişilecek uygulama kimliği numarası<br/>
        ///<paramref name="Poînter"/>'de Bellek bulunan Pointer değeri (Lütfen (uint)Pointer kullanın.)<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static double ReadDouble(int PID, uint Poînter, params int[] Offset)
        {
            int basarisiz;
            int Lenght = 8;
            if (!CheckProcess(PID, out basarisiz))
            {
                return 0;
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            int pointer = (int)Poînter;

            if (Offset == null)
            {
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToDouble(durumu, 0);
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToDouble(durumu, 0);
            }
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     double value = ReadDouble("Game.exe", Module + Pointer, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     double value = ReadDouble("Game.exe", Module + Pointer);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="ProcessName"/>'te erişilecek uygulama adı<br/>
        ///<paramref name="Poînter"/>'de Bellek bulunan Pointer değeri (Lütfen (uint)Pointer kullanın.)<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static double ReadDouble(string ProcessName, uint Poînter, params int[] Offset)
        {
            int basarisiz;
            string procname = ProcessName;
            if (ProcessName.Contains(".exe"))
                procname = procname.Replace(".exe", "");
            int PID = Process.GetProcessesByName(procname)[0].Id;
            int Lenght = 8;
            if (!CheckProcess(PID, out basarisiz))
            {
                return 0;
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            int pointer = (int)Poînter;

            if (Offset == null)
            {
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToDouble(durumu, 0);
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToDouble(durumu, 0);
            }
        }
        //-------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     ReadString(PID, Module + Pointer, Lenght, System.Text.Encoding, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     ReadString(PID, Module + Pointer, Lenght, System.Text.Encoding);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="PID"/>'te erişilecek uygulama kimliği numarası<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri <br/>
        ///<paramref name="Lenght"/>'nde karakter uzunluk sayısı girin. <br/>
        ///<paramref name="Type"/>'nde metin kodlama türü kullanın (Varsayılan <see cref="System.Text.Encoding.UTF8"/>'tir.)
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string ReadString(int PID, int Pointer, int Lenght, System.Text.Encoding Type, params int[] Offset)
        {
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            int pointer = Pointer;

            if (Offset == null)
            {
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return Type.GetString(durumu);
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return Type.GetString(durumu);
            }
            return basarisiz.ToString();
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     ReadString("Game.exe", Module + Pointer, Lenght, System.Text.Encoding, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     ReadString("Game.exe", Module + Pointer, Lenght, System.Text.Encoding);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="ProcessName"/>'te erişilecek uygulama adı<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri <br/>
        ///<paramref name="Lenght"/>'nde karakter uzunluk sayısı girin. <br/>
        ///<paramref name="Type"/>'nde metin kodlama türü kullanın (Varsayılan <see cref="System.Text.Encoding.UTF8"/>'tir.)
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string ReadString(string ProcessName, int Pointer, int Lenght, System.Text.Encoding Type, params int[] Offset)
        {
            int basarisiz;
            string procname = ProcessName;
            if (ProcessName.Contains(".exe"))
                procname = procname.Replace(".exe", "");
            int PID = Process.GetProcessesByName(procname)[0].Id;
            if (!CheckProcess(PID, out basarisiz))
            {
                return basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            int pointer = Pointer;

            if (Offset == null)
            {
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return Type.GetString(durumu);
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return Type.GetString(durumu);
            }
            return basarisiz.ToString();
        }

        //-------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     string value = ReadBool(PID, Module + Pointer, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     string value = ReadBool(PID, Module + Pointer);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="PID"/>'te erişilecek uygulama kimliği numarası<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string ReadBool(int PID, int Pointer, params int[] Offset)
        {
            int Lenght = 1;
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return "R" + basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            int pointer = Pointer;

            if (Offset == null)
            {
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToBoolean(durumu, 0).ToString();
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToBoolean(durumu, 0).ToString();
            }
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     string value = ReadBool("Game.exe", Module + Pointer, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     string value = ReadBool("Game.exe", Module + Pointer);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="ProcessName"/>'te erişilecek uygulama adı<br/>
        ///<paramref name="Pointer"/>'de Bellek bulunan Pointer değeri<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static string ReadBool(string ProcessName, int Pointer, params int[] Offset)
        {
            string procname = ProcessName;
            if (ProcessName.Contains(".exe"))
                procname = procname.Replace(".exe", "");
            int PID = Process.GetProcessesByName(procname)[0].Id;
            int Lenght = 1;
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return "R" + basarisiz.ToString();
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            int pointer = Pointer;

            if (Offset == null)
            {
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToBoolean(durumu, 0).ToString();
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToBoolean(durumu, 0).ToString();
            }
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     string value = ReadBool(PID, Module + Pointer, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     string value = ReadBool(PID, Module + Pointer);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="PID"/>'te erişilecek uygulama kimliği numarası<br/>
        ///<paramref name="Poînter"/>'de Bellek bulunan Pointer değeri (Lütfen (uint)Pointer kullanın.)<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static bool ReadBool(int PID, uint Poînter, params int[] Offset)
        {
            int Lenght = 1;
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return false;
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            int pointer = (int)Poînter;

            if (Offset == null)
            {
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToBoolean(durumu, 0);
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToBoolean(durumu, 0);
            }
        }
        /// <summary>
        /// <p>
        ///     [TR] Omertrans156 tarafından kodlanmış faydalı Read ve Write Memory fonksiyonları <br/>
        ///     [EN] Usefully Read and Write Memory Functions coded by Omertrans156<br/>
        ///     
        ///     <br/>Usage/Kullanımı:<br/>
        ///     <code><br/>With Offset:<br/>
        ///     bool value = ReadBool("Game.exe", Module + Pointer, Offset[]);
        ///     <br/>Without Offset:<br/>
        ///     double value = ReadBool("Game.exe", Module + Pointer);</code><br/>
        ///     
        /// </p>
        /// </summary>
        ///<remarks>  
        ///<paramref name="ProcessName"/>'te erişilecek uygulama adı<br/>
        ///<paramref name="Poînter"/>'de Bellek bulunan Pointer değeri (Lütfen (uint)Pointer kullanın.)<br/>
        ///<paramref name="Offset"/>'te kalıcı Pointer bulmak için kullanılan Offset'tir.
        ///</remarks>  
        ///<returns> 
        /// <br> 0 - Sorunu yok</br> 
        /// <br> 1 - PID: 0'dır.</br> 
        /// <br> 2 - Process null'dır.</br>
        /// <br> 3 - 'Yanıt vermiyor' sorunu.</br>
        /// <br> 4 - OpenProcess işlevi başarısız.</br>
        /// <br> 5 - 64bit desteklenmez.</br>
        /// <br> 6 - Value geçerisizdir.</br>
        /// <br> 7 - Yazma başarısız.</br>
        /// <br> 8 - Value maksimum aştı.</br>
        /// <br> 10 - Bilinmeyen özel bir hata oluştu.</br>
        /// <br> 11 - Erişim engellendi. (<see cref="Win32Exception"/>)</br>
        /// <br> 12 - Uygulama bulunamadı. (<see cref="ArgumentException"/>)</br>
        /// <br> 13 - İşlem başlatılmadı yada ilişkilendirilmiş bir işlem yok. (<see cref="InvalidOperationException"/>)</br>
        /// <br> 14 - Uzak bilgisayarda bir uygulama erişmez. (<see cref="NotSupportedException"/>)</br>
        /// </returns>
        public static bool ReadBool(string ProcessName, uint Poînter, params int[] Offset)
        {
            string procname = ProcessName;
            if (ProcessName.Contains(".exe"))
                procname = procname.Replace(".exe", "");
            int PID = Process.GetProcessesByName(procname)[0].Id;
            int Lenght = 1;
            int basarisiz;
            if (!CheckProcess(PID, out basarisiz))
            {
                return false;
            }

            Process Proc;
            Proc = Process.GetProcessById(PID);
            IntPtr handle = Proc.Handle;

            int pointer = (int)Poînter;

            if (Offset == null)
            {
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToBoolean(durumu, 0);
            }
            else
            {
                foreach (var off in Offset)
                {
                    int oldPointer = pointer;
                    Write.ReadProcessMemory(handle, oldPointer, ref pointer, 4, 0);
                    pointer += off;
                }
                byte[] durumu = ReadByteFunc(handle, pointer, Lenght);
                return BitConverter.ToBoolean(durumu, 0);
            }
        }
    }
}
