using GathererEngine.Models;
using RetrieverCore.CoreLogic.Interfaces;
using RetrieverCore.CoreLogic.Utlities;
using RetrieverCore.Extensions;
using RetrieverCore.LocalDatabase.Models;
using RetrieverCore.Models.Common;
using RetrieverCore.Models.Common.Win32Entieties;
using RetrieverCore.Models.ComputerComponents.Physical;
using RetrieverCore.Models.ComputerComponents.Virtual;
using RetrieverCore.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetrieverCore.CoreLogic.Services
{
    public class StorageService : IStorageService
    {
        private readonly IStorageRepository _repository;

        public StorageService(IStorageRepository repository)
        {
            _repository = repository;
        }

        public async Task<Result<IEnumerable<StorageEntity>>> GetDesignedStorages(string model)
        {
            if (Guard.IsNullOrWhitespace(model, out var e))
            {
                return Result<IEnumerable<StorageEntity>>.Fail(e);
            }

            try
            {
                var result = await _repository.GetDesignedStoragesAsync(model);

                return Result<IEnumerable<StorageEntity>>.Ok(result);
            }
            catch (Exception ex)
            {
                return Result<IEnumerable<StorageEntity>>.Fail(ex);
            }
        }

        public async Task<Result<IEnumerable<StorageComponent>>> GetPhysicalStoragesAsync()
        {
            var output = new List<StorageComponent>();

            var win32DiskDrives = await GetWin32DiskDrivesAsync();
            if (!win32DiskDrives.IsSuccess)
            {
                return Result<IEnumerable<StorageComponent>>.Fail(win32DiskDrives.Exception);
            }
            if (win32DiskDrives.IsSuccess && !win32DiskDrives.Output.Any())
            {
                return Result<IEnumerable<StorageComponent>>.Ok(output);
            }

            var win32DiskPartitions = await GetWin32DiskPartitionsAsync();
            if (!win32DiskPartitions.IsSuccess || !win32DiskPartitions.Output.Any())
            {
                return Result<IEnumerable<StorageComponent>>.Fail(win32DiskPartitions.Exception);
            }

            var win32DiskDriveToDiskPartitions = await GetWin32DiskDriveToDiskPartitionsAsync();
            if (!win32DiskDriveToDiskPartitions.IsSuccess || !win32DiskDriveToDiskPartitions.Output.Any())
            {
                return Result<IEnumerable<StorageComponent>>.Fail(win32DiskDriveToDiskPartitions.Exception);
            }

            var win32LogicalDiscsToPartitions = await GetWin32LogicalDiscsToPartitionsAsync();
            if (!win32LogicalDiscsToPartitions.IsSuccess || !win32LogicalDiscsToPartitions.Output.Any())
            {
                return Result<IEnumerable<StorageComponent>>.Fail(win32LogicalDiscsToPartitions.Exception);
            }

            var win32LogicalDiscs = await GetWin32LogicalDiscsAsync();
            if (!win32LogicalDiscs.IsSuccess || !win32LogicalDiscs.Output.Any())
            {
                return Result<IEnumerable<StorageComponent>>.Fail(win32LogicalDiscs.Exception);
            }

            var msftPhysicalDiscs = await GetMSFTPhysicalDiscsAsync();
            if (!msftPhysicalDiscs.IsSuccess || !msftPhysicalDiscs.Output.Any())
            {
                return Result<IEnumerable<StorageComponent>>.Fail(msftPhysicalDiscs.Exception);
            }

            var mappings = RelateObjects(win32DiskDriveToDiskPartitions.Output, win32LogicalDiscsToPartitions.Output);
            if (!mappings.IsSuccess || !mappings.Output.Any())
            {
                return Result<IEnumerable<StorageComponent>>.Fail(mappings.Exception);
            }

            try
            {
                foreach (var mapping in mappings.Output)
                {
                    var diskDrive = win32DiskDrives.Output.First(x => x.DeviceID == mapping.Key);
                    var msftPhysicalDisk = msftPhysicalDiscs.Output.FirstOrDefault(x => x.Model == diskDrive.Model);
                    var diskPartitions = new List<DiskPartition>();

                    foreach (var pair in mapping)
                    {
                        var partition = win32DiskPartitions.Output.First(x => x.DeviceID == pair.DiskPartition);
                        var logicalDisk = win32LogicalDiscs.Output.FirstOrDefault(x => x.DeviceID == pair.LogicalDisk);
                        diskPartitions.Add(partition.ToDiskPartition(logicalDisk));
                    }

                    output.Add(diskDrive.ToStorageComponent(msftPhysicalDisk, diskPartitions));
                }
            }
            catch (Exception e)
            {
                return Result<IEnumerable<StorageComponent>>.Fail(e);
            }

            return Result<IEnumerable<StorageComponent>>.Ok(output);
        }

        private Result<IEnumerable<IGrouping<string, DiskMapping>>> RelateObjects(IEnumerable<Win32_DiskDriveToDiskPartition> drivesToPartitions,
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
                          DiskDrive = _diskDriveToDiskPartition.DiskDrive,
                          DiskPartition = _diskDriveToDiskPartition.DiskPartition,
                          LogicalDisk = _logicalDiskToDiskPartition.LogicalDisk
                      } )
                    .GroupBy(key => key.DiskDrive)
                    .ToList();
                return Result<IEnumerable<IGrouping<string, DiskMapping>>>.Ok(result);
            }
            catch (Exception e)
            {
                return Result<IEnumerable<IGrouping<string, DiskMapping>>>.Fail(e);
            }
        }

        private async Task<Result<IEnumerable<Win32_DiskDrive>>> GetWin32DiskDrivesAsync()
        {
            try
            {
                var output = await _repository.GetWin32DiskDrivesAsync();

                if (Guard.IsNull(output, out var e))
                {
                    return Result<IEnumerable<Win32_DiskDrive>>.Fail(e);
                }

                return Result<IEnumerable<Win32_DiskDrive>>.Ok(output);
            }
            catch (Exception ex)
            {
                return Result<IEnumerable<Win32_DiskDrive>>.Fail(ex);
            }
        }

        private async Task<Result<IEnumerable<Win32_DiskPartition>>> GetWin32DiskPartitionsAsync()
        {
            try
            {
                var output = await _repository.GetWin32DiskPartitionsAsync();

                if (Guard.IsEmptyOrAnyNull(output, out var e))
                {
                    return Result<IEnumerable<Win32_DiskPartition>>.Fail(e);
                }

                return Result<IEnumerable<Win32_DiskPartition>>.Ok(output);
            }
            catch (Exception ex)
            {
                return Result<IEnumerable<Win32_DiskPartition>>.Fail(ex);
            }
        }

        private async Task<Result<IEnumerable<Win32_DiskDriveToDiskPartition>>> GetWin32DiskDriveToDiskPartitionsAsync()
        {
            try
            {
                var output = await _repository.GetWin32DiskDriveToDiskPartitionsAsync();

                if (Guard.IsEmptyOrAnyNull(output, out var e))
                {
                    return Result<IEnumerable<Win32_DiskDriveToDiskPartition>>.Fail(e);
                }

                return Result<IEnumerable<Win32_DiskDriveToDiskPartition>>.Ok(output);
            }
            catch (Exception ex)
            {
                return Result<IEnumerable<Win32_DiskDriveToDiskPartition>>.Fail(ex);
            }
        }

        private async Task<Result<IEnumerable<Win32_LogicalDiskToPartition>>> GetWin32LogicalDiscsToPartitionsAsync()
        {
            try
            {
                var output = await _repository.GetWin32LogicalDiscsToPartitionsAsync();

                if (Guard.IsEmptyOrAnyNull(output, out var e))
                {
                    return Result<IEnumerable<Win32_LogicalDiskToPartition>>.Fail(e);
                }

                return Result<IEnumerable<Win32_LogicalDiskToPartition>>.Ok(output);
            }
            catch (Exception ex)
            {
                return Result<IEnumerable<Win32_LogicalDiskToPartition>>.Fail(ex);
            }
        }

        private async Task<Result<IEnumerable<Win32_LogicalDisk>>> GetWin32LogicalDiscsAsync()
        {
            try
            {
                var output = await _repository.GetWin32LogicalDiscsAsync();

                if (Guard.IsEmptyOrAnyNull(output, out var e))
                {
                    return Result<IEnumerable<Win32_LogicalDisk>>.Fail(e);
                }

                return Result<IEnumerable<Win32_LogicalDisk>>.Ok(output);
            }
            catch (Exception ex)
            {
                return Result<IEnumerable<Win32_LogicalDisk>>.Fail(ex);
            }
        }

        private async Task<Result<IEnumerable<MSFT_PhysicalDisk>>> GetMSFTPhysicalDiscsAsync()
        {
            try
            {
                var output = await _repository.GetMSFTPhysicalDiscsAsync();

                if (Guard.IsEmptyOrAnyNull(output, out var e))
                {
                    return Result<IEnumerable<MSFT_PhysicalDisk>>.Fail(e);
                }

                return Result<IEnumerable<MSFT_PhysicalDisk>>.Ok(output);
            }
            catch (Exception ex)
            {
                return Result<IEnumerable<MSFT_PhysicalDisk>>.Fail(ex);
            }
        }
    }
}
