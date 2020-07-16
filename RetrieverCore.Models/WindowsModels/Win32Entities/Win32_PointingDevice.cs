using RetrieverCore.Models.WindowsModels.Constants;
using System;

namespace RetrieverCore.Models.WindowsModels.Win32Entities
{
    public class Win32_PointingDevice
    {
        public const string Scope = WmiScope.Cimv2;

        public string Name { get; set; }
        public UInt32 ConfigManagerErrorCode { get; set; }
        public UInt16 DeviceInterface { get; set; }
        public string Manufacturer { get; set; }
        public UInt16 PointingType { get; set; }
        public string Status { get; set; }
    }
}
