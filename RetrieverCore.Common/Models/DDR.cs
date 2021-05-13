using RetrieverCore.Common.Models.Base;

namespace RetrieverCore.Common.Models
{
    public class DDR : EntityBase
    {
        //Win32_PhysicalMemory
        public double Capacity { get; set; }
        public int Clocking { get; set; }
        public string Vendor { get; set; }
        public string FormFactor { get; set; }
    }
}
