using RetrieverCore.Models.WindowsModels.Constants;
using System;

namespace RetrieverCore.Models.WindowsModels.Win32Entities
{
    public class BatteryStaticData
    {
        public const string Scope = WmiScope.Wmi;
        public UInt32 DesignedCapacity { get; set; }
        public UInt32 Tag { get; set; }
    }
}
