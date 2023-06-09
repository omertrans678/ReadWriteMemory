using System;

namespace omertrans156.ReadWriteMemory.Exceptions
{
    public class InvalidPointerException : Exception
    {
        public InvalidPointerException(object message)
            : base($"Invalid: pointer '{message}' is a " + message.GetType())
        {
        }
    }
}
