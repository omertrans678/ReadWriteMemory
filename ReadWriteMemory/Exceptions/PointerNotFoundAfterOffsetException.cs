using System;

namespace omertrans156.ReadWriteMemory.Exceptions
{
    public class PointerNotFoundAfterOffsetException : Exception
    {
        public PointerNotFoundAfterOffsetException()
            : base("Pointer not found after offset calculated")
        {
        }

        public PointerNotFoundAfterOffsetException(string message)
            : base(message)
        {
        }

        public PointerNotFoundAfterOffsetException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
