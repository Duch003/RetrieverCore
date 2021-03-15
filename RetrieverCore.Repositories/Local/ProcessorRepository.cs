using Microsoft.EntityFrameworkCore;
using RetrieverCore.MasterDatabase.Context;
using RetrieverCore.Repositories.Interfaces;
using RetrieverCore.LocalDatabase.Models;
using GathererEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RetrieverCore.LocalDatabase;
using GathererEngine;

namespace RetrieverCore.Repositories.Local
{
    public class ProcessorRepository : IProcessorRepository
    {
        private readonly LocalDatabaseContext _localContext;
        private readonly IGathererEngine _gathererEngine;

        public ProcessorRepository(LocalDatabaseContext localContext, IGathererEngine gathererEngine)
        {
            _localContext = localContext;
            _gathererEngine = gathererEngine;
        }

        public async Task<IEnumerable<ProcessorEntity>> GetDesignedProcessors(string model)
        {
            return await Task.Run(() => _localContext.Computers
                .Include(x => x.Processors)
                .Where(x => string.Equals(x.Model, model, StringComparison.InvariantCultureIgnoreCase))
                .SelectMany(x => x.Processors)
                .AsEnumerable());
        }

        public async Task<IEnumerable<Win32_Processor>> GetWin32Processors()
        {
            return await Task.Run(() => _gathererEngine.GatherDeviceData<Win32_Processor>(Win32_Processor.Scope));
        }
    }
}
