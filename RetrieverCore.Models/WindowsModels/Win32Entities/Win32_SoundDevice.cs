using RetrieverCore.Models.WindowsModels.Constants;
using System;

namespace RetrieverCore.Models.WindowsModels.Win32Entities
{
    public class Win32_SoundDevice
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt16 Availability { get; set; }
        public string Caption { get; set; }
        public string Manufacturer { get; set; }

    }
}
