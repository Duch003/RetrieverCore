using RetrieverCore.LocalDatabase.Models;
using System.Collections.Generic;

namespace RetrieverCore.TestDataGenerator.Database
{
    public static class DDREntityFactory
    {
        public static List<DDREntity> GetForDDRServiceTests()
        {
            var output = new List<DDREntity>();

            output.Add(new DDREntity
            {
                Capacity = 8589934592,
                DesignedClocking = 2400,
                SetClocking = 2400
            });
            output.Add(new DDREntity
            {
                Capacity = 17179869184,
                DesignedClocking = 2667,
                SetClocking = 2667
            });
            output.Add(new DDREntity
            {
                Capacity = 8589934592,
                DesignedClocking = 2667,
                SetClocking = 2400
            });
            output.Add(new DDREntity
            {
                Capacity = 4294967296,
                DesignedClocking = 1600,
                SetClocking = 1600
            });

            return output;
        }
    }
}
