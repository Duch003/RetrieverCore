using RetrieverCore.LocalDatabase.Models;
using GathererEngine.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RetrieverCore.Repositories.Interfaces
{
    public interface IGPURepository
    {
        Task<IEnumerable<GPUEntity>> GetDesignedGPUsAsync(string model);
        Task<IEnumerable<Win32_VideoController>> GetWin32VideoControllersAsync();
    }
}