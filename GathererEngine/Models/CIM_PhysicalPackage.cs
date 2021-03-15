
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class CIM_PhysicalPackage
    {
        public const string Scope = WmiScope.Cimv2;
        public string Caption { get; set; }
        public string CreationClassName { get; set; }
        public float Depth { get; set; }
        public string Description { get; set; }
        public float Height { get; set; }
        public bool HotSwappable { get; set; }
        public DateTime InstallDate { get; set; }
        public UInt16 Location { get; set; }
        public string Manufacturer { get; set; }
        public UInt32 MaxCapacity { get; set; }
        public UInt64 MaxCapacityEx { get; set; }
        public UInt16 MemoryDevices { get; set; }
        public UInt16 MemoryErrorCorrection { get; set; }
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
        public UInt16 Use { get; set; }
        public string Version { get; set; }
        public float Weight { get; set; }
        public float Width { get; set; }

    }
}