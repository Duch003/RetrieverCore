using System;
using System.Collections.Generic;
using System.Text;

namespace RetrieverCore.Models.DatabaseEntities
{
    public class ComputerEntity
    {
        public int ID { get; set; }
        public string Vendor { get; set; }
        public string Model { get; set; }
        public string[] Notes { get; set; }
        public IEnumerable<BatteryEntity> Batteries { get; set; }
        public IEnumerable<DDREntity> DDRs { get; set; }
        public IEnumerable<GPUEntity> GPUs { get; set; }
        public IEnumerable<StorageEntity> Storages { get; set; }
        public MainboardEntity Mainboard { get; set; }
        public IEnumerable<NetworkInterfaceEntity> NetworkInterfaces { get; set; }
    }
}
