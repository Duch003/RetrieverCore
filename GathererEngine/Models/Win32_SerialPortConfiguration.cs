
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_SerialPortConfiguration
    {
        public const string Scope = WmiScope.Cimv2;
        public bool AbortReadWriteOnError { get; set; }
        public UInt32 BaudRate { get; set; }
        public bool BinaryModeEnabled { get; set; }
        public UInt32 BitsPerByte { get; set; }
        public string Caption { get; set; }
        public bool ContinueXMitOnXOff { get; set; }
        public bool CTSOutflowControl { get; set; }
        public string Description { get; set; }
        public bool DiscardNULLBytes { get; set; }
        public bool DSROutflowControl { get; set; }
        public bool DSRSensitivity { get; set; }
        public string DTRFlowControlType { get; set; }
        public UInt32 EOFCharacter { get; set; }
        public UInt32 ErrorReplaceCharacter { get; set; }
        public bool ErrorReplacementEnabled { get; set; }
        public UInt32 EventCharacter { get; set; }
        public bool IsBusy { get; set; }
        public string Name { get; set; }
        public string Parity { get; set; }
        public bool ParityCheckEnabled { get; set; }
        public string RTSFlowControlType { get; set; }
        public string SettingID { get; set; }
        public string StopBits { get; set; }
        public UInt32 XOffCharacter { get; set; }
        public UInt32 XOffXMitThreshold { get; set; }
        public UInt32 XOnCharacter { get; set; }
        public UInt32 XOnXMitThreshold { get; set; }
        public UInt32 XOnXOffInFlowControl { get; set; }
        public UInt32 XOnXOffOutFlowControl { get; set; }

    }
}