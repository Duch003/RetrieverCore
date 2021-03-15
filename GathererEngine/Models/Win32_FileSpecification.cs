
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_FileSpecification
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt16 Attributes { get; set; }
        public string Caption { get; set; }
        public string CheckID { get; set; }
        public bool CheckMode { get; set; }
        public UInt32 CheckSum { get; set; }
        public UInt32 CRC1 { get; set; }
        public UInt32 CRC2 { get; set; }
        public DateTime CreateTimeStamp { get; set; }
        public string Description { get; set; }
        public string FileID { get; set; }
        public UInt64 FileSize { get; set; }
        public string Language { get; set; }
        public string MD5Checksum { get; set; }
        public string Name { get; set; }
        public UInt16 Sequence { get; set; }
        public string SoftwareElementID { get; set; }
        public UInt16 SoftwareElementState { get; set; }
        public UInt16 TargetOperatingSystem { get; set; }
        public string Version { get; set; }

    }
}