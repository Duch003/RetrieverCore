
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class WDMClassesOfDriver
    {
        public const string Scope = WmiScope.Wmi;
        public string ClassName { get; set; }
        public string Driver { get; set; }
        public UInt32 HighDateTime { get; set; }
        public UInt32 LowDateTime { get; set; }

    }
}