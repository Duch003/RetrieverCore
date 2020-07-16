using System;

namespace RetrieverCore.Models.WindowsModels.Decoders
{
    public class DeviceInterfaceDecoder
    {
        public static string Decode(UInt16 device)
        {
            switch (device)
            {
                case 1:
                    return "Other";
                case 2:
                default:
                    return "Unknown";
                case 3:
                    return "Serial";
                case 4:
                    return "PS/2";
                case 5:
                    return "Infrared";
                case 6:
                    return "HP-HIL";
                case 7:
                    return "Bus mouse";
                case 8:
                    return "ADB (Apple Desktop Bus)";
                case 160:
                    return "Bus mouse DB-9";
                case 161:
                    return "Bus mouse micro-DIN";
                case 162:
                    return "USB";
            }
        }
    }
}
