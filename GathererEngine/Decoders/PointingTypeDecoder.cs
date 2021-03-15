using System;

namespace GathererEngine.Decoders
{
    public class PointingTypeDecoder
    {
        public static string Decode(UInt16 type)
        {
            switch (type)
            {
                case 1:
                    return "Other";
                case 2:
                default:
                    return "Unknown";
                case 3:
                    return "Mouse";
                case 4:
                    return "Track Ball";
                case 5:
                    return "Track Point";
                case 6:
                    return "Glide Point";
                case 7:
                    return "Touch Pad";
                case 8:
                    return "Touch Screen";
                case 9:
                    return "Mouse - Optical Sensor";
            }
        }
    }
}
