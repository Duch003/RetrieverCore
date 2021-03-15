
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_IRQResource
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt16 Availability { get; set; }
        public string Caption { get; set; }
        public string CreationClassName { get; set; }
        public string CSCreationClassName { get; set; }
        public string CSName { get; set; }
        public string Description { get; set; }
        public bool Hardware { get; set; }
        public DateTime InstallDate { get; set; }
        public UInt32 IRQNumber { get; set; }
        public string Name { get; set; }
        public bool Shareable { get; set; }
        public string Status { get; set; }
        public UInt16 TriggerLevel { get; set; }
        public UInt16 TriggerType { get; set; }
        public UInt32 Vector { get; set; }

    }
}