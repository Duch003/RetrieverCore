using GathererEngine.Models;
using System.Collections.Generic;

namespace RetrieverCore.TestDataGenerator.WindowsEntities
{
    public static class Win32_VideoControllerFactory
    {
        public static List<Win32_VideoController> GetForGPUServiceTests()
        {
            var output = new List<Win32_VideoController>();

            output.Add(new Win32_VideoController
            {
                AdapterCompatibility = "Intel Corporation",
                AdapterRAM = 1073741824,
                CurrentHorizontalResolution = 1920,
                CurrentVerticalResolution = 1080,
                Name = "Intel(R) UHD Graphics 630"
            });
            output.Add(new Win32_VideoController
            {
                AdapterCompatibility = "Microsoft",
                AdapterRAM = null,
                CurrentHorizontalResolution = 1920,
                CurrentVerticalResolution = 1080,
                Name = "Microsoft Remote Display Adapter"
            });
            output.Add(new Win32_VideoController
            {
                AdapterCompatibility = "NVIDIA",
                AdapterRAM = 2147483648,
                CurrentHorizontalResolution = 1920,
                CurrentVerticalResolution = 1080,
                Name = "NVIDIA GeForce 830M"
            });
            output.Add(new Win32_VideoController
            {
                AdapterCompatibility = "Advanced Micro Devices, Inc.",
                AdapterRAM = 2147483648,
                CurrentHorizontalResolution = 1920,
                CurrentVerticalResolution = 1080,
                Name = "AMD Radeon(TM) R5 M330"
            });
            output.Add(new Win32_VideoController
            {
                AdapterCompatibility = "Intel Corporation",
                AdapterRAM = 1073741824,
                CurrentHorizontalResolution = 1366,
                CurrentVerticalResolution = 768,
                Name = "Intel(R) HD Graphics 5500"
            });

            return output;
        }
    }
}
