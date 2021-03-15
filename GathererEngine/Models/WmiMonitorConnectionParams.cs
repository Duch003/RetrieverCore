
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class WmiMonitorConnectionParams
    {
        public const string Scope = WmiScope.Wmi;
        public bool Active { get; set; }
        public string InstanceName { get; set; }
        public UInt32 VideoOutputTechnology { get; set; }

    }
}