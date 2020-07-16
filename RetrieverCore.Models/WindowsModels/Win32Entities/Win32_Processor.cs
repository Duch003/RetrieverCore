using RetrieverCore.Models.WindowsModels.Constants;
using System;

namespace RetrieverCore.Models.WindowsModels.Win32Entities
{
    public class Win32_Processor
    {
        public const string Scope = WmiScope.Cimv2;
        public string Name { get; set; }
        public UInt32 MaxClockSpeed { get; set; }
        public UInt16 Availability { get; set; }
        public UInt16 CpuStatus { get; set; }
        public string DeviceID { get; set; }
        public string Status { get; set; }
        public UInt16 StatusInfo { get; set; }
        public UInt32? ExtClock { get; set; } //[MHz]
        public UInt32 L2CacheSize { get; set; }
        public UInt16 ProcessorType { get; set; }
        public string SocketDesignation { get; set; }
        public UInt16 Architecture { get; set; }
        public string Caption { get; set; }
        public UInt32 CurrentClockSpeed { get; set; }
        public UInt16 Family { get; set; }
        public UInt32 L3CacheSize { get; set; }
        public UInt32 NumberOfCores { get; set; }
        public UInt32 NumberOfEnabledCore { get; set; }
        public UInt32 NumberOfLogicalProcessors { get; set; }
        public string Role { get; set; }
        public UInt16 UpgradeMethod { get; set; }
    }
}
