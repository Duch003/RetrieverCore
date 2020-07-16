using System;

namespace RetrieverCore.Models.WindowsModels.Decoders
{
    public class ArchitectureDecoder
    {
        public static string Decode(UInt16 type)
        {
            switch (type)
            {
                case 0:
                    return "x86";
                case 1:
                    return "MIPS";
                case 2:
                    return "Alpha";
                case 3:
                    return "PowerPC";
                case 5:
                    return "ARM";
                case 6:
                    return "ia64";
                case 9:
                    return "x64";
                default:
                    return "Unknown";
            }
        }
    }
}
