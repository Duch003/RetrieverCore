using System;

namespace RetrieverCore.Models.WindowsModels.Decoders
{
    public class CurrentSRAMDecoder
    {
        public static string Decode(UInt16 currentSRAM)
        {
            switch (currentSRAM)
            {
                case 0:
                    return "Other";
                case 1:
                default:
                    return "Unknown";
                case 2:
                    return "Non-Burst";
                case 3:
                    return "Burst";
                case 4:
                    return "Pipeline Burst";
                case 5:
                    return "Synchronous";
                case 6:
                    return "Asynchronous";
            }
        }
    }
}
