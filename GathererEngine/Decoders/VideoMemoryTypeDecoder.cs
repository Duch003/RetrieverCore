using System;
using System.Collections.Generic;
using System.Text;

namespace GathererEngine.Decoders
{
    public class VideoMemoryTypeDecoder
    {
        public static string Decode(UInt16 type)
        {
            switch (type)
            {
                case 1:
                    return "Other";
                case 2:
                default:
                    return "Unknown";
                case 3:
                    return "VRAM";
                case 4:
                    return "DRAM";
                case 5:
                    return "SRAM";
                case 6:
                    return "WRAM";
                case 7:
                    return "EDO RAM";
                case 8:
                    return "Burst Synchronous DRAM";
                case 9:
                    return "Pipelined Burst SRAM";
                case 10:
                    return "CDRAM";
                case 11:
                    return "3DRAM";
                case 12:
                    return "SDRAM";
                case 13:
                    return "SGRAM";
            }
        }
    }
}
