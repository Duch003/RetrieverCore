using GathererEngine.Models;
using System.Collections.Generic;

namespace RetrieverCore.TestDataGenerator.WindowsEntities
{
    public static class MSFT_PhysicalDiskFactory
    {
        public static List<MSFT_PhysicalDisk> GetForStorageServiceTests()
        {
            var output = new List<MSFT_PhysicalDisk>();

            output.Add(new MSFT_PhysicalDisk
            {
                Model = "KINGSTON SA400S37480G",
                MediaType = 4,
                BusType = 11
            });
            output.Add(new MSFT_PhysicalDisk
            {
                Model = "USB Flash Memory USB Device",
                MediaType = 3,
                BusType = 12
            });

            return output;
        }
    }
}
