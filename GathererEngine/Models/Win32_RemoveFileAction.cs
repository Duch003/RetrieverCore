
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_RemoveFileAction
    {
        public const string Scope = WmiScope.Cimv2;
        public string ActionID { get; set; }
        public string Caption { get; set; }
        public string Description { get; set; }
        public UInt16 Direction { get; set; }
        public string DirProperty { get; set; }
        public string File { get; set; }
        public string FileKey { get; set; }
        public string FileName { get; set; }
        public UInt16 InstallMode { get; set; }
        public string Name { get; set; }
        public string SoftwareElementID { get; set; }
        public UInt16 SoftwareElementState { get; set; }
        public UInt16 TargetOperatingSystem { get; set; }
        public string Version { get; set; }

    }
}