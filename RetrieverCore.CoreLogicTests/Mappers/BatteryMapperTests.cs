using RetrieverCore.CoreLogic.Mappers;
using RetrieverCore.Models.WMIEntieties;
using System;
using System.Threading.Tasks;
using Xunit;

namespace RetrieverCore.CoreLogicTests.Mappers
{
    public class BatteryMapperTests
    {
        #region Tests
        [Fact]
        public void From_AllParametersAreCorrect_ReturnsBattery()
        {
            //Arrange
            var batteryFullChargedCapacity = new BatteryFullChargedCapacity
            {
                FullChargedCapacity = 1000
            };
            var batteryStaticData = new BatteryStaticData
            {
                DesignedCapacity = 1100
            };
            var win32Battery = new Win32_Battery
            {
                BatteryStatus = 1,
                EstimatedChargeRemaining = 90
            };

            //Act
            var result = BatteryMapper.From(batteryFullChargedCapacity, win32Battery, batteryStaticData);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.ID == 0);
            Assert.True(result.Deleted == false);
            Assert.True(result.DesignedCapacity == batteryStaticData.DesignedCapacity);
            Assert.True(result.ChargeLevel == win32Battery.EstimatedChargeRemaining);
            Assert.True(result.Status == win32Battery.BatteryStatus);
            Assert.True(result.WearLevel == 9.09);
        }

        [Fact]
        public void From_FullChargedCapacityIsZero_ReturnsBattery()
        {
            //Arrange
            var batteryFullChargedCapacity = new BatteryFullChargedCapacity
            {
                FullChargedCapacity = 0
            };
            var batteryStaticData = new BatteryStaticData
            {
                DesignedCapacity = 1100
            };
            var win32Battery = new Win32_Battery
            {
                BatteryStatus = 1,
                EstimatedChargeRemaining = 90
            };

            //Act
            var result = BatteryMapper.From(batteryFullChargedCapacity, win32Battery, batteryStaticData);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.ID == 0);
            Assert.True(result.Deleted == false);
            Assert.True(result.DesignedCapacity == batteryStaticData.DesignedCapacity);
            Assert.True(result.ChargeLevel == win32Battery.EstimatedChargeRemaining);
            Assert.True(result.Status == win32Battery.BatteryStatus);
            Assert.True(result.WearLevel == 100);
        }

        [Fact]
        public void From_FullChargedCapacityIsNull_ReturnsBattery()
        {
            //Arrange
            var batteryFullChargedCapacity = new BatteryFullChargedCapacity
            {
                FullChargedCapacity = null
            };
            var batteryStaticData = new BatteryStaticData
            {
                DesignedCapacity = 1100
            };
            var win32Battery = new Win32_Battery
            {
                BatteryStatus = 1,
                EstimatedChargeRemaining = 90
            };

            //Act
            var result = BatteryMapper.From(batteryFullChargedCapacity, win32Battery, batteryStaticData);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.ID == 0);
            Assert.True(result.Deleted == false);
            Assert.True(result.DesignedCapacity == batteryStaticData.DesignedCapacity);
            Assert.True(result.ChargeLevel == win32Battery.EstimatedChargeRemaining);
            Assert.True(result.Status == win32Battery.BatteryStatus);
            Assert.True(double.IsNaN(result.WearLevel));
        }

        [Fact]
        public void From_DesignedCapacityIsZero_ReturnsBattery()
        {
            //Arrange
            var batteryFullChargedCapacity = new BatteryFullChargedCapacity
            {
                FullChargedCapacity = 1000
            };
            var batteryStaticData = new BatteryStaticData
            {
                DesignedCapacity = 0
            };
            var win32Battery = new Win32_Battery
            {
                BatteryStatus = 1,
                EstimatedChargeRemaining = 90
            };

            //Act
            var result = BatteryMapper.From(batteryFullChargedCapacity, win32Battery, batteryStaticData);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.ID == 0);
            Assert.True(result.Deleted == false);
            Assert.True(result.DesignedCapacity == batteryStaticData.DesignedCapacity);
            Assert.True(result.ChargeLevel == win32Battery.EstimatedChargeRemaining);
            Assert.True(result.Status == win32Battery.BatteryStatus);
            Assert.True(double.IsNaN(result.WearLevel));
        }

        [Fact]
        public void From_DesignedCapacityIsNull_ReturnsBattery()
        {
            //Arrange
            var batteryFullChargedCapacity = new BatteryFullChargedCapacity
            {
                FullChargedCapacity = 1000
            };
            var batteryStaticData = new BatteryStaticData
            {
                DesignedCapacity = null
            };
            var win32Battery = new Win32_Battery
            {
                BatteryStatus = 1,
                EstimatedChargeRemaining = 90
            };

            //Act
            var result = BatteryMapper.From(batteryFullChargedCapacity, win32Battery, batteryStaticData);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.ID == 0);
            Assert.True(result.Deleted == false);
            Assert.True(double.IsNaN(result.DesignedCapacity));
            Assert.True(result.ChargeLevel == win32Battery.EstimatedChargeRemaining);
            Assert.True(result.Status == win32Battery.BatteryStatus);
            Assert.True(double.IsNaN(result.WearLevel));
        }

        [Fact]
        public void From_BatteryStatusIsZero_ReturnsBattery()
        {
            //Arrange
            var batteryFullChargedCapacity = new BatteryFullChargedCapacity
            {
                FullChargedCapacity = 1000
            };
            var batteryStaticData = new BatteryStaticData
            {
                DesignedCapacity = 1100
            };
            var win32Battery = new Win32_Battery
            {
                BatteryStatus = 0,
                EstimatedChargeRemaining = 90
            };

            //Act
            var result = BatteryMapper.From(batteryFullChargedCapacity, win32Battery, batteryStaticData);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.ID == 0);
            Assert.True(result.Deleted == false);
            Assert.True(result.DesignedCapacity == batteryStaticData.DesignedCapacity);
            Assert.True(result.ChargeLevel == win32Battery.EstimatedChargeRemaining);
            Assert.True(result.Status == win32Battery.BatteryStatus);
            Assert.True(result.WearLevel == 9.09);
        }

        [Fact]
        public void From_BatteryStatusIsNull_ReturnsBattery()
        {
            //Arrange
            var batteryFullChargedCapacity = new BatteryFullChargedCapacity
            {
                FullChargedCapacity = 1000
            };
            var batteryStaticData = new BatteryStaticData
            {
                DesignedCapacity = 1100
            };
            var win32Battery = new Win32_Battery
            {
                BatteryStatus = null,
                EstimatedChargeRemaining = 90
            };

            //Act
            var result = BatteryMapper.From(batteryFullChargedCapacity, win32Battery, batteryStaticData);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.ID == 0);
            Assert.True(result.Deleted == false);
            Assert.True(result.DesignedCapacity == batteryStaticData.DesignedCapacity);
            Assert.True(result.ChargeLevel == win32Battery.EstimatedChargeRemaining);
            Assert.True(result.Status == -1);
            Assert.True(result.WearLevel == 9.09);
        }

        [Fact]
        public void From_EstimatedChargeRemainingIsZero_ReturnsBattery()
        {
            //Arrange
            var batteryFullChargedCapacity = new BatteryFullChargedCapacity
            {
                FullChargedCapacity = 1000
            };
            var batteryStaticData = new BatteryStaticData
            {
                DesignedCapacity = 1100
            };
            var win32Battery = new Win32_Battery
            {
                BatteryStatus = 1,
                EstimatedChargeRemaining = 0
            };

            //Act
            var result = BatteryMapper.From(batteryFullChargedCapacity, win32Battery, batteryStaticData);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.ID == 0);
            Assert.True(result.Deleted == false);
            Assert.True(result.DesignedCapacity == batteryStaticData.DesignedCapacity);
            Assert.True(result.ChargeLevel == win32Battery.EstimatedChargeRemaining);
            Assert.True(result.Status == win32Battery.BatteryStatus);
            Assert.True(result.WearLevel == 9.09);
        }

        [Fact]
        public void From_EstimatedChargeRemainingIsNull_ReturnsBattery()
        {
            //Arrange
            var batteryFullChargedCapacity = new BatteryFullChargedCapacity
            {
                FullChargedCapacity = 1000
            };
            var batteryStaticData = new BatteryStaticData
            {
                DesignedCapacity = 1100
            };
            var win32Battery = new Win32_Battery
            {
                BatteryStatus = 1,
                EstimatedChargeRemaining = null
            };

            //Act
            var result = BatteryMapper.From(batteryFullChargedCapacity, win32Battery, batteryStaticData);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.ID == 0);
            Assert.True(result.Deleted == false);
            Assert.True(result.DesignedCapacity == batteryStaticData.DesignedCapacity);
            Assert.True(double.IsNaN(result.ChargeLevel));
            Assert.True(result.Status == win32Battery.BatteryStatus);
            Assert.True(result.WearLevel == 9.09);
        }

        [Fact]
        public void From_ParameterBatteryFullChargedCapacityIsNull_ThrowsNullReferenceEception()
        {
            //Arrange
            BatteryFullChargedCapacity batteryFullChargedCapacity = null;
            var batteryStaticData = new BatteryStaticData
            {
                DesignedCapacity = 1100
            };
            var win32Battery = new Win32_Battery
            {
                BatteryStatus = 1,
                EstimatedChargeRemaining = null
            };

            //Act
            //Assert
            Assert.Throws<NullReferenceException>(() => BatteryMapper.From(batteryFullChargedCapacity, win32Battery, batteryStaticData));
        }

        [Fact]
        public void From_ParameterWin32BatteryIsNull_ThrowsNullReferenceEception()
        {
            //Arrange
            var batteryFullChargedCapacity = new BatteryFullChargedCapacity
            {
                FullChargedCapacity = 1000
            };
            var batteryStaticData = new BatteryStaticData
            {
                DesignedCapacity = 1100
            };
            Win32_Battery win32Battery = null;

            //Act
            //Assert
            Assert.Throws<NullReferenceException>(() => BatteryMapper.From(batteryFullChargedCapacity, win32Battery, batteryStaticData));
        }

        [Fact]
        public void From_ParameterBatteryStaticDataIsNull_ThrowsNullReferenceEception()
        {
            //Arrange
            var batteryFullChargedCapacity = new BatteryFullChargedCapacity
            {
                FullChargedCapacity = 1000
            };
            BatteryStaticData batteryStaticData = null;
            var win32Battery = new Win32_Battery
            {
                BatteryStatus = 1,
                EstimatedChargeRemaining = null
            };

            //Act
            //Assert
            Assert.Throws<NullReferenceException>(() => BatteryMapper.From(batteryFullChargedCapacity, win32Battery, batteryStaticData));
        }
        #endregion
    }
}