using System;
using GathererEngine.Constants;
using GathererEngine.Extensions;

namespace GathererEngine.Models
{
    public class CIM_VideoControllerResolution
    {
        public const string Scope = WmiScope.Cimv2;
        public string Caption { get; set; }
        public string Description { get; set; }
        public UInt32? HorizontalResolution { get; set; }
        public UInt32? MaxRefreshRate { get; set; }
        public UInt32? MinRefreshRate { get; set; }
        public UInt64? NumberOfColors { get; set; }
        public UInt32? RefreshRate { get; set; }
        public UInt16? ScanMode { get; set; }
        public string SettingID { get; set; }
        public UInt32? VerticalResolution { get; set; }
    }
}
