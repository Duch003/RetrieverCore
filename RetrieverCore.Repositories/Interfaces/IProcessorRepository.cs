using RetrieverCore.LocalDatabase.Models;
using GathererEngine.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RetrieverCore.Repositories.Interfaces
{
    public interface IProcessorRepository
    {
        Task<IEnumerable<ProcessorEntity>> GetDesignedProcessors(string model);
        Task<IEnumerable<Win32_Processor>> GetWin32Processors();
    }
}