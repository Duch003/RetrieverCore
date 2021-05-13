using System;
using GathererEngine.Constants;
using RetrieverCore.Models.WMIEntieties.Base;

namespace RetrieverCore.Models.WMIEntieties
{
    public class Win32_DiskPartition : WmiEntityBase
    {
        public Win32_DiskPartition() : base()
        {
            Scope = WmiScope.Cimv2;
        }

        public bool? Bootable { get; set; }
        public bool? BootPartition { get; set; }
        public string DeviceID { get; set; }
        public UInt64? Size { get; set; }
        public bool? PrimaryPartition { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
    }
}
