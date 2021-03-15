
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_LocalTime
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt32 Day { get; set; }
        public UInt32 DayOfWeek { get; set; }
        public UInt32 Hour { get; set; }
        public UInt32 Milliseconds { get; set; }
        public UInt32 Minute { get; set; }
        public UInt32 Month { get; set; }
        public UInt32 Quarter { get; set; }
        public UInt32 Second { get; set; }
        public UInt32 WeekInMonth { get; set; }
        public UInt32 Year { get; set; }

    }
}