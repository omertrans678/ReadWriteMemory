using System;

namespace omertrans156.ReadWriteMemory.Exceptions
{
    public class TooManyModulesException : Exception
    {
        public TooManyModulesException()
            : base("Too many modules.")
        {
        }

        public TooManyModulesException(string message)
            : base(message)
        {
        }

        public TooManyModulesException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
