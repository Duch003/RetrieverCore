
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class MSNdis_PhysicalMediumType
    {
        public const string Scope = WmiScope.Wmi;
        public bool Active { get; set; }
        public string InstanceName { get; set; }
        public UInt32 NdisPhysicalMediumType { get; set; }

    }
}