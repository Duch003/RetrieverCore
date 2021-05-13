using System;
using GathererEngine.Attributes;
using GathererEngine.Constants;
using RetrieverCore.Models.WMIEntieties.Base;

namespace RetrieverCore.Models.WMIEntieties
{
    public class Win32_PortConnector : WmiEntityBase
    {
        public Win32_PortConnector() : base()
        {
            Scope = WmiScope.Cimv2;
        }

        public string ExternalReferenceDesignator { get; set; }
        public string InternalReferenceDesignator { get; set; }
        public UInt16? PortType { get; set; }
    }
}
