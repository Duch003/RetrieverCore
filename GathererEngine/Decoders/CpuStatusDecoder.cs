using System;
using System.Collections.Generic;
using System.Text;

namespace GathererEngine.Decoders
{
    public class CpuStatusDecoder
    {
        public static string Decode(UInt16 status)
        {
            switch (status)
            {
                case 0:
                default:
                    return "Unknown";
                case 1:
                    return "CPU Enabled";
                case 2:
                    return "CPU Disabled by User via BIOS Setup";
                case 3:
                    return "CPU Disabled By BIOS (POST Error)";
                case 4:
                    return "CPU is Idle";
                case 5:
                case 6:
                    return "Reserved";
                case 7:
                    return "Other";
            }
        }
    }
}
