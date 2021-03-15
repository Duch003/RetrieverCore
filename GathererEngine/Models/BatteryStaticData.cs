using System;
using GathererEngine.Attributes;
using GathererEngine.Constants;
using GathererEngine.Extensions;

namespace GathererEngine.Models
{
    public class BatteryStaticData : MappableToDatabaseExtension
    {
        public const string Scope = WmiScope.Wmi;
        public bool? Active { get; set; }
        public UInt32? Capabilities { get; set; }
        public string Caption { get; set; }
        public UInt32? Chemistry { get; set; }
        public UInt32? CriticalBias { get; set; }
        public UInt32? DefaultAlert1 { get; set; }
        public UInt32? DefaultAlert2 { get; set; }
        public string Description { get; set; }
        [Use]
        public UInt32? DesignedCapacity { get; set; }
        public string DeviceName { get; set; }
        public UInt64? Frequency_Object { get; set; }
        public UInt64? Frequency_PerfTime { get; set; }
        public UInt64? Frequency_Sys100NS { get; set; }
        public UInt64? Granularity0 { get; set; }
        public UInt64? Granularity1 { get; set; }
        public UInt64? Granularity2 { get; set; }
        public UInt64? Granularity3 { get; set; }
        public string InstanceName { get; set; }
        public DateTime? ManufactureDate { get; set; }
        public string ManufactureName { get; set; }
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        [Use]
        public UInt32? Tag { get; set; }
        public byte? Technology { get; set; }
        public UInt64? Timestamp_Object { get; set; }
        public UInt64? Timestamp_PerfTime { get; set; }
        public UInt64? Timestamp_Sys100NS { get; set; }
        [Use]
        public string UniqueID { get; set; }
    }
}
