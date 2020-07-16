using System;

namespace RetrieverCore.Models.WindowsModels.Decoders
{
    public class HealthStatusDeocder
    {
        public static string Decode(UInt16 health)
        {
            switch (health)
            {
                case 0:
                    return "Healthy";
                case 1:
                    return "Warning";
                case 2:
                    return "Unhealthy";
                case 5:
                default:
                    return "Unknown";
            }
        }
    }
}
