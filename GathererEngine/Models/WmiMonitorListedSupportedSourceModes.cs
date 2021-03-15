
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class WmiMonitorListedSupportedSourceModes
    {
        public const string Scope = WmiScope.Wmi;
        public bool Active { get; set; }
        public string InstanceName { get; set; }
        public object MonitorSourceModes { get; set; }
        public UInt16 NumOfMonitorSourceModes { get; set; }
        public UInt16 PreferredMonitorSourceModeIndex { get; set; }

    }
}