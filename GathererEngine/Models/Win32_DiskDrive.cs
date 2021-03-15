using System;
using GathererEngine.Attributes;
using GathererEngine.Constants;
using GathererEngine.Extensions;

namespace GathererEngine.Models
{
    public class Win32_DiskDrive : MappableToDatabaseExtension
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt16? Availability { get; set; }
        public UInt32? BytesPerSector { get; set; }
        public UInt16?[] Capabilities { get; set; }
        [Use]
        public string[] CapabilityDescriptions { get; set; }
        [Use]
        public string Caption { get; set; }
        public string CompressionMethod { get; set; }
        public UInt32? ConfigManagerErrorCode { get; set; }
        public bool? ConfigManagerUserConfig { get; set; }
        public string CreationClassName { get; set; }
        public UInt64? DefaultBlockSize { get; set; }
        public string Description { get; set; }
        [Use]
        public string DeviceID { get; set; }
        public bool? ErrorCleared { get; set; }
        public string ErrorDescription { get; set; }
        public string ErrorMethodology { get; set; }
        public string FirmwareRevision { get; set; }
        public UInt32? Index { get; set; }
        public DateTime? InstallDate { get; set; }
        [Use]
        public string InterfaceType { get; set; }
        public UInt32? LastErrorCode { get; set; }
        public string Manufacturer { get; set; }
        public UInt64? MaxBlockSize { get; set; }
        public UInt64? MaxMediaSize { get; set; }
        public bool? MediaLoaded { get; set; }
        [Use]
        public string MediaType { get; set; }
        public UInt64? MinBlockSize { get; set; }
        [Use]
        public string Model { get; set; }
        public string Name { get; set; }
        public bool? NeedsCleaning { get; set; }
        public UInt32? NumberOfMediaSupported { get; set; }
        public UInt32? Partitions { get; set; }
        public string PNPDeviceID { get; set; }
        public UInt16?[] PowerManagementCapabilities { get; set; }
        public bool? PowerManagementSupported { get; set; }
        public UInt32? SCSIBus { get; set; }
        public UInt16? SCSILogicalUnit { get; set; }
        public UInt16? SCSIPort { get; set; }
        public UInt16? SCSITargetId { get; set; }
        public UInt32? SectorsPerTrack { get; set; }
        public string SerialNumber { get; set; }
        public UInt32? Signature { get; set; }
        [Use]
        public UInt64? Size { get; set; }
        public string Status { get; set; }
        public UInt16? StatusInfo { get; set; }
        public string SystemCreationClassName { get; set; }
        public string SystemName { get; set; }
        public UInt64? TotalCylinders { get; set; }
        public UInt32? TotalHeads { get; set; }
        public UInt64? TotalSectors { get; set; }
        public UInt64? TotalTracks { get; set; }
        public UInt32? TracksPerCylinder { get; set; }
    }
}
