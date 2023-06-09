using System;

namespace omertrans156.ReadWriteMemory.Exceptions
{
    public class ModuleNotFoundException : Exception
    {
        public ModuleNotFoundException(string moduleName)
            : base($"Module '{moduleName}' not found.")
        {
        }
    }
}
