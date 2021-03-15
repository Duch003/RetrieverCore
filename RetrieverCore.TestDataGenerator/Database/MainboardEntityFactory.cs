using RetrieverCore.LocalDatabase.Models;
using System.Collections.Generic;

namespace RetrieverCore.TestDataGenerator.Database
{
    public static class MainboardEntityFactory
    {
        public static List<MainboardEntity> GetForMainboardServiceTests()
        {
            var output = new List<MainboardEntity>();

            output.Add(new MainboardEntity
            {
                ID = 0,
                Manufacturer = "Dell Inc.",
                Model = "0F4TD7",
                Version = "A00"
            });
            output.Add(new MainboardEntity
            {
                ID = 1,
                Manufacturer = "LENOVO",
                Model = "Lenovo G50-80",
                Version = "SDK0J40700 WIN"
            });
            output.Add(new MainboardEntity
            {
                ID = 2,
                Manufacturer = "Micro-Star International Co., Ltd.",
                Model = "MS-16JD",
                Version = "REV:1.0"
            });

            return output;
        }
    }
}
