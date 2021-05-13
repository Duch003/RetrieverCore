using Microsoft.Extensions.Configuration;
using RetrieverCore.CoreLogic.Interfaces;
using RetrieverCore.CoreLogic.Mappers;
using RetrieverCore.Repositories.Interfaces;
using RetrieverCore.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RetrieverCore.Models.WMIEntieties;
using RetrieverCore.Common.Models;

namespace RetrieverCore.CoreLogic.Services
{
    public class BatteryService : IBatteryService
    {
        private readonly IGenericDatabaseRepository<Battery> _batteryRepo;
        private readonly IGenericComponentRepository _componentRepository;

        public BatteryService(IGenericDatabaseRepository<Battery> batteryRepo, IGenericComponentRepository componentRepository)
        {
            _batteryRepo = batteryRepo;
            _componentRepository = componentRepository;
        }

        #region Public methods

        public async Task<Result<IEnumerable<Battery>>> GetPhysicalBatteriesAsync()
        {
            var output = new List<Battery>();

            var staticDataResult = await GetPhysicalData(() => _componentRepository.Get<BatteryStaticData>());
            if (!staticDataResult.IsSuccess || !staticDataResult.Output.Any())
            {
                return Result<IEnumerable<Battery>>.Fail(staticDataResult.Exception);
            }

            var win32batteryResult = await GetPhysicalData(() => _componentRepository.Get<Win32_Battery>());
            if (!win32batteryResult.IsSuccess)
            {
                return Result<IEnumerable<Battery>>.Fail(win32batteryResult.Exception);
            }

            var fullChargedCapacityResult = await GetPhysicalData(() => _componentRepository.Get<BatteryFullChargedCapacity>());
            if (!fullChargedCapacityResult.IsSuccess)
            {
                return Result<IEnumerable<Battery>>.Fail(fullChargedCapacityResult.Exception);
            }

            try
            {
                foreach (var staticData in staticDataResult.Output)
                {
                    var fulChargedCapacity = fullChargedCapacityResult.Output.First(x => x.Tag == staticData.Tag);
                    var win32battery = win32batteryResult.Output.First(x => x.DeviceID == staticData.UniqueID);
                    output.Add(BatteryMapper.From(fulChargedCapacity, win32battery, staticData));
                }

                return Result<IEnumerable<Battery>>.Ok(output);
            }
            catch(Exception e)
            {
                return Result<IEnumerable<Battery>>.Fail(e);
            }
        }

        public async Task<Result<IEnumerable<Battery>>> GetDesignedBatteriesAsync(Guid setId)
        {
            try
            {
                var output = await _batteryRepo.GetBySetIdAsync(setId);

                return Result<IEnumerable<Battery>>.Ok(output);
            }
            catch (Exception e)
            {
                return Result<IEnumerable<Battery>>.Fail(e);
            }
        }

        #endregion

        #region Private methods

        private async Task<Result<IEnumerable<T>>> GetPhysicalData<T>(Func<IEnumerable<T>> source)
        {
            try
            {
                var output = await Task.FromResult(source());

                return Result<IEnumerable<T>>.Ok(output);
            }
            catch (Exception e)
            {
                return Result<IEnumerable<T>>.Fail(e);
            }
        }

        #endregion
    }
}
