using RetrieverCore.CoreLogic.Mappers;
using RetrieverCore.Models.WMIEntieties;
using System;
using Xunit;

namespace RetrieverCore.CoreLogicTests.Mappers
{
    public class ComputerMapperTests
    {
        #region Tests
        [Fact]
        public void From_ParameterIsValid_ReturnsComputer()
        {
            //Arrange
            var win32ComputerSystem = new Win32_ComputerSystem
            {
                Manufacturer = "Manufacturer",
                Model = "Model"
            };

            //Act
            var result = ComputerMapper.From(win32ComputerSystem);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.ID == 0);
            Assert.False(result.Deleted);
            Assert.True(result.Name == "Manufacturer - Model");
        }

        [Fact]
        public void From_ManufacturerIsEmpty_ReturnsComputer()
        {
            //Arrange
            var win32ComputerSystem = new Win32_ComputerSystem
            {
                Manufacturer = string.Empty,
                Model = "Model"
            };

            //Act
            var result = ComputerMapper.From(win32ComputerSystem);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.ID == 0);
            Assert.False(result.Deleted);
            Assert.True(result.Name == "Unknown manufacturer - Model");
        }

        [Fact]
        public void From_ModelIsEmpty_ReturnsComputer()
        {
            //Arrange
            var win32ComputerSystem = new Win32_ComputerSystem
            {
                Manufacturer = "Manufacturer",
                Model = string.Empty
            };

            //Act
            var result = ComputerMapper.From(win32ComputerSystem);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.ID == 0);
            Assert.False(result.Deleted);
            Assert.True(result.Name == "Manufacturer - Unknown model");
        }

        [Fact]
        public void From_ManufacturerIsWhitespace_ReturnsComputer()
        {
            //Arrange
            var win32ComputerSystem = new Win32_ComputerSystem
            {
                Manufacturer = " ",
                Model = "Model"
            };

            //Act
            var result = ComputerMapper.From(win32ComputerSystem);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.ID == 0);
            Assert.False(result.Deleted);
            Assert.True(result.Name == "Unknown manufacturer - Model");
        }

        [Fact]
        public void From_ModelIsWhitespace_ReturnsComputer()
        {
            //Arrange
            var win32ComputerSystem = new Win32_ComputerSystem
            {
                Manufacturer = "Manufacturer",
                Model = " "
            };

            //Act
            var result = ComputerMapper.From(win32ComputerSystem);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.ID == 0);
            Assert.False(result.Deleted);
            Assert.True(result.Name == "Manufacturer - Unknown model");
        }

        [Fact]
        public void From_ManufacturerIsNull_ReturnsComputer()
        {
            //Arrange
            var win32ComputerSystem = new Win32_ComputerSystem
            {
                Manufacturer = null,
                Model = "Model"
            };

            //Act
            var result = ComputerMapper.From(win32ComputerSystem);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.ID == 0);
            Assert.False(result.Deleted);
            Assert.True(result.Name == "Unknown manufacturer - Model");
        }

        [Fact]
        public void From_ModelIsNull_ReturnsComputer()
        {
            //Arrange
            var win32ComputerSystem = new Win32_ComputerSystem
            {
                Manufacturer = "Manufacturer",
                Model = null
            };

            //Act
            var result = ComputerMapper.From(win32ComputerSystem);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.ID == 0);
            Assert.False(result.Deleted);
            Assert.True(result.Name == "Manufacturer - Unknown model");
        }

        [Fact]
        public void From_ParameterIsNull()
        {
            //Arrange
            Win32_ComputerSystem win32ComputerSystem = null;

            //Act
            //Assert
            Assert.Throws<NullReferenceException>(() => ComputerMapper.From(win32ComputerSystem));
        }
        #endregion
    }
}
