using RetrieverCore.Models.WindowsModels.Constants;
using System;

namespace RetrieverCore.Models.WindowsModels.Win32Entities
{
    public class Win32_PNPEntity
    {
        public const string Scope = WmiScope.Cimv2;
        public const string Conditions = "ConfigManagerErrorCode != 0";
        public string Caption { get; set; }
        public UInt32 ConfigManagerErrorCode { get; set; }
        public string Status { get; set; }
    }
}
