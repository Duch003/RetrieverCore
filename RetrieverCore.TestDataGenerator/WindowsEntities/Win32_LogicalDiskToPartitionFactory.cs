using GathererEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetrieverCore.TestDataGenerator.WindowsEntities
{
    public static class Win32_LogicalDiskToPartitionFactory
    {
        public static List<Win32_LogicalDiskToPartition> GetForStorageServiceTests()
        {
            var output = new List<Win32_LogicalDiskToPartition>();

            output.Add(new Win32_LogicalDiskToPartition
            {
                Antecedent = "\\\\DUCH003\\root\\cimv2:Win32_DiskPartition.DeviceID=\"Disk #0, Partition #0\"",
                Dependent = "\\\\DUCH003\\root\\cimv2:Win32_LogicalDisk.DeviceID=\"C:\""
            });
            output.Add(new Win32_LogicalDiskToPartition
            {
                Antecedent = "\\\\DUCH003\\root\\cimv2:Win32_DiskPartition.DeviceID=\"Disk #0, Partition #1\"",
                Dependent = "\\\\DUCH003\\root\\cimv2:Win32_LogicalDisk.DeviceID=\"D:\""
            });
            output.Add(new Win32_LogicalDiskToPartition
            {
                Antecedent = "\\\\DUCH003\\root\\cimv2:Win32_DiskPartition.DeviceID=\"Disk #1, Partition #0\"",
                Dependent = "\\\\DUCH003\\root\\cimv2:Win32_LogicalDisk.DeviceID=\"F:\""
            });
            output.Add(new Win32_LogicalDiskToPartition
            {
                Antecedent = "\\\\DUCH003\\root\\cimv2:Win32_DiskPartition.DeviceID=\"Disk #2, Partition #0\"",
                Dependent = "\\\\DUCH003\\root\\cimv2:Win32_LogicalDisk.DeviceID=\"G:\""
            });

            return output;
        }
    }
}
