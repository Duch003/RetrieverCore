using System;

namespace GathererEngine.Decoders
{
    public class PhysicalDiskMediaTypeDecoder
    {
        public static string Decode(UInt16 type)
        {
            switch (type)
            {
                case 0:
                default:
                    return "Unspecified";
                case 3:
                    return "HDD";
                case 4:
                    return "SSD";
                case 5:
                    return "SCM";
            }
        }
    }
}
