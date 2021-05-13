using RetrieverCore.Common.Models.Base;

namespace RetrieverCore.Common.Models
{
    public class Partition : EntityBase
    {
        //Win32_LogicalDisk, Win32_DiskPartition, Win32_Volume
        public bool IsBootable { get; set; }
        public bool IsBootPartition { get; set; }
        public bool IsPrimaryPartition { get; set; }
        public double Size { get; set; }
        public string Description { get; set; }
        public string DeviceType { get; set; }
        public string FileSystem { get; set; }
        public string LogicalDiskMediaType { get; set; }
        public string VolumeName { get; set; }
        public string PartitionLetter { get; set; }
    }
}
