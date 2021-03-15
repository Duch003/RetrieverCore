using System;
using System.Net.NetworkInformation;

namespace RetrieverCore.Models.Common.Win32Entieties
{
    public class CommonNetworkInterface
    {
        public string AdapterType { get; set; }
        public string Caption { get; set; }
        public Guid? GUID { get; set; }
        public string ProductName { get; set; }
        public NetworkInterfaceType NetworkInterfaceType { get; set; }
        public string MAC { get; set; }
    }
}
