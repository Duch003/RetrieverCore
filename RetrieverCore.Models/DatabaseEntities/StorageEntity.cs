using System;
using System.Collections.Generic;
using System.Text;

namespace RetrieverCore.Models.DatabaseEntities
{
    public class StorageEntity
    {
        public int ID { get; set; }
        public int Capacity { get; set; }
        public string Type { get; set; }
    }
}
