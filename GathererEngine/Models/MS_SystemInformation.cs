
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class MS_SystemInformation
    {
        public const string Scope = WmiScope.Wmi;
        public bool Active { get; set; }
        public string BaseBoardManufacturer { get; set; }
        public string BaseBoardProduct { get; set; }
        public string BaseBoardVersion { get; set; }
        public byte BiosMajorRelease { get; set; }
        public byte BiosMinorRelease { get; set; }
        public string BIOSReleaseDate { get; set; }
        public string BIOSVendor { get; set; }
        public string BIOSVersion { get; set; }
        public byte ECFirmwareMajorRelease { get; set; }
        public byte ECFirmwareMinorRelease { get; set; }
        public string InstanceName { get; set; }
        public string SystemFamily { get; set; }
        public string SystemManufacturer { get; set; }
        public string SystemProductName { get; set; }
        public string SystemSKU { get; set; }
        public string SystemVersion { get; set; }

    }
}