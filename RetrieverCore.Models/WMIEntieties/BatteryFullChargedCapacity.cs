using System;
using GathererEngine.Constants;
using RetrieverCore.Models.WMIEntieties.Base;

namespace RetrieverCore.Models.WMIEntieties
{
    public class BatteryFullChargedCapacity : WmiEntityBase
    {
        public BatteryFullChargedCapacity() : base()
        {
            Scope = WmiScope.Wmi;
        }

        public static string Conditions(UInt32 tag) => $"Tag = { tag }";
        public UInt32? FullChargedCapacity { get; set; }
        public UInt32? Tag { get; set; }
    }
}
