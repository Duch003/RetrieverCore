using RetrieverCore.CoreLogic.Interfaces;
using RetrieverCore.CoreLogic.Utlities;
using RetrieverCore.Extensions;
using RetrieverCore.Repositories.Interfaces;
using RetrieverCore.Models.Common;
using RetrieverCore.Models.Common.Win32Entieties;
using RetrieverCore.LocalDatabase.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RetrieverCore.CoreLogic.Services
{
    public class MainboardPortService : IMainboardPortService
    {
        private readonly IMainboardPortRepository _repository;

        public MainboardPortService(IMainboardPortRepository repository)
        {
            _repository = repository;
        }

        public async Task<Result<IEnumerable<CommonPortType>>> GetPhysicalMainboardPortsAsync()
        {
            var output = new List<CommonPortType>();

            try
            {
                var portConnectors = await _repository.GetWin32PortConnectorsAsync();
                if (Guard.IsEmptyOrAnyNull(portConnectors, out var epc))
                {
                    return Result<IEnumerable<CommonPortType>>.Fail(epc);
                }

                var serialPorts = await _repository.GetWin32SerialPortsAsync();
                if (Guard.IsEmptyOrAnyNull(serialPorts, out var esp))
                {
                    return Result<IEnumerable<CommonPortType>>.Fail(esp);
                }

                output.AddRange(portConnectors.ForEach(x => x.MapToCommon()));
                output.AddRange(serialPorts.ForEach(x => x.MapToCommon()));

                return Result<IEnumerable<CommonPortType>>.Ok(output);
            }
            catch (Exception e)
            {
                return Result<IEnumerable<CommonPortType>>.Fail(e);
            }
        }

        public async Task<Result<IEnumerable<MainboardPortEntity>>> GetDesignedMainboardPortsAsync(string model)
        {
            if (Guard.IsNullOrWhitespace(model, out var e))
            {
                return Result<IEnumerable<MainboardPortEntity>>.Fail(e);
            }

            try
            {
                var output = await _repository.GetDesignedMainboardPortsAsync(model);

                return Result<IEnumerable<MainboardPortEntity>>.Ok(output);
            }
            catch (Exception ex)
            {
                return Result<IEnumerable<MainboardPortEntity>>.Fail(ex);
            }
        }
    }
}
