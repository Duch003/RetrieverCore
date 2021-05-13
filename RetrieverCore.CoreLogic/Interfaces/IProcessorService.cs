using RetrieverCore.Models.Common;
using RetrieverCore.Common.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace RetrieverCore.CoreLogic.Interfaces
{
    public interface IProcessorService
    {
        Task<Result<IEnumerable<CPU>>> GetDesignedCPUsAsync(Guid setId);
        Task<Result<IEnumerable<CPU>>> GetPhysicalCPUsAsync();
    }
}