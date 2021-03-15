
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_Desktop
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt32 BorderWidth { get; set; }
        public string Caption { get; set; }
        public bool CoolSwitch { get; set; }
        public UInt32 CursorBlinkRate { get; set; }
        public string Description { get; set; }
        public bool DragFullWindows { get; set; }
        public UInt32 GridGranularity { get; set; }
        public UInt32 IconSpacing { get; set; }
        public string IconTitleFaceName { get; set; }
        public UInt32 IconTitleSize { get; set; }
        public bool IconTitleWrap { get; set; }
        public string Name { get; set; }
        public string Pattern { get; set; }
        public bool ScreenSaverActive { get; set; }
        public string ScreenSaverExecutable { get; set; }
        public bool ScreenSaverSecure { get; set; }
        public UInt32 ScreenSaverTimeout { get; set; }
        public string SettingID { get; set; }
        public string Wallpaper { get; set; }
        public bool WallpaperStretched { get; set; }
        public bool WallpaperTiled { get; set; }

    }
}