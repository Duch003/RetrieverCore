
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_WMISetting
    {
        public const string Scope = WmiScope.Cimv2;
        public string ASPScriptDefaultNamespace { get; set; }
        public bool ASPScriptEnabled { get; set; }
        public string AutorecoverMofs { get; set; }
        public UInt32 AutoStartWin9X { get; set; }
        public UInt32 BackupInterval { get; set; }
        public DateTime BackupLastTime { get; set; }
        public string BuildVersion { get; set; }
        public string Caption { get; set; }
        public string DatabaseDirectory { get; set; }
        public UInt32 DatabaseMaxSize { get; set; }
        public string Description { get; set; }
        public bool EnableAnonWin9xConnections { get; set; }
        public bool EnableEvents { get; set; }
        public bool EnableStartupHeapPreallocation { get; set; }
        public UInt32 HighThresholdOnClientObjects { get; set; }
        public UInt32 HighThresholdOnEvents { get; set; }
        public string InstallationDirectory { get; set; }
        public UInt32 LastStartupHeapPreallocation { get; set; }
        public string LoggingDirectory { get; set; }
        public UInt32 LoggingLevel { get; set; }
        public UInt32 LowThresholdOnClientObjects { get; set; }
        public UInt32 LowThresholdOnEvents { get; set; }
        public UInt32 MaxLogFileSize { get; set; }
        public UInt32 MaxWaitOnClientObjects { get; set; }
        public UInt32 MaxWaitOnEvents { get; set; }
        public string MofSelfInstallDirectory { get; set; }
        public string SettingID { get; set; }

    }
}