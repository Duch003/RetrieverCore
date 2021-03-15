using System;
using GathererEngine.Constants;
using GathererEngine.Extensions;

namespace GathererEngine.Models
{
    public class Win32_BIOS : MappableToDatabaseExtension
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt16?[] BiosCharacteristics { get; set; }
        public string[] BIOSVersion { get; set; }
        public string BuildNumber { get; set; }
        public string Caption { get; set; }
        public string CodeSet { get; set; }
        public string CurrentLanguage { get; set; }
        public string Description { get; set; }
        public byte? EmbeddedControllerMajorVersion { get; set; }
        public byte? EmbeddedControllerMinorVersion { get; set; }
        public string IdentificationCode { get; set; }
        public UInt16? InstallableLanguages { get; set; }
        public DateTime? InstallDate { get; set; }
        public string LanguageEdition { get; set; }
        public string[] ListOfLanguages { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public string OtherTargetOS { get; set; }
        public bool? PrimaryBIOS { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string SerialNumber { get; set; }
        public string SMBIOSBIOSVersion { get; set; }
        public UInt16? SMBIOSMajorVersion { get; set; }
        public UInt16? SMBIOSMinorVersion { get; set; }
        public bool? SMBIOSPresent { get; set; }
        public string SoftwareElementID { get; set; }
        public UInt16? SoftwareElementState { get; set; }
        public string Status { get; set; }
        public byte? SystemBiosMajorVersion { get; set; }
        public byte? SystemBiosMinorVersion { get; set; }
        public UInt16? TargetOperatingSystem { get; set; }
        public string Version { get; set; }
    }
}
