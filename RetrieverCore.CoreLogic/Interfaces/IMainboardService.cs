using RetrieverCore.Models.Common;
using RetrieverCore.LocalDatabase.Models;
using GathererEngine.Models;
using System.Threading.Tasks;

namespace RetrieverCore.CoreLogic.Interfaces
{
    public interface IMainboardService
    {
        Task<Result<MainboardEntity>> GetDesignedMainboardAsync(string model);
        Task<Result<Win32_BaseBoard>> GetPhysicalMainboardAsync();
    }
}