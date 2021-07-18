using Databases.RetrieverCore.Common.Models;
using RetrieverCore.Models.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RetrieverCore.CoreLogic.Interfaces
{
    public interface IBatteryService
    {
        Task<Result<IEnumerable<Battery>>> GetDesignedBatteriesAsync(Guid setId);
        Task<Result<IEnumerable<Battery>>> GetPhysicalBatteriesAsync();
    }
}