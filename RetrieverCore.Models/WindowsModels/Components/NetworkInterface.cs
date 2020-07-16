using System.Net.NetworkInformation;

namespace RetrieverCore.Models.WindowsModels.Components
{
    public class NetworkInterface
    {
        public static readonly string[] Ignore = new[] { "bluetooth", "virtual" };

        public NetworkInterface(string description, OperationalStatus operationalStatus, PhysicalAddress physicalAddress)
        {
            Description = description;
            OperationalStatus = operationalStatus;
            PhysicalAddress = physicalAddress;
        }

        public string Description { get; }
        public OperationalStatus OperationalStatus { get; }
        public PhysicalAddress PhysicalAddress { get; }
    }
}
