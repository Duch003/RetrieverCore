
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class CIM_CacheMemory
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt16 Access { get; set; }
        public byte AdditionalErrorData { get; set; }
        public UInt16 Associativity { get; set; }
        public UInt16 Availability { get; set; }
        public UInt64 BlockSize { get; set; }
        public UInt32 CacheSpeed { get; set; }
        public UInt16 CacheType { get; set; }
        public string Caption { get; set; }
        public UInt32 ConfigManagerErrorCode { get; set; }
        public bool ConfigManagerUserConfig { get; set; }
        public bool CorrectableError { get; set; }
        public string CreationClassName { get; set; }
        public UInt16 CurrentSRAM { get; set; }
        public string Description { get; set; }
        public string DeviceID { get; set; }
        public UInt64 EndingAddress { get; set; }
        public UInt16 ErrorAccess { get; set; }
        public UInt64 ErrorAddress { get; set; }
        public bool ErrorCleared { get; set; }
        public UInt16 ErrorCorrectType { get; set; }
        public byte ErrorData { get; set; }
        public UInt16 ErrorDataOrder { get; set; }
        public string ErrorDescription { get; set; }
        public UInt16 ErrorInfo { get; set; }
        public string ErrorMethodology { get; set; }
        public UInt64 ErrorResolution { get; set; }
        public DateTime ErrorTime { get; set; }
        public UInt32 ErrorTransferSize { get; set; }
        public UInt32 FlushTimer { get; set; }
        public DateTime InstallDate { get; set; }
        public UInt32 InstalledSize { get; set; }
        public UInt32 LastErrorCode { get; set; }
        public UInt16 Level { get; set; }
        public UInt32 LineSize { get; set; }
        public UInt16 Location { get; set; }
        public UInt32 MaxCacheSize { get; set; }
        public string Name { get; set; }
        public UInt64 NumberOfBlocks { get; set; }
        public string OtherErrorDescription { get; set; }
        public string PNPDeviceID { get; set; }
        public UInt16 PowerManagementCapabilities { get; set; }
        public bool PowerManagementSupported { get; set; }
        public string Purpose { get; set; }
        public UInt16 ReadPolicy { get; set; }
        public UInt16 ReplacementPolicy { get; set; }
        public UInt64 StartingAddress { get; set; }
        public string Status { get; set; }
        public UInt16 StatusInfo { get; set; }
        public UInt16 SupportedSRAM { get; set; }
        public string SystemCreationClassName { get; set; }
        public bool SystemLevelAddress { get; set; }
        public string SystemName { get; set; }
        public UInt16 WritePolicy { get; set; }

    }
}