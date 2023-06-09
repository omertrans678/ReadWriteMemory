using System;

namespace omertrans156.ReadWriteMemory.Exceptions
{
    public class ModuleNameMissingException : Exception
    {
        public ModuleNameMissingException()
            : base("Multi-processes Read Memory is ModuleName+Pointer only.")
        {
        }

        public ModuleNameMissingException(string message)
            : base(message)
        {
        }

        public ModuleNameMissingException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
