using RetrieverCore.Models.WindowsModels.Constants;
using System;

namespace RetrieverCore.Models.WindowsModels.Win32Entities
{
    public class Win32_Fan
    {
        public const string Scope = WmiScope.Cimv2;
        public bool ActiveCooling { get; set; }
        public UInt16 Availability { get; set; }
        public string Status { get; set; }
        public UInt16 StatusInfo { get; set; }
    }
}
