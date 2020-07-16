using RetrieverCore.Models.WindowsModels.Constants;
using System;

namespace RetrieverCore.Models.WindowsModels.Win32Entities
{
    public class Win32_PortConnector
    {
        public const string Scope = WmiScope.Cimv2;
        public string InternalReferenceDesignator { get; set; }
        public string ExternalReferenceDesignator { get; set; }
        public UInt16 PortType { get; set; }
        public UInt16[] ConnectorType { get; set; }
        public string Tag { get; set; }
    }
}
