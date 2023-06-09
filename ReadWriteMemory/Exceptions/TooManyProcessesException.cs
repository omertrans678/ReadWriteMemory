using System;

namespace omertrans156.ReadWriteMemory.Exceptions
{
    public class TooManyProcessesException : Exception
    {
        public TooManyProcessesException()
            : base("Too many processes using Read Memory.")
        {
        }
        public TooManyProcessesException(string message)
          : base("Too many processes using " + message)
        {
        }

        public TooManyProcessesException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
