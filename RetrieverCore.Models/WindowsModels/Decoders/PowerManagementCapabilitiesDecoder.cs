using System;

namespace RetrieverCore.Models.WindowsModels.Decoders
{
    public class PowerManagementCapabilitiesDecoder
    {
        public static string Decode(UInt16 capability)
        {
            switch (capability)
            {
                case 0:
                    return "Unknown";
                case 1:
                    return "Not Supported";
                case 2:
                    return "Disabled";
                default:
                    return "Unknown capability";
            }
        }
    }
}
