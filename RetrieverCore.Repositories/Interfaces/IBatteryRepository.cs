using RetrieverCore.LocalDatabase.Models;
using GathererEngine.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RetrieverCore.Repositories.Interfaces
{
    public interface IBatteryRepository
    {
        Task<IEnumerable<BatteryEntity>> GetDesignedBatteriesAsync(string model);

        Task<Win32_Battery> GetWin32BatteryAsync(string deviceId);

        Task<IEnumerable<BatteryStaticData>> GetBatteriesStaticDataAsync();

        Task<BatteryFullChargedCapacity> GetBatteryFullChargedCapacityAsync(uint tag);
    }
}