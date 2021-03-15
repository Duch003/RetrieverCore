using System;
using GathererEngine.Attributes;
using GathererEngine.Constants;
using GathererEngine.Extensions;

namespace GathererEngine.Models
{
    public class Win32_PhysicalMemory : MappableToDatabaseExtension
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt32? Attributes { get; set; }
        public string BankLabel { get; set; }
        [Use]
        public UInt64? Capacity { get; set; }
        public string Caption { get; set; }
        [Use]
        public UInt32? ConfiguredClockSpeed { get; set; }
        public UInt32? ConfiguredVoltage { get; set; }
        public string CreationClassName { get; set; }
        public UInt16? DataWidth { get; set; }
        public string Description { get; set; }
        public string DeviceLocator { get; set; }
        public UInt16? FormFactor { get; set; }
        public bool? HotSwappable { get; set; }
        public DateTime? InstallDate { get; set; }
        public UInt16? InterleaveDataDepth { get; set; }
        public UInt32? InterleavePosition { get; set; }
        public string Manufacturer { get; set; }
        public UInt32? MaxVoltage { get; set; }
        public UInt16? MemoryType { get; set; }
        public UInt32? MinVoltage { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }
        public string OtherIdentifyingInfo { get; set; }
        public string PartNumber { get; set; }
        public UInt32? PositionInRow { get; set; }
        public bool? PoweredOn { get; set; }
        public bool? Removable { get; set; }
        public bool? Replaceable { get; set; }
        public string SerialNumber { get; set; }
        public string SKU { get; set; }
        public UInt32? SMBIOSMemoryType { get; set; }
        [Use]
        public UInt32? Speed { get; set; }
        public string Status { get; set; }
        public string Tag { get; set; }
        public UInt16? TotalWidth { get; set; }
        public UInt16? TypeDetail { get; set; }
        public string Version { get; set; }
    }
}
