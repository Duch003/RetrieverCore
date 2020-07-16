using RetrieverCore.Models.WindowsModels.Constants;
using System;

namespace RetrieverCore.Models.WindowsModels.Win32Entities
{
    public class Win32_DiskDrive
    {
        public const string Scope = WmiScope.Cimv2;
        public string DeviceId { get; set; }
        public string Caption { get; set; }
        public UInt64 Size { get; set; }
        public string MediaType { get; set; }
        public string InterfaceType { get; set; }
        public UInt32 ConfigManagerErrorCode { get; set; }
        public string[] CapabilityDescriptions { get; set; }
        public string Model { get; set; }
        public string Status { get; set; }

    }
}
