
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class MSNdis_QueryNicSwitchHardwareCapabilities
    {
        public const string Scope = WmiScope.Wmi;
        public bool Active { get; set; }
        public string InstanceName { get; set; }

    }
}