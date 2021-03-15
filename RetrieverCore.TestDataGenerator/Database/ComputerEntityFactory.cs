using RetrieverCore.LocalDatabase.Models;
using System;
using System.Collections.Generic;

namespace RetrieverCore.TestDataGenerator.Database
{
    public static class ComputerEntityFactory
    {
        public static List<ComputerEntity> GetForComputerServiceTests()
        {
            var output = new List<ComputerEntity>();

            output.Add(new ComputerEntity
            {
                Vendor = "Vendor1",
                Model = "Model1",
                Notes = new[] { "Note", "Note", "Note" }
            });
            output.Add(new ComputerEntity
            {
                Vendor = "Vendor2",
                Model = "Model2",
                Notes = new[] { "Note", "Note" }
            });
            output.Add(new ComputerEntity
            {
                Vendor = "Vendor3",
                Model = "Model3",
                Notes = Array.Empty<string>()
            });
            output.Add(new ComputerEntity
            {
                Vendor = "Vendor1",
                Model = "Model4",
                Notes = null
            });
            output.Add(new ComputerEntity
            {
                Vendor = "Vendor3",
                Model = "Model5",
                Notes = new[] { "Note", "Note" }
            });

            return output;
        }
    }
}
