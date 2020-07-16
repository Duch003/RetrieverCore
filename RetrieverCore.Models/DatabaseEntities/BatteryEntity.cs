using System;
using System.Collections.Generic;
using System.Text;

namespace RetrieverCore.Models.DatabaseEntities
{
    public class BatteryEntity
    {
        public int ID { get; set; }
        public double Voltage { get; set; }
        public string Vendor { get; set; }
        public double MaxWearLevel { get; set; }
    }
}
