using GathererEngine.Constants;
using System;
using RetrieverCore.Models.WMIEntieties.Base;

namespace RetrieverCore.Models.WMIEntieties
{
    public class BatteryStaticData : WmiEntityBase
    {
        public BatteryStaticData() : base()
        {
            Scope = WmiScope.Wmi;
        }

        public UInt32? DesignedCapacity { get; set; }
        public UInt32? Tag { get; set; }
        public string UniqueID { get; set; }
    }
}
