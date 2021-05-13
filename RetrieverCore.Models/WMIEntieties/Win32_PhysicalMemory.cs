using System;
using GathererEngine.Constants;
using RetrieverCore.Models.WMIEntieties.Base;

namespace RetrieverCore.Models.WMIEntieties
{
    public class Win32_PhysicalMemory : WmiEntityBase
    {
        public Win32_PhysicalMemory() : base()
        {
            Scope = WmiScope.Cimv2;
        }

        public UInt64? Capacity { get; set; }
        public UInt32? ConfiguredClockSpeed { get; set; }
        public UInt16? FormFactor { get; set; }
        public string Manufacturer { get; set; }
    }
}
