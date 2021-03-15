using RetrieverCore.Models.Common;

namespace RetrieverCore.Models.ComputerComponents.Physical
{
    public class GPUComponent
    {
        //Win32_VideoController
        public Resolution Resolution { get; set; }
        public string Model { get; set; }
        public int Capacity { get; set; }
        public string Status { get; set; }
        public string AdapterDACType { get; set; }
        public string Caption { get; set; }
        public string VideoArchitecture { get; set; }
        public string Vendor { get; set; }
        public long NumberOfColors { get; set; }
        public int MaxRefreshRate { get; set; }
    }
}
