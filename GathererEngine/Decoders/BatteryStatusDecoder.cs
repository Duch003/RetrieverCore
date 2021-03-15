namespace GathererEngine.Decoders
{
    public class BatteryStatusDecoder
    {
        public static string Decode(int status)
        {
            switch (status)
            {
                case 1:
                    return "The battery is discharging.";
                case 2:
                    return "Connected to charger, fully charged.";
                case 3:
                    return "Fully charged";
                case 4:
                    return "Low";
                case 5:
                    return "Critical";
                case 6:
                    return "Charging";
                case 7:
                    return "Charging and high";
                case 8:
                    return "Charging and low";
                case 9:
                    return "Charging and critical";
                case 10:
                    return "Undefined";
                case 11:
                    return "Partially charged";
                default:
                    return "Unknown";
            }
        }
    }
}
