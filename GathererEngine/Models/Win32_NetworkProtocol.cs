
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_NetworkProtocol
    {
        public const string Scope = WmiScope.Cimv2;
        public string Caption { get; set; }
        public bool ConnectionlessService { get; set; }
        public string Description { get; set; }
        public bool GuaranteesDelivery { get; set; }
        public bool GuaranteesSequencing { get; set; }
        public DateTime InstallDate { get; set; }
        public UInt32 MaximumAddressSize { get; set; }
        public UInt32 MaximumMessageSize { get; set; }
        public bool MessageOriented { get; set; }
        public UInt32 MinimumAddressSize { get; set; }
        public string Name { get; set; }
        public bool PseudoStreamOriented { get; set; }
        public string Status { get; set; }
        public bool SupportsBroadcasting { get; set; }
        public bool SupportsConnectData { get; set; }
        public bool SupportsDisconnectData { get; set; }
        public bool SupportsEncryption { get; set; }
        public bool SupportsExpeditedData { get; set; }
        public bool SupportsFragmentation { get; set; }
        public bool SupportsGracefulClosing { get; set; }
        public bool SupportsGuaranteedBandwidth { get; set; }
        public bool SupportsMulticasting { get; set; }
        public bool SupportsQualityofService { get; set; }

    }
}