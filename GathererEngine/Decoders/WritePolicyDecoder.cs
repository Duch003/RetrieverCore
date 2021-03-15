using System;

namespace GathererEngine.Decoders
{
    public class WritePolicyDecoder
    {
        public static string Decode(UInt16 policy)
        {
            switch (policy)
            {
                case 1:
                    return "Other";
                case 2:
                default:
                    return "Unknown";
                case 3:
                    return "Write Back";
                case 4:
                    return "Write Through";
                case 5:
                    return "Varies with Address";
                case 6:
                    return "Determination Per I/O";
            }
        }
    }
}
