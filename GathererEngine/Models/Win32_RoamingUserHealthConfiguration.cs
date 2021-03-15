
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_RoamingUserHealthConfiguration
    {
        public const string Scope = WmiScope.Cimv2;
        public byte HealthStatusForTempProfiles { get; set; }
        public UInt16 LastProfileDownloadIntervalCautionInHours { get; set; }
        public UInt16 LastProfileDownloadIntervalUnhealthyInHours { get; set; }
        public UInt16 LastProfileUploadIntervalCautionInHours { get; set; }
        public UInt16 LastProfileUploadIntervalUnhealthyInHours { get; set; }

    }
}