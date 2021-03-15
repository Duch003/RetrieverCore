using GathererEngine.Models;
using System.Collections.Generic;

namespace RetrieverCore.TestDataGenerator.WindowsEntities
{
    public static class Win32_ComputerSystemFactory
    {
        public static List<Win32_ComputerSystem> GetForComputerServiceTests()
        {
            var output = new List<Win32_ComputerSystem>();

            output.Add(new Win32_ComputerSystem
            {
                Manufacturer = "Vendor1",
                Model = "Model1",
                OEMStringArray = new[] { "Dell System", "1[07D1]", "3[1.0]", "12[www.dell.com]", "14[1]", "15[0]", "27[7793329610]" }
            });
            output.Add(new Win32_ComputerSystem
            {
                Manufacturer = "Vendor2",
                Model = "Model2",
                OEMStringArray = new[] { "", "$BIOSE2100000100000010200", "", "" }
            });
            output.Add(new Win32_ComputerSystem
            {
                Manufacturer = "Vendor3",
                Model = "Model3",
                OEMStringArray = new[] { "OemString1", "OemString2", "OemString3" }
            });
            output.Add(new Win32_ComputerSystem
            {
                Manufacturer = "Vendor1",
                Model = "Model4",
                OEMStringArray = new[] { "Lenovo" }
            });
            output.Add(new Win32_ComputerSystem
            {
                Manufacturer = "Vendor3",
                Model = "Model5",
                OEMStringArray = new[] { "Dell System", "1[062B]", "3[1.0]", "12[www.dell.com]", "14[1]", "15[0]" }
            });

            return output;
        }
    }
}
