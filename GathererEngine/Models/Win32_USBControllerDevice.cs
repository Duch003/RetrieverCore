
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_USBControllerDevice
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt16 AccessState { get; set; }
        public string Antecedent { get; set; }
        public string Dependent { get; set; }
        public UInt32 NegotiatedDataWidth { get; set; }
        public UInt64 NegotiatedSpeed { get; set; }
        public UInt32 NumberOfHardResets { get; set; }
        public UInt32 NumberOfSoftResets { get; set; }

    }
}