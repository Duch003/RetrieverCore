using System.Net.NetworkInformation;
using System.Text;

namespace Tests.RetrieverCore.Common.Implementations
{
    public class FakeNetworkInterface : NetworkInterface
    {
        public string IdToReturn { get; set; }
        public override string Id { get => IdToReturn; }
        public NetworkInterfaceType NetworkInterfaceTypeToReturn { get; set; }
        public override NetworkInterfaceType NetworkInterfaceType { get => NetworkInterfaceTypeToReturn; }
        public string MAC { get; set; }

        public FakeNetworkInterface() : base()
        {
        }

        public override PhysicalAddress GetPhysicalAddress()
        {
            return new PhysicalAddress(Encoding.ASCII.GetBytes(MAC));
        }
    }
}
