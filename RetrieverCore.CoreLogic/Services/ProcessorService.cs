using RetrieverCore.CoreLogic.Interfaces;
using RetrieverCore.Repositories.Interfaces;
using RetrieverCore.Models.Common;
using RetrieverCore.Common.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RetrieverCore.Models.WMIEntieties;
using System.Linq;
using RetrieverCore.CoreLogic.Mappers;

namespace RetrieverCore.CoreLogic.Services
{
    public class ProcessorService : IProcessorService
    {
        private readonly IGenericDatabaseRepository<CPU> _cpuRepo;
        private readonly IGenericComponentRepository _componentRepo;

        public ProcessorService(IGenericDatabaseRepository<CPU> cpuRepo, IGenericComponentRepository componentRepo)
        {
            _cpuRepo = cpuRepo;
            _componentRepo = componentRepo;
        }

        public async Task<Result<IEnumerable<CPU>>> GetDesignedCPUsAsync(Guid setId)
        {
            try
            {
                var result = await _cpuRepo.GetBySetIdAsync(setId);

                return Result<IEnumerable<CPU>>.Ok(result);
            }
            catch (Exception e)
            {
                return Result<IEnumerable<CPU>>.Fail(e);
            }
        }

        public async Task<Result<IEnumerable<CPU>>> GetPhysicalCPUsAsync()
        {
            try
            {
                var result = await Task.Run(() => _componentRepo.Get<Win32_Processor>());
                var output = result.Select(x => CPUMapper.From(x));

                return Result<IEnumerable<CPU>>.Ok(output);
            }
            catch (Exception e)
            {
                return Result<IEnumerable<CPU>>.Fail(e);
            }
        }
    }
}
