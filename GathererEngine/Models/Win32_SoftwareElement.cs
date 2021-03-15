
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_SoftwareElement
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt16 Attributes { get; set; }
        public string BuildNumber { get; set; }
        public string Caption { get; set; }
        public string CodeSet { get; set; }
        public string Description { get; set; }
        public string IdentificationCode { get; set; }
        public DateTime InstallDate { get; set; }
        public Int16 InstallState { get; set; }
        public string LanguageEdition { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public string OtherTargetOS { get; set; }
        public string Path { get; set; }
        public string SerialNumber { get; set; }
        public string SoftwareElementID { get; set; }
        public UInt16 SoftwareElementState { get; set; }
        public string Status { get; set; }
        public UInt16 TargetOperatingSystem { get; set; }
        public string Version { get; set; }

    }
}