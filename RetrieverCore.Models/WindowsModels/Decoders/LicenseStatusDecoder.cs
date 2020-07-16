namespace RetrieverCore.Models.WindowsModels.Decoders
{
    public class LicenseStatusDecoder
    {
        public static string Decode(int status)
        {
            switch (status)
            {
                case 0:
                    return "Unlicensed";
                case 1:
                    return "Licensed";
                case 2:
                    return "OOB grace";
                case 3:
                    return "OOT grace";
                case 4:
                    return "Non-geniue grace";
                case 5:
                    return "Notification";
                case 6:
                    return "Extended grace";
                case 7:
                    return "Not found";
                default:
                    return "Unknown";
            }
        }
    }
}
