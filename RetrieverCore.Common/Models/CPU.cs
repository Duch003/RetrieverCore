using RetrieverCore.Common.Models.Base;

namespace RetrieverCore.Common.Models
{
    public class CPU : EntityBase
    {
        public string ModelWithVendor { get; set; }
        public int L2CacheSize { get; set; }
        public int L3CacheSize { get; set; }
        public string ProcessorType { get; set; }
        public string Architecture { get; set; }
        public string Caption { get; set; }
        public int CurrentClockSpeed { get; set; }
        public string Family { get; set; }
        public int NumberOfCores { get; set; }
        public int NumberOfLogicalProcessors { get; set; }
        public string UpgradeMethod { get; set; }
        //public IEnumerable<CacheMemory> Caches { get; set; }
    }
}
