using System;

namespace GathererEngine.Decoders
{
    public class LevelDecoder
    {
        public static string Decode(UInt16 level)
        {
            switch (level)
            {
                case 1:
                    return "Other";
                case 2:
                default:
                    return "Unknown";
                case 3:
                    return "Primary";
                case 4:
                    return "Secondary";
                case 5:
                    return "Tetiary";
                case 6:
                    return "Not Applicable";
            }
        }
    }
}
