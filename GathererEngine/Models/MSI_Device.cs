
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class MSI_Device
    {
        public const string Scope = WmiScope.Wmi;
        public bool Active { get; set; }
        public byte Device { get; set; }
        public string InstanceName { get; set; }

    }
}