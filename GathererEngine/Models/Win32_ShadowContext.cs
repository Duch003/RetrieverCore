
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_ShadowContext
    {
        public const string Scope = WmiScope.Cimv2;
        public string Caption { get; set; }
        public bool ClientAccessible { get; set; }
        public string Description { get; set; }
        public bool Differential { get; set; }
        public bool ExposedLocally { get; set; }
        public bool ExposedRemotely { get; set; }
        public bool HardwareAssisted { get; set; }
        public bool Imported { get; set; }
        public string Name { get; set; }
        public bool NoAutoRelease { get; set; }
        public bool NotSurfaced { get; set; }
        public bool NoWriters { get; set; }
        public bool Persistent { get; set; }
        public bool Plex { get; set; }
        public string SettingID { get; set; }
        public bool Transportable { get; set; }

    }
}