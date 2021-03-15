using RetrieverCore.Models.ComputerComponents.Cache;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetrieverCore.Models.ComputerComponents.Physical
{
    public class ProcessorComponent
    {
        public string ModelWithVendor { get; set; }
        public int MaxClockSpeed { get; set; }
        public string Availability { get; set; }
        public string CpuStatus { get; set; }
        public string Status { get; set; }
        public int? ExternalClockFrequency { get; set; }
        public int L2CacheSize { get; set; }
        public int L3CacheSize { get; set; }
        public string ProcessorType { get; set; }
        public string Architecture { get; set; }
        public string Caption { get; set; }
        public int CurrentClockSpeed { get; set; }
        public string Family { get; set; }
        public int NumberOfCores { get; set; }
        public int NumberOfEnabledCores { get; set; }
        public int NumberOfLogicalProcessors { get; set; }
        public string Role { get; set; }
        public string UpgradeMethod { get; set; }
        public IEnumerable<CacheMemory> Caches { get; set; }

    }
}
