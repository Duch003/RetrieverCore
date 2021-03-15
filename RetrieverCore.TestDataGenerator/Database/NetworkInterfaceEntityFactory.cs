using RetrieverCore.LocalDatabase.Models;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace RetrieverCore.TestDataGenerator.Database
{
    public static class NetworkInterfaceEntityFactory
    {
        public static List<NetworkInterfaceEntity> GetForNetworkInterfaceServiceTests()
        {
            var output = new List<NetworkInterfaceEntity>();

            output.Add(new NetworkInterfaceEntity
            {
                ID = 0,
                AdapterType = "Ethernet 802.3",
                Caption = "[00000003] Intel(R) Ethernet Connection (7) I219-LM",
                ProductName = "Intel(R) Ethernet Connection (7) I219-LM",
                NetworkInterfaceType = NetworkInterfaceType.Ethernet
            });
            output.Add(new NetworkInterfaceEntity
            {
                ID = 0,
                AdapterType = "Ethernet 802.3",
                Caption = "[00000002] Intel(R) Wireless-AC 9560 160MHz",
                ProductName = "Intel(R) Wireless-AC 9560 160MHz",
                NetworkInterfaceType = NetworkInterfaceType.Wireless80211
            });

            return output;
        }
    }
}
