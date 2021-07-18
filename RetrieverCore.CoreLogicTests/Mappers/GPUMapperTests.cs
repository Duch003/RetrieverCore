using RetrieverCore.CoreLogic.Mappers;
using RetrieverCore.Models.WMIEntieties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using RetrieverCore.Models;

namespace RetrieverCore.CoreLogicTests.Mappers
{
    public class GPUMapperTests
    {
        #region Tests
        [Fact]
        public void From_ParameterIsValid_ReturnsGPU()
        {
            //Arrange
            var win32VideoController = new Win32_VideoController
            {
                Availability = 1,
                CurrentVerticalResolution = 1,
                CurrentHorizontalResolution = 1,
                Caption = "Caption1",
                AdapterRAM = 1073741824,
                AdapterDACType = "AdapterDACType",
                VideoArchitecture = 1,
                CurrentNumberOfColors = 1,
                MaxRefreshRate = 1
            };

            //Act
            var result = GPUMapper.From(win32VideoController);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Availability == "Other");
            Assert.True(result.Height == win32VideoController.CurrentVerticalResolution);
            Assert.True(result.Width == win32VideoController.CurrentHorizontalResolution);
            Assert.True(result.NumberOfColors == (long)win32VideoController.CurrentNumberOfColors);
            Assert.True(result.Name == win32VideoController.Caption);
            Assert.True(result.Capacity == 1);
            Assert.True(result.AdapterDACType == win32VideoController.AdapterDACType);
            Assert.True(result.VideoArchitecture == "Other");
            Assert.True(result.MaxRefreshRate == win32VideoController.MaxRefreshRate);
        }

        [Theory]
        [InlineData(0, "Unknown")]
        [InlineData(1, "Other")]
        [InlineData(2, "Unknown")]
        [InlineData(3, "Running or Full Power")]
        [InlineData(4, "Warning")]
        [InlineData(5, "In Test")]
        [InlineData(6, "Not Applicable")]
        [InlineData(7, "Power Off")]
        [InlineData(8, "Off Line")]
        [InlineData(9, "Off Duty")]
        [InlineData(10, "Degraded ")]
        [InlineData(11, "Not Installed")]
        [InlineData(12, "Install Error")]
        [InlineData(13, "Power Save - Unknown")]
        [InlineData(14, "Power Save - Low Power Mode")]
        [InlineData(15, "Power Save - Standby")]
        [InlineData(16, "Power Cycle")]
        [InlineData(17, "Power Save - Warning")]
        [InlineData(18, "Paused ")]
        [InlineData(19, "Not Ready")]
        [InlineData(20, "Not Configured")]
        [InlineData(21, "Quiesced")]
        [InlineData(22, "Unknown")]
        public void From_VariousAvailabilities_ReturnsGPU(ushort availability, string decoded)
        {
            //Arrange
            var win32VideoController = new Win32_VideoController
            {
                Availability = availability,
                CurrentVerticalResolution = 1,
                CurrentHorizontalResolution = 1,
                Caption = "Caption1",
                AdapterRAM = 1073741824,
                AdapterDACType = "AdapterDACType",
                VideoArchitecture = 1,
                CurrentNumberOfColors = 1,
                MaxRefreshRate = 1
            };

            //Act
            var result = GPUMapper.From(win32VideoController);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Availability == decoded);
        }

        [Theory]
        [InlineData(0, "Unknown")]
        [InlineData(1, "Other")]
        [InlineData(2, "Unknown")]
        [InlineData(3, "CGA")]
        [InlineData(4, "EGA")]
        [InlineData(5, "VGA")]
        [InlineData(6, "SVGA")]
        [InlineData(7, "MDA")]
        [InlineData(8, "HGC")]
        [InlineData(9, "MCGA")]
        [InlineData(10, "8514A")]
        [InlineData(11, "XGA")]
        [InlineData(12, "Linear Frame Buffer")]
        [InlineData(160, "PC-98")]
        public void From_VariousVideoArchitectures_ReturnsGPU(ushort videoArchitecture, string decoded)
        {
            //Arrange
            var win32VideoController = new Win32_VideoController
            {
                Availability = 1,
                CurrentVerticalResolution = 1,
                CurrentHorizontalResolution = 1,
                Caption = "Caption1",
                AdapterRAM = 1073741824,
                AdapterDACType = "AdapterDACType",
                VideoArchitecture = videoArchitecture,
                CurrentNumberOfColors = 1,
                MaxRefreshRate = 1
            };

            //Act
            var result = GPUMapper.From(win32VideoController);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.VideoArchitecture == decoded);
        }

        [Fact]
        public void From_AvailabilityIsNull_ReturnsGPU()
        {
            //Arrange
            var win32VideoController = new Win32_VideoController
            {
                Availability = null,
                CurrentVerticalResolution = 1,
                CurrentHorizontalResolution = 1,
                Caption = "Caption1",
                AdapterRAM = 1073741824,
                AdapterDACType = "AdapterDACType",
                VideoArchitecture = 1,
                CurrentNumberOfColors = 1,
                MaxRefreshRate = 1
            };

            //Act
            var result = GPUMapper.From(win32VideoController);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Availability == "Unknown");
            Assert.True(result.Height == win32VideoController.CurrentVerticalResolution);
            Assert.True(result.Width == win32VideoController.CurrentHorizontalResolution);
            Assert.True(result.NumberOfColors == (long)win32VideoController.CurrentNumberOfColors);
            Assert.True(result.Name == win32VideoController.Caption);
            Assert.True(result.Capacity == 1);
            Assert.True(result.AdapterDACType == win32VideoController.AdapterDACType);
            Assert.True(result.VideoArchitecture == "Other");
            Assert.True(result.MaxRefreshRate == win32VideoController.MaxRefreshRate);
        }

        [Fact]
        public void From_CurrentVerticalResolutionIsNull_ReturnsGPU()
        {
            //Arrange
            var win32VideoController = new Win32_VideoController
            {
                Availability = 1,
                CurrentVerticalResolution = null,
                CurrentHorizontalResolution = 1,
                Caption = "Caption1",
                AdapterRAM = 1073741824,
                AdapterDACType = "AdapterDACType",
                VideoArchitecture = 1,
                CurrentNumberOfColors = 1,
                MaxRefreshRate = 1
            };

            //Act
            var result = GPUMapper.From(win32VideoController);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Availability == "Other");
            Assert.True(result.Height == 0);
            Assert.True(result.Width == win32VideoController.CurrentHorizontalResolution);
            Assert.True(result.NumberOfColors == (long)win32VideoController.CurrentNumberOfColors);
            Assert.True(result.Name == win32VideoController.Caption);
            Assert.True(result.Capacity == 1);
            Assert.True(result.AdapterDACType == win32VideoController.AdapterDACType);
            Assert.True(result.VideoArchitecture == "Other");
            Assert.True(result.MaxRefreshRate == win32VideoController.MaxRefreshRate);
        }

        [Fact]
        public void From_CurrentHorizontalResolutionIsNull_ReturnsGPU()
        {
            //Arrange
            var win32VideoController = new Win32_VideoController
            {
                Availability = 1,
                CurrentVerticalResolution = 1,
                CurrentHorizontalResolution = null,
                Caption = "Caption1",
                AdapterRAM = 1073741824,
                AdapterDACType = "AdapterDACType",
                VideoArchitecture = 1,
                CurrentNumberOfColors = 1,
                MaxRefreshRate = 1
            };

            //Act
            var result = GPUMapper.From(win32VideoController);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Availability == "Other");
            Assert.True(result.Height == win32VideoController.CurrentVerticalResolution);
            Assert.True(result.Width == 0);
            Assert.True(result.NumberOfColors == (long)win32VideoController.CurrentNumberOfColors);
            Assert.True(result.Name == win32VideoController.Caption);
            Assert.True(result.Capacity == 1);
            Assert.True(result.AdapterDACType == win32VideoController.AdapterDACType);
            Assert.True(result.VideoArchitecture == "Other");
            Assert.True(result.MaxRefreshRate == win32VideoController.MaxRefreshRate);
        }

        [Fact]
        public void From_CaptionIsNull_ReturnsGPU()
        {
            //Arrange
            var win32VideoController = new Win32_VideoController
            {
                Availability = 1,
                CurrentVerticalResolution = 1,
                CurrentHorizontalResolution = 1,
                Caption = null,
                AdapterRAM = 1073741824,
                AdapterDACType = "AdapterDACType",
                VideoArchitecture = 1,
                CurrentNumberOfColors = 1,
                MaxRefreshRate = 1
            };

            //Act
            var result = GPUMapper.From(win32VideoController);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Availability == "Other");
            Assert.True(result.Height == win32VideoController.CurrentVerticalResolution);
            Assert.True(result.Width == win32VideoController.CurrentHorizontalResolution);
            Assert.True(result.NumberOfColors == (long)win32VideoController.CurrentNumberOfColors);
            Assert.True(result.Name == "Unknown");
            Assert.True(result.Capacity == 1);
            Assert.True(result.AdapterDACType == win32VideoController.AdapterDACType);
            Assert.True(result.VideoArchitecture == "Other");
            Assert.True(result.MaxRefreshRate == win32VideoController.MaxRefreshRate);
        }

        [Fact]
        public void From_CaptionIsEmpty_ReturnsGPU()
        {
            //Arrange
            var win32VideoController = new Win32_VideoController
            {
                Availability = 1,
                CurrentVerticalResolution = 1,
                CurrentHorizontalResolution = 1,
                Caption = string.Empty,
                AdapterRAM = 1073741824,
                AdapterDACType = "AdapterDACType",
                VideoArchitecture = 1,
                CurrentNumberOfColors = 1,
                MaxRefreshRate = 1
            };

            //Act
            var result = GPUMapper.From(win32VideoController);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Availability == "Other");
            Assert.True(result.Height == win32VideoController.CurrentVerticalResolution);
            Assert.True(result.Width == win32VideoController.CurrentHorizontalResolution);
            Assert.True(result.NumberOfColors == (long)win32VideoController.CurrentNumberOfColors);
            Assert.True(result.Name == "Unknown");
            Assert.True(result.Capacity == 1);
            Assert.True(result.AdapterDACType == win32VideoController.AdapterDACType);
            Assert.True(result.VideoArchitecture == "Other");
            Assert.True(result.MaxRefreshRate == win32VideoController.MaxRefreshRate);
        }

        [Fact]
        public void From_CaptionIsWhitespace_ReturnsGPU()
        {
            //Arrange
            var win32VideoController = new Win32_VideoController
            {
                Availability = 1,
                CurrentVerticalResolution = 1,
                CurrentHorizontalResolution = 1,
                Caption = " ",
                AdapterRAM = 1073741824,
                AdapterDACType = "AdapterDACType",
                VideoArchitecture = 1,
                CurrentNumberOfColors = 1,
                MaxRefreshRate = 1
            };

            //Act
            var result = GPUMapper.From(win32VideoController);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Availability == "Other");
            Assert.True(result.Height == win32VideoController.CurrentVerticalResolution);
            Assert.True(result.Width == win32VideoController.CurrentHorizontalResolution);
            Assert.True(result.NumberOfColors == (long)win32VideoController.CurrentNumberOfColors);
            Assert.True(result.Name == "Unknown");
            Assert.True(result.Capacity == 1);
            Assert.True(result.AdapterDACType == win32VideoController.AdapterDACType);
            Assert.True(result.VideoArchitecture == "Other");
            Assert.True(result.MaxRefreshRate == win32VideoController.MaxRefreshRate);
        }

        [Fact]
        public void From_AdapterRAMIsNull_ReturnsGPU()
        {
            //Arrange
            var win32VideoController = new Win32_VideoController
            {
                Availability = 1,
                CurrentVerticalResolution = 1,
                CurrentHorizontalResolution = 1,
                Caption = "Caption1",
                AdapterRAM = null,
                AdapterDACType = "AdapterDACType",
                VideoArchitecture = 1,
                CurrentNumberOfColors = 1,
                MaxRefreshRate = 1
            };

            //Act
            var result = GPUMapper.From(win32VideoController);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Availability == "Other");
            Assert.True(result.Height == win32VideoController.CurrentVerticalResolution);
            Assert.True(result.Width == win32VideoController.CurrentHorizontalResolution);
            Assert.True(result.NumberOfColors == (long)win32VideoController.CurrentNumberOfColors);
            Assert.True(result.Name == win32VideoController.Caption);
            Assert.True(result.Capacity == Constants.DefaultNumericValue);
            Assert.True(result.AdapterDACType == win32VideoController.AdapterDACType);
            Assert.True(result.VideoArchitecture == "Other");
            Assert.True(result.MaxRefreshRate == win32VideoController.MaxRefreshRate);
        }

        [Fact]
        public void From_AdapterDACTypeIsNull_ReturnsGPU()
        {
            //Arrange
            var win32VideoController = new Win32_VideoController
            {
                Availability = 1,
                CurrentVerticalResolution = 1,
                CurrentHorizontalResolution = 1,
                Caption = "Caption1",
                AdapterRAM = 1073741824,
                AdapterDACType = null,
                VideoArchitecture = 1,
                CurrentNumberOfColors = 1,
                MaxRefreshRate = 1
            };

            //Act
            var result = GPUMapper.From(win32VideoController);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Availability == "Other");
            Assert.True(result.Height == win32VideoController.CurrentVerticalResolution);
            Assert.True(result.Width == win32VideoController.CurrentHorizontalResolution);
            Assert.True(result.NumberOfColors == (long)win32VideoController.CurrentNumberOfColors);
            Assert.True(result.Name == win32VideoController.Caption);
            Assert.True(result.Capacity == 1);
            Assert.True(result.AdapterDACType == "Unknown");
            Assert.True(result.VideoArchitecture == "Other");
            Assert.True(result.MaxRefreshRate == win32VideoController.MaxRefreshRate);
        }

        [Fact]
        public void From_AdapterDACTypeIsEmpty_ReturnsGPU()
        {
            //Arrange
            var win32VideoController = new Win32_VideoController
            {
                Availability = 1,
                CurrentVerticalResolution = 1,
                CurrentHorizontalResolution = 1,
                Caption = "Caption1",
                AdapterRAM = 1073741824,
                AdapterDACType = string.Empty,
                VideoArchitecture = 1,
                CurrentNumberOfColors = 1,
                MaxRefreshRate = 1
            };

            //Act
            var result = GPUMapper.From(win32VideoController);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Availability == "Other");
            Assert.True(result.Height == win32VideoController.CurrentVerticalResolution);
            Assert.True(result.Width == win32VideoController.CurrentHorizontalResolution);
            Assert.True(result.NumberOfColors == (long)win32VideoController.CurrentNumberOfColors);
            Assert.True(result.Name == win32VideoController.Caption);
            Assert.True(result.Capacity == 1);
            Assert.True(result.AdapterDACType == "Unknown");
            Assert.True(result.VideoArchitecture == "Other");
            Assert.True(result.MaxRefreshRate == win32VideoController.MaxRefreshRate);
        }

        [Fact]
        public void From_AdapterDACTypeIsWhitespace_ReturnsGPU()
        {
            //Arrange
            var win32VideoController = new Win32_VideoController
            {
                Availability = 1,
                CurrentVerticalResolution = 1,
                CurrentHorizontalResolution = 1,
                Caption = "Caption1",
                AdapterRAM = 1073741824,
                AdapterDACType = " ",
                VideoArchitecture = 1,
                CurrentNumberOfColors = 1,
                MaxRefreshRate = 1
            };

            //Act
            var result = GPUMapper.From(win32VideoController);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Availability == "Other");
            Assert.True(result.Height == win32VideoController.CurrentVerticalResolution);
            Assert.True(result.Width == win32VideoController.CurrentHorizontalResolution);
            Assert.True(result.NumberOfColors == (long)win32VideoController.CurrentNumberOfColors);
            Assert.True(result.Name == win32VideoController.Caption);
            Assert.True(result.Capacity == 1);
            Assert.True(result.AdapterDACType == "Unknown");
            Assert.True(result.VideoArchitecture == "Other");
            Assert.True(result.MaxRefreshRate == win32VideoController.MaxRefreshRate);
        }

        [Fact]
        public void From_VideoArchitectureIsNull_ReturnsGPU()
        {
            //Arrange
            var win32VideoController = new Win32_VideoController
            {
                Availability = 1,
                CurrentVerticalResolution = 1,
                CurrentHorizontalResolution = 1,
                Caption = "Caption1",
                AdapterRAM = 1073741824,
                AdapterDACType = "AdapterDACType",
                VideoArchitecture = null,
                CurrentNumberOfColors = 1,
                MaxRefreshRate = 1
            };

            //Act
            var result = GPUMapper.From(win32VideoController);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Availability == "Other");
            Assert.True(result.Height == win32VideoController.CurrentVerticalResolution);
            Assert.True(result.Width == win32VideoController.CurrentHorizontalResolution);
            Assert.True(result.NumberOfColors == (long)win32VideoController.CurrentNumberOfColors);
            Assert.True(result.Name == win32VideoController.Caption);
            Assert.True(result.Capacity == 1);
            Assert.True(result.AdapterDACType == win32VideoController.AdapterDACType);
            Assert.True(result.VideoArchitecture == "Unknown");
            Assert.True(result.MaxRefreshRate == win32VideoController.MaxRefreshRate);
        }

        [Fact]
        public void From_MaxRefreshRateIsNull_ReturnsGPU()
        {
            //Arrange
            var win32VideoController = new Win32_VideoController
            {
                Availability = 1,
                CurrentVerticalResolution = 1,
                CurrentHorizontalResolution = 1,
                Caption = "Caption1",
                AdapterRAM = 1073741824,
                AdapterDACType = "AdapterDACType",
                VideoArchitecture = 1,
                CurrentNumberOfColors = 1,
                MaxRefreshRate = null
            };

            //Act
            var result = GPUMapper.From(win32VideoController);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Availability == "Other");
            Assert.True(result.Height == win32VideoController.CurrentVerticalResolution);
            Assert.True(result.Width == win32VideoController.CurrentHorizontalResolution);
            Assert.True(result.NumberOfColors == (long)win32VideoController.CurrentNumberOfColors);
            Assert.True(result.Name == win32VideoController.Caption);
            Assert.True(result.Capacity == 1);
            Assert.True(result.AdapterDACType == win32VideoController.AdapterDACType);
            Assert.True(result.VideoArchitecture == "Other");
            Assert.True(result.MaxRefreshRate == Constants.DefaultNumericValue);
        }

        [Fact]
        public void From_ParameterIsNull_ThrowsNullReferenceException()
        {
            //Arrange
            Win32_VideoController win32VideoController = null;

            //Act
            //Assert
            Assert.Throws<NullReferenceException>(() => GPUMapper.From(win32VideoController));
        }
        #endregion
    }
}
