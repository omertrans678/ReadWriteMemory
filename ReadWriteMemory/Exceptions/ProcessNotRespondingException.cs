using System;

namespace omertrans156.ReadWriteMemory.Exceptions
{
    public class ProcessNotRespondingException : Exception
    {
        public ProcessNotRespondingException()
            : base("Process is not responding")
        {
        }
    }
}
