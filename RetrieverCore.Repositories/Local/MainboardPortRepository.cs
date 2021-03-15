using Microsoft.EntityFrameworkCore;
using RetrieverCore.Repositories.Interfaces;
using RetrieverCore.LocalDatabase.Models;
using GathererEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RetrieverCore.LocalDatabase;
using GathererEngine;

namespace RetrieverCore.Repositories.Local
{
    public class MainboardPortRepository : IMainboardPortRepository
    {
        private readonly LocalDatabaseContext _localContext;
        private readonly IGathererEngine _gathererEgine;

        public MainboardPortRepository(LocalDatabaseContext localContext, IGathererEngine gathererEgine)
        {
            _localContext = localContext;
            _gathererEgine = gathererEgine;
        }

        public async Task<IEnumerable<MainboardPortEntity>> GetDesignedMainboardPortsAsync(string model)
        {
            return await Task.Run(() => _localContext.Computers
                .Include(x => x.MainboardPorts)
                .Where(x => string.Equals(model, x.Model, StringComparison.InvariantCultureIgnoreCase))
                .SelectMany(x => x.MainboardPorts)
                .AsEnumerable());
        }

        public async Task<IEnumerable<Win32_PortConnector>> GetWin32PortConnectorsAsync()
        {
            return await Task.Run(() => _gathererEgine.GatherDeviceData<Win32_PortConnector>(Win32_PortConnector.Scope));
        }

        public async Task<IEnumerable<Win32_SerialPort>> GetWin32SerialPortsAsync()
        {
            return await Task.Run(() => _gathererEgine.GatherDeviceData<Win32_SerialPort>(Win32_SerialPort.Scope));
        }

    }
}
