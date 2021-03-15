using GathererEngine.Models;
using RetrieverCore.LocalDatabase.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RetrieverCore.Repositories.Interfaces
{
    public interface IStorageRepository
    {
        Task<IEnumerable<StorageEntity>> GetDesignedStoragesAsync(string model);
        Task<IEnumerable<Win32_DiskDrive>> GetWin32DiskDrivesAsync();
        Task<IEnumerable<Win32_DiskDriveToDiskPartition>> GetWin32DiskDriveToDiskPartitionsAsync();
        Task<IEnumerable<Win32_DiskPartition>> GetWin32DiskPartitionsAsync();
        Task<IEnumerable<Win32_LogicalDiskToPartition>> GetWin32LogicalDiscsToPartitionsAsync();
        Task<IEnumerable<Win32_LogicalDisk>> GetWin32LogicalDiscsAsync();

        Task<IEnumerable<MSFT_PhysicalDisk>> GetMSFTPhysicalDiscsAsync();
    }
}