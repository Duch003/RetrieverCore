
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class MSSmBios_RawSMBiosTables
    {
        public const string Scope = WmiScope.Wmi;
        public bool Active { get; set; }
        public byte DmiRevision { get; set; }
        public string InstanceName { get; set; }
        public UInt32 Size { get; set; }
        public byte SMBiosData { get; set; }
        public byte SmbiosMajorVersion { get; set; }
        public byte SmbiosMinorVersion { get; set; }
        public bool Used20CallingMethod { get; set; }

    }
}