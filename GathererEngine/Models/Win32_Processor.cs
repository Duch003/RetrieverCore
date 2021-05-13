using System;
using GathererEngine.Attributes;
using GathererEngine.Constants;
using GathererEngine.Extensions;

namespace GathererEngine.Models
{
    public class Win32_Processor
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt16? AddressWidth { get; set; }
        
        public UInt16? Architecture { get; set; }
        public string AssetTag { get; set; }
        public UInt16? Availability { get; set; }
        public string Caption { get; set; }
        public UInt32? Characteristics { get; set; }
        public UInt32? ConfigManagerErrorCode { get; set; }
        public bool? ConfigManagerUserConfig { get; set; }
        public UInt16? CpuStatus { get; set; }
        public string CreationClassName { get; set; }
        
        public UInt32? CurrentClockSpeed { get; set; }
        public UInt16? CurrentVoltage { get; set; }
        public UInt16? DataWidth { get; set; }
        public string Description { get; set; }
        public string DeviceID { get; set; }
        public bool? ErrorCleared { get; set; }
        public string ErrorDescription { get; set; }
        public UInt32? ExtClock { get; set; }
        public UInt16? Family { get; set; }
        public DateTime? InstallDate { get; set; }
        
        public UInt32? L2CacheSize { get; set; }
        public UInt32? L2CacheSpeed { get; set; }
        
        public UInt32? L3CacheSize { get; set; }
        public UInt32? L3CacheSpeed { get; set; }
        public UInt32? LastErrorCode { get; set; }
        public UInt16? Level { get; set; }
        public UInt16? LoadPercentage { get; set; }
        
        public string Manufacturer { get; set; }
        public UInt32? MaxClockSpeed { get; set; }
        
        public string Name { get; set; }
        
        public UInt32? NumberOfCores { get; set; }
        public UInt32? NumberOfEnabledCore { get; set; }
        
        public UInt32? NumberOfLogicalProcessors { get; set; }
        public string OtherFamilyDescription { get; set; }
        public string PartNumber { get; set; }
        public string PNPDeviceID { get; set; }
        public UInt16?[] PowerManagementCapabilities { get; set; }
        public bool? PowerManagementSupported { get; set; }
        public string ProcessorId { get; set; }
        public UInt16? ProcessorType { get; set; }
        public UInt16? Revision { get; set; }
        public string Role { get; set; }
        public bool? SecondLevelAddressTranslationExtensions { get; set; }
        public string SerialNumber { get; set; }
        
        public string SocketDesignation { get; set; }
        public string Status { get; set; }
        public UInt16? StatusInfo { get; set; }
        public string Stepping { get; set; }
        public string SystemCreationClassName { get; set; }
        public string SystemName { get; set; }
        public UInt32? ThreadCount { get; set; }
        public string UniqueId { get; set; }
        public UInt16? UpgradeMethod { get; set; }
        public string Version { get; set; }
        public bool? VirtualizationFirmwareEnabled { get; set; }
        public bool? VMMonitorModeExtensions { get; set; }
        public UInt32? VoltageCaps { get; set; }
    }
}
