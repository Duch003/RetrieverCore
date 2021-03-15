
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class MSNdis_MaximumLookahead
    {
        public const string Scope = WmiScope.Wmi;
        public bool Active { get; set; }
        public string InstanceName { get; set; }
        public UInt32 NdisMaximumLookahead { get; set; }

    }
}