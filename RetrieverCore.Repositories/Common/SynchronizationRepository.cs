//using RetrieverCore.MasterDatabase.Context;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;
//using RetrieverCore.LocalDatabase;

//namespace RetrieverCore.Repositories.Common
//{
//    public class SynchronizationRepository
//    {
//        private readonly MasterDatabaseContext _masterContext;
//        private readonly LocalDatabaseContext _localContext;

//        public SynchronizationRepository(MasterDatabaseContext masterContext, LocalDatabaseContext localContext)
//        {
//            _masterContext = masterContext;
//            _localContext = localContext;
//        }

//        public async Task<IList<int>> GetDeltaAsync<TMaster, TLocal>()
//            where TMaster : MasterExtension
//            where TLocal : LocalExtension
//        {

//            return await ( from masterEntity in _masterContext.Set<TMaster>().AsNoTracking()
//                           join localEntity in _localContext.Set<TLocal>().AsNoTracking()
//                              on masterEntity.WMIID equals localEntity.WMIID
//                           where masterEntity.UpdateID != localEntity.UpdateID
//                           select masterEntity.WMIID )
//                     .ToListAsync();
//        }

//        public async Task<List<TMaster>> GetDiffEntiresAsync<TMaster>(IList<int> wmiids)
//            where TMaster : MasterExtension
//        {
//            return await _masterContext
//                .Set<TMaster>()
//                .AsNoTracking()
//                .Where(x => wmiids.Contains(x.WMIID))
//                .ToListAsync();
//        }

//        public async Task UpdateLocalDatabase<TMaster>(IList<TMaster> masterEntities, Dictionary<string, string> masterToLocalColumnMap)
//            where TMaster : MasterExtension
//        {

//        }
//    }
//}
