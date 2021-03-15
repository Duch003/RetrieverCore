using GathererEngine.Models;
using RetrieverCore.CoreLogic.Interfaces;
using RetrieverCore.CoreLogic.Utlities;
using RetrieverCore.Extensions;
using RetrieverCore.LocalDatabase.Models;
using RetrieverCore.Models.Common;
using RetrieverCore.Models.Common.Win32Entieties;
using RetrieverCore.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace RetrieverCore.CoreLogic.Services
{
    public class NetworkInterfaceService : INetworkInterfaceService
    {
        private readonly INetworkInterfaceRepository _repository;

        public NetworkInterfaceService(INetworkInterfaceRepository repository)
        {
            _repository = repository;
        }

        public async Task<Result<IEnumerable<CommonNetworkInterface>>> GetPhysicalNetworkInterfacesAsync()
        {
            try
            {
                var networkInterfaces = await _repository.GetPhysicalNetworkInterfacesAsync();
                if (Guard.IsEmptyOrAnyNull(networkInterfaces, out var eni))
                {
                    return Result<IEnumerable<CommonNetworkInterface>>.Fail(eni);
                }

                var networkAdapters = await _repository.GetWin32NetworkAdaptersAsync();
                if (Guard.IsEmptyOrAnyNull(networkAdapters, out var ena))
                {
                    return Result<IEnumerable<CommonNetworkInterface>>.Fail(ena);
                }

                var output = networkAdapters.ForEach(x => Pair(x, networkInterfaces));

                return Result<IEnumerable<CommonNetworkInterface>>.Ok(output);
            }
            catch (Exception e)
            {
                return Result<IEnumerable<CommonNetworkInterface>>.Fail(e);
            }
        }

        public async Task<Result<IEnumerable<NetworkInterfaceEntity>>> GetDesignedNetworkInterfacesAsync(string model)
        {
            if (Guard.IsNullOrWhitespace(model, out var ex))
            {
                return Result<IEnumerable<NetworkInterfaceEntity>>.Fail(ex);
            }

            try
            {
                var output = await _repository.GetDesignedNetworkInterfacesAsync(model);

                return Result<IEnumerable<NetworkInterfaceEntity>>.Ok(output);
            }
            catch (Exception e)
            {
                return Result<IEnumerable<NetworkInterfaceEntity>>.Fail(e);
            }
        }

        private CommonNetworkInterface Pair(Win32_NetworkAdapter networkAdapter, IEnumerable<NetworkInterface> networkInterfaces)
        {
            if (string.IsNullOrWhiteSpace(networkAdapter.GUID))
            {
                return networkAdapter.ToCommon(null);
            }

            var iface = networkInterfaces
                .FirstOrDefault(x => string.Equals(x.Id, networkAdapter.GUID, StringComparison.InvariantCultureIgnoreCase));
            return networkAdapter.ToCommon(iface);
        }
    }
}
