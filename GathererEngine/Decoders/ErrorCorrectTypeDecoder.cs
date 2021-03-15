using System;

namespace GathererEngine.Decoders
{
    public class ErrorCorrectTypeDecoder
    {
        public static string Decode(UInt16 type)
        {
            switch(type)
            {
                case 1:
                    return "Other";
                case 2:
                default:
                    return "Unknown";
                case 3:
                    return "Read";
                case 4:
                    return "Write";
                case 5:
                    return "Partial Write";
            }
        }
    }
}
