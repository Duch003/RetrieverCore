namespace RetrieverCore.Models.ComputerComponents.Physical
{
    public class DDRComponent
    {
        //Win32_PhysicalMemory
        public int Capacity { get; set; }
        public int Clocking { get; set; }
        public string Vendor { get; set; }
        public string FormFactor { get; set; }
    }
}
