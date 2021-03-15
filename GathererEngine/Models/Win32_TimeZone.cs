using System;
using GathererEngine.Constants;
using GathererEngine.Extensions;

namespace GathererEngine.Models
{
    public class Win32_TimeZone : MappableToDatabaseExtension
    {
        public const string Scope = WmiScope.Cimv2;
        public Int32? Bias { get; set; }
        public string Caption { get; set; }
        public Int32? DaylightBias { get; set; }
        public UInt32? DaylightDay { get; set; }
        public byte? DaylightDayOfWeek { get; set; }
        public UInt32? DaylightHour { get; set; }
        public UInt32? DaylightMillisecond { get; set; }
        public UInt32? DaylightMinute { get; set; }
        public UInt32? DaylightMonth { get; set; }
        public string DaylightName { get; set; }
        public UInt32? DaylightSecond { get; set; }
        public UInt32? DaylightYear { get; set; }
        public string Description { get; set; }
        public string SettingID { get; set; }
        public UInt32? StandardBias { get; set; }
        public UInt32? StandardDay { get; set; }
        public byte? StandardDayOfWeek { get; set; }
        public UInt32? StandardHour { get; set; }
        public UInt32? StandardMillisecond { get; set; }
        public UInt32? StandardMinute { get; set; }
        public UInt32? StandardMonth { get; set; }
        public string StandardName { get; set; }
        public UInt32? StandardSecond { get; set; }
        public UInt32? StandardYear { get; set; }
    }
}
