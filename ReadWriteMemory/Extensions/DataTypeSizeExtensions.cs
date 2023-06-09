using static omertrans156.ReadWriteMemory.Utility.MemoryUtility;

namespace omertrans156.ReadWriteMemory.Extensions
{
    public static class DataTypeSizeExtensions
    {
        public static int GetSize(this DataTypeSize input, int lenght = 0)
        {
            switch (input)
            {
                case DataTypeSize.ArrayBytes:
                    return lenght;
                case DataTypeSize.Byte:
                    return 1;
                case DataTypeSize.Short:
                    return 2;
                case DataTypeSize.Int:
                    return 4;
                case DataTypeSize.Long:
                    return 8;
                case DataTypeSize.Float:
                    return 4;
                case DataTypeSize.Double:
                    return 8;
                case DataTypeSize.Bool:
                    return 1;
                case DataTypeSize.String:
                    return lenght;
                default:
                    return 0;
            }
        }
    }
}
