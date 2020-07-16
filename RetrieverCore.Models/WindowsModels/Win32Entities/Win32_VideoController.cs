using RetrieverCore.Models.WindowsModels.Constants;
using System;

namespace RetrieverCore.Models.WindowsModels.Win32Entities
{
    public class Win32_VideoController
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt32 CurrentHorizontalResolution { get; set; }
        public UInt32 CurrentVerticalResolution { get; set; }
        public string Name { get; set; }
        public UInt32 AdapterRAM { get; set; } //[bytes]
        public string Status { get; set; }
        public string AdapterDACType { get; set; }
        public string Caption { get; set; }
        public DateTime DriverDate { get; set; }
        public string DriverVersion { get; set; }
        public UInt16 VideoArchitecture { get; set; }
        public string VideoProcessor { get; set; }
        public string AdapterCompatibility { get; set; } //a.k.a. Vendor
        public UInt64 CurrentNumberOfColors { get; set; }
        public UInt32 MaxRefreshRate { get; set; }
    }
}
