using RetrieverCore.Models.WindowsModels.Constants;
using System;

namespace RetrieverCore.Models.WindowsModels.Win32Entities
{
    public class Win32_ComputerSystem
    {
        public const string Scope = WmiScope.Cimv2;
        public string Model { get; set; }
        public string[] OEMStringArray { get; set; }
        public UInt32 NumberOfLogicalProcessors { get; set; }
        public UInt32 NumberOfProcessors { get; set; }
        public string SystemType { get; set; }
    }
}
