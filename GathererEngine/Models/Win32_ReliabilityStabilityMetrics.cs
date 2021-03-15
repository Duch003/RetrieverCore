
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_ReliabilityStabilityMetrics
    {
        public const string Scope = WmiScope.Cimv2;
        public DateTime EndMeasurementDate { get; set; }
        public string RelID { get; set; }
        public DateTime StartMeasurementDate { get; set; }
        public double SystemStabilityIndex { get; set; }
        public DateTime TimeGenerated { get; set; }

    }
}