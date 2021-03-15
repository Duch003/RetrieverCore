using System;

namespace GathererEngine.Decoders
{
    public class LocationDecoder
    {
        public static string Decode(UInt16 location)
        {
            switch (location)
            {
                case 0:
                    return "Internal";
                case 1:
                    return "External";
                case 2:
                    return "Reserved";
                case 3:
                default:
                    return "Unknown";
            }
        }
    }
}
