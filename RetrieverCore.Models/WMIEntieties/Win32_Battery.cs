using System;
using GathererEngine.Constants;
using RetrieverCore.Models.WMIEntieties.Base;

namespace RetrieverCore.Models.WMIEntieties
{
    public class Win32_Battery : WmiEntityBase
    {
        public Win32_Battery() : base()
        {
            Scope = WmiScope.Cimv2;
        }

        public static string Conditions(string deviceId) => $"DeviceID = { deviceId }";
        public UInt16? BatteryStatus { get; set; }
        public string DeviceID { get; set; }
        public UInt16? EstimatedChargeRemaining { get; set; }
    }
}
