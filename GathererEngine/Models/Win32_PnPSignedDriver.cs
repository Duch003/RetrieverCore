
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_PnPSignedDriver
    {
        public const string Scope = WmiScope.Cimv2;
        public string Caption { get; set; }
        public string ClassGuid { get; set; }
        public string CompatID { get; set; }
        public string CreationClassName { get; set; }
        public string Description { get; set; }
        public string DeviceClass { get; set; }
        public string DeviceID { get; set; }
        public string DeviceName { get; set; }
        public string DevLoader { get; set; }
        public DateTime DriverDate { get; set; }
        public string DriverName { get; set; }
        public string DriverProviderName { get; set; }
        public string DriverVersion { get; set; }
        public string FriendlyName { get; set; }
        public string HardWareID { get; set; }
        public string InfName { get; set; }
        public DateTime InstallDate { get; set; }
        public bool IsSigned { get; set; }
        public string Location { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public string PDO { get; set; }
        public string Signer { get; set; }
        public bool Started { get; set; }
        public string StartMode { get; set; }
        public string Status { get; set; }
        public string SystemCreationClassName { get; set; }
        public string SystemName { get; set; }

    }
}