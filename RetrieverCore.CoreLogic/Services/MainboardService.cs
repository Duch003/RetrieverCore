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
    public class MainboardService : IMainboardService
    {
        private readonly IMainboardRepository _repository;

        public MainboardService(IMainboardRepository repository)
        {
            _repository = repository;
        }

        public async Task<Result<MainboardEntity>> GetDesignedMainboardAsync(string model)
        {
            if (Guard.IsNullOrWhitespace(model, out var error))
            {
                return Result<MainboardEntity>.Fail(error);
            }

            try
            {
                var result = await _repository.GetDesignedMainboard(model);

                return Result<MainboardEntity>.Ok(result);
            }
            catch (Exception e)
            {
                return Result<MainboardEntity>.Fail(e);
            }
        }

        public async Task<Result<Win32_BaseBoard>> GetPhysicalMainboardAsync()
        {
            try
            {
                var result = await _repository.GetWin32BaseBoard();

                if (Guard.IsNull(result, out var e))
                {
                    return Result<Win32_BaseBoard>.Fail(e);
                }

                return Result<Win32_BaseBoard>.Ok(result);
            }
            catch (Exception e)
            {
                return Result<Win32_BaseBoard>.Fail(e);
            }
        }
    }
}
