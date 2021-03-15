
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_PrinterConfiguration
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt32 BitsPerPel { get; set; }
        public string Caption { get; set; }
        public bool Collate { get; set; }
        public UInt32 Color { get; set; }
        public UInt32 Copies { get; set; }
        public string Description { get; set; }
        public string DeviceName { get; set; }
        public UInt32 DisplayFlags { get; set; }
        public UInt32 DisplayFrequency { get; set; }
        public UInt32 DitherType { get; set; }
        public UInt32 DriverVersion { get; set; }
        public bool Duplex { get; set; }
        public string FormName { get; set; }
        public UInt32 HorizontalResolution { get; set; }
        public UInt32 ICMIntent { get; set; }
        public UInt32 ICMMethod { get; set; }
        public UInt32 LogPixels { get; set; }
        public UInt32 MediaType { get; set; }
        public string Name { get; set; }
        public UInt32 Orientation { get; set; }
        public UInt32 PaperLength { get; set; }
        public string PaperSize { get; set; }
        public UInt32 PaperWidth { get; set; }
        public UInt32 PelsHeight { get; set; }
        public UInt32 PelsWidth { get; set; }
        public UInt32 PrintQuality { get; set; }
        public UInt32 Scale { get; set; }
        public string SettingID { get; set; }
        public UInt32 SpecificationVersion { get; set; }
        public UInt32 TTOption { get; set; }
        public UInt32 VerticalResolution { get; set; }
        public UInt32 XResolution { get; set; }
        public UInt32 YResolution { get; set; }

    }
}