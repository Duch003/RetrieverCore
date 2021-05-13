using System;
using GathererEngine.Constants;
using GathererEngine.Extensions;

namespace GathererEngine.Models
{
    public class CIM_VideoController
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt16?[] AcceleratorCapabilities { get; set; }
        public string AdapterCompatibility { get; set; }
        public string AdapterDACType { get; set; }
        public UInt32? AdapterRAM { get; set; }
        public UInt16? Availability { get; set; }
        public string[] CapabilityDescriptions { get; set; }
        public string Caption { get; set; }
        public UInt32? ColorTableEntries { get; set; }
        public UInt32? ConfigManagerErrorCode { get; set; }
        public bool? ConfigManagerUserConfig { get; set; }
        public string CreationClassName { get; set; }
        public UInt32? CurrentBitsPerPixel { get; set; }
        public UInt32? CurrentHorizontalResolution { get; set; }
        public UInt64? CurrentNumberOfColors { get; set; }
        public UInt32? CurrentNumberOfColumns { get; set; }
        public UInt32? CurrentNumberOfRows { get; set; }
        public UInt32? CurrentRefreshRate { get; set; }
        public UInt16? CurrentScanMode { get; set; }
        public UInt32? CurrentVerticalResolution { get; set; }
        public string Description { get; set; }
        public string DeviceID { get; set; }
        public UInt32? DeviceSpecificPens { get; set; }
        public UInt32? DitherType { get; set; }
        public DateTime? DriverDate { get; set; }
        public string DriverVersion { get; set; }
        public bool? ErrorCleared { get; set; }
        public string ErrorDescription { get; set; }
        public UInt32? ICMIntent { get; set; }
        public UInt32? ICMMethod { get; set; }
        public string InfFilename { get; set; }
        public string InfSection { get; set; }
        public DateTime? InstallDate { get; set; }
        public string InstalledDisplayDrivers { get; set; }
        public UInt32? LastErrorCode { get; set; }
        public UInt32? MaxMemorySupported { get; set; }
        public UInt32? MaxNumberControlled { get; set; }
        public UInt32? MaxRefreshRate { get; set; }
        public UInt32? MinRefreshRate { get; set; }
        public bool? Monochrome { get; set; }
        public string Name { get; set; }
        public UInt16? NumberOfColorPlanes { get; set; }
        public UInt32? NumberOfVideoPages { get; set; }
        public string PNPDeviceID { get; set; }
        public UInt16?[] PowerManagementCapabilities { get; set; }
        public bool? PowerManagementSupported { get; set; }
        public UInt16? ProtocolSupported { get; set; }
        public UInt32? ReservedSystemPaletteEntries { get; set; }
        public UInt32? SpecificationVersion { get; set; }
        public string Status { get; set; }
        public UInt16? StatusInfo { get; set; }
        public string SystemCreationClassName { get; set; }
        public string SystemName { get; set; }
        public UInt32? SystemPaletteEntries { get; set; }
        public DateTime? TimeOfLastReset { get; set; }
        public UInt16? VideoArchitecture { get; set; }
        public UInt16? VideoMemoryType { get; set; }
        public UInt16? VideoMode { get; set; }
        public string VideoModeDescription { get; set; }
        public string VideoProcessor { get; set; }
    }
}
