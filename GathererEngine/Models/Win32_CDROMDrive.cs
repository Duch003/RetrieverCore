using System;
using GathererEngine.Constants;
using GathererEngine.Extensions;

namespace GathererEngine.Models
{
    public class Win32_CDROMDrive
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt16? Availability { get; set; }
        public UInt16?[] Capabilities { get; set; }
        public string[] CapabilityDescriptions { get; set; }
        public string Caption { get; set; }
        public string CompressionMethod { get; set; }
        public UInt32? ConfigManagerErrorCode { get; set; }
        public bool? ConfigManagerUserConfig { get; set; }
        public string CreationClassName { get; set; }
        public UInt64? DefaultBlockSize { get; set; }
        public string Description { get; set; }
        public string DeviceID { get; set; }
        public string Drive { get; set; }
        public bool? DriveIntegrity { get; set; }
        public bool? ErrorCleared { get; set; }
        public string ErrorDescription { get; set; }
        public string ErrorMethodology { get; set; }
        public UInt16? FileSystemFlags { get; set; }
        public UInt32? FileSystemFlagsEx { get; set; }
        public string Id { get; set; }
        public DateTime? InstallDate { get; set; }
        public UInt32? LastErrorCode { get; set; }
        public string Manufacturer { get; set; }
        public UInt64? MaxBlockSize { get; set; }
        public UInt32? MaximumComponentLength { get; set; }
        public UInt64? MaxMediaSize { get; set; }
        public bool? MediaLoaded { get; set; }
        public string MediaType { get; set; }
        public string MfrAssignedRevisionLevel { get; set; }
        public UInt64? MinBlockSize { get; set; }
        public string Name { get; set; }
        public bool? NeedsCleaning { get; set; }
        public UInt32? NumberOfMediaSupported { get; set; }
        public string PNPDeviceID { get; set; }
        public UInt16?[] PowerManagementCapabilities { get; set; }
        public bool? PowerManagementSupported { get; set; }
        public string RevisionLevel { get; set; }
        public UInt32? SCSIBus { get; set; }
        public UInt16? SCSILogicalUnit { get; set; }
        public UInt16? SCSIPort { get; set; }
        public UInt16? SCSITargetId { get; set; }
        public string SerialNumber { get; set; }
        public UInt64? Size { get; set; }
        public string Status { get; set; }
        public UInt16? StatusInfo { get; set; }
        public string SystemCreationClassName { get; set; }
        public string SystemName { get; set; }
        public double? TransferRate { get; set; }
        public string VolumeName { get; set; }
        public string VolumeSerialNumber { get; set; }
    }
}
