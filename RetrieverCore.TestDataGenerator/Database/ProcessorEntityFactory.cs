using RetrieverCore.LocalDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetrieverCore.TestDataGenerator.Database
{
    public static class ProcessorEntityFactory
    {
        public static List<ProcessorEntity> GetFroProcessorServiceTests()
        {
            var output = new List<ProcessorEntity>();

            output.Add(new ProcessorEntity
            {
                ID = 0,
                Architecture = "x64",
                ClockSpeed = 2496,
                L2CacheSize = 1024,
                L3CacheSize = 8192,
                Manufacturer = "GenuineIntel",
                Model = "Intel(R) Core(TM) i5-8400H CPU @ 2.50GHz",
                Cores = 4,
                LogicalProcessors = 8,
                Socket = "U3E1"
            });
            output.Add(new ProcessorEntity
            {
                ID = 0,
                Architecture = "x64",
                ClockSpeed = 2801,
                L2CacheSize = 1024,
                L3CacheSize = 6144,
                Manufacturer = "GenuineIntel",
                Model = "Intel(R) Core(TM) i5-7440HQ CPU @ 2.80GHz",
                Cores = 4,
                LogicalProcessors = 4,
                Socket = "U3E1"
            });
            output.Add(new ProcessorEntity
            {
                ID = 0,
                Architecture = "x64",
                ClockSpeed = 2295,
                L2CacheSize = 256,
                L3CacheSize = 3072,
                Manufacturer = "GenuineIntel",
                Model = "Intel(R) Core(TM) i5-5300U CPU @ 2.30GHz",
                Cores = 2,
                LogicalProcessors = 4,
                Socket = "SOCKET 0"
            });
            output.Add(new ProcessorEntity
            {
                ID = 0,
                Architecture = "x64",
                ClockSpeed = 400,
                L2CacheSize = 1024,
                L3CacheSize = 6144,
                Manufacturer = "GenuineIntel",
                Model = "Intel(R) Core(TM) i5-8265U CPU @ 1.60GHz",
                Cores = 4,
                LogicalProcessors = 8,
                Socket = "U3E1"
            });

            return output;
        }
    }
}
