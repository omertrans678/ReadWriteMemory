using System;
using System.Runtime.InteropServices;

namespace omertrans156.ReadWriteMemory.Exceptions
{
    public class OpenProcessFailedException : Exception
    {
        public OpenProcessFailedException()
            : base("Failed to open process error code " + Marshal.GetLastWin32Error())
        {
        }
    }
}
