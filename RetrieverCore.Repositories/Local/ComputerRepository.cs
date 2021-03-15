using Microsoft.EntityFrameworkCore;
using RetrieverCore.MasterDatabase.Context;
using RetrieverCore.Repositories.Interfaces;
using RetrieverCore.LocalDatabase.Models;
using GathererEngine.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using RetrieverCore.LocalDatabase;
using GathererEngine;

namespace RetrieverCore.Repositories.Local
{
    public class ComputerRepository : IComputerRepository
    {
        private readonly LocalDatabaseContext _localContext;
        private readonly IGathererEngine _gathererEngine;

        public ComputerRepository(LocalDatabaseContext localContext, IGathererEngine gathererEngine)
        {
            _localContext = localContext;
            _gathererEngine = gathererEngine;
        }

        public async Task<ComputerEntity> GetDesignedComputerAsync(string model)
        {
            return await _localContext.Computers
                .FirstOrDefaultAsync(x => string.Equals(model, x.Model, StringComparison.InvariantCultureIgnoreCase));
        }

        public async Task<Win32_ComputerSystem> GetWin32ComputerSystemAsync()
        {
            return await Task.Run(() => _gathererEngine.GatherDeviceData<Win32_ComputerSystem>(Win32_ComputerSystem.Scope)
                .FirstOrDefault());
        }
    }
}
