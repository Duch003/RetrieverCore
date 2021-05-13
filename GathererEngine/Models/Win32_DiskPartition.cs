using System;
using GathererEngine.Attributes;
using GathererEngine.Constants;
using GathererEngine.Extensions;

namespace GathererEngine.Models
{
    public class Win32_DiskPartition
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt16? Access { get; set; }
        public UInt16? Availability { get; set; }
        
        public UInt64? BlockSize { get; set; }
        public bool? Bootable { get; set; }
        
        public bool? BootPartition { get; set; }
        public string Caption { get; set; }
        public UInt32? ConfigManagerErrorCode { get; set; }
        public bool? ConfigManagerUserConfig { get; set; }
        public string CreationClassName { get; set; }
        public string Description { get; set; }
        
        public string DeviceID { get; set; }
        public UInt32? DiskIndex { get; set; }
        public bool? ErrorCleared { get; set; }
        public string ErrorDescription { get; set; }
        public string ErrorMethodology { get; set; }
        public UInt32? HiddenSectors { get; set; }
        public UInt32? Index { get; set; }
        public DateTime? InstallDate { get; set; }
        public UInt32? LastErrorCode { get; set; }
        public string Name { get; set; }
        public UInt64? NumberOfBlocks { get; set; }
        public string PNPDeviceID { get; set; }
        public UInt16?[] PowerManagementCapabilities { get; set; }
        public bool? PowerManagementSupported { get; set; }
        public bool? PrimaryPartition { get; set; }
        public string Purpose { get; set; }
        public bool? RewritePartition { get; set; }
        
        public UInt64? Size { get; set; }
        public UInt64? StartingOffset { get; set; }
        public string Status { get; set; }
        public UInt16? StatusInfo { get; set; }
        public string SystemCreationClassName { get; set; }
        public string SystemName { get; set; }
        public string Type { get; set; }
    }
}
