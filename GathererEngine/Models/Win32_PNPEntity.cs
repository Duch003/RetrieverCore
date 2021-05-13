using System;
using GathererEngine.Constants;
using GathererEngine.Extensions;

namespace GathererEngine.Models
{
    public class Win32_PnPEntity
    {
        public const string Scope = WmiScope.Cimv2;
        public const string Conditions = "ConfigManagerErrorCode != 0";
        public UInt16? Availability { get; set; }
        public string Caption { get; set; }
        public string ClassGuid { get; set; }
        public string[] CompatibleID { get; set; }
        public UInt32? ConfigManagerErrorCode { get; set; }
        public bool? ConfigManagerUserConfig { get; set; }
        public string CreationClassName { get; set; }
        public string Description { get; set; }
        public string DeviceID { get; set; }
        public bool? ErrorCleared { get; set; }
        public string ErrorDescription { get; set; }
        public string[] HardwareID { get; set; }
        public DateTime? InstallDate { get; set; }
        public UInt32? LastErrorCode { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public string PNPClass { get; set; }
        public string PNPDeviceID { get; set; }
        public UInt16?[] PowerManagementCapabilities { get; set; }
        public bool? PowerManagementSupported { get; set; }
        public bool? Present { get; set; }
        public string Service { get; set; }
        public string Status { get; set; }
        public UInt16? StatusInfo { get; set; }
        public string SystemCreationClassName { get; set; }
        public string SystemName { get; set; }
    }
}
