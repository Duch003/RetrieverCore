
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_SecuritySettingAccess
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt32 AccessMask { get; set; }
        public string GuidInheritedObjectType { get; set; }
        public string GuidObjectType { get; set; }
        public UInt32 Inheritance { get; set; }
        public string SecuritySetting { get; set; }
        public string Trustee { get; set; }
        public UInt32 Type { get; set; }

    }
}