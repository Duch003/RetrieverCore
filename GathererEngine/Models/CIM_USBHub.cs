
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class CIM_USBHub
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt16 Availability { get; set; }
        public string Caption { get; set; }
        public byte ClassCode { get; set; }
        public UInt32 ConfigManagerErrorCode { get; set; }
        public bool ConfigManagerUserConfig { get; set; }
        public string CreationClassName { get; set; }
        public byte CurrentAlternateSettings { get; set; }
        public byte CurrentConfigValue { get; set; }
        public string Description { get; set; }
        public string DeviceID { get; set; }
        public bool ErrorCleared { get; set; }
        public string ErrorDescription { get; set; }
        public bool GangSwitched { get; set; }
        public DateTime InstallDate { get; set; }
        public UInt32 LastErrorCode { get; set; }
        public string Name { get; set; }
        public byte NumberOfConfigs { get; set; }
        public byte NumberOfPorts { get; set; }
        public string PNPDeviceID { get; set; }
        public UInt16 PowerManagementCapabilities { get; set; }
        public bool PowerManagementSupported { get; set; }
        public byte ProtocolCode { get; set; }
        public string Status { get; set; }
        public UInt16 StatusInfo { get; set; }
        public byte SubclassCode { get; set; }
        public string SystemCreationClassName { get; set; }
        public string SystemName { get; set; }
        public UInt16 USBVersion { get; set; }

    }
}