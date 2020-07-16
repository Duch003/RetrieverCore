using RetrieverCore.Models.WindowsModels.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetrieverCore.Models.WindowsModels.Win32Entities
{
    public class Win32_Keyboard
    {
        public const string Scope = WmiScope.Cimv2;
        public string Caption { get; set; }
        public UInt32 ConfigManagerErrorCode { get; set; }
        public bool ConfigManagerUserConfig { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}
