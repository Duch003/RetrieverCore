using System;

namespace GathererEngine.Decoders
{
    public class AvailabilityDecoder
    {
        public static string Decode(UInt16 status)
        {
            switch (status)
            {
                case 1:
                    return "Other";
                case 2:
                    return "Unknown";
                case 3:
                    return "Running or Full Power";
                case 4:
                    return "Warning";
                case 5:
                    return "In Test";
                case 6:
                    return "Not Applicable";
                case 7:
                    return "Power Off";
                case 8:
                    return "Off Line";
                case 9:
                    return "Off Duty";
                case 10:
                    return "Degraded ";
                case 11:
                    return "Not Installed";
                case 12:
                    return "Install Error";
                case 13:
                    return "Power Save - Unknown";
                case 14:
                    return "Power Save - Low Power Mode";
                case 15:
                    return "Power Save - Standby";
                case 16:
                    return "Power Cycle";
                case 17:
                    return "Power Save - Warning";
                case 18:
                    return "Paused ";
                case 19:
                    return "Not Ready";
                case 20:
                    return "Not Configured";
                case 21:
                    return "Quiesced";
                default:
                    return "Unknwon status";
            }
        }
    }
}
