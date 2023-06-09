namespace omertrans156.ReadWriteMemory.Debug
{
    internal class Console
    {
        static readonly bool EnableDebug = false;
        public static void WriteLine(object msj)
        {
            if (!EnableDebug)
                return;
            System.Console.WriteLine(msj);
        }
        public static void WriteLine(string msj, params object[] args)
        {
            if (!EnableDebug)
                return;
            System.Console.WriteLine(msj, args);
        }
        public static void Write(object msj)
        {
            if (!EnableDebug)
                return;
            System.Console.Write(msj);
        }
        public static void Write(string msj, params object[] args)
        {
            if (!EnableDebug)
                return;
            System.Console.Write(msj, args);
        }
    }
}
