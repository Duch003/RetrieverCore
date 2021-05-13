using System;
using GathererEngine.Attributes;
using GathererEngine.Constants;
using GathererEngine.Extensions;

namespace GathererEngine.Models
{
    public class Win32_PortConnector
    {
        public const string Scope = WmiScope.Cimv2;
        public string Caption { get; set; }
        public string ConnectorPinout { get; set; }
        public UInt16?[] ConnectorType { get; set; }
        public string CreationClassName { get; set; }
        public string Description { get; set; }
        
        public string ExternalReferenceDesignator { get; set; }
        public DateTime? InstallDate { get; set; }
        
        public string InternalReferenceDesignator { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }
        public string OtherIdentifyingInfo { get; set; }
        public string PartNumber { get; set; }
        
        public UInt16? PortType { get; set; }
        public bool? PoweredOn { get; set; }
        public string SerialNumber { get; set; }
        public string SKU { get; set; }
        public string Status { get; set; }
        public string Tag { get; set; }
        public string Version { get; set; }
    }
}
