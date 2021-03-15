using GathererEngine.Models;
using System.Collections.Generic;

namespace RetrieverCore.TestDataGenerator.WindowsEntities
{
    public static class Win32_ProcessorFactory
    {
        public static List<Win32_Processor> GetForProcessorServiceTests()
        {
            var output = new List<Win32_Processor>();

            output.Add(new Win32_Processor
            {
                Architecture = 9,
                CurrentClockSpeed = 2496,
                L2CacheSize = 1024,
                L3CacheSize = 8192,
                Manufacturer = "GenuineIntel",
                Name = "Intel(R) Core(TM) i5-8400H CPU @ 2.50GHz",
                NumberOfCores = 4,
                NumberOfLogicalProcessors = 8,
                SocketDesignation = "U3E1"
            });
            output.Add(new Win32_Processor
            {
                Architecture = 9,
                CurrentClockSpeed = 2801,
                L2CacheSize = 1024,
                L3CacheSize = 6144,
                Manufacturer = "GenuineIntel",
                Name = "Intel(R) Core(TM) i5-7440HQ CPU @ 2.80GHz",
                NumberOfCores = 4,
                NumberOfLogicalProcessors = 4,
                SocketDesignation = "U3E1"
            });
            output.Add(new Win32_Processor
            {
                Architecture = 9,
                CurrentClockSpeed = 2295,
                L2CacheSize = 256,
                L3CacheSize = 3072,
                Manufacturer = "GenuineIntel",
                Name = "Intel(R) Core(TM) i5-5300U CPU @ 2.30GHz",
                NumberOfCores = 2,
                NumberOfLogicalProcessors = 4,
                SocketDesignation = "SOCKET 0"
            });
            output.Add(new Win32_Processor
            {
                Architecture = 9,
                CurrentClockSpeed = 400,
                L2CacheSize = 1024,
                L3CacheSize = 6144,
                Manufacturer = "GenuineIntel",
                Name = "Intel(R) Core(TM) i5-8265U CPU @ 1.60GHz",
                NumberOfCores = 4,
                NumberOfLogicalProcessors = 8,
                SocketDesignation = "U3E1"
            });

            return output;
        }
    }
}
