using RetrieverCore.LocalDatabase.Models;
using GathererEngine.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RetrieverCore.Repositories.Interfaces
{
    public interface IDDRRepository
    {
        Task<IEnumerable<DDREntity>> GetDesignedDDRsAsync(string model);
        Task<IEnumerable<Win32_PhysicalMemory>> GetWin32PhysicalMemoriesAsync();
    }
}