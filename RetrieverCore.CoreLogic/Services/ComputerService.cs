using RetrieverCore.CoreLogic.Interfaces;
using RetrieverCore.CoreLogic.Utlities;
using RetrieverCore.Repositories.Interfaces;
using RetrieverCore.Models.Common;
using RetrieverCore.LocalDatabase.Models;
using GathererEngine.Models;
using System;
using System.Threading.Tasks;

namespace RetrieverCore.CoreLogic.Services
{
    public class ComputerService : IComputerService
    {
        private readonly IComputerRepository _repository;

        public ComputerService(IComputerRepository repository)
        {
            _repository = repository;
        }

        public async Task<Result<ComputerEntity>> GetDesignedComputerAsync(string model)
        {
            if (Guard.IsNullOrWhitespace(model, out var error))
            {
                return Result<ComputerEntity>.Fail(error);
            }

            try
            {
                var result = await _repository.GetDesignedComputerAsync(model);

                return Result<ComputerEntity>.Ok(result);
            }
            catch (Exception e)
            {
                return Result<ComputerEntity>.Fail(e);
            }
        }

        public async Task<Result<Win32_ComputerSystem>> GetPhysicalComputerAsync()
        {
            try
            {
                var result = await _repository.GetWin32ComputerSystemAsync();

                if(Guard.IsNull(result, out var e))
                {
                    return Result<Win32_ComputerSystem>.Fail(e);
                }

                return Result<Win32_ComputerSystem>.Ok(result);
            }
            catch (Exception e)
            {
                return Result<Win32_ComputerSystem>.Fail(e);
            }
        }
    }
}
