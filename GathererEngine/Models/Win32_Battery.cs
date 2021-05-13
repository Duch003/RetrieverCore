using System;
using GathererEngine.Attributes;
using GathererEngine.Constants;
using GathererEngine.Extensions;

namespace GathererEngine.Models
{
    public class Win32_Battery
    {
        public const string Scope = WmiScope.Cimv2;
        public static string Conditions(string deviceId) => $"DeviceID = { deviceId }";
        public UInt16? Availability { get; set; }
        public UInt32? BatteryRechargeTime { get; set; }
        
        public UInt16? BatteryStatus { get; set; }
        public string Caption { get; set; }
        public UInt16? Chemistry { get; set; }
        public UInt32? ConfigManagerErrorCode { get; set; }
        public bool? ConfigManagerUserConfig { get; set; }
        public string CreationClassName { get; set; }
        public string Description { get; set; }
        public UInt32? DesignCapacity { get; set; }
        public UInt64? DesignVoltage { get; set; }
        
        public string DeviceID { get; set; }
        public bool? ErrorCleared { get; set; }
        public string ErrorDescription { get; set; }
        
        public UInt16? EstimatedChargeRemaining { get; set; }
        public UInt32? EstimatedRunTime { get; set; }
        public UInt32? ExpectedBatteryLife { get; set; }
        public UInt32? ExpectedLife { get; set; }
        public UInt32? FullChargeCapacity { get; set; }
        public DateTime? InstallDate { get; set; }
        public UInt32? LastErrorCode { get; set; }
        public UInt32? MaxRechargeTime { get; set; }
        public string Name { get; set; }
        public string PNPDeviceID { get; set; }
        public UInt16?[] PowerManagementCapabilities { get; set; }
        public bool? PowerManagementSupported { get; set; }
        public string SmartBatteryVersion { get; set; }
        public string Status { get; set; }
        public UInt16? StatusInfo { get; set; }
        public string SystemCreationClassName { get; set; }
        public string SystemName { get; set; }
        public UInt32? TimeOnBattery { get; set; }
        public UInt32? TimeToFullCharge { get; set; }
    }
}
