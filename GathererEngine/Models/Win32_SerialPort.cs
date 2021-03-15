using System;
using GathererEngine.Attributes;
using GathererEngine.Constants;
using GathererEngine.Extensions;

namespace GathererEngine.Models
{
    public class Win32_SerialPort : MappableToDatabaseExtension
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt16? Availability { get; set; }
        public bool? Binary { get; set; }
        public UInt16?[] Capabilities { get; set; }
        public string[] CapabilityDescriptions { get; set; }
        [Use]
        public string Caption { get; set; }
        public UInt32? ConfigManagerErrorCode { get; set; }
        public bool? ConfigManagerUserConfig { get; set; }
        public string CreationClassName { get; set; }
        public string Description { get; set; }
        [Use]
        public string DeviceID { get; set; }
        public bool? ErrorCleared { get; set; }
        public string ErrorDescription { get; set; }
        public DateTime? InstallDate { get; set; }
        public UInt32? LastErrorCode { get; set; }
        public UInt32? MaxBaudRate { get; set; }
        public UInt32? MaximumInputBufferSize { get; set; }
        public UInt32? MaximumOutputBufferSize { get; set; }
        public UInt32? MaxNumberControlled { get; set; }
        public string Name { get; set; }
        public bool? OSAutoDiscovered { get; set; }
        public string PNPDeviceID { get; set; }
        public UInt16?[] PowerManagementCapabilities { get; set; }
        public bool? PowerManagementSupported { get; set; }
        public UInt16? ProtocolSupported { get; set; }
        [Use]
        public string ProviderType { get; set; }
        public bool? SettableBaudRate { get; set; }
        public bool? SettableDataBits { get; set; }
        public bool? SettableFlowControl { get; set; }
        public bool? SettableParity { get; set; }
        public bool? SettableParityCheck { get; set; }
        public bool? SettableRLSD { get; set; }
        public bool? SettableStopBits { get; set; }
        public string Status { get; set; }
        public UInt16? StatusInfo { get; set; }
        public bool? Supports16BitMode { get; set; }
        public bool? SupportsDTRDSR { get; set; }
        public bool? SupportsElapsedTimeouts { get; set; }
        public bool? SupportsIntTimeouts { get; set; }
        public bool? SupportsParityCheck { get; set; }
        public bool? SupportsRLSD { get; set; }
        public bool? SupportsRTSCTS { get; set; }
        public bool? SupportsSpecialCharacters { get; set; }
        public bool? SupportsXOnXOff { get; set; }
        public bool? SupportsXOnXOffSet { get; set; }
        public string SystemCreationClassName { get; set; }
        public string SystemName { get; set; }
        public DateTime? TimeOfLastReset { get; set; }
    }
}
