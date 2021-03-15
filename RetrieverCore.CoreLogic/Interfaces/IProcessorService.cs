using RetrieverCore.Models.Common;
using RetrieverCore.LocalDatabase.Models;
using GathererEngine.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RetrieverCore.CoreLogic.Interfaces
{
    public interface IProcessorService
    {
        Task<Result<IEnumerable<ProcessorEntity>>> GetDesignedProcessorsAsync(string model);
        Task<Result<IEnumerable<Win32_Processor>>> GetPhysicalProcessorsAsync();
    }
}