using RetrieverCore.LocalDatabase.Models;
using GathererEngine.Models;
using System.Threading.Tasks;

namespace RetrieverCore.Repositories.Interfaces
{
    public interface IComputerRepository
    {
        Task<ComputerEntity> GetDesignedComputerAsync(string model);
        Task<Win32_ComputerSystem> GetWin32ComputerSystemAsync();
    }
}