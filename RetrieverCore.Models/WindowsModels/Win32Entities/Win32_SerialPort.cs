using RetrieverCore.Models.WindowsModels.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetrieverCore.Models.WindowsModels.Win32Entities
{
    public class Win32_SerialPort
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt16 Availability { get; set; }
        public string Caption { get; set; }
        public UInt32 ConfigManagerErrorCode { get; set; }
        public string Description { get; set; }
        public string DeviceID { get; set; }
        public string Name { get; set; }
        public bool OSAutoDiscovered { get; set; }
        public UInt16[] PowerManagementCapabilities { get; set; }
        public string ProviderType { get; set; }
        public string Status { get; set; }

    }
}
