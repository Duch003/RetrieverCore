using RetrieverCore.Models.WindowsModels.Constants;

namespace RetrieverCore.Models.WindowsModels.Win32Entities
{
    public class SoftwareLicensingService
    {
        public const string Scope = WmiScope.Cimv2;
        public const string Conditions = "OA3xOriginalProductKey != null";
        public string OA3xOriginalProductKey { get; set; }
    }
}
