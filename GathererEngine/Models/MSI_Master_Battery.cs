
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class MSI_Master_Battery
    {
        public const string Scope = WmiScope.Wmi;
        public bool Active { get; set; }
        public string InstanceName { get; set; }
        public Int16 Master_Battery { get; set; }

    }
}