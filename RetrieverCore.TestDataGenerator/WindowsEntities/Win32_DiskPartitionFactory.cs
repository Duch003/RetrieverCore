using GathererEngine.Models;
using System.Collections.Generic;

namespace RetrieverCore.TestDataGenerator.WindowsEntities
{
    public static class Win32_DiskPartitionFactory
    {
        public static Win32_DiskPartition GetForDiskPartitionExtensionTests()
        {
            var output = new Win32_DiskPartition
            {
                Bootable = true,
                BootPartition = true,
                PrimaryPartition = true,
                Size = 1000202273280,
                Description = "GPT: System",
                Type = "GPT: System"
            };

            return output;
        }

        public static List<Win32_DiskPartition> GetForStorageServiceTests()
        {
            var output = new List<Win32_DiskPartition>();

            output.Add(new Win32_DiskPartition
            {
                DeviceID = "Disk #0, Partition #0",
                Bootable = true,
                BootPartition = true,
                PrimaryPartition = true,
                Size = 1000202273280,
                Description = "GPT: System",
                Type = "GPT: System"
            });
            output.Add(new Win32_DiskPartition
            {
                DeviceID = "Disk #0, Partition #1",
                Bootable = true,
                BootPartition = false,
                PrimaryPartition = false,
                Size = 999545634816,
                Description = "GPT: Basic Data",
                Type = "GPT: Basic Data"
            });
            output.Add(new Win32_DiskPartition
            {
                DeviceID = "Disk #0, Partition #2",
                Bootable = false,
                BootPartition = false,
                PrimaryPartition = false,
                Size = 588251136,
                Description = "Unknown",
                Type = "Unknown"
            });
            output.Add(new Win32_DiskPartition
            {
                DeviceID = "Disk #1, Partition #0",
                Bootable = false,
                BootPartition = false,
                PrimaryPartition = false,
                Size = 4996464640,
                Description = "GPT: Unknown",
                Type = "GPT: Unknown"
            });
            output.Add(new Win32_DiskPartition
            {
                DeviceID = "Disk #2, Partition #0",
                Bootable = false,
                BootPartition = false,
                PrimaryPartition = true,
                Size = 2560622592,
                Description = "GPT: Basic Data",
                Type = "GPT: Basic Data"
            });

            return output;
        }
    }
}
