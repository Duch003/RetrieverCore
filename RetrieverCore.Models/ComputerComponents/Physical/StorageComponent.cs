using RetrieverCore.Models.ComputerComponents.Virtual;
using System.Collections.Generic;

namespace RetrieverCore.Models.ComputerComponents.Physical
{
    public class StorageComponent
    {
        //MSFT_PhysicalDisk, Win32_DiskDrive
        public ulong Capacity { get; set; }
        //public string Type { get; set; }
        public string PhysicalDiskMediaType { get; set; }
        public string BusType { get; set; }
        public string DiskDriveMediaType { get; set; }
        public string InterfaceType { get; set; }
        public string Caption { get; set; }
        public string[] Capabilities { get; set; }
        public string Model { get; set; }
        public IEnumerable<DiskPartition> Partitions { get; set; }
    }
}
