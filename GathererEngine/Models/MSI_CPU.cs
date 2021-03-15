
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class MSI_CPU
    {
        public const string Scope = WmiScope.Wmi;
        public bool Active { get; set; }
        public byte CPU { get; set; }
        public string InstanceName { get; set; }

    }
}