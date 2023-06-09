using System;
using System.Runtime.InteropServices;

namespace omertrans156.ReadWriteMemory.Exceptions
{
    public class FailedWriteMemoryException : Exception
    {
        public FailedWriteMemoryException()
            : base("Memory write operation failed. Error code: " + Marshal.GetLastWin32Error())
        {
        }

        public FailedWriteMemoryException(string message)
            : base("Memory write operation failed. Error code: " + Marshal.GetLastWin32Error() + " " + message)
        {
        }

        public FailedWriteMemoryException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
