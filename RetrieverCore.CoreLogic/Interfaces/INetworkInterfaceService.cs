using RetrieverCore.Models.Common;
using RetrieverCore.LocalDatabase.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using RetrieverCore.Models.Common.Win32Entieties;

namespace RetrieverCore.CoreLogic.Interfaces
{
    public interface INetworkInterfaceService
    {
        Task<Result<IEnumerable<NetworkInterfaceEntity>>> GetDesignedNetworkInterfacesAsync(string model);
        Task<Result<IEnumerable<CommonNetworkInterface>>> GetPhysicalNetworkInterfacesAsync();
    }
}