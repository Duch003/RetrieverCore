using RetrieverCore.Models.Common;
using RetrieverCore.Common.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace RetrieverCore.CoreLogic.Interfaces
{
    public interface IGPUService
    {
        Task<Result<IEnumerable<GPU>>> GetDesignedGPUsAsync(Guid setId);
        Task<Result<IEnumerable<GPU>>> GetPhysicalGPUsAsync();
    }
}