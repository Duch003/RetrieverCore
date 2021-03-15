using RetrieverCore.LocalDatabase.Models;
using RetrieverCore.Models.Common;
using RetrieverCore.Models.ComputerComponents.Physical;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RetrieverCore.CoreLogic.Interfaces
{
    public interface IStorageService
    {
        Task<Result<IEnumerable<StorageEntity>>> GetDesignedStorages(string model);
        Task<Result<IEnumerable<StorageComponent>>> GetPhysicalStoragesAsync();
    }
}