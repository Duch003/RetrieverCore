using GathererEngine.Models;
using System.Collections.Generic;

namespace RetrieverCore.TestDataGenerator.WindowsEntities
{
    public static class BatteryFullChargedCapacityFactory
    {
        public static List<BatteryFullChargedCapacity> GetForBatteryServiceTests()
        {
            var output = new List<BatteryFullChargedCapacity>();

            output.Add(new BatteryFullChargedCapacity
            {
                FullChargedCapacity = 65748,
                Tag = 0
            });
            output.Add(new BatteryFullChargedCapacity
            {
                FullChargedCapacity = 88715,
                Tag = 1
            });
            output.Add(new BatteryFullChargedCapacity
            {
                FullChargedCapacity = 44407,
                Tag = 2
            });

            return output;
        }
    }
}
