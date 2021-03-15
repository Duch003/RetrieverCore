
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_OSRecoveryConfiguration
    {
        public const string Scope = WmiScope.Cimv2;
        public bool AutoReboot { get; set; }
        public string Caption { get; set; }
        public string DebugFilePath { get; set; }
        public UInt32 DebugInfoType { get; set; }
        public string Description { get; set; }
        public string ExpandedDebugFilePath { get; set; }
        public string ExpandedMiniDumpDirectory { get; set; }
        public bool KernelDumpOnly { get; set; }
        public string MiniDumpDirectory { get; set; }
        public string Name { get; set; }
        public bool OverwriteExistingDebugFile { get; set; }
        public bool SendAdminAlert { get; set; }
        public string SettingID { get; set; }
        public bool WriteDebugInfo { get; set; }
        public bool WriteToSystemLog { get; set; }

    }
}