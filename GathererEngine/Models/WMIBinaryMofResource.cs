
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class WMIBinaryMofResource
    {
        public const string Scope = WmiScope.Wmi;
        public UInt32 HighDateTime { get; set; }
        public UInt32 LowDateTime { get; set; }
        public bool MofProcessed { get; set; }
        public string Name { get; set; }

    }
}