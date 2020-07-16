using System;
using System.Collections.Generic;
using System.Text;

namespace RetrieverCore.Models.DatabaseEntities
{
    public class MainboardEntity
    {
        public int ID { get; set; }
        public string Manufacturer { get; set; }
        public string Socket { get; set; }
        public string Model { get; set; } //a.k.a. Product
        public IEnumerable<MainboardPortEntity> MainboardPorts { get; set; }
        public int ProcessorID { get; set; }
        public IEnumerable<ProcessorEntity> Processors { get; set; }

    }
}
