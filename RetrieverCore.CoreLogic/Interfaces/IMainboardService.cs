using RetrieverCore.Models.Common;
using Databases.RetrieverCore.Common.Models;
using System.Threading.Tasks;
using System;

namespace RetrieverCore.CoreLogic.Interfaces
{
    public interface IMainboardService
    {
        Task<Result<Mainboard>> GetDesignedMainboardAsync(Guid setId);
        Task<Result<Mainboard>> GetPhysicalMainboardAsync();
    }
}