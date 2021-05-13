using GathererEngine;
using RetrieverCore.Repositories.Interfaces;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace RetrieverCore.Repositories.Local
{
    public class ExtendedNetworkInterfaceComponentRepository : GenericComponentRepository, IExtendedNetworkInterfaceComponentRepository
    {
        public ExtendedNetworkInterfaceComponentRepository(IGathererEngine gathererEngine) : base(gathererEngine)
        {
        }

        public IEnumerable<NetworkInterface> Get()
        {
            return NetworkInterface.GetAllNetworkInterfaces();
        }
    }
}
