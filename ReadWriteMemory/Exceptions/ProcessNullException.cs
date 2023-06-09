using System;
namespace omertrans156.ReadWriteMemory.Exceptions
{
    public class ProcessNullException : Exception
    {
        public ProcessNullException()
            : base("Process is null")
        {
        }
    }
}
