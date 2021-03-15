using GathererEngine.Models;
using RetrieverCore.LocalDatabase.Models;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace RetrieverCore.Repositories.Interfaces
{
    public interface INetworkInterfaceRepository
    {
        Task<IEnumerable<NetworkInterfaceEntity>> GetDesignedNetworkInterfacesAsync(string model);
        Task<IEnumerable<NetworkInterface>> GetPhysicalNetworkInterfacesAsync();
        Task<IEnumerable<Win32_NetworkAdapter>> GetWin32NetworkAdaptersAsync();
    }
}