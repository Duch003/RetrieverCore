using RetrieverCore.Models.Common;
using RetrieverCore.LocalDatabase.Models;
using GathererEngine.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RetrieverCore.CoreLogic.Interfaces
{
    public interface IDDRService
    {
        Task<Result<IEnumerable<DDREntity>>> GetDesignedDDRsAsync(string model);
        Task<Result<IEnumerable<Win32_PhysicalMemory>>> GetPhysicalDDRsAsync();
    }
}