
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_DCOMApplicationSetting
    {
        public const string Scope = WmiScope.Cimv2;
        public string AppID { get; set; }
        public UInt32 AuthenticationLevel { get; set; }
        public string Caption { get; set; }
        public string CustomSurrogate { get; set; }
        public string Description { get; set; }
        public bool EnableAtStorageActivation { get; set; }
        public string LocalService { get; set; }
        public string RemoteServerName { get; set; }
        public string RunAsUser { get; set; }
        public string ServiceParameters { get; set; }
        public string SettingID { get; set; }
        public bool UseSurrogate { get; set; }

    }
}