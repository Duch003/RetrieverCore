using System;

namespace GathererEngine.Decoders
{
    public class StatusInfoDecoder
    {
        public static string Decode(UInt16 status)
        {
            switch (status)
            {
                case 1:
                    return "Other";
                case 2:
                    return "Unknown ";
                case 3:
                    return "Enabled ";
                case 4:
                    return "Disabled ";
                case 5:
                    return "Not Applicable";
                default:
                    return "Unknown";
            }
        }
    }
}
