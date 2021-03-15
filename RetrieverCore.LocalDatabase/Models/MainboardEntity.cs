using System.Collections.Generic;

namespace RetrieverCore.LocalDatabase.Models
{
    public class MainboardEntity
    {
        public int ID { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; } //a.k.a. Product
        public string Version { get; set; }
    }
}
