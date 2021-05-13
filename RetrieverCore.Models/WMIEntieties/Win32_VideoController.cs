using System;
using GathererEngine.Constants;
using RetrieverCore.Models.WMIEntieties.Base;

namespace RetrieverCore.Models.WMIEntieties
{
    public class Win32_VideoController : WmiEntityBase
    {
        public Win32_VideoController() : base()
        {
            Scope = WmiScope.Cimv2;
        }

        public UInt16? Availability { get; set; }
        public UInt32? AdapterRAM { get; set; }
        public UInt32? CurrentHorizontalResolution { get; set; }
        public UInt32? CurrentVerticalResolution { get; set; }
        public string Caption { get; set; }
        public string AdapterDACType { get; set; }
        public UInt16? VideoArchitecture { get; set; }
        public UInt64? CurrentNumberOfColors { get; set; }
        public UInt32? MaxRefreshRate { get; set; }
    }
}
