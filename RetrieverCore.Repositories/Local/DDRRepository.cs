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
    public class DDRRepository : IDDRRepository
    {
        private readonly LocalDatabaseContext _localContext;
        private readonly IGathererEngine _gatererEngine;

        public DDRRepository(LocalDatabaseContext localContext, IGathererEngine gatererEngine)
        {
            _localContext = localContext;
            _gatererEngine = gatererEngine;
        }

        public async Task<IEnumerable<DDREntity>> GetDesignedDDRsAsync(string model)
        {
            return await _localContext.Computers
                .Include(x => x.DDRs)
                .Where(x => string.Equals(model, x.Model, StringComparison.OrdinalIgnoreCase))
                .SelectMany(x => x.DDRs)
                .ToListAsync();
        }

        public async Task<IEnumerable<Win32_PhysicalMemory>> GetWin32PhysicalMemoriesAsync()
        {
            return await Task.Run(() => _gatererEngine
                .GatherDeviceData<Win32_PhysicalMemory>(Win32_PhysicalMemory.Scope)
                .AsEnumerable());
        }
    }
}
