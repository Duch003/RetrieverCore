using System;
using GathererEngine.Constants;
using RetrieverCore.Models.WMIEntieties.Base;

namespace RetrieverCore.Models.WMIEntieties
{
    public class Win32_Processor : WmiEntityBase
    {
        public Win32_Processor() : base()
        {
            Scope = WmiScope.Cimv2;
        }

        public UInt16? Architecture { get; set; }
        public UInt32? CurrentClockSpeed { get; set; }
        public UInt32? L2CacheSize { get; set; }
        public UInt32? L3CacheSize { get; set; }
        public string Name { get; set; }
        public UInt32? NumberOfCores { get; set; }
        public UInt32? NumberOfLogicalProcessors { get; set; }
        public UInt16? ProcessorType { get; set; }
        public string Caption { get; set; }
        public UInt16? Family { get; set; }
        public UInt16? UpgradeMethod { get; set; }
    }
}
