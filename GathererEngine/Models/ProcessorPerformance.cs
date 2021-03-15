
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class ProcessorPerformance
    {
        public const string Scope = WmiScope.Wmi;
        public bool Active { get; set; }
        public string Caption { get; set; }
        public string Description { get; set; }
        public UInt32 frequency { get; set; }
        public UInt64 Frequency_Object { get; set; }
        public UInt64 Frequency_PerfTime { get; set; }
        public UInt64 Frequency_Sys100NS { get; set; }
        public string InstanceName { get; set; }
        public string Name { get; set; }
        public UInt32 percentage { get; set; }
        public UInt32 power { get; set; }
        public UInt64 Timestamp_Object { get; set; }
        public UInt64 Timestamp_PerfTime { get; set; }
        public UInt64 Timestamp_Sys100NS { get; set; }

    }
}