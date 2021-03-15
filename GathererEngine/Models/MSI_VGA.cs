
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class MSI_VGA
    {
        public const string Scope = WmiScope.Wmi;
        public bool Active { get; set; }
        public string InstanceName { get; set; }
        public byte VGA { get; set; }

    }
}