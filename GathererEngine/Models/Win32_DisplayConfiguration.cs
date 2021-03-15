
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_DisplayConfiguration
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt32 BitsPerPel { get; set; }
        public string Caption { get; set; }
        public string Description { get; set; }
        public string DeviceName { get; set; }
        public UInt32 DisplayFlags { get; set; }
        public UInt32 DisplayFrequency { get; set; }
        public UInt32 DitherType { get; set; }
        public string DriverVersion { get; set; }
        public UInt32 ICMIntent { get; set; }
        public UInt32 ICMMethod { get; set; }
        public UInt32 LogPixels { get; set; }
        public UInt32 PelsHeight { get; set; }
        public UInt32 PelsWidth { get; set; }
        public string SettingID { get; set; }
        public UInt32 SpecificationVersion { get; set; }

    }
}