
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class MSNdis_CoMediaConnectStatus
    {
        public const string Scope = WmiScope.Wmi;
        public bool Active { get; set; }
        public string InstanceName { get; set; }
        public UInt32 NdisCoMediaConnectStatus { get; set; }

    }
}