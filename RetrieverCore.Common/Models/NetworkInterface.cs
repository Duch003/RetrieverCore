using RetrieverCore.Common.Models.Base;
using System;
using System.Net.NetworkInformation;

namespace RetrieverCore.Common.Models
{
    public class NetworkInterface : EntityBase
    {
        public string AdapterType { get; set; }
        public string Caption { get; set; }
        public Guid? GUID { get; set; }
        public string ProductName { get; set; }
        public NetworkInterfaceType NetworkInterfaceType { get; set; }
        public string MAC { get; set; }
    }
}
