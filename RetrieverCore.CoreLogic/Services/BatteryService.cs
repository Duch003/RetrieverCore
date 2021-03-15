using Microsoft.Extensions.Configuration;
using RetrieverCore.CoreLogic.Interfaces;
using RetrieverCore.CoreLogic.Mappers;
using RetrieverCore.CoreLogic.Utlities;
using RetrieverCore.Repositories.Interfaces;
using RetrieverCore.Models.Common;
using RetrieverCore.Models.ComputerComponents.Physical;
using RetrieverCore.LocalDatabase.Models;
using GathererEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetrieverCore.CoreLogic.Services
{
    public class BatteryService : IBatteryService
    {
        private readonly IConfiguration _configuration;
        private readonly IBatteryRepository _batteryRepository;

        public BatteryService(IConfiguration configuration, IBatteryRepository batteryRepository)
        {
            _configuration = configuration;
            _batteryRepository = batteryRepository;
        }

        #region Public methods

        public async Task<Result<IEnumerable<BatteryComponent>>> GetPhysicalBatteriesAsync()
        {
            var output = new List<BatteryComponent>();

            var staticDataResult = await Task.Run(() => GetBatteriesStaticDataAsync());
            if (!staticDataResult.IsSuccess || !staticDataResult.Output.Any())
            {
                return Result<IEnumerable<BatteryComponent>>.Fail(staticDataResult.Exception);
            }

            foreach (var staticData in staticDataResult.Output)
            {
                if (!staticData.Tag.HasValue || string.IsNullOrWhiteSpace(staticData.UniqueID))
                {
                    var invalidBattery = new BatteryComponent(double.NaN, double.NaN, -1, double.NaN);
                    invalidBattery.Messages.Add($"Could not match battery static data with related instances: Tag: {staticData.Tag ?? null}, UniqueID: {staticData.UniqueID}.");
                    output.Add(invalidBattery);
                    continue;
                }

                var win32batteryResult = await Task.Run(() => GetWin32BatteryAsync(staticData.UniqueID));
                if (!win32batteryResult.IsSuccess)
                {
                    return Result<IEnumerable<BatteryComponent>>.Fail(win32batteryResult.Exception);
                }

                var fullChargedCapacityResult = await Task.Run(() => GetBatteryFullChargedCapacityAsync(staticData.Tag));
                if (!fullChargedCapacityResult.IsSuccess)
                {
                    return Result<IEnumerable<BatteryComponent>>.Fail(fullChargedCapacityResult.Exception);
                }

                output.Add(BatteryComponentMapper.From(fullChargedCapacityResult.Output, win32batteryResult.Output, staticData));
            }

            return Result<IEnumerable<BatteryComponent>>.Ok(output);
        }

        public async Task<Result<IEnumerable<BatteryComponent>>> GetDesignedBatteriesAsync(string model)
        {
            if (Guard.IsNullOrWhitespace(model, out var error))
            {
                return Result<IEnumerable<BatteryComponent>>.Fail(error);
            }

            var maxWearLevel = _configuration.GetValue<double?>("MaxWearLevel");
            if (!maxWearLevel.HasValue)
            {
                return Result<IEnumerable<BatteryComponent>>
                    .Fail(new Exception("MaxWearLevel unreadable from configuration."));
            }

            var result = await GetData(model);
            if (!result.IsSuccess)
            {
                return Result<IEnumerable<BatteryComponent>>
                    .Fail(new Exception("No record found in database.", result.Exception));
            }

            var output = new List<BatteryComponent>();
            foreach (var battery in result.Output)
            {
                output.Add(BatteryComponentMapper.From(battery, maxWearLevel.Value));
            }

            return Result<IEnumerable<BatteryComponent>>.Ok(output);
        }

        #endregion

        #region Private methods

        private async Task<Result<IEnumerable<BatteryEntity>>> GetData(string model)
        {
            try
            {
                var output = await _batteryRepository.GetDesignedBatteriesAsync(model);

                return Result<IEnumerable<BatteryEntity>>.Ok(output);
            }
            catch (Exception e)
            {
                return Result<IEnumerable<BatteryEntity>>.Fail(e);
            }
        }

        private async Task<Result<BatteryFullChargedCapacity>> GetBatteryFullChargedCapacityAsync(uint? tag)
        {
            try
            {
                var output = await _batteryRepository.GetBatteryFullChargedCapacityAsync(tag.Value);

                if (Guard.IsNull(output, out var e))
                {
                    return Result<BatteryFullChargedCapacity>.Fail(e);
                }

                return Result<BatteryFullChargedCapacity>.Ok(output);
            }
            catch (Exception e)
            {
                return Result<BatteryFullChargedCapacity>.Fail(e);
            }
        }

        private async Task<Result<Win32_Battery>> GetWin32BatteryAsync(string deviceId)
        {
            try
            {
                var output = await _batteryRepository.GetWin32BatteryAsync(deviceId);

                if (Guard.IsNull(output, out var e))
                {
                    return Result<Win32_Battery>.Fail(e);
                }

                return Result<Win32_Battery>.Ok(output);
            }
            catch (Exception e)
            {
                return Result<Win32_Battery>.Fail(e);
            }
        }

        private async Task<Result<IEnumerable<BatteryStaticData>>> GetBatteriesStaticDataAsync()
        {
            try
            {
                var output = await _batteryRepository.GetBatteriesStaticDataAsync();

                if (Guard.IsEmptyOrAnyNull(output, out var e))
                {
                    return Result<IEnumerable<BatteryStaticData>>.Fail(e);
                }

                return Result<IEnumerable<BatteryStaticData>>.Ok(output);
            }
            catch (Exception e)
            {
                return Result<IEnumerable<BatteryStaticData>>.Fail(e);
            }
        }

        #endregion
    }
}
