using RetrieverCore.Models.WindowsModels.Constants;
using System;
namespace RetrieverCore.Models.WindowsModels.Win32Entities
{
    public class MSAcpi_ThermalZoneTemperature
    {
        public const string Scope = WmiScope.Wmi;
        public bool Active { get; set; }
        public UInt32 CurrentTemperature { get; set; }
        public UInt32 CriticalTripPoint { get; set; }
        public UInt32 ThermalStamp { get; set; } //(raw / 10) - 273.15;
    }
}
