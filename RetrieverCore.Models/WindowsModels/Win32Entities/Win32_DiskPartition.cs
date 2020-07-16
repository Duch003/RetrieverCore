using RetrieverCore.Models.WindowsModels.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetrieverCore.Models.WindowsModels.Win32Entities
{
    public class Win32_DiskPartition
    {
        public const string Scope = WmiScope.Cimv2;
        public string DeviceID { get; set; }
        public bool Bootable { get; set; }
        public bool BootPartition { get; set; }
        public bool PrimaryPartition { get; set; }
        public UInt64 Size { get; set; }
    }
}
