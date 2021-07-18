using RetrieverCore.CoreLogic.Mappers;
using RetrieverCore.Models.WMIEntieties;
using System;
using Xunit;
using RetrieverCore.Models;

namespace RetrieverCore.CoreLogicTests.Mappers
{
    public class DDRMapperTests
    {
        #region Tests
        [Theory]
        [InlineData(0, "Unknown")]
        [InlineData(1, "Other")]
        [InlineData(2, "SIP")]
        [InlineData(3, "DIP")]
        [InlineData(4, "ZIP")]
        [InlineData(5, "SOJ")]
        [InlineData(6, "Proprietary")]
        [InlineData(7, "SIMM")]
        [InlineData(8, "DIMM")]
        [InlineData(9, "TSOP")]
        [InlineData(10, "PGA")]
        [InlineData(11, "RIM")]
        [InlineData(12, "SODIMM")]
        [InlineData(13, "SRIMM")]
        [InlineData(14, "SMD")]
        [InlineData(15, "SSMP")]
        [InlineData(16, "QFP")]
        [InlineData(17, "TQFP")]
        [InlineData(18, "SOIC")]
        [InlineData(19, "LCC")]
        [InlineData(20, "PLCC")]
        [InlineData(21, "BGA")]
        [InlineData(22, "FPBGA")]
        [InlineData(23, "LGA")]
        [InlineData(24, "Unknown")]
        public void From_ParameterIsValid_ReturnsDDR(ushort formFactor, string decoded)
        {
            //Arrange
            var win32PhysicalMemory = new Win32_PhysicalMemory
            {
                Capacity = 8589934592,
                ConfiguredClockSpeed = 2000,
                FormFactor = formFactor,
                Manufacturer = "Manufacturer"
            };

            //Act
            var result = DDRMapper.From(win32PhysicalMemory);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Capacity == 8);
            Assert.True(result.FormFactor == decoded);
            Assert.False(result.Deleted);
            Assert.True(result.ID == 0);
            Assert.True(result.SetID == new Guid(new string('0', 32)));
            Assert.True(result.Vendor == win32PhysicalMemory.Manufacturer);
            Assert.True(result.Clocking == 2000);
        }

        [Fact]
        public void From_CapacityIsZero_ReturnsDDR()
        {
            //Arrange
            var win32PhysicalMemory = new Win32_PhysicalMemory
            {
                Capacity = 0,
                ConfiguredClockSpeed = 2000,
                FormFactor = 1,
                Manufacturer = "Manufacturer"
            };

            //Act
            var result = DDRMapper.From(win32PhysicalMemory);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Capacity == 0);
            Assert.True(result.FormFactor == "Other");
            Assert.False(result.Deleted);
            Assert.True(result.ID == 0);
            Assert.True(result.SetID == new Guid(new string('0', 32)));
            Assert.True(result.Vendor == win32PhysicalMemory.Manufacturer);
            Assert.True(result.Clocking == 2000);
        }

        [Fact]
        public void From_CapacityIsNull_ReturnsDDR()
        {
            //Arrange
            var win32PhysicalMemory = new Win32_PhysicalMemory
            {
                Capacity = null,
                ConfiguredClockSpeed = 2000,
                FormFactor = 1,
                Manufacturer = "Manufacturer"
            };

            //Act
            var result = DDRMapper.From(win32PhysicalMemory);

            //Assert
            Assert.NotNull(result);
            Assert.True(double.IsNaN(result.Capacity));
            Assert.True(result.FormFactor == "Other");
            Assert.False(result.Deleted);
            Assert.True(result.ID == 0);
            Assert.True(result.SetID == new Guid(new string('0', 32)));
            Assert.True(result.Vendor == win32PhysicalMemory.Manufacturer);
            Assert.True(result.Clocking == 2000);
        }

        [Fact]
        public void From_ConfiguredClockSpeedIsZero_ReturnsDDR()
        {
            //Arrange
            var win32PhysicalMemory = new Win32_PhysicalMemory
            {
                Capacity = 8589934592,
                ConfiguredClockSpeed = 0,
                FormFactor = 1,
                Manufacturer = "Manufacturer"
            };

            //Act
            var result = DDRMapper.From(win32PhysicalMemory);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Capacity == 8);
            Assert.True(result.FormFactor == "Other");
            Assert.False(result.Deleted);
            Assert.True(result.ID == 0);
            Assert.True(result.SetID == new Guid(new string('0', 32)));
            Assert.True(result.Vendor == win32PhysicalMemory.Manufacturer);
            Assert.True(result.Clocking == 0);
        }

        [Fact]
        public void From_ConfiguredClockSpeedIsNull_ReturnsDDR()
        {
            //Arrange
            var win32PhysicalMemory = new Win32_PhysicalMemory
            {
                Capacity = 8589934592,
                ConfiguredClockSpeed = null,
                FormFactor = 1,
                Manufacturer = "Manufacturer"
            };

            //Act
            var result = DDRMapper.From(win32PhysicalMemory);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Capacity == 8);
            Assert.True(result.FormFactor == "Other");
            Assert.False(result.Deleted);
            Assert.True(result.ID == 0);
            Assert.True(result.SetID == new Guid(new string('0', 32)));
            Assert.True(result.Vendor == win32PhysicalMemory.Manufacturer);
            Assert.True(result.Clocking == Constants.DefaultNumericValue);
        }

        [Fact]
        public void From_FormFactorIsNull_ReturnsDDR()
        {
            //Arrange
            var win32PhysicalMemory = new Win32_PhysicalMemory
            {
                Capacity = 8589934592,
                ConfiguredClockSpeed = 2000,
                FormFactor = null,
                Manufacturer = "Manufacturer"
            };

            //Act
            var result = DDRMapper.From(win32PhysicalMemory);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Capacity == 8);
            Assert.True(result.FormFactor == "Unknown");
            Assert.False(result.Deleted);
            Assert.True(result.ID == 0);
            Assert.True(result.SetID == new Guid(new string('0', 32)));
            Assert.True(result.Vendor == win32PhysicalMemory.Manufacturer);
            Assert.True(result.Clocking == 2000);
        }

        [Fact]
        public void From_ManufacturerIsEmpty_ReturnsDDR()
        {
            //Arrange
            var win32PhysicalMemory = new Win32_PhysicalMemory
            {
                Capacity = 8589934592,
                ConfiguredClockSpeed = 2000,
                FormFactor = 1,
                Manufacturer = string.Empty
            };

            //Act
            var result = DDRMapper.From(win32PhysicalMemory);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Capacity == 8);
            Assert.True(result.FormFactor == "Other");
            Assert.False(result.Deleted);
            Assert.True(result.ID == 0);
            Assert.True(result.SetID == new Guid(new string('0', 32)));
            Assert.True(result.Vendor == "Unknown manufacturer");
            Assert.True(result.Clocking == 2000);
        }

        [Fact]
        public void From_ManufacturerIsNull_ReturnsDDR()
        {
            //Arrange
            var win32PhysicalMemory = new Win32_PhysicalMemory
            {
                Capacity = 8589934592,
                ConfiguredClockSpeed = 2000,
                FormFactor = 1,
                Manufacturer = null
            };

            //Act
            var result = DDRMapper.From(win32PhysicalMemory);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Capacity == 8);
            Assert.True(result.FormFactor == "Other");
            Assert.False(result.Deleted);
            Assert.True(result.ID == 0);
            Assert.True(result.SetID == new Guid(new string('0', 32)));
            Assert.True(result.Vendor == "Unknown manufacturer");
            Assert.True(result.Clocking == 2000);
        }

        [Fact]
        public void From_ParameterIsNull_ThrowsNullReferenceException()
        {
            //Arrange
            Win32_PhysicalMemory win32PhysicalMemory = null;

            //Act
            //Assert
            Assert.Throws<NullReferenceException>(() => DDRMapper.From(win32PhysicalMemory));
        }
        #endregion
    }
}
