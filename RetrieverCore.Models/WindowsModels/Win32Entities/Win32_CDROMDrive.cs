using RetrieverCore.Models.WindowsModels.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetrieverCore.Models.WindowsModels.Win32Entities
{
    public class Win32_CDROMDrive
    {
        public const string Scope = WmiScope.Cimv2;
        public string Caption { get; set; }
        public UInt64 Size { get; set; }
    }
}
