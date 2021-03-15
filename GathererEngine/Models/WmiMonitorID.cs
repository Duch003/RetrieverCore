
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class WmiMonitorID
    {
        public const string Scope = WmiScope.Wmi;
        public bool Active { get; set; }
        public string InstanceName { get; set; }
        public UInt16 ManufacturerName { get; set; }
        public UInt16 ProductCodeID { get; set; }
        public UInt16 SerialNumberID { get; set; }
        public UInt16 UserFriendlyName { get; set; }
        public UInt16 UserFriendlyNameLength { get; set; }
        public byte WeekOfManufacture { get; set; }
        public UInt16 YearOfManufacture { get; set; }

    }
}