using System;

namespace omertrans156.ReadWriteMemory.Exceptions
{
    public class InvalidValueException : Exception
    {
        public InvalidValueException()
            : base("Invalid value")
        {
        }
    }
}
