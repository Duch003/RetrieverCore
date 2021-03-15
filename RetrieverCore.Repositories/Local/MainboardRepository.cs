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
    public class MainboardRepository : IMainboardRepository
    {
        private readonly LocalDatabaseContext _localContext;
        private readonly IGathererEngine _gathererEngine;

        public MainboardRepository(LocalDatabaseContext localContext, IGathererEngine gathererEngine)
        {
            _localContext = localContext;
            _gathererEngine = gathererEngine;
        }

        public async Task<MainboardEntity> GetDesignedMainboard(string model)
        {
            return await Task.Run(() => _localContext.Computers
                .Include(x => x.Mainboard)
                .Where(x => string.Equals(x.Model, model, StringComparison.InvariantCultureIgnoreCase))
                .Select(x => x.Mainboard)
                .FirstOrDefaultAsync());
        }

        public async Task<Win32_BaseBoard> GetWin32BaseBoard()
        {
            return await Task.Run(() => _gathererEngine.GatherDeviceData<Win32_BaseBoard>(Win32_BaseBoard.Scope)
                .FirstOrDefault());
        }
    }
}
