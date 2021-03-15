using GathererEngine.Models;
using System.Collections.Generic;

namespace RetrieverCore.TestDataGenerator.WindowsEntities
{
    public static class Win32_DiskDriveToDiskPartitionFactory
    {
        public static List<Win32_DiskDriveToDiskPartition> GetForStorageServiceTests()
        {
            var output = new List<Win32_DiskDriveToDiskPartition>();

            output.Add(new Win32_DiskDriveToDiskPartition
            {
                Antecedent = "\\\\DUCH003\\root\\cimv2:Win32_DiskDrive.DeviceID=\"\\\\.\\PHYSICALDRIVE0\"",
                Dependent = "\\\\DUCH003\\root\\cimv2:Win32_DiskPartition.DeviceID=\"Disk #0, Partition #0\""
            });
            output.Add(new Win32_DiskDriveToDiskPartition
            {
                Antecedent = "\\\\DUCH003\\root\\cimv2:Win32_DiskDrive.DeviceID=\"\\\\.\\PHYSICALDRIVE0\"",
                Dependent = "\\\\DUCH003\\root\\cimv2:Win32_DiskPartition.DeviceID=\"Disk #0, Partition #1\""
            });
            output.Add(new Win32_DiskDriveToDiskPartition
            {
                Antecedent = "\\\\DUCH003\\root\\cimv2:Win32_DiskDrive.DeviceID=\"\\\\.\\PHYSICALDRIVE1\"",
                Dependent = "\\\\DUCH003\\root\\cimv2:Win32_DiskPartition.DeviceID=\"Disk #1, Partition #0\""
            });
            output.Add(new Win32_DiskDriveToDiskPartition
            {
                Antecedent = "\\\\DUCH003\\root\\cimv2:Win32_DiskDrive.DeviceID=\"\\\\.\\PHYSICALDRIVE2\"",
                Dependent = "\\\\DUCH003\\root\\cimv2:Win32_DiskPartition.DeviceID=\"Disk #2, Partition #0\""
            });

            return output;
        }
    }
}
