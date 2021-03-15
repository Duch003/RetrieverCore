using RetrieverCore.LocalDatabase.Models;
using System.Collections.Generic;

namespace RetrieverCore.TestDataGenerator.Database
{
    public static class GPUEntityFactory
    {
        public static List<GPUEntity> GetForGPUServiceTests()
        {
            var output = new List<GPUEntity>();

            output.Add(new GPUEntity
            {
                Manufacturer = "Intel Corporation",
                MemorySize = 1073741824,
                Model = "Intel(R) UHD Graphics 630",
                ScreenHeight = 1080,
                ScreenWidth = 1920
            });
            output.Add(new GPUEntity
            {
                Manufacturer = "NVIDIA",
                MemorySize = 2147483648,
                Model = "NVIDIA GeForce 830M",
                ScreenHeight = 1080,
                ScreenWidth = 1920
            });
            output.Add(new GPUEntity
            {
                Manufacturer = "Advanced Micro Devices, Inc.",
                MemorySize = 1073741824,
                Model = "AMD Radeon(TM) R5 M330",
                ScreenHeight = 1080,
                ScreenWidth = 1920
            });
            output.Add(new GPUEntity
            {
                Manufacturer = "Intel Corporation",
                MemorySize = 1073741824,
                Model = "Intel(R) HD Graphics 5500",
                ScreenHeight = 768,
                ScreenWidth = 1366
            });

            return output;
        }
    }
}
