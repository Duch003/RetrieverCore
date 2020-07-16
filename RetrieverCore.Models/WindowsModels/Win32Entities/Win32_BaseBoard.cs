using RetrieverCore.Models.WindowsModels.Constants;

namespace RetrieverCore.Models.WindowsModels.Win32Entities
{
    public class Win32_BaseBoard
    {
        public const string Scope = WmiScope.Cimv2;
        public string Product { get; set; }
        public string Manufacturer { get; set; }
        public string SerialNumber { get; set; }
        public bool Replecable { get; set; }
        public bool Removable { get; set; }
    }
}
