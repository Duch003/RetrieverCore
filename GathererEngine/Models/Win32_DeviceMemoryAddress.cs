
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_DeviceMemoryAddress
    {
        public const string Scope = WmiScope.Cimv2;
        public string Caption { get; set; }
        public string CreationClassName { get; set; }
        public string CSCreationClassName { get; set; }
        public string CSName { get; set; }
        public string Description { get; set; }
        public UInt64 EndingAddress { get; set; }
        public DateTime InstallDate { get; set; }
        public string MemoryType { get; set; }
        public string Name { get; set; }
        public UInt64 StartingAddress { get; set; }
        public string Status { get; set; }

    }
}