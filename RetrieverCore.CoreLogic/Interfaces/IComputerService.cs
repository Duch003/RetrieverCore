using RetrieverCore.Models.Common;
using RetrieverCore.Common.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace RetrieverCore.CoreLogic.Interfaces
{
    public interface IComputerService
    {
        Task<Result<IEnumerable<Computer>>> GetDesignedComputersAsync();
        Task<Result<IEnumerable<Computer>>> GetPhysicalComputersAsync();
    }
}