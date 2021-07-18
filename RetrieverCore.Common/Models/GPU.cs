using Databases.RetrieverCore.Common.Models.Base;

namespace Databases.RetrieverCore.Common.Models
{
    public class GPU : EntityBase
    {
        //Win32_VideoController
        public string Availability { get; set; }
        public long Height { get; set; }
        public long Width { get; set; }
        public long Capacity { get; set; }
        public string AdapterDACType { get; set; }
        public string Name { get; set; }
        public string VideoArchitecture { get; set; }
        public long NumberOfColors { get; set; }
        public int MaxRefreshRate { get; set; }
    }
}
