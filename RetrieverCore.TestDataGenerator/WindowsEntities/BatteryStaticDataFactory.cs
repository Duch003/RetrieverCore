using GathererEngine.Models;
using System.Collections.Generic;

namespace RetrieverCore.TestDataGenerator.WindowsEntities
{
    public static class BatteryStaticDataFactory
    {
        public static List<BatteryStaticData> GetForBatteryServiceTests()
        {
            var output = new List<BatteryStaticData>();

            output.Add(new BatteryStaticData
            {
                Tag = 0,
                UniqueID = "UniqueIdentifier0",
                DesignedCapacity = 67997
            });
            output.Add(new BatteryStaticData
            {
                Tag = 1,
                UniqueID = "UniqueIdentifier1",
                DesignedCapacity = 97003
            });
            output.Add(new BatteryStaticData
            {
                Tag = 2,
                UniqueID = "UniqueIdentifier2",
                DesignedCapacity = 67997
            });

            return output;
        }
    }
}
