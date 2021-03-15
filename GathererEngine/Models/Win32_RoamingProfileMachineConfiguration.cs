
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_RoamingProfileMachineConfiguration
    {
        public const string Scope = WmiScope.Cimv2;
        public bool AddAdminGroupToRUPEnabled { get; set; }
        public bool AllowCrossForestUserPolicy { get; set; }
        public object BackgroundUploadParams { get; set; }
        public UInt16 DeleteProfilesOlderDays { get; set; }
        public bool DeleteRoamingCacheEnabled { get; set; }
        public bool DetectSlowLinkDisabled { get; set; }
        public bool ForceUnloadDisabled { get; set; }
        public bool IsConfiguredByWMI { get; set; }
        public string MachineProfilePath { get; set; }
        public bool OnlyAllowLocalProfiles { get; set; }
        public bool OwnerCheckDisabled { get; set; }
        public bool PrimaryComputerEnabled { get; set; }
        public bool ProfileUploadDisabled { get; set; }
        public object SlowLinkTimeOutParams { get; set; }
        public bool SlowLinkUIEnabled { get; set; }
        public bool TempProfileLogonBlocked { get; set; }
        public UInt16 WaitForNetworkInSec { get; set; }
        public bool WaitForRemoteProfile { get; set; }

    }
}