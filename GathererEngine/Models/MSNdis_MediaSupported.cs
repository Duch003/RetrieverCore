
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class MSNdis_MediaSupported
    {
        public const string Scope = WmiScope.Wmi;
        public bool Active { get; set; }
        public string InstanceName { get; set; }
        public UInt32 NdisMediaSupported { get; set; }
        public UInt32 NumberElements { get; set; }

    }
}