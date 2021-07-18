using RetrieverCore.Models.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RetrieverCore.CoreLogic.Interfaces
{
    public interface INetworkInterfaceService
    {
        Task<Result<IEnumerable<Databases.RetrieverCore.Common.Models.NetworkInterface>>> GetDesignedNetworkInterfacesAsync(Guid setId);
        Task<Result<IEnumerable<Databases.RetrieverCore.Common.Models.NetworkInterface>>> GetPhysicalNetworkInterfacesAsync();
    }
}