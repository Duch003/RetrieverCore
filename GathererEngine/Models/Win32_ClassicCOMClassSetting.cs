
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_ClassicCOMClassSetting
    {
        public const string Scope = WmiScope.Cimv2;
        public string AppID { get; set; }
        public string AutoConvertToClsid { get; set; }
        public string AutoTreatAsClsid { get; set; }
        public string Caption { get; set; }
        public string ComponentId { get; set; }
        public bool Control { get; set; }
        public string DefaultIcon { get; set; }
        public string Description { get; set; }
        public string InprocHandler { get; set; }
        public string InprocHandler32 { get; set; }
        public string InprocServer { get; set; }
        public string InprocServer32 { get; set; }
        public bool Insertable { get; set; }
        public bool JavaClass { get; set; }
        public string LocalServer { get; set; }
        public string LocalServer32 { get; set; }
        public string LongDisplayName { get; set; }
        public string ProgId { get; set; }
        public string SettingID { get; set; }
        public string Int16DisplayName { get; set; }
        public string ThreadingModel { get; set; }
        public string ToolBoxBitmap32 { get; set; }
        public string TreatAsClsid { get; set; }
        public string TypeLibraryId { get; set; }
        public string Version { get; set; }
        public string VersionIndependentProgId { get; set; }

    }
}