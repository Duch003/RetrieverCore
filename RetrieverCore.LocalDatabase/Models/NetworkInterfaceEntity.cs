using System.Net.NetworkInformation;

namespace RetrieverCore.LocalDatabase.Models
{
    public class NetworkInterfaceEntity
    {
        public int ID { get; set; }
        public string AdapterType { get; set; }
        public string Caption { get; set; }
        public string Manufacturer { get; set; }
        public string ProductName { get; set; }
        public NetworkInterfaceType NetworkInterfaceType { get; set; }
    }
}
