using RetrieverCore.Models.WindowsModels.Constants;
using System;

namespace RetrieverCore.Models.WindowsModels.Win32Entities
{
    public class Win32_Battery
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt16 EstimatedChargeRemaining { get; set; } //[%]
        public UInt16 BatteryStatus { get; set; }
        public UInt16 Chemistry { get; set; }
        public string DeviceID { get; set; }
        public UInt32 EstimatedRunTime { get; set; } //[minutes]
        public UInt16[] PowerManagementCapabilities { get; set; }
        public bool PowerManagementSupported { get; set; }
    }
}
