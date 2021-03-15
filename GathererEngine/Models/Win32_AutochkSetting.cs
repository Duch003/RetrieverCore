
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_AutochkSetting
    {
        public const string Scope = WmiScope.Cimv2;
        public string Caption { get; set; }
        public string Description { get; set; }
        public string SettingID { get; set; }
        public UInt32 UserInputDelay { get; set; }

    }
}