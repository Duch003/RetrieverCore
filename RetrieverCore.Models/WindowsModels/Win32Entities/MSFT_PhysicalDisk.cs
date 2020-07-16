using RetrieverCore.Models.WindowsModels.Constants;
using System;

namespace RetrieverCore.Models.WindowsModels.Win32Entities
{
    public class MSFT_PhysicalDisk
    {
        public const string Scope = WmiScope.Storage;
        public string DeviceId { get; set; }
        public UInt16 MediaType { get; set; }
        public UInt16 HealthStatus { get; set; }
        public UInt16 BusType { get; set; }
    }
}
