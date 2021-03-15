using System;

namespace GathererEngine.Decoders
{
    public class UpgrageMethodDecoder
    {
        public static string Decode(UInt16 method)
        {
            switch (method)
            {
                case 1:
                    return "Other";
                case 2:
                default:
                    return "Unknown";
                case 3:
                    return "Daughter Board";
                case 4:
                    return "ZIF Socket";
                case 5:
                    return "Replacement/Piggy Back";
                case 6:
                    return "None";
                case 7:
                    return "LIF Socket";
                case 8:
                    return "Slot 1";
                case 9:
                    return "Slot 2";
                case 10:
                    return "370 Pin Socket";
                case 11:
                    return "Slot A";
                case 12:
                    return "Slot M";
                case 13:
                    return "Socket 423";
                case 14:
                    return "Socket A (Socket 462)";
                case 15:
                    return "Socket 478";
                case 16:
                    return "Socket 754";
                case 17:
                    return "Socket 940";
                case 18:
                    return "Socket 939";
            }
        }
    }
}
