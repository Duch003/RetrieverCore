using System;
using GathererEngine.Constants;
using GathererEngine.Extensions;

namespace GathererEngine.Models
{
    public class CIM_ComputerSystem
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt16? AdminPasswordStatus { get; set; }
        public bool? AutomaticManagedPagefile { get; set; }
        public bool? AutomaticResetBootOption { get; set; }
        public bool? AutomaticResetCapability { get; set; }
        public UInt16? BootOptionOnLimit { get; set; }
        public UInt16? BootOptionOnWatchDog { get; set; }
        public bool? BootROMSupported { get; set; }
        public UInt16?[] BootStatus { get; set; }
        public string BootupState { get; set; }
        public string Caption { get; set; }
        public UInt16? ChassisBootupState { get; set; }
        public string ChassisSKUNumber { get; set; }
        public string CreationClassName { get; set; }
        public Int16? CurrentTimeZone { get; set; }
        public bool? DaylightInEffect { get; set; }
        public string Description { get; set; }
        public string DNSHostName { get; set; }
        public string Domain { get; set; }
        public UInt16? DomainRole { get; set; }
        public bool? EnableDaylightSavingsTime { get; set; }
        public UInt16? FrontPanelResetStatus { get; set; }
        public bool? HypervisorPresent { get; set; }
        public bool? InfraredSupported { get; set; }
        public string[] InitialLoadInfo { get; set; }
        public DateTime? InstallDate { get; set; }
        public UInt16? KeyboardPasswordStatus { get; set; }
        public string LastLoadInfo { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }
        public string NameFormat { get; set; }
        public bool? NetworkServerModeEnabled { get; set; }
        public UInt32? NumberOfLogicalProcessors { get; set; }
        public UInt32? NumberOfProcessors { get; set; }
        public byte?[] OEMLogoBitmap { get; set; }
        public string[] OEMStringArray { get; set; }
        public bool? PartOfDomain { get; set; }
        public Int64? PauseAfterReset { get; set; }
        public UInt16? PCSystemType { get; set; }
        public UInt16? PCSystemTypeEx { get; set; }
        public UInt16?[] PowerManagementCapabilities { get; set; }
        public bool? PowerManagementSupported { get; set; }
        public UInt16? PowerOnPasswordStatus { get; set; }
        public UInt16? PowerState { get; set; }
        public UInt16? PowerSupplyState { get; set; }
        public string PrimaryOwnerContact { get; set; }
        public string PrimaryOwnerName { get; set; }
        public UInt16? ResetCapability { get; set; }
        public Int16? ResetCount { get; set; }
        public Int16? ResetLimit { get; set; }
        public string[] Roles { get; set; }
        public string Status { get; set; }
        public string[] SupportContactDescription { get; set; }
        public string SystemFamily { get; set; }
        public string SystemSKUNumber { get; set; }
        public UInt16? SystemStartupDelay { get; set; }
        public string[] SystemStartupOptions { get; set; }
        public byte? SystemStartupSetting { get; set; }
        public string SystemType { get; set; }
        public UInt16? ThermalState { get; set; }
        public UInt64? TotalPhysicalMemory { get; set; }
        public string UserName { get; set; }
        public UInt16? WakeUpType { get; set; }
        public string Workgroup { get; set; }
    }
}
