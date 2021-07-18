using RetrieverCore.Models.Common;
using Databases.RetrieverCore.Common.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace RetrieverCore.CoreLogic.Interfaces
{
    public interface IDDRService
    {
        Task<Result<IEnumerable<DDR>>> GetDesignedDDRsAsync(Guid setId);
        Task<Result<IEnumerable<DDR>>> GetPhysicalDDRsAsync();
    }
}