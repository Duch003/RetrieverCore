using System;
using System.Collections.Generic;
using System.Text;

namespace RetrieverCore.Models.DatabaseEntities
{
    public class ProcessorEntity
    {
        public int ID { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public double L2CacheSize { get; set; }
        public double L3CacheSize { get; set; }
        public double ClockSpeed { get; set; }
        public byte Cores { get; set; }
        public byte LogicalProcessor { get; set; }
        public string Socket { get; set; }
        public string Architecture { get; set; }
    }
}
