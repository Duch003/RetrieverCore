using RetrieverCore.Models.WindowsModels.Constants;
using System;

namespace RetrieverCore.Models.WindowsModels.Win32Entities
{
    public class BatteryFullChargedCapacity
    {
        public const string Scope = WmiScope.Wmi;
        public static string Conditions(UInt32 tag) => $"Tag = {tag}";
        public UInt32 Tag { get; set; }
        public UInt32 FullChargedCapacity { get; set; }
    }
}
