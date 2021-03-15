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
    public class GPURepository : IGPURepository
    {
        private readonly LocalDatabaseContext _localContext;
        private readonly IGathererEngine _gathererEngine;

        public GPURepository(LocalDatabaseContext localContext, IGathererEngine gathererEngine)
        {
            _localContext = localContext;
            _gathererEngine = gathererEngine;
        }

        public async Task<IEnumerable<GPUEntity>> GetDesignedGPUsAsync(string model)
        {
            return await _localContext.Computers
                .Include(x => x.GPUs)
                .Where(x => string.Equals(model, x.Model, StringComparison.OrdinalIgnoreCase))
                .SelectMany(x => x.GPUs)
                .ToListAsync();
        }

        public async Task<IEnumerable<Win32_VideoController>> GetWin32VideoControllersAsync()
        {
            return await Task.Run(() => _gathererEngine
                .GatherDeviceData<Win32_VideoController>(Win32_VideoController.Scope)
                .AsEnumerable());
        }
    }
}
