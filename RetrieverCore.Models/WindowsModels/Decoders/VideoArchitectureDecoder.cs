using System;

namespace RetrieverCore.Models.WindowsModels.Decoders
{
    public class VideoArchitectureDecoder
    {
        public static string Decode(UInt16 architecture)
        {
            switch (architecture)
            {
                case 1:
                    return "Other";
                case 2:
                default:
                    return "Unknown";
                case 3:
                    return "CGA";
                case 4:
                    return "EGA";
                case 5:
                    return "VGA";
                case 6:
                    return "SVGA";
                case 7:
                    return "MDA";
                case 8:
                    return "HGC";
                case 9:
                    return "MCGA";
                case 10:
                    return "8514A";
                case 11:
                    return "XGA";
                case 12:
                    return "Linear Frame Buffer";
                case 160:
                    return "PC-98";
            }
        }
    }
}
