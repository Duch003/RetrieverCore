using RetrieverCore.Common.Models;
using RetrieverCore.CoreLogic.Interfaces;
using RetrieverCore.CoreLogic.Mappers;
using RetrieverCore.Models.Common;
using RetrieverCore.Models.WMIEntieties;
using RetrieverCore.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetrieverCore.CoreLogic.Services
{
    public class StorageService : IStorageService
    {
        private readonly IGenericDatabaseRepository<Storage> _storageRepo;
        private readonly IGenericComponentRepository _componentRepo;

        public StorageService(IGenericDatabaseRepository<Storage> storageRepo, IGenericComponentRepository componentRepo)
        {
            _storageRepo = storageRepo;
            _componentRepo = componentRepo;
        }

        public async Task<Result<IEnumerable<Storage>>> GetDesignedStoragesAsync(Guid setId)
        {
            try
            {
                var result = await _storageRepo.GetBySetIdAsync(setId);

                return Result<IEnumerable<Storage>>.Ok(result);
            }
            catch (Exception e)
            {
                return Result<IEnumerable<Storage>>.Fail(e);
            }
        }

        public async Task<Result<IEnumerable<Storage>>> GetPhysicalStoragesAsync()
        {
            var output = new List<Storage>();

            var win32DiskDrives = await GetPhysicalData(() => _componentRepo.Get<Win32_DiskDrive>());
            if (!win32DiskDrives.IsSuccess)
            {
                return Result<IEnumerable<Storage>>.Fail(win32DiskDrives.Exception);
            }

            var win32DiskPartitions = await GetPhysicalData(() => _componentRepo.Get<Win32_DiskPartition>());
            if (!win32DiskPartitions.IsSuccess)
            {
                return Result<IEnumerable<Storage>>.Fail(win32DiskPartitions.Exception);
            }

            var win32DiskDriveToDiskPartitions = await GetPhysicalData(() => _componentRepo.Get<Win32_DiskDriveToDiskPartition>());
            if (!win32DiskDriveToDiskPartitions.IsSuccess)
            {
                return Result<IEnumerable<Storage>>.Fail(win32DiskDriveToDiskPartitions.Exception);
            }

            var win32LogicalDiscsToPartitions = await GetPhysicalData(() => _componentRepo.Get<Win32_LogicalDiskToPartition>());
            if (!win32LogicalDiscsToPartitions.IsSuccess)
            {
                return Result<IEnumerable<Storage>>.Fail(win32LogicalDiscsToPartitions.Exception);
            }

            var win32LogicalDiscs = await GetPhysicalData(() => _componentRepo.Get<Win32_LogicalDisk>());
            if (!win32LogicalDiscs.IsSuccess)
            {
                return Result<IEnumerable<Storage>>.Fail(win32LogicalDiscs.Exception);
            }

            var msftPhysicalDiscs = await GetPhysicalData(() => _componentRepo.Get<MSFT_PhysicalDisk>());
            if (!msftPhysicalDiscs.IsSuccess)
            {
                return Result<IEnumerable<Storage>>.Fail(msftPhysicalDiscs.Exception);
            }

            var mappings = RelateObjects(win32DiskDriveToDiskPartitions.Output, win32LogicalDiscsToPartitions.Output);
            if (!mappings.IsSuccess)
            {
                return Result<IEnumerable<Storage>>.Fail(mappings.Exception);
            }

            try
            {
                foreach (var mapGroup in mappings.Output.GroupBy(x => x.DiskDrive).ToList())
                {
                    var diskDrive = win32DiskDrives.Output.First(x => x.DeviceID == mapGroup.Key);
                    var msftPhysicalDisk = msftPhysicalDiscs.Output.First(x => x.Model == diskDrive.Model);
                    
                    var diskPartitions = new List<Partition>();

                    foreach (var mapping in mapGroup)
                    {
                        var diskPartition = win32DiskPartitions.Output.First(x => x.DeviceID == mapping.DiskPartition);
                        var logicalDisk = win32LogicalDiscs.Output.FirstOrDefault(x => x.DeviceID == mapping.LogicalDisk);
                        
                        diskPartitions.Add(PartitionMapper.From(diskPartition, logicalDisk));
                    }

                    output.Add(StorageMapper.From(diskDrive, msftPhysicalDisk, diskPartitions));
                }

                return Result<IEnumerable<Storage>>.Ok(output);
            }
            catch (Exception e)
            {
                return Result<IEnumerable<Storage>>.Fail(e);
            }
        }

        private Result<IEnumerable<DiskMapping>> RelateObjects(IEnumerable<Win32_DiskDriveToDiskPartition> drivesToPartitions,
            IEnumerable<Win32_LogicalDiskToPartition> logicalDiscsToPartitions)
        {
            try
            {
                var result =
                    ( from _diskDriveToDiskPartition in drivesToPartitions
                         .Select(x => new
                         {
                             DiskDrive = x.Antecedent.Split("Win32_DiskDrive.DeviceID=\"").Last().Replace("\"", ""), // "\\\\.\\PHYSICALDRIVE0"
                             DiskPartition = x.Dependent.Split("Win32_DiskPartition.DeviceID=\"").Last().Replace("\"", "") // "Disk #1, Partition #0"
                         })
                      join _logicalDiskToDiskPartition in logicalDiscsToPartitions
                          .Select(x => new
                          {
                              DiskPartition = x.Antecedent.Split("Win32_DiskPartition.DeviceID=\"").Last().Replace("\"", ""), // "Disk #1, Partition #0"
                              LogicalDisk = x.Dependent.Split("Win32_LogicalDisk.DeviceID=\"").Last().Replace("\"", "") // "C:"
                          })
                      on _diskDriveToDiskPartition.DiskPartition equals _logicalDiskToDiskPartition.DiskPartition
                      select new DiskMapping
                      {
                          DiskDrive = _diskDriveToDiskPartition.DiskDrive,          // "\\\\.\\PHYSICALDRIVE0"
                          DiskPartition = _diskDriveToDiskPartition.DiskPartition,  // "Disk #1, Partition #0"
                          LogicalDisk = _logicalDiskToDiskPartition.LogicalDisk     // "C:"
                      } )
                    .ToList();
                return Result<IEnumerable<DiskMapping>>.Ok(result);
            }
            catch (Exception e)
            {
                return Result<IEnumerable<DiskMapping>>.Fail(e);
            }
        }

        private async Task<Result<IEnumerable<T>>> GetPhysicalData<T>(Func<IEnumerable<T>> source)
        {
            try
            {
                var output = await Task.Run(() => source());

                return Result<IEnumerable<T>>.Ok(output);
            }
            catch (Exception e)
            {
                return Result<IEnumerable<T>>.Fail(e);
            }
        }
    }
}
