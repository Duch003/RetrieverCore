
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class MSNdis_CoReceivePdusOk
    {
        public const string Scope = WmiScope.Wmi;
        public bool Active { get; set; }
        public string InstanceName { get; set; }
        public UInt64 NdisCoReceivePdusOk { get; set; }

    }
}