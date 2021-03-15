
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class ScriptingStandardConsumerSetting
    {
        public const string Scope = WmiScope.Cimv2;
        public string Caption { get; set; }
        public string Description { get; set; }
        public UInt32 MaximumScripts { get; set; }
        public string SettingID { get; set; }
        public UInt32 Timeout { get; set; }

    }
}