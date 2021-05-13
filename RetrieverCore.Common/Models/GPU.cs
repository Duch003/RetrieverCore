using RetrieverCore.Common.Models.Base;

namespace RetrieverCore.Common.Models
{
    public class GPU : EntityBase
    {
        //Win32_VideoController
        public string Availability { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public long Capacity { get; set; }
        public string AdapterDACType { get; set; }
        public string Name { get; set; }
        public string VideoArchitecture { get; set; }
        public long NumberOfColors { get; set; }
        public int MaxRefreshRate { get; set; }
    }
}
