using System;
using System.Net.NetworkInformation;
using System.Text;

namespace RetrieverCore.TestDataGenerator.TestModels
{
    public class TestNetworkInterface : NetworkInterface
    {
        public string Mac { get; set; }
        public override string Id { get; }
        public override NetworkInterfaceType NetworkInterfaceType { get; }

        public override PhysicalAddress GetPhysicalAddress()
        {
            return new PhysicalAddress(Encoding.ASCII.GetBytes(Mac));
        }

        public TestNetworkInterface(string mac, NetworkInterfaceType interfaceType, string guid) : base()
        {
            Mac = mac;
            NetworkInterfaceType = interfaceType;
            Id = guid;
        }
    }
}
