
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class MSPower_DeviceWakeEnable
    {
        public const string Scope = WmiScope.Wmi;
        public bool Active { get; set; }
        public bool Enable { get; set; }
        public string InstanceName { get; set; }

    }
}