
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class MSNdis_EthernetMulticastList
    {
        public const string Scope = WmiScope.Wmi;
        public bool Active { get; set; }
        public string InstanceName { get; set; }
        public object NdisMulticastList { get; set; }
        public UInt32 NumberElements { get; set; }

    }
}