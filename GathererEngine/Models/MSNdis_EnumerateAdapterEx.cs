
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class MSNdis_EnumerateAdapterEx
    {
        public const string Scope = WmiScope.Wmi;
        public bool Active { get; set; }
        public object EnumerateAdapter { get; set; }
        public string InstanceName { get; set; }

    }
}