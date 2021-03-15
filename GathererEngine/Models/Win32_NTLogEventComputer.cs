
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_NTLogEventComputer
    {
        public const string Scope = WmiScope.Cimv2;
        public string Computer { get; set; }
        public string Record { get; set; }

    }
}