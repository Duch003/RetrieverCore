
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class WmiMonitorColorCharacteristics
    {
        public const string Scope = WmiScope.Wmi;
        public bool Active { get; set; }
        public object Blue { get; set; }
        public object DefaultWhite { get; set; }
        public object Green { get; set; }
        public string InstanceName { get; set; }
        public object Red { get; set; }

    }
}