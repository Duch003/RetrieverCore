using System;

namespace RetrieverCore.Models.WindowsModels.Decoders
{
    public class ProcessorTypeDecoder
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
                    return "Central Processor";
                case 4:
                    return "Math Processor";
                case 5:
                    return "DSP Processor";
                case 6:
                    return "Video Processor";
            }
        }
    }
}
