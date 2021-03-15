
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_StartupCommand
    {
        public const string Scope = WmiScope.Cimv2;
        public string Caption { get; set; }
        public string Command { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public string SettingID { get; set; }
        public string User { get; set; }
        public string UserSID { get; set; }

    }
}