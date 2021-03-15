
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class WmiMonitorBrightness
    {
        public const string Scope = WmiScope.Wmi;
        public bool Active { get; set; }
        public byte CurrentBrightness { get; set; }
        public string InstanceName { get; set; }
        public byte Level { get; set; }
        public UInt32 Levels { get; set; }

    }
}