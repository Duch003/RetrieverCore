using RetrieverCore.Models.WindowsModels.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetrieverCore.Models.WindowsModels.Win32Entities
{
    public class Win32_MotherboardDevice
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt16 Availability { get; set; }
        public string PrimaryBusType { get; set; }
        public string SecondaryBusType { get; set; }
        public string Status { get; set; }
    }
}
