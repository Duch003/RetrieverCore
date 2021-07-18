using Databases.RetrieverCore.Common.Models;
using RetrieverCore.Models.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RetrieverCore.CoreLogic.Interfaces
{
    public interface IStorageService
    {
        Task<Result<IEnumerable<Storage>>> GetDesignedStoragesAsync(Guid setId);
        Task<Result<IEnumerable<Storage>>> GetPhysicalStoragesAsync();
    }
}