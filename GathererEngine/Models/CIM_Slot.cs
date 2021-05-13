using System;
using GathererEngine.Constants;
using GathererEngine.Extensions;

namespace GathererEngine.Models
{
    public class CIM_Slot
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt32? BusNumber { get; set; }
        public string Caption { get; set; }
        public string ConnectorPinout { get; set; }
        public UInt16?[] ConnectorType { get; set; }
        public string CreationClassName { get; set; }
        public UInt16? CurrentUsage { get; set; }
        public string Description { get; set; }
        public UInt32? DeviceNumber { get; set; }
        public UInt32? FunctionNumber { get; set; }
        public float? HeightAllowed { get; set; }
        public DateTime? InstallDate { get; set; }
        public float? LengthAllowed { get; set; }
        public string Manufacturer { get; set; }
        public UInt16? MaxDataWidth { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }
        public UInt16? Number { get; set; }
        public string OtherIdentifyingInfo { get; set; }
        public string PartNumber { get; set; }
        public bool? PMESignal { get; set; }
        public bool? PoweredOn { get; set; }
        public string PurposeDescription { get; set; }
        public UInt32? SegmentGroupNumber { get; set; }
        public string SerialNumber { get; set; }
        public bool? Shared { get; set; }
        public string SKU { get; set; }
        public string SlotDesignation { get; set; }
        public bool? SpecialPurpose { get; set; }
        public string Status { get; set; }
        public bool? SupportsHotPlug { get; set; }
        public string Tag { get; set; }
        public UInt32? ThermalRating { get; set; }
        public UInt16?[] VccMixedVoltageSupport { get; set; }
        public string Version { get; set; }
        public UInt16?[] VppMixedVoltageSupport { get; set; }
    }
}
