
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_Perf
    {
        public const string Scope = WmiScope.Cimv2;
        public string Caption { get; set; }
        public string Description { get; set; }
        public UInt64 Frequency_Object { get; set; }
        public UInt64 Frequency_PerfTime { get; set; }
        public UInt64 Frequency_Sys100NS { get; set; }
        public string Name { get; set; }
        public UInt32 StateServerSessionsAbandoned { get; set; }
        public UInt32 StateServerSessionsActive { get; set; }
        public UInt32 StateServerSessionsTimedOut { get; set; }
        public UInt32 StateServerSessionsTotal { get; set; }
        public UInt64 Timestamp_Object { get; set; }
        public UInt64 Timestamp_PerfTime { get; set; }
        public UInt64 Timestamp_Sys100NS { get; set; }

    }
}