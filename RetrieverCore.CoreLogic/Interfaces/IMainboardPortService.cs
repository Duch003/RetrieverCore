using RetrieverCore.Models.Common;
using RetrieverCore.Models.Common.Win32Entieties;
using RetrieverCore.LocalDatabase.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RetrieverCore.CoreLogic.Interfaces
{
    public interface IMainboardPortService
    {
        Task<Result<IEnumerable<MainboardPortEntity>>> GetDesignedMainboardPortsAsync(string model);
        Task<Result<IEnumerable<CommonPortType>>> GetPhysicalMainboardPortsAsync();
    }
}