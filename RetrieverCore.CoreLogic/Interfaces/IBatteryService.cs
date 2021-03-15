using RetrieverCore.Models.Common;
using RetrieverCore.Models.ComputerComponents.Physical;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RetrieverCore.CoreLogic.Interfaces
{
    public interface IBatteryService
    {
        Task<Result<IEnumerable<BatteryComponent>>> GetDesignedBatteriesAsync(string model);
        Task<Result<IEnumerable<BatteryComponent>>> GetPhysicalBatteriesAsync();
    }
}