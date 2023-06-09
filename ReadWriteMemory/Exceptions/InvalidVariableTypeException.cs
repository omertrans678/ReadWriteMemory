using System;

namespace omertrans156.ReadWriteMemory.Exceptions
{
    public class InvalidVariableTypeException : Exception
    {
        public InvalidVariableTypeException()
            : base("Invalid Variable ")
        {
        }

        public InvalidVariableTypeException(string message)
            : base("Invalid Variable: " + message)
        {
        }
        public InvalidVariableTypeException(object message)
       : base("Invalid Variable: " + message + " is a " + message.GetType())
        {
        }
        public InvalidVariableTypeException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
