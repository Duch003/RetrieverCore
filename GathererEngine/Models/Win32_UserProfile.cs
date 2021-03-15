
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_UserProfile
    {
        public const string Scope = WmiScope.Cimv2;
        public object AppDataRoaming { get; set; }
        public object Contacts { get; set; }
        public object Desktop { get; set; }
        public object Documents { get; set; }
        public object Downloads { get; set; }
        public object Favorites { get; set; }
        public byte HealthStatus { get; set; }
        public DateTime LastAttemptedProfileDownloadTime { get; set; }
        public DateTime LastAttemptedProfileUploadTime { get; set; }
        public DateTime LastBackgroundRegistryUploadTime { get; set; }
        public DateTime LastDownloadTime { get; set; }
        public DateTime LastUploadTime { get; set; }
        public DateTime LastUseTime { get; set; }
        public object Links { get; set; }
        public bool Loaded { get; set; }
        public string LocalPath { get; set; }
        public object Music { get; set; }
        public object Pictures { get; set; }
        public UInt32 RefCount { get; set; }
        public bool RoamingConfigured { get; set; }
        public string RoamingPath { get; set; }
        public bool RoamingPreference { get; set; }
        public object SavedGames { get; set; }
        public object Searches { get; set; }
        public string SID { get; set; }
        public bool Special { get; set; }
        public object StartMenu { get; set; }
        public UInt32 Status { get; set; }
        public object Videos { get; set; }

    }
}