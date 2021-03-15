using GathererEngine;
using GathererEngine.Models;
using Microsoft.EntityFrameworkCore;
using RetrieverCore.LocalDatabase;
using RetrieverCore.LocalDatabase.Models;
using RetrieverCore.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetrieverCore.Repositories.Local
{
    public class StorageRepository : IStorageRepository
    {
        private readonly LocalDatabaseContext _localContext;
        private readonly IGathererEngine _gathererEngine;

        public StorageRepository(LocalDatabaseContext localContext, IGathererEngine gathererEngine)
        {
            _localContext = localContext;
            _gathererEngine = gathererEngine;
        }

        public async Task<IEnumerable<StorageEntity>> GetDesignedStoragesAsync(string model)
        {
            return await _localContext.Computers
                .Include(x => x.Storages)
                .Where(x => string.Equals(x.Model, model, StringComparison.InvariantCultureIgnoreCase))
                .SelectMany(x => x.Storages)
                .ToListAsync();
        }

        public async Task<IEnumerable<Win32_DiskDriveToDiskPartition>> GetWin32DiskDriveToDiskPartitionsAsync()
        {
            return await Task.Run(() => _gathererEngine.GatherDeviceData<Win32_DiskDriveToDiskPartition>(Win32_DiskDriveToDiskPartition.Scope)
                .AsEnumerable());
        }

        public async Task<IEnumerable<Win32_DiskPartition>> GetWin32DiskPartitionsAsync()
        {
            return await Task.Run(() => _gathererEngine.GatherDeviceData<Win32_DiskPartition>(Win32_DiskPartition.Scope)
                .AsEnumerable());
        }

        public async Task<IEnumerable<Win32_DiskDrive>> GetWin32DiskDrivesAsync()
        {
            return await Task.Run(() => _gathererEngine.GatherDeviceData<Win32_DiskDrive>(Win32_DiskDrive.Scope)
                .AsEnumerable());
        }

        public async Task<IEnumerable<Win32_LogicalDiskToPartition>> GetWin32LogicalDiscsToPartitionsAsync()
        {
            return await Task.Run(() => _gathererEngine.GatherDeviceData<Win32_LogicalDiskToPartition>(Win32_LogicalDiskToPartition.Scope)
                .AsEnumerable());
        }

        public async Task<IEnumerable<Win32_LogicalDisk>> GetWin32LogicalDiscsAsync()
        {
            return await Task.Run(() => _gathererEngine.GatherDeviceData<Win32_LogicalDisk>(Win32_LogicalDisk.Scope)
                .AsEnumerable());
        }

        public async Task<IEnumerable<MSFT_PhysicalDisk>> GetMSFTPhysicalDiscsAsync()
        {
            return await Task.Run(() => _gathererEngine.GatherDeviceData<MSFT_PhysicalDisk>(MSFT_PhysicalDisk.Scope)
                .AsEnumerable());
        }
    }
}
