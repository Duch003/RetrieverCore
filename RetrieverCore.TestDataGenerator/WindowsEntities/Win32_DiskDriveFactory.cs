using GathererEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetrieverCore.TestDataGenerator.WindowsEntities
{
    public static class Win32_DiskDriveFactory
    {
        public static List<Win32_DiskDrive> GetForStorageServiceTests()
        {
            var output = new List<Win32_DiskDrive>();

            output.Add(new Win32_DiskDrive
            {
                DeviceID = "\\\\.\\PHYSICALDRIVE0",
                Model = "KINGSTON SA400S37480G",
                Size = 1000202273280 + 999545634816,
                MediaType = "Fixed hard disk media",
                InterfaceType = "IDE",
                Caption = "KINGSTON SA400S37480G",
                CapabilityDescriptions = new string[] { "Random Access", "Supports Writing", "SMART Notification" },
            });
            output.Add(new Win32_DiskDrive
            {
                DeviceID = "\\\\.\\PHYSICALDRIVE1",
                Model = "LITEON LCH-256V2S-11 2.5 7mm 256GB",
                Size = 4996464640,
                MediaType = "Fixed hard disk media",
                InterfaceType = "IDE",
                Caption = "LITEON LCH-256V2S-11 2.5 7mm 256GB",
                CapabilityDescriptions = new string[] { "Random Access", "Supports Writing", "SMART Notification" },
            });
            output.Add(new Win32_DiskDrive
            {
                DeviceID = "\\\\.\\PHYSICALDRIVE2",
                Model = "USB Flash Memory USB Device",
                Size = 2560622592,
                MediaType = "Removable Media",
                InterfaceType = "USB",
                Caption = "USB Flash Memory USB Device",
                CapabilityDescriptions = new string[] { "Random Access", "Supports Writing", "Supports Removable Media" },
            });

            return output;
        }
    }
}
