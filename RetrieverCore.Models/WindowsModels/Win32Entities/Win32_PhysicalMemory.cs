using RetrieverCore.Models.WindowsModels.Constants;
using System;

namespace RetrieverCore.Models.WindowsModels.Win32Entities
{
    public class Win32_PhysicalMemory
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt64 Capacity { get; set; }
        public UInt32 ConfiguredClockSpeed { get; set; } //[MHz]
        public UInt16 FormFactor { get; set; }
        public string Manufacturer { get; set; }
        public UInt32 Speed { get; set; } //[nano sec.]
    }
}
