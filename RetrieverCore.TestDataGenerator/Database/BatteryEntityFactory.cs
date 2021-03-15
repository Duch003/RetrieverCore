using RetrieverCore.LocalDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetrieverCore.TestDataGenerator.Database
{
    public static class BatteryEntityFactory
    {
        public static List<BatteryEntity> GetForBatteryServiceTests()
        {
            var output = new List<BatteryEntity>();

            output.Add(new BatteryEntity
            {
                ID = 0,
                DesignedCapacity = 67997
            });
            output.Add(new BatteryEntity
            {
                ID = 1,
                DesignedCapacity = 97003
            });
            output.Add(new BatteryEntity
            {
                ID = 2,
                DesignedCapacity = 67997
            });

            return output;
        }
    }
}
