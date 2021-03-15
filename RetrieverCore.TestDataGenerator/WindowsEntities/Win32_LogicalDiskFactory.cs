using GathererEngine.Models;
using System.Collections.Generic;

namespace RetrieverCore.TestDataGenerator.WindowsEntities
{
    public static class Win32_LogicalDiskFactory
    {
        public static Win32_LogicalDisk GetForDiskPartitionExtensionTests()
        {
            var output = new Win32_LogicalDisk
            {
                FileSystem = "NTFS",
                MediaType = 12,
                VolumeName = "Windows"
            };

            return output;
        }

        public static List<Win32_LogicalDisk> GetForStorageServiceTests()
        {
            var output = new List<Win32_LogicalDisk>();
            
            output.Add(new Win32_LogicalDisk 
            {
                DeviceID = "C:",
                FileSystem = "NTFS",
                MediaType = 12,
                VolumeName = "Windows"
            });
            output.Add(new Win32_LogicalDisk
            {
                DeviceID = "D:",
                FileSystem = null,
                MediaType = 11,
                VolumeName = null
            });
            output.Add(new Win32_LogicalDisk
            {
                DeviceID = "E:",
                FileSystem = "FAT32",
                MediaType = null,
                VolumeName = "ESD-USB"
            });
            output.Add(new Win32_LogicalDisk
            {
                DeviceID = "F:",
                FileSystem = "FAT32",
                MediaType = null,
                VolumeName = "EFI"
            });

            return output;
        }
    }
}
