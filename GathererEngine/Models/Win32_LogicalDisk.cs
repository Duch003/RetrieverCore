using System;
using GathererEngine.Constants;
using GathererEngine.Extensions;

namespace GathererEngine.Models
{
    public class Win32_LogicalDisk : MappableToDatabaseExtension
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt16? Access { get; set; }
        public UInt16? Availability { get; set; }
        public UInt64? BlockSize { get; set; }
        public string Caption { get; set; }
        public bool? Compressed { get; set; }
        public UInt32? ConfigManagerErrorCode { get; set; }
        public bool? ConfigManagerUserConfig { get; set; }
        public string CreationClassName { get; set; }
        public string Description { get; set; }
        public string DeviceID { get; set; }
        public UInt32? DriveType { get; set; }
        public bool? ErrorCleared { get; set; }
        public string ErrorDescription { get; set; }
        public string ErrorMethodology { get; set; }
        public string FileSystem { get; set; }
        public UInt64? FreeSpace { get; set; }
        public DateTime? InstallDate { get; set; }
        public UInt32? LastErrorCode { get; set; }
        public UInt32? MaximumComponentLength { get; set; }
        public UInt32? MediaType { get; set; }
        public string Name { get; set; }
        public UInt64? NumberOfBlocks { get; set; }
        public string PNPDeviceID { get; set; }
        public UInt16?[] PowerManagementCapabilities { get; set; }
        public bool? PowerManagementSupported { get; set; }
        public string ProviderName { get; set; }
        public string Purpose { get; set; }
        public bool? QuotasDisabled { get; set; }
        public bool? QuotasIncomplete { get; set; }
        public bool? QuotasRebuilding { get; set; }
        public UInt64? Size { get; set; }
        public string Status { get; set; }
        public UInt16? StatusInfo { get; set; }
        public bool? SupportsDiskQuotas { get; set; }
        public bool? SupportsFileBasedCompression { get; set; }
        public string SystemCreationClassName { get; set; }
        public string SystemName { get; set; }
        public bool? VolumeDirty { get; set; }
        public string VolumeName { get; set; }
        public string VolumeSerialNumber { get; set; }
    }
}
