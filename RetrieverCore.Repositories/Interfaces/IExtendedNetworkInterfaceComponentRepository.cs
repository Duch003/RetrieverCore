using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace RetrieverCore.Repositories.Interfaces
{
    public interface IExtendedNetworkInterfaceComponentRepository : IGenericComponentRepository
    {
        IEnumerable<NetworkInterface> Get();
    }
}