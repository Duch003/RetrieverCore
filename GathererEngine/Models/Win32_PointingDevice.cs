using System;
using GathererEngine.Constants;
using GathererEngine.Extensions;

namespace GathererEngine.Models
{
    public class Win32_PointingDevice
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt16? Availability { get; set; }
        public string Caption { get; set; }
        public UInt32? ConfigManagerErrorCode { get; set; }
        public bool? ConfigManagerUserConfig { get; set; }
        public string CreationClassName { get; set; }
        public string Description { get; set; }
        public string DeviceID { get; set; }
        public UInt16? DeviceInterface { get; set; }
        public UInt32? DoubleSpeedThreshold { get; set; }
        public bool? ErrorCleared { get; set; }
        public string ErrorDescription { get; set; }
        public UInt16? Handedness { get; set; }
        public string HardwareType { get; set; }
        public string InfFileName { get; set; }
        public string InfSection { get; set; }
        public DateTime? InstallDate { get; set; }
        public bool? IsLocked { get; set; }
        public UInt32? LastErrorCode { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public byte? NumberOfButtons { get; set; }
        public string PNPDeviceID { get; set; }
        public UInt16? PointingType { get; set; }
        public UInt16?[] PowerManagementCapabilities { get; set; }
        public bool? PowerManagementSupported { get; set; }
        public UInt32? QuadSpeedThreshold { get; set; }
        public UInt32? Resolution { get; set; }
        public UInt32? SampleRate { get; set; }
        public string Status { get; set; }
        public UInt16? StatusInfo { get; set; }
        public UInt32? Synch { get; set; }
        public string SystemCreationClassName { get; set; }
        public string SystemName { get; set; }
    }
}
