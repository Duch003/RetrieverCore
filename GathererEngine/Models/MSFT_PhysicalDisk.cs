using System;
using GathererEngine.Constants;
using GathererEngine.Extensions;

namespace GathererEngine.Models
{
    public class MSFT_PhysicalDisk : MappableToDatabaseExtension
    {
        public const string Scope = WmiScope.Storage;
        public string AdapterSerialNumber { get; set; }
        public UInt64? AllocatedSize { get; set; }
        public UInt16? BusType { get; set; }
        public UInt16?[] CannotPoolReason { get; set; }
        public bool? CanPool { get; set; }
        public string Description { get; set; }
        public string DeviceId { get; set; }
        public UInt16? EnclosureNumber { get; set; }
        public string FirmwareVersion { get; set; }
        public string FriendlyName { get; set; }
        public UInt16? HealthStatus { get; set; }
        public bool? IsIndicationEnabled { get; set; }
        public bool? IsPartial { get; set; }
        public UInt64? LogicalSectorSize { get; set; }
        public string Manufacturer { get; set; }
        public UInt16? MediaType { get; set; }
        public string Model { get; set; }
        public string ObjectId { get; set; }
        public string[] OperationalDetails { get; set; }
        public UInt16?[] OperationalStatus { get; set; }
        public string OtherCannotPoolReasonDescription { get; set; }
        public string PartNumber { get; set; }
        public string PassThroughClass { get; set; }
        public string PassThroughIds { get; set; }
        public string PassThroughNamespace { get; set; }
        public string PassThroughServer { get; set; }
        public string PhysicalLocation { get; set; }
        public UInt64? PhysicalSectorSize { get; set; }
        public string SerialNumber { get; set; }
        public UInt64? Size { get; set; }
        public UInt16? SlotNumber { get; set; }
        public string SoftwareVersion { get; set; }
        public UInt32? SpindleSpeed { get; set; }
        public string StoragePoolUniqueId { get; set; }
        public UInt16?[] SupportedUsages { get; set; }
        public string UniqueId { get; set; }
        public UInt16? UniqueIdFormat { get; set; }
        public UInt16? Usage { get; set; }
        public UInt64? VirtualDiskFootprint { get; set; }
    }
}
