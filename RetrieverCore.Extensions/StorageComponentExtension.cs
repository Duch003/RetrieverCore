using GathererEngine.Decoders;
using GathererEngine.Models;
using RetrieverCore.Models.ComputerComponents.Physical;
using RetrieverCore.Models.ComputerComponents.Virtual;
using System.Collections.Generic;

namespace RetrieverCore.Extensions
{
    public static class StorageComponentExtension
    {
        public static StorageComponent ToStorageComponent(this Win32_DiskDrive win32DiskDrive, MSFT_PhysicalDisk msftPhyicalDisk, 
            IEnumerable<DiskPartition> diskPartitions)
        {
            if(win32DiskDrive == null)
            {
                return null;
            }

            var output = new StorageComponent
            {
                Capacity = win32DiskDrive.Size.HasValue ? win32DiskDrive.Size.Value : ulong.MinValue,
                DiskDriveMediaType = win32DiskDrive.MediaType,
                InterfaceType = win32DiskDrive.InterfaceType,
                Caption = win32DiskDrive.Caption,
                Capabilities = win32DiskDrive.CapabilityDescriptions,
                Model = win32DiskDrive.Model,
                Partitions = diskPartitions
            };

            if(msftPhyicalDisk != null)
            {
                output.PhysicalDiskMediaType = msftPhyicalDisk.MediaType.HasValue
                    ? PhysicalDiskMediaTypeDecoder.Decode(msftPhyicalDisk.MediaType.Value)
                    : PhysicalDiskMediaTypeDecoder.Decode(0);
                output.BusType = msftPhyicalDisk.BusType.HasValue
                    ? BusTypeDecoder.Decode(msftPhyicalDisk.BusType.Value)
                    : BusTypeDecoder.Decode(0);
            }

            return output;
        }
    }
}
