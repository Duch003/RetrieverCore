using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RetrieverCore.LocalDatabase.Models
{
    public class ComputerEntity
    {
        public int ID { get; set; }
        public string Vendor { get; set; } //Win32_ComputerSystem
        public string Model { get; set; } //Win32_ComputerSystem
        public string[] Notes { get; set; }

        public IEnumerable<BatteryEntity> Batteries { get; set; }
        public IEnumerable<DDREntity> DDRs { get; set; }
        public IEnumerable<GPUEntity> GPUs { get; set; }
        public IEnumerable<StorageEntity> Storages { get; set; }
        public MainboardEntity Mainboard { get; set; }
        public IEnumerable<NetworkInterfaceEntity> NetworkInterfaces { get; set; }
        public IEnumerable<MainboardPortEntity> MainboardPorts { get; set; }
        public IEnumerable<ProcessorEntity> Processors { get; set; }
    }
}
