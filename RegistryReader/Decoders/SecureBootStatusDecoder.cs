namespace RegistryReader.Decoders
{
    public static class SecureBootStatusDecoder
    {
        public static string Decode(int status)
        {
            switch (status)
            {
                case 0:
                    return "Disabled";
                case 1:
                    return "Enabled";
                case 2:
                    return "Not supported";
                default:
                    return "Unknown";
            }
        }
    }
}
