
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_BootConfiguration
    {
        public const string Scope = WmiScope.Cimv2;
        public string BootDirectory { get; set; }
        public string Caption { get; set; }
        public string ConfigurationPath { get; set; }
        public string Description { get; set; }
        public string LastDrive { get; set; }
        public string Name { get; set; }
        public string ScratchDirectory { get; set; }
        public string SettingID { get; set; }
        public string TempDirectory { get; set; }

    }
}