using Databases.RetrieverCore.Common.Models;
using RetrieverCore.Models.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RetrieverCore.CoreLogic.Interfaces
{
    public interface ICPUService
    {
        Task<Result<IEnumerable<CPU>>> GetDesignedCPUsAsync(Guid setId);
        Task<Result<IEnumerable<CPU>>> GetPhysicalCPUsAsync();
    }
}