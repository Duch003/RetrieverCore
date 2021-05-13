using GathererEngine.Constants;
using RetrieverCore.Models.WMIEntieties.Base;
using System;

namespace RetrieverCore.Models.WMIEntieties
{
    public class Win32_MotherboardDevice : WmiEntityBase
    {
        public Win32_MotherboardDevice() : base()
        {
            Scope = WmiScope.Cimv2;
        }

        public string PrimaryBusType { get; set; }
        public string SecondaryBusType { get; set; }
        public UInt16? Availability { get; set; }
    }
}
