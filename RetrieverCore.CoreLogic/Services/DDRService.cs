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
    public class DDRService : IDDRService
    {
        private readonly IDDRRepository _repository;

        public DDRService(IDDRRepository repository)
        {
            _repository = repository;
        }

        public async Task<Result<IEnumerable<DDREntity>>> GetDesignedDDRsAsync(string model)
        {
            if (Guard.IsNullOrWhitespace(model, out var error))
            {
                return Result<IEnumerable<DDREntity>>.Fail(error);
            }

            try
            {
                var result = await _repository.GetDesignedDDRsAsync(model);

                return Result<IEnumerable<DDREntity>>.Ok(result);
            }
            catch (Exception e)
            {
                return Result<IEnumerable<DDREntity>>.Fail(e);
            }
        }

        public async Task<Result<IEnumerable<Win32_PhysicalMemory>>> GetPhysicalDDRsAsync()
        {
            try
            {
                var result = await _repository.GetWin32PhysicalMemoriesAsync();

                if(Guard.IsEmptyOrAnyNull(result, out var e))
                {
                    return Result<IEnumerable<Win32_PhysicalMemory>>.Fail(e);
                }

                return Result<IEnumerable<Win32_PhysicalMemory>>.Ok(result);
            }
            catch (Exception e)
            {
                return Result<IEnumerable<Win32_PhysicalMemory>>.Fail(e);
            }
        }
    }
}
