using RetrieverCore.Models.WindowsModels.Constants;
using System;

namespace RetrieverCore.Models.WindowsModels.Win32Entities
{
    public class Win32_LogicalDisk
    {
        public const string Scope = WmiScope.Cimv2;
        public string DeviceID { get; set; }
        public string Description { get; set; }
        public UInt32 DeviceType { get; set; }
        public string FileSystem { get; set; }
        public UInt32 MediaType { get; set; }
        public string Size { get; set; }
        public string VolumeName { get; set; }
    }
}
