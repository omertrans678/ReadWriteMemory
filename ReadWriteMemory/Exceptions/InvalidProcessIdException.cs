using System;
namespace omertrans156.ReadWriteMemory.Exceptions
{
    public class InvalidProcessIdException : Exception
    {
        public InvalidProcessIdException()
            : base("Invalid process ID: 0")
        {
        }
    }
}
