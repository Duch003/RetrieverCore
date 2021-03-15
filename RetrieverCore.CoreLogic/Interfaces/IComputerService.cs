using RetrieverCore.Models.Common;
using RetrieverCore.LocalDatabase.Models;
using GathererEngine.Models;
using System.Threading.Tasks;

namespace RetrieverCore.CoreLogic.Interfaces
{
    public interface IComputerService
    {
        Task<Result<ComputerEntity>> GetDesignedComputerAsync(string model);
        Task<Result<Win32_ComputerSystem>> GetPhysicalComputerAsync();
    }
}