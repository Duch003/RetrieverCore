using GathererEngine.Models;
using System.Collections.Generic;

namespace RetrieverCore.TestDataGenerator.WindowsEntieties
{
    public static class Win32_NetworkAdapterFactory
    {
        public static Win32_NetworkAdapter GetForWin32_CommonNetworkInterfaceExtensionTests()
        {
            return new Win32_NetworkAdapter
            {
                AdapterType = "Ethernet 802.3",
                Caption = "[00000003] Intel(R) Ethernet Connection (7) I219-LM",
                GUID = "{FF45B283-C377-490E-AE9D-023D18ADBCDC}",
                ProductName = "Intel(R) Ethernet Connection (7) I219-LM"
            };
        }

        public static List<Win32_NetworkAdapter> GetForNetworkInterfaceServiceTests()
        {
            var output = new List<Win32_NetworkAdapter>();

            output.Add(new Win32_NetworkAdapter
            {
                AdapterType = "Ethernet 802.3",
                Caption = "[00000003] Intel(R) Ethernet Connection (7) I219-LM",
                GUID = "{FF45B283-C377-490E-AE9D-023D18ADBCDC}",
                ProductName = "Intel(R) Ethernet Connection (7) I219-LM"
            });
            output.Add(new Win32_NetworkAdapter
            {
                AdapterType = "Ethernet 802.3",
                Caption = "[00000002] Intel(R) Wireless-AC 9560 160MHz",
                GUID = "{40F51E2E-6CC6-4AD0-9CE1-04DB2611942B}",
                ProductName = "Intel(R) Wireless-AC 9560 160MHz"
            });
            output.Add(new Win32_NetworkAdapter
            {
                AdapterType = null,
                Caption = "[00000010] WAN Miniport (PPPOE)",
                GUID = null,
                ProductName = "WAN Miniport (PPPOE)"
            });

            return output;
        }
    }
}
