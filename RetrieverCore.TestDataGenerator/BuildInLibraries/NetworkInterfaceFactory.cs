using RetrieverCore.TestDataGenerator.TestModels;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace RetrieverCore.TestDataGenerator.BuildInLibraries
{
    public static class NetworkInterfaceFactory
    {
        public static List<NetworkInterface> GetForNetworkInterfaceServiceTests()
        {
            var output = new List<NetworkInterface>();

            output.Add(new TestNetworkInterface("4CCC6A815EEF", NetworkInterfaceType.Ethernet, "{FF45B283-C377-490E-AE9D-023D18ADBCDC}"));
            output.Add(new TestNetworkInterface("84EF18F0C70B", NetworkInterfaceType.Wireless80211, "{40F51E2E-6CC6-4AD0-9CE1-04DB2611942B}"));
            output.Add(new TestNetworkInterface(null, NetworkInterfaceType.Loopback, null));

            return output;
        }

        public static NetworkInterface GetForWin32_CommonNetworkInterfaceExtensionTests()
        {
            return new TestNetworkInterface("4CCC6A815EEF", NetworkInterfaceType.Ethernet, "{FF45B283-C377-490E-AE9D-023D18ADBCDC}");
        }
    }
}
