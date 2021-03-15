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
    public class ProcessorService : IProcessorService
    {
        private readonly IProcessorRepository _repository;

        public ProcessorService(IProcessorRepository repository)
        {
            _repository = repository;
        }

        public async Task<Result<IEnumerable<ProcessorEntity>>> GetDesignedProcessorsAsync(string model)
        {
            if (Guard.IsNullOrWhitespace(model, out var error))
            {
                return Result<IEnumerable<ProcessorEntity>>.Fail(error);
            }

            try
            {
                var result = await _repository.GetDesignedProcessors(model);

                return Result<IEnumerable<ProcessorEntity>>.Ok(result);
            }
            catch (Exception e)
            {
                return Result<IEnumerable<ProcessorEntity>>.Fail(e);
            }
        }

        public async Task<Result<IEnumerable<Win32_Processor>>> GetPhysicalProcessorsAsync()
        {
            try
            {
                var result = await _repository.GetWin32Processors();

                if (Guard.IsEmptyOrAnyNull(result, out var e))
                {
                    return Result<IEnumerable<Win32_Processor>>.Fail(e);
                }

                return Result<IEnumerable<Win32_Processor>>.Ok(result);
            }
            catch (Exception e)
            {
                return Result<IEnumerable<Win32_Processor>>.Fail(e);
            }
        }
    }
}
