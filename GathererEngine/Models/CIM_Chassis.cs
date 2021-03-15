
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class CIM_Chassis
    {
        public const string Scope = WmiScope.Cimv2;
        public bool AudibleAlarm { get; set; }
        public string BreachDescription { get; set; }
        public string CableManagementStrategy { get; set; }
        public string Caption { get; set; }
        public UInt16 ChassisTypes { get; set; }
        public string CreationClassName { get; set; }
        public Int16 CurrentRequiredOrProduced { get; set; }
        public float Depth { get; set; }
        public string Description { get; set; }
        public UInt16 HeatGeneration { get; set; }
        public float Height { get; set; }
        public bool HotSwappable { get; set; }
        public DateTime InstallDate { get; set; }
        public bool LockPresent { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }
        public UInt16 NumberOfPowerCords { get; set; }
        public string OtherIdentifyingInfo { get; set; }
        public string PartNumber { get; set; }
        public bool PoweredOn { get; set; }
        public bool Removable { get; set; }
        public bool Replaceable { get; set; }
        public UInt16 SecurityBreach { get; set; }
        public UInt16 SecurityStatus { get; set; }
        public string SerialNumber { get; set; }
        public string ServiceDescriptions { get; set; }
        public UInt16 ServicePhilosophy { get; set; }
        public string SKU { get; set; }
        public string SMBIOSAssetTag { get; set; }
        public string Status { get; set; }
        public string Tag { get; set; }
        public string TypeDescriptions { get; set; }
        public string Version { get; set; }
        public bool VisibleAlarm { get; set; }
        public float Weight { get; set; }
        public float Width { get; set; }

    }
}