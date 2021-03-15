using GathererEngine.Models;
using System.Collections.Generic;

namespace RetrieverCore.TestDataGenerator.WindowsEntities
{
    public static class Win32_BatteryFactory
    {
        public static List<Win32_Battery> GetForBatteryServiceTests()
        {
            var output = new List<Win32_Battery>();

            output.Add(new Win32_Battery
            {
                DeviceID = "UniqueIdentifier0",
                EstimatedChargeRemaining = 12,
                BatteryStatus = 8
            });
            output.Add(new Win32_Battery
            {
                DeviceID = "UniqueIdentifier1",
                EstimatedChargeRemaining = 100,
                BatteryStatus = 1
            });
            output.Add(new Win32_Battery
            {
                DeviceID = "UniqueIdentifier2",
                EstimatedChargeRemaining = 92,
                BatteryStatus = 2
            });

            return output;
        }
    }
}
