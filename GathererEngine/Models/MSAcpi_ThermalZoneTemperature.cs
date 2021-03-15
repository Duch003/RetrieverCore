using System;
using GathererEngine.Constants;
using GathererEngine.Extensions;

namespace GathererEngine.Models
{
    public class MSAcpi_ThermalZoneTemperature : MappableToDatabaseExtension
    {
        public const string Scope = WmiScope.Wmi;
        public bool? Active { get; set; }
        public UInt32?[] ActiveTripPoint { get; set; }
        public UInt32? ActiveTripPointCount { get; set; }
        public UInt32? CriticalTripPoint { get; set; }
        public UInt32? CurrentTemperature { get; set; }
        public string InstanceName { get; set; }
        public UInt32? PassiveTripPoint { get; set; }
        public UInt32? Reserved { get; set; }
        public UInt32? SamplingPeriod { get; set; }
        public UInt32? ThermalConstant1 { get; set; }
        public UInt32? ThermalConstant2 { get; set; }
        public UInt32? ThermalStamp { get; set; }
    }
}
