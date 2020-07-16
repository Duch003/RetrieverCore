using System;
using System.Collections.Generic;
using System.Text;

namespace RetrieverCore.Models.WindowsModels.Win32Entities
{
    public class Win32_CacheMemory
    {
        public string DeviceID { get; set; }
        public UInt16 ErrorCorrectType { get; set; }
        public UInt16 Availability { get; set; }
        public string Status { get; set; }
        public UInt16 StatusInfo { get; set; }
        public UInt32 InstalledSize { get; set; }
        public UInt16 Level { get; set; }
        public UInt16 WritePolicy { get; set; }
        public UInt16 Associativity { get; set; }
        public UInt16[] CurrentSRAM { get; set; }
        public UInt16 Location { get; set; }
        public string Purpose { get; set; }
        public UInt16[] SupportedSRAM { get; set; } //same decoder as for CurrentSRAM
    }
}
