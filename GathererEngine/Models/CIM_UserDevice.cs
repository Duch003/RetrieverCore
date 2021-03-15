
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class CIM_UserDevice
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt16 Availability { get; set; }
        public UInt32 Bandwidth { get; set; }
        public string Caption { get; set; }
        public UInt32 ConfigManagerErrorCode { get; set; }
        public bool ConfigManagerUserConfig { get; set; }
        public string CreationClassName { get; set; }
        public string Description { get; set; }
        public string DeviceID { get; set; }
        public UInt16 DisplayType { get; set; }
        public bool ErrorCleared { get; set; }
        public string ErrorDescription { get; set; }
        public DateTime InstallDate { get; set; }
        public bool IsLocked { get; set; }
        public UInt32 LastErrorCode { get; set; }
        public string MonitorManufacturer { get; set; }
        public string MonitorType { get; set; }
        public string Name { get; set; }
        public UInt32 PixelsPerXLogicalInch { get; set; }
        public UInt32 PixelsPerYLogicalInch { get; set; }
        public string PNPDeviceID { get; set; }
        public UInt16 PowerManagementCapabilities { get; set; }
        public bool PowerManagementSupported { get; set; }
        public UInt32 ScreenHeight { get; set; }
        public UInt32 ScreenWidth { get; set; }
        public string Status { get; set; }
        public UInt16 StatusInfo { get; set; }
        public string SystemCreationClassName { get; set; }
        public string SystemName { get; set; }

    }
}