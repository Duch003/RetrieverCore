using System;

namespace GathererEngine.Decoders
{
    public class DeviceTypeDecoder
    {
        public static string Decode(UInt32 type)
        {
            switch (type)
            {
                case 0:
                default:
                    return "Unknown";
                case 1:
                    return "No Root Directory";
                case 2:
                    return "Removable Disk";
                case 3:
                    return "Local Disk";
                case 4:
                    return "Network Drive";
                case 5:
                    return "Compact Disc";
                case 6:
                    return "RAM Disk";
            }
        }
    }
}
