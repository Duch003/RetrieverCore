
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_OnBoardDevice
    {
        public const string Scope = WmiScope.Cimv2;
        public string Caption { get; set; }
        public string CreationClassName { get; set; }
        public string Description { get; set; }
        public UInt16 DeviceType { get; set; }
        public bool Enabled { get; set; }
        public bool HotSwappable { get; set; }
        public DateTime InstallDate { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }
        public string OtherIdentifyingInfo { get; set; }
        public string PartNumber { get; set; }
        public bool PoweredOn { get; set; }
        public bool Removable { get; set; }
        public bool Replaceable { get; set; }
        public string SerialNumber { get; set; }
        public string SKU { get; set; }
        public string Status { get; set; }
        public string Tag { get; set; }
        public string Version { get; set; }

    }
}