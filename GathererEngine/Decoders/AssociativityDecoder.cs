using System;

namespace GathererEngine.Decoders
{
    public class AssociativityDecoder
    {
        public static string Decode(UInt16 associativity)
        {
            switch (associativity)
            {
                case 1:
                    return "Other";
                case 2:
                default:
                    return "Unknown";
                case 3:
                    return "Direct Mapped";
                case 4:
                    return "2-way Set-Associative";
                case 5:
                    return "4-way Set-Associative ";
                case 6:
                    return "Fully Associative";
                case 7:
                    return "8-way Set-Associative";
                case 8:
                    return "16-way Set-Associative";
            }
        }
    }
}
