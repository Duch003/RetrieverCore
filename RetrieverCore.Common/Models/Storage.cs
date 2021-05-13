using RetrieverCore.Common.Models.Base;
using System.Collections.Generic;

namespace RetrieverCore.Common.Models
{
    public class Storage : EntityBase
    {
        //MSFT_PhysicalDisk, Win32_DiskDrive
        public double Capacity { get; set; }
        //public string Type { get; set; }
        public string PhysicalDiskMediaType { get; set; }
        public string BusType { get; set; }
        public string DiskDriveMediaType { get; set; }
        public string InterfaceType { get; set; }
        public string Caption { get; set; }
        public string[] Capabilities { get; set; }
        public string Model { get; set; }
        public IEnumerable<Partition> Partitions { get; set; }
    }
}
