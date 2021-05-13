using System;
using GathererEngine.Constants;
using GathererEngine.Extensions;

namespace GathererEngine.Models
{
    public class BatteryStatus
    {
        public const string Scope = WmiScope.Wmi;
        public bool? Active { get; set; }
        public string Caption { get; set; }
        public Int32? ChargeRate { get; set; }
        public bool? Charging { get; set; }
        public bool? Critical { get; set; }
        public string Description { get; set; }
        public Int32? DischargeRate { get; set; }
        public bool? Discharging { get; set; }
        public UInt64? Frequency_Object { get; set; }
        public UInt64? Frequency_PerfTime { get; set; }
        public UInt64? Frequency_Sys100NS { get; set; }
        public string InstanceName { get; set; }
        public string Name { get; set; }
        public bool? PowerOnline { get; set; }
        public UInt32? RemainingCapacity { get; set; }
        public UInt32? Tag { get; set; }
        public UInt64? Timestamp_Object { get; set; }
        public UInt64? Timestamp_PerfTime { get; set; }
        public UInt64? Timestamp_Sys100NS { get; set; }
        public UInt32? Voltage { get; set; }
    }
}
