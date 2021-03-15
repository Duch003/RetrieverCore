
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_NTLogEventLog
    {
        public const string Scope = WmiScope.Cimv2;
        public string Log { get; set; }
        public string Record { get; set; }

    }
}