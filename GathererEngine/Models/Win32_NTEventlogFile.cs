
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_NTEventlogFile
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt32 AccessMask { get; set; }
        public bool Archive { get; set; }
        public string Caption { get; set; }
        public bool Compressed { get; set; }
        public string CompressionMethod { get; set; }
        public string CreationClassName { get; set; }
        public DateTime CreationDate { get; set; }
        public string CSCreationClassName { get; set; }
        public string CSName { get; set; }
        public string Description { get; set; }
        public string Drive { get; set; }
        public string EightDotThreeFileName { get; set; }
        public bool Encrypted { get; set; }
        public string EncryptionMethod { get; set; }
        public string Extension { get; set; }
        public string FileName { get; set; }
        public UInt64 FileSize { get; set; }
        public string FileType { get; set; }
        public string FSCreationClassName { get; set; }
        public string FSName { get; set; }
        public bool Hidden { get; set; }
        public DateTime InstallDate { get; set; }
        public UInt64 InUseCount { get; set; }
        public DateTime LastAccessed { get; set; }
        public DateTime LastModified { get; set; }
        public string LogfileName { get; set; }
        public string Manufacturer { get; set; }
        public UInt32 MaxFileSize { get; set; }
        public string Name { get; set; }
        public UInt32 NumberOfRecords { get; set; }
        public UInt32 OverwriteOutDated { get; set; }
        public string OverWritePolicy { get; set; }
        public string Path { get; set; }
        public bool Readable { get; set; }
        public string Sources { get; set; }
        public string Status { get; set; }
        public bool System { get; set; }
        public string Version { get; set; }
        public bool Writeable { get; set; }

    }
}