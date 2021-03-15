
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_DisplayControllerConfiguration
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt32 BitsPerPixel { get; set; }
        public string Caption { get; set; }
        public UInt32 ColorPlanes { get; set; }
        public string Description { get; set; }
        public UInt32 DeviceEntriesInAColorTable { get; set; }
        public UInt32 DeviceSpecificPens { get; set; }
        public UInt32 HorizontalResolution { get; set; }
        public string Name { get; set; }
        public Int32 RefreshRate { get; set; }
        public UInt32 ReservedSystemPaletteEntries { get; set; }
        public string SettingID { get; set; }
        public UInt32 SystemPaletteEntries { get; set; }
        public UInt32 VerticalResolution { get; set; }
        public string VideoMode { get; set; }

    }
}