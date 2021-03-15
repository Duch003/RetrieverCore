using Microsoft.EntityFrameworkCore;
using RetrieverCore.LocalDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using RetrieverCore.LocalDatabase;
using RetrieverCore.Repositories.Interfaces;
using GathererEngine.Models;
using GathererEngine;

namespace RetrieverCore.Repositories.Local
{
    public class NetworkInterfaceRepository : INetworkInterfaceRepository
    {
        private readonly LocalDatabaseContext _localContext;
        private readonly IGathererEngine _gathererEngine;

        public NetworkInterfaceRepository(LocalDatabaseContext localContext, IGathererEngine gathererEngine)
        {
            _localContext = localContext;
            _gathererEngine = gathererEngine;
        }

        public async Task<IEnumerable<NetworkInterface>> GetPhysicalNetworkInterfacesAsync()
        {
            return await Task.Run(() => NetworkInterface.GetAllNetworkInterfaces());
        }

        public async Task<IEnumerable<NetworkInterfaceEntity>> GetDesignedNetworkInterfacesAsync(string model)
        {
            return await Task.Run(() => _localContext.Computers
                .Include(x => x.NetworkInterfaces)
                .Where(x => string.Equals(x.Model, model, StringComparison.InvariantCultureIgnoreCase))
                .SelectMany(x => x.NetworkInterfaces)
                .AsEnumerable());
        }

        public async Task<IEnumerable<Win32_NetworkAdapter>> GetWin32NetworkAdaptersAsync()
        {
            return await Task.Run(() => _gathererEngine.GatherDeviceData<Win32_NetworkAdapter>(Win32_NetworkAdapter.Scope));
        }
    }
}
