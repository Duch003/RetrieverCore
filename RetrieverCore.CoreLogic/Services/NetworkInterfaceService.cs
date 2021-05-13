using RetrieverCore.CoreLogic.Interfaces;
using RetrieverCore.CoreLogic.Mappers;
using RetrieverCore.Models.Common;
using RetrieverCore.Models.WMIEntieties;
using RetrieverCore.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetrieverCore.CoreLogic.Services
{
    public class NetworkInterfaceService : INetworkInterfaceService
    {
        private readonly IGenericDatabaseRepository<Common.Models.NetworkInterface> _interfaceRepo;
        private readonly IExtendedNetworkInterfaceComponentRepository _componentRepo;

        public NetworkInterfaceService(IGenericDatabaseRepository<Common.Models.NetworkInterface> interfaceRepo, IExtendedNetworkInterfaceComponentRepository componentRepo)
        {
            _interfaceRepo = interfaceRepo;
            _componentRepo = componentRepo;
        }

        public async Task<Result<IEnumerable<Common.Models.NetworkInterface>>> GetPhysicalNetworkInterfacesAsync()
        {
            try
            {
                var networkInterfaces = await Task.Run(() => _componentRepo.Get());
                var networkAdapters = await Task.Run(() => _componentRepo.Get<Win32_NetworkAdapter>());
                var output = new List<Common.Models.NetworkInterface>();

                foreach(var iface in networkInterfaces)
                {
                    var relatedAdapter = networkAdapters.First(x => string.Equals(x.GUID, iface.Id, StringComparison.InvariantCultureIgnoreCase));
                    output.Add(NetworkInterfaceMapper.From(iface, relatedAdapter));
                }

                return Result<IEnumerable<Common.Models.NetworkInterface>>.Ok(output);
            }
            catch (Exception e)
            {
                return Result<IEnumerable<Common.Models.NetworkInterface>>.Fail(e);
            }
        }

        public async Task<Result<IEnumerable<Common.Models.NetworkInterface>>> GetDesignedNetworkInterfacesAsync(Guid setId)
        {
            try
            {
                var output = await _interfaceRepo.GetBySetIdAsync(setId);

                return Result<IEnumerable<Common.Models.NetworkInterface>>.Ok(output);
            }
            catch (Exception e)
            {
                return Result<IEnumerable<Common.Models.NetworkInterface>>.Fail(e);
            }
        }
    }
}
