using RetrieverCore.Models.WindowsModels.Constants;
using System;

namespace RetrieverCore.Models.WindowsModels.Win32Entities
{
    public class Win32_BIOS
    {
        public const string Scope = WmiScope.Cimv2;
        public string Status { get; set; }
        public string SMBIOSBIOSVersion { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Name { get; set; }
        public string Caption { get; set; }
        public UInt16[] BiosCharacteristics { get; set; }
        public string[] BIOSVersion { get; set; }
        public string Description { get; set; }
        public string SerialNumber { get; set; }
        public string SoftwareElementID { get; set; }
        public string Version { get; set; }
    }
}
