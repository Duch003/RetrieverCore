
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class MSDiskDriver_Performance
    {
        public const string Scope = WmiScope.Wmi;
        public bool Active { get; set; }
        public string DeviceName { get; set; }
        public string InstanceName { get; set; }
        public object PerfData { get; set; }

    }
}