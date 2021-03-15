
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_OfflineFilesMachineConfiguration
    {
        public const string Scope = WmiScope.Cimv2;
        public bool BackgroundSyncEnabled { get; set; }
        public object BackgroundSyncParams { get; set; }
        public bool DiskSpaceLimitEnabled { get; set; }
        public object DiskSpaceLimitParams { get; set; }
        public bool EconomicalAdminPinningEnabled { get; set; }
        public bool Enabled { get; set; }
        public string ExcludedFileTypes { get; set; }
        public bool IsConfiguredByWMI { get; set; }
        public bool MakeAvailableOfflineButtonRemoved { get; set; }
        public bool OfflineFilesCacheEncrypted { get; set; }
        public bool SlowLinkEnabled { get; set; }
        public string SlowLinkParams { get; set; }
        public bool SyncOnCostedNetworkEnabled { get; set; }
        public UInt32 TransparentCachingLatencyThreshold { get; set; }
        public bool WorkOfflineButtonRemoved { get; set; }

    }
}