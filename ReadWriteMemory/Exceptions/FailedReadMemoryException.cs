using System;
using System.Runtime.InteropServices;

namespace omertrans156.ReadWriteMemory.Exceptions
{
    public class FailedReadMemoryException : Exception
    {
        public FailedReadMemoryException()
            : base("Memory read operation failed. Error code: " + Marshal.GetLastWin32Error())
        {
        }

        public FailedReadMemoryException(string message)
            : base("Memory read operation failed. Error code: " + Marshal.GetLastWin32Error() + " " + message)
        {
        }

        public FailedReadMemoryException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
