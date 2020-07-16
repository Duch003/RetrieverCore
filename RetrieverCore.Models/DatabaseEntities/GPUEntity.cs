using RetrieverCore.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RetrieverCore.Models.DatabaseEntities
{
    public class GPUEntity
    {
        public int ID { get; set; }
        public string Manufacturer { get; set; }
        public double MemorySize { get; set; }
        public string Model { get; set; }
        public int ScreenHeight { get; set; }
        public int ScreenWidth { get; set; }

        [NotMapped]
        public Resolution Resolution 
        {
            get
            {
                return new Resolution(ScreenWidth, ScreenHeight);
            }
        } 
    }
}
