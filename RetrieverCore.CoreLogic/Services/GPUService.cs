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
    public class GPUService : IGPUService
    {
        private readonly IGenericDatabaseRepository<GPU> _gpuRepo;
        private readonly IGenericComponentRepository _componentRepo;

        public GPUService(IGenericDatabaseRepository<GPU> gpuRepo, IGenericComponentRepository componentRepo)
        {
            _gpuRepo = gpuRepo;
            _componentRepo = componentRepo;
        }

        public async Task<Result<IEnumerable<GPU>>> GetDesignedGPUsAsync(Guid setId)
        {
            try
            {
                var result = await _gpuRepo.GetBySetIdAsync(setId);

                return Result<IEnumerable<GPU>>.Ok(result);
            }
            catch (Exception e)
            {
                return Result<IEnumerable<GPU>>.Fail(e);
            }
        }

        public async Task<Result<IEnumerable<GPU>>> GetPhysicalGPUsAsync()
        {
            try
            {
                var result = await Task.Run(() => _componentRepo.Get<Win32_VideoController>());
                var output = result.Select(x => GPUMapper.From(x));

                return Result<IEnumerable<GPU>>.Ok(output);
            }
            catch (Exception e)
            {
                return Result<IEnumerable<GPU>>.Fail(e);
            }
        }
    }
}
