using RetrieverCore.LocalDatabase.Models;
using System.Collections.Generic;

namespace RetrieverCore.TestDataGenerator.Database
{
    public static class StorageEntityFactory
    {
        public static List<StorageEntity> GetForStorageServiceTests()
        {
            var output = new List<StorageEntity>();

            output.Add(new StorageEntity
            {
                ID = 0,
                Capacity = 15611581440
            });
            output.Add(new StorageEntity
            {
                ID = 1,
                Capacity = 256060514304
            });
            output.Add(new StorageEntity
            {
                ID = 2,
                Capacity = 1000204886016
            });

            return output;
        }
    }
}
