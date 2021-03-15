using RetrieverCore.CoreLogic.Interfaces;
using RetrieverCore.CoreLogic.Utlities;
using RetrieverCore.Repositories.Interfaces;
using RetrieverCore.Models.Common;
using RetrieverCore.LocalDatabase.Models;
using GathererEngine.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RetrieverCore.CoreLogic.Services
{
    public class GPUService : IGPUService
    {
        private readonly IGPURepository _repository;

        public GPUService(IGPURepository repository)
        {
            _repository = repository;
        }

        public async Task<Result<IEnumerable<GPUEntity>>> GetDesignedGPUsAsync(string model)
        {
            if (Guard.IsNullOrWhitespace(model, out var error))
            {
                return Result<IEnumerable<GPUEntity>>.Fail(error);
            }

            try
            {
                var result = await _repository.GetDesignedGPUsAsync(model);

                return Result<IEnumerable<GPUEntity>>.Ok(result);
            }
            catch (Exception e)
            {
                return Result<IEnumerable<GPUEntity>>.Fail(e);
            }
        }

        public async Task<Result<IEnumerable<Win32_VideoController>>> GetPhysicalGPUsAsync()
        {
            try
            {
                var result = await _repository.GetWin32VideoControllersAsync();

                if (Guard.IsEmptyOrAnyNull(result, out var e))
                {
                    return Result<IEnumerable<Win32_VideoController>>.Fail(e);
                }

                return Result<IEnumerable<Win32_VideoController>>.Ok(result);
            }
            catch (Exception e)
            {
                return Result<IEnumerable<Win32_VideoController>>.Fail(e);
            }
        }
    }
}
