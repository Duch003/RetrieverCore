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
    public class DDRService : IDDRService
    {
        private readonly IGenericDatabaseRepository<DDR> _ddrRepo;
        private readonly IGenericComponentRepository _componentRepo;

        public DDRService(IGenericDatabaseRepository<DDR> ddrRepo, IGenericComponentRepository componentRepo)
        {
            _ddrRepo = ddrRepo;
            _componentRepo = componentRepo;
        }

        public async Task<Result<IEnumerable<DDR>>> GetDesignedDDRsAsync(Guid setId)
        {
            try
            {
                var result = await _ddrRepo.GetBySetIdAsync(setId);

                return Result<IEnumerable<DDR>>.Ok(result);
            }
            catch (Exception e)
            {
                return Result<IEnumerable<DDR>>.Fail(e);
            }
        }

        public async Task<Result<IEnumerable<DDR>>> GetPhysicalDDRsAsync()
        {
            try
            {
                var result = await Task.Run(() => _componentRepo.Get<Win32_PhysicalMemory>());
                var output = result.Select(x => DDRMapper.From(x)).ToList();

                return Result<IEnumerable<DDR>>.Ok(output);
            }
            catch (Exception e)
            {
                return Result<IEnumerable<DDR>>.Fail(e);
            }
        }
    }
}
