using GathererEngine.Decoders;
using GathererEngine.Models;
using RetrieverCore.Models.ComputerComponents.Virtual;

namespace RetrieverCore.Extensions
{
    public static class DiskPartitionExtension
    {
        public static DiskPartition ToDiskPartition(this Win32_DiskPartition win32Partition, Win32_LogicalDisk win32LogicalDisk)
        {
            return Map(win32Partition, win32LogicalDisk);
        }

        public static DiskPartition ToDiskPartition(this Win32_LogicalDisk win32LogicalDisk, Win32_DiskPartition win32Partition)
        {
            return Map(win32Partition, win32LogicalDisk);
        }

        private static DiskPartition Map(Win32_DiskPartition win32Partition, Win32_LogicalDisk win32LogicalDisk)
        {
            if(win32Partition == null)
            {
                return null;
            }

            var output = new DiskPartition
            {
                IsBootable = win32Partition.Bootable.HasValue && win32Partition.Bootable.Value,
                IsBootPartition = win32Partition.BootPartition.HasValue && win32Partition.BootPartition.Value,
                IsPrimaryPartition = win32Partition.PrimaryPartition.HasValue && win32Partition.PrimaryPartition.Value,
                Size = win32Partition.Size.HasValue ? win32Partition.Size.Value : ulong.MinValue,
                Description = win32Partition.Description,
                DeviceType = win32Partition.Type
            };

            if(win32LogicalDisk != null)
            {
                output.FileSystem = win32LogicalDisk.FileSystem;
                output.LogicalDiskMediaType = win32LogicalDisk.MediaType.HasValue
                    ? LogicalDiskMediaTypeDecoder.Decode(win32LogicalDisk.MediaType.Value)
                    : LogicalDiskMediaTypeDecoder.Decode(0);
                output.VolumeName = win32LogicalDisk.VolumeName;
                output.PartitionLetter = win32LogicalDisk.DeviceID;
            }

            return output;
        }
    }
}
