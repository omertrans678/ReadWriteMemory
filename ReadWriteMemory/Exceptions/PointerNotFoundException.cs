using System;

namespace omertrans156.ReadWriteMemory.Exceptions
{
    public class PointerNotFoundException : Exception
    {
        public PointerNotFoundException()
            : base("Pointer not found or Write failed")
        {
        }

        public PointerNotFoundException(string message)
            : base(message)
        {
        }

        public PointerNotFoundException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
