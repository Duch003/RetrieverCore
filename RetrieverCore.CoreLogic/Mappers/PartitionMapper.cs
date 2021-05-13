using GathererEngine.Decoders;
using RetrieverCore.Common.Models;
using RetrieverCore.Models;
using RetrieverCore.Models.WMIEntieties;

namespace RetrieverCore.CoreLogic.Mappers
{
    public static class PartitionMapper
    {
        public static Partition From(Win32_DiskPartition win32Partition, Win32_LogicalDisk win32LogicalDisk)
        {
            var output = new Partition();
            output.IsBootable = win32Partition.Bootable.HasValue && win32Partition.Bootable.Value;
            output.IsBootPartition = win32Partition.BootPartition.HasValue && win32Partition.BootPartition.Value;
            output.IsPrimaryPartition = win32Partition.PrimaryPartition.HasValue && win32Partition.PrimaryPartition.Value;
            output.Size = win32Partition.Size.HasValue 
                ? win32Partition.Size.Value / Constants.Gibibyte
                : Constants.DefaultNumericValue;
            output.Description = win32Partition.Description;
            output.DeviceType = win32Partition.Type;

            if (win32LogicalDisk != null)
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
