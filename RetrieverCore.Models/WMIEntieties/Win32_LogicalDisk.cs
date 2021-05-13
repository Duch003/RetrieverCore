using System;
using GathererEngine.Constants;
using RetrieverCore.Models.WMIEntieties.Base;

namespace RetrieverCore.Models.WMIEntieties
{
    public class Win32_LogicalDisk : WmiEntityBase
    {
        public Win32_LogicalDisk() : base()
        {
            Scope = WmiScope.Cimv2;
        }

        public string DeviceID { get; set; }
        public string FileSystem { get; set; }
        public UInt32? MediaType { get; set; }
        public string VolumeName { get; set; }
    }
}
