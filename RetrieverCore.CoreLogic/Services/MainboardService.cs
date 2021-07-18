using RetrieverCore.CoreLogic.Interfaces;
using RetrieverCore.Repositories.Interfaces;
using RetrieverCore.Models.Common;
using Databases.RetrieverCore.Common.Models;
using System;
using System.Threading.Tasks;
using RetrieverCore.Models.WMIEntieties;
using RetrieverCore.CoreLogic.Mappers;
using System.Linq;

namespace RetrieverCore.CoreLogic.Services
{
    public class MainboardService : IMainboardService
    {
        private readonly IGenericDatabaseRepository<Mainboard> _mainboardRepo;
        private readonly IGenericComponentRepository _componentRepo;

        public MainboardService(IGenericDatabaseRepository<Mainboard> mainboardRepo, IGenericComponentRepository componentRepo)
        {
            _mainboardRepo = mainboardRepo;
            _componentRepo = componentRepo;
        }

        public async Task<Result<Mainboard>> GetDesignedMainboardAsync(Guid setId)
        {
            try
            {
                var result = await _mainboardRepo.SingleAsync(x => x.SetID == setId && !x.Deleted);

                return Result<Mainboard>.Ok(result);
            }
            catch (Exception e)
            {
                return Result<Mainboard>.Fail(e);
            }
        }

        public async Task<Result<Mainboard>> GetPhysicalMainboardAsync()
        {
            try
            {
                var baseBoards = await Task.Run(() => _componentRepo.Get<Win32_BaseBoard>());
                var motherboardDevice = await Task.Run(() => _componentRepo.Get<Win32_MotherboardDevice>());
                var output = MainboardMapper.From(baseBoards.Single(), motherboardDevice.Single());

                return Result<Mainboard>.Ok(output);
            }
            catch (Exception e)
            {
                return Result<Mainboard>.Fail(e);
            }
        }
    }
}
