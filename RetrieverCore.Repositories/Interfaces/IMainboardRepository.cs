using RetrieverCore.LocalDatabase.Models;
using GathererEngine.Models;
using System.Threading.Tasks;

namespace RetrieverCore.Repositories.Interfaces
{
    public interface IMainboardRepository
    {
        Task<MainboardEntity> GetDesignedMainboard(string model);
        Task<Win32_BaseBoard> GetWin32BaseBoard();
    }
}