using System;
using GathererEngine.Constants;
using RetrieverCore.Models.WMIEntieties.Base;

namespace RetrieverCore.Models.WMIEntieties
{
    public class Win32_DiskDrive : WmiEntityBase
    {
        public Win32_DiskDrive() : base()
        {
            Scope = WmiScope.Cimv2;
        }

        public string[] CapabilityDescriptions { get; set; }
        public string Caption { get; set; }
        public string DeviceID { get; set; }
        public string InterfaceType { get; set; }
        public string MediaType { get; set; }
        public string Model { get; set; }
        public UInt64? Size { get; set; }
    }
}
