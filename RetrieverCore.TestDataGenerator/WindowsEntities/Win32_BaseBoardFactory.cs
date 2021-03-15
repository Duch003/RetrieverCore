using GathererEngine.Models;
using System.Collections.Generic;

namespace RetrieverCore.TestDataGenerator.WindowsEntities
{
    public static class Win32_BaseBoardFactory
    {
        public static List<Win32_BaseBoard> GetForMainboardServiceTests()
        {
            var output = new List<Win32_BaseBoard>();

            output.Add(new Win32_BaseBoard
            {
                Manufacturer = "Dell Inc.",
                Product = "0F4TD7",
                Version = "A00"
            });
            output.Add(new Win32_BaseBoard
            {
                Manufacturer = "LENOVO",
                Product = "Lenovo G50-80",
                Version = "SDK0J40700 WIN"
            });
            output.Add(new Win32_BaseBoard
            {
                Manufacturer = "Micro-Star International Co., Ltd.",
                Product = "MS-16JD",
                Version = "REV:1.0"
            });

            return output;
        }
    }
}
