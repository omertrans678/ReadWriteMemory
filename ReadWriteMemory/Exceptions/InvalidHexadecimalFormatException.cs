using System;

namespace omertrans156.ReadWriteMemory.Exceptions
{
    public class InvalidHexadecimalFormatException : Exception
    {
        public InvalidHexadecimalFormatException()
            : base("Invalid format value")
        {
        }

        public InvalidHexadecimalFormatException(string message)
            : base("Invalid format value: " + message)
        {
        }

        public InvalidHexadecimalFormatException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
