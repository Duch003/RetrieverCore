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
    public class BatteryRepository : IBatteryRepository
    {
        private readonly LocalDatabaseContext _localContext;
        private readonly IGathererEngine _gathererEngine;

        public BatteryRepository(LocalDatabaseContext localContext, IGathererEngine gathererEngine)
        {
            _localContext = localContext;
            _gathererEngine = gathererEngine;
        }

        public async Task<IEnumerable<BatteryEntity>> GetDesignedBatteriesAsync(string model)
        {
            return await _localContext.Computers
                    .Include(x => x.Batteries)
                    .Where(x => string.Equals(x.Model, model, StringComparison.OrdinalIgnoreCase))
                    .SelectMany(x => x.Batteries)
                    .ToListAsync();
        }

        public async Task<Win32_Battery> GetWin32BatteryAsync(string deviceId)
        {
            return await Task.Run(() => _gathererEngine.GatherDeviceData<Win32_Battery>(
                Win32_Battery.Scope, Win32_Battery.Conditions(deviceId))
                .First());
        }

        public async Task<IEnumerable<BatteryStaticData>> GetBatteriesStaticDataAsync()
        {
            return await Task.Run(() => _gathererEngine.GatherDeviceData<BatteryStaticData>(BatteryStaticData.Scope));
        }

        public async Task<BatteryFullChargedCapacity> GetBatteryFullChargedCapacityAsync(uint tag)
        {
            return await Task.Run(() => _gathererEngine.GatherDeviceData<BatteryFullChargedCapacity>(
                BatteryFullChargedCapacity.Scope, BatteryFullChargedCapacity.Conditions(tag))
                .First());
        }
    }
}
