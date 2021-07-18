using RetrieverCore.CoreLogic.Mappers;
using RetrieverCore.Models.WMIEntieties;
using System;
using Xunit;

namespace RetrieverCore.CoreLogicTests.Mappers
{
    public class MainboardMapperTests
    {
        [Fact]
        public void From_AllParametersAreValid_ReturnsMainboard()
        {
            //Arrange
            var win32BaseBoard = new Win32_BaseBoard()
            {
                Manufacturer = "Manufacturer",
                Product = "Product",
            };
            var win32MotherboardDevice = new Win32_MotherboardDevice
            {
                PrimaryBusType = "PrimeryBusType",
                SecondaryBusType = "SecondaryBusType",
            };

            //Act
            var result = MainboardMapper.From(win32BaseBoard, win32MotherboardDevice);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Manufacturer == win32BaseBoard.Manufacturer);
            Assert.True(result.Model == win32BaseBoard.Product);
            Assert.True(result.PrimaryBusType == win32MotherboardDevice.PrimaryBusType);
            Assert.True(result.SecondaryBusType == win32MotherboardDevice.SecondaryBusType);
        }

        [Fact]
        public void From_ManufacturerIsEmpty_ReturnsMainboard()
        {
            //Arrange
            var win32BaseBoard = new Win32_BaseBoard()
            {
                Manufacturer = string.Empty,
                Product = "Product",
            };
            var win32MotherboardDevice = new Win32_MotherboardDevice
            {
                PrimaryBusType = "PrimeryBusType",
                SecondaryBusType = "SecondaryBusType",
            };

            //Act
            var result = MainboardMapper.From(win32BaseBoard, win32MotherboardDevice);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Manufacturer == win32BaseBoard.Manufacturer);
            Assert.True(result.Model == win32BaseBoard.Product);
            Assert.True(result.PrimaryBusType == win32MotherboardDevice.PrimaryBusType);
            Assert.True(result.SecondaryBusType == win32MotherboardDevice.SecondaryBusType);
        }

        [Fact]
        public void From_ManufacturerIsNull_ReturnsMainboard()
        {
            //Arrange
            var win32BaseBoard = new Win32_BaseBoard()
            {
                Manufacturer = null,
                Product = "Product",
            };
            var win32MotherboardDevice = new Win32_MotherboardDevice
            {
                PrimaryBusType = "PrimeryBusType",
                SecondaryBusType = "SecondaryBusType",
            };

            //Act
            var result = MainboardMapper.From(win32BaseBoard, win32MotherboardDevice);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Manufacturer == win32BaseBoard.Manufacturer);
            Assert.True(result.Model == win32BaseBoard.Product);
            Assert.True(result.PrimaryBusType == win32MotherboardDevice.PrimaryBusType);
            Assert.True(result.SecondaryBusType == win32MotherboardDevice.SecondaryBusType);
        }

        [Fact]
        public void From_ProductIsEmpty_ReturnsMainboard()
        {
            //Arrange
            var win32BaseBoard = new Win32_BaseBoard()
            {
                Manufacturer = "Manufacturer",
                Product = string.Empty,
            };
            var win32MotherboardDevice = new Win32_MotherboardDevice
            {
                PrimaryBusType = "PrimeryBusType",
                SecondaryBusType = "SecondaryBusType",
            };

            //Act
            var result = MainboardMapper.From(win32BaseBoard, win32MotherboardDevice);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Manufacturer == win32BaseBoard.Manufacturer);
            Assert.True(result.Model == win32BaseBoard.Product);
            Assert.True(result.PrimaryBusType == win32MotherboardDevice.PrimaryBusType);
            Assert.True(result.SecondaryBusType == win32MotherboardDevice.SecondaryBusType);
        }

        [Fact]
        public void From_ProductIsNull_ReturnsMainboard()
        {
            //Arrange
            var win32BaseBoard = new Win32_BaseBoard()
            {
                Manufacturer = "Manufacturer",
                Product = null,
            };
            var win32MotherboardDevice = new Win32_MotherboardDevice
            {
                PrimaryBusType = "PrimeryBusType",
                SecondaryBusType = "SecondaryBusType",
            };

            //Act
            var result = MainboardMapper.From(win32BaseBoard, win32MotherboardDevice);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Manufacturer == win32BaseBoard.Manufacturer);
            Assert.True(result.Model == win32BaseBoard.Product);
            Assert.True(result.PrimaryBusType == win32MotherboardDevice.PrimaryBusType);
            Assert.True(result.SecondaryBusType == win32MotherboardDevice.SecondaryBusType);
        }

        [Fact]
        public void From_PrimaryBusTypeIsEmpty_ReturnsMainboard()
        {
            //Arrange
            var win32BaseBoard = new Win32_BaseBoard()
            {
                Manufacturer = "Manufacturer",
                Product = "Product",
            };
            var win32MotherboardDevice = new Win32_MotherboardDevice
            {
                PrimaryBusType = string.Empty,
                SecondaryBusType = "SecondaryBusType",
            };

            //Act
            var result = MainboardMapper.From(win32BaseBoard, win32MotherboardDevice);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Manufacturer == win32BaseBoard.Manufacturer);
            Assert.True(result.Model == win32BaseBoard.Product);
            Assert.True(result.PrimaryBusType == win32MotherboardDevice.PrimaryBusType);
            Assert.True(result.SecondaryBusType == win32MotherboardDevice.SecondaryBusType);
        }

        [Fact]
        public void From_PrimaryBusTypeIsNull_ReturnsMainboard()
        {
            //Arrange
            var win32BaseBoard = new Win32_BaseBoard()
            {
                Manufacturer = "Manufacturer",
                Product = "Product",
            };
            var win32MotherboardDevice = new Win32_MotherboardDevice
            {
                PrimaryBusType = null,
                SecondaryBusType = "SecondaryBusType",
            };

            //Act
            var result = MainboardMapper.From(win32BaseBoard, win32MotherboardDevice);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Manufacturer == win32BaseBoard.Manufacturer);
            Assert.True(result.Model == win32BaseBoard.Product);
            Assert.True(result.PrimaryBusType == win32MotherboardDevice.PrimaryBusType);
            Assert.True(result.SecondaryBusType == win32MotherboardDevice.SecondaryBusType);
        }

        [Fact]
        public void From_SecondaryBusTypeIsEmpty_ReturnsMainboard()
        {
            //Arrange
            var win32BaseBoard = new Win32_BaseBoard()
            {
                Manufacturer = "Manufacturer",
                Product = "Product",
            };
            var win32MotherboardDevice = new Win32_MotherboardDevice
            {
                PrimaryBusType = "PrimeryBusType",
                SecondaryBusType = string.Empty,
            };

            //Act
            var result = MainboardMapper.From(win32BaseBoard, win32MotherboardDevice);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Manufacturer == win32BaseBoard.Manufacturer);
            Assert.True(result.Model == win32BaseBoard.Product);
            Assert.True(result.PrimaryBusType == win32MotherboardDevice.PrimaryBusType);
            Assert.True(result.SecondaryBusType == win32MotherboardDevice.SecondaryBusType);
        }

        [Fact]
        public void From_SecondaryBusTypeIsNull_ReturnsMainboard()
        {
            //Arrange
            var win32BaseBoard = new Win32_BaseBoard()
            {
                Manufacturer = "Manufacturer",
                Product = "Product",
            };
            var win32MotherboardDevice = new Win32_MotherboardDevice
            {
                PrimaryBusType = "PrimeryBusType",
                SecondaryBusType = null,
            };

            //Act
            var result = MainboardMapper.From(win32BaseBoard, win32MotherboardDevice);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Manufacturer == win32BaseBoard.Manufacturer);
            Assert.True(result.Model == win32BaseBoard.Product);
            Assert.True(result.PrimaryBusType == win32MotherboardDevice.PrimaryBusType);
            Assert.True(result.SecondaryBusType == win32MotherboardDevice.SecondaryBusType);
        }

        [Fact]
        public void From_Win32BaseBoardIsNull_ThrowsNullReferenceException()
        {
            //Arrange
            Win32_BaseBoard win32BaseBoard = null;
            var win32MotherboardDevice = new Win32_MotherboardDevice
            {
                PrimaryBusType = "PrimeryBusType",
                SecondaryBusType = "SecondaryBusType",
            };

            //Act
            //Assert
            Assert.Throws<NullReferenceException>(() => MainboardMapper.From(win32BaseBoard, win32MotherboardDevice));
        }

        [Fact]
        public void From_Win32MotherboardDeviceIsNull_ReturnsMainboard()
        {
            //Arrange
            var win32BaseBoard = new Win32_BaseBoard()
            {
                Manufacturer = "Manufacturer",
                Product = "Product",
            };
            Win32_MotherboardDevice win32MotherboardDevice = null;

            //Act
            //Assert
            Assert.Throws<NullReferenceException>(() => MainboardMapper.From(win32BaseBoard, win32MotherboardDevice));
        }
    }
}
