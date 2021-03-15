using GathererEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetrieverCore.TestDataGenerator.WindowsEntities
{
    public static class Win32_PhysicalMemoryFactory
    {
        public static List<Win32_PhysicalMemory> GetForDDRServiceTests()
        {
            var output = new List<Win32_PhysicalMemory>();

            output.Add(new Win32_PhysicalMemory
            {
                Capacity = 8589934592,
                Speed = 2400,
                ConfiguredClockSpeed = 2400
            });
            output.Add(new Win32_PhysicalMemory
            {
                Capacity = 17179869184,
                Speed = 2667,
                ConfiguredClockSpeed = 2667
            });
            output.Add(new Win32_PhysicalMemory
            {
                Capacity = 8589934592,
                Speed = 2667,
                ConfiguredClockSpeed = 2400
            });
            output.Add(new Win32_PhysicalMemory
            {
                Capacity = 4294967296,
                Speed = 1600,
                ConfiguredClockSpeed = 1600
            });

            return output;
        }
    }
}
