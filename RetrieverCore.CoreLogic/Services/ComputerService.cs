using RetrieverCore.CoreLogic.Interfaces;
using RetrieverCore.Repositories.Interfaces;
using RetrieverCore.Models.Common;
using System;
using System.Threading.Tasks;
using Databases.RetrieverCore.Common.Models;
using System.Collections.Generic;
using RetrieverCore.Models.WMIEntieties;
using RetrieverCore.CoreLogic.Mappers;
using System.Linq;

namespace RetrieverCore.CoreLogic.Services
{
    public class ComputerService : IComputerService
    {
        private readonly IGenericDatabaseRepository<Computer> _computerRepo;
        private readonly IGenericComponentRepository _componentRepo;

        public ComputerService(IGenericDatabaseRepository<Computer> computerRepo, IGenericComponentRepository componentRepo)
        {
            _computerRepo = computerRepo;
            _componentRepo = componentRepo;
        }

        public async Task<Result<IEnumerable<Computer>>> GetDesignedComputersAsync()
        {
            try
            {
                var result = await _computerRepo.GetAsync(x => !x.Deleted);

                return Result<IEnumerable<Computer>>.Ok(result);
            }
            catch (Exception e)
            {
                return Result<IEnumerable<Computer>>.Fail(e);
            }
        }

        public async Task<Result<IEnumerable<Computer>>> GetPhysicalComputersAsync()
        {
            try
            {
                var result = await Task.Run(() => _componentRepo.Get<Win32_ComputerSystem>());
                var output = result.Select(x => ComputerMapper.From(x)).ToList();

                return Result<IEnumerable<Computer>>.Ok(output);
            }
            catch (Exception e)
            {
                return Result<IEnumerable<Computer>>.Fail(e);
            }
        }
    }
}
