
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class WmiMonitorDigitalVideoInputParams
    {
        public const string Scope = WmiScope.Wmi;
        public bool Active { get; set; }
        public string InstanceName { get; set; }
        public bool IsDFP1xCompatible { get; set; }

    }
}