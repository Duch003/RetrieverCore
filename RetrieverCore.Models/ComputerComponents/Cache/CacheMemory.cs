using System;
using System.Collections.Generic;
using System.Text;

namespace RetrieverCore.Models.ComputerComponents.Cache
{
    public class CacheMemory
    {
        public string ErrorCorrectType { get; set; }
        public string Availability { get; set; }
        public string Status { get; set; }
        public string StatusInfo { get; set; }
        public int Size { get; set; }
        public string Level { get; set; }
        public string WritePolicy { get; set; }
        public string Associativity { get; set; }
        public string[] CurrentSRAM { get; set; }
        public string Location { get; set; }
        public string[] SupportedSRAM { get; set; }
    }
}
