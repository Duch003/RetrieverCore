using GathererEngine.Decoders;
using GathererEngine.Models;
using RetrieverCore.Extensions;
using RetrieverCore.TestDataGenerator.WindowsEntities;
using System.Collections.Generic;
using Xunit;

namespace RetrieverCore.ExtensionsTests
{
    public class CommonPortTypeExtensionTests
    {
        private List<Win32_PortConnector> _portConnectors = Win32_PortConnectorFactory.GetForWin32_PortConnectorExtensionTests();
        private List<Win32_PortConnector> _nullPortConnectors;
        private Win32_PortConnector _nullEntity_PortConnector = null;

        private List<Win32_SerialPort> _serialPorts = Win32_SerialPortFactory.GetForWin32_SerialPortExtensionTests();
        private List<Win32_SerialPort> _nullSerialPorts;
        private Win32_SerialPort _nullEntity_SerialPort = null;

        public CommonPortTypeExtensionTests()
        {
            _nullPortConnectors = new List<Win32_PortConnector>();
            _nullPortConnectors.Add(new Win32_PortConnector());
            _nullPortConnectors.Add(new Win32_PortConnector());
            _nullPortConnectors.Add(new Win32_PortConnector());

            _nullSerialPorts = new List<Win32_SerialPort>();
            _nullSerialPorts.Add(new Win32_SerialPort());
            _nullSerialPorts.Add(new Win32_SerialPort());
            _nullSerialPorts.Add(new Win32_SerialPort());
        }

        [Fact]
        public void MapToCommon_Win32PortConnector_InputIsFine_ReturnsWin32CommonPortType()
        {
            //Arrange

            //Act
            var result0 = _portConnectors[0].MapToCommon();
            var result1 = _portConnectors[1].MapToCommon();
            var result2 = _portConnectors[2].MapToCommon();

            //Assert
            Assert.Equal(PortTypeDecoder.Decode(16), result0.Device);
            Assert.Equal("USB1", result0.ExternalName);
            Assert.Equal("J3A1", result0.InternalName);

            Assert.Equal(PortTypeDecoder.Decode(28), result1.Device);
            Assert.Equal("Video", result1.ExternalName);
            Assert.Equal("J2A2B", result1.InternalName);

            Assert.Equal(PortTypeDecoder.Decode(0), result2.Device);
            Assert.Null(result2.ExternalName);
            Assert.Equal("JXDP1 - CPU XDP Port", result2.InternalName);
        }

        [Fact]
        public void MapToCommon_Win32PortConnector_InputContainsOnlyNulls_ReturnsWin32CommonPortType()
        {
            //Arrange

            //Act
            var result0 = _nullPortConnectors[0].MapToCommon();
            var result1 = _nullPortConnectors[1].MapToCommon();
            var result2 = _nullPortConnectors[2].MapToCommon();

            //Assert
            Assert.Equal("Unknown", result0.Device);
            Assert.Null(result0.ExternalName);
            Assert.Null(result0.InternalName);

            Assert.Equal("Unknown", result1.Device);
            Assert.Null(result1.ExternalName);
            Assert.Null(result1.InternalName);

            Assert.Equal("Unknown", result2.Device);
            Assert.Null(result2.ExternalName);
            Assert.Null(result2.InternalName);
        }

        [Fact]
        public void MapToCommon_Win32PortConnector_InputIsNull_ReturnsNull()
        {
            //Arrange

            //Act
            var result0 = _nullEntity_PortConnector.MapToCommon();

            //Assert
            Assert.Null(result0);
        }

        [Fact]
        public void MapToCommon_Win32SerialPort_InputIsFine_ReturnsWin32CommonPortType()
        {
            //Arrange

            //Act
            var result0 = _serialPorts[0].MapToCommon();
            var result1 = _serialPorts[1].MapToCommon();
            var result2 = _serialPorts[2].MapToCommon();

            //Assert
            Assert.Equal("RS232 Serial Port", result0.Device);
            Assert.Equal("Intel(R) Active Management Technology - SOL (COM3)", result0.ExternalName);
            Assert.Equal("COM3", result0.InternalName);

            Assert.Equal("RS232 Serial Port", result1.Device);
            Assert.Equal("Standardowy port szeregowy przez link Bluetooth (COM4)", result1.ExternalName);
            Assert.Equal("COM4", result1.InternalName);

            Assert.Null(result2.Device);
            Assert.Equal("Standardowy port szeregowy przez link Bluetooth (COM5)", result2.ExternalName);
            Assert.Equal("COM5", result2.InternalName);
        }

        [Fact]
        public void MapToCommon_Win32SerialPort_InputContainsOnlyNulls_ReturnsWin32CommonPortType()
        {
            //Arrange

            //Act
            var result0 = _nullSerialPorts[0].MapToCommon();
            var result1 = _nullSerialPorts[1].MapToCommon();
            var result2 = _nullSerialPorts[2].MapToCommon();

            //Assert
            Assert.Null(result0.Device);
            Assert.Null(result0.ExternalName);
            Assert.Null(result0.InternalName);

            Assert.Null(result1.Device);
            Assert.Null(result1.ExternalName);
            Assert.Null(result1.InternalName);

            Assert.Null(result2.Device);
            Assert.Null(result2.ExternalName);
            Assert.Null(result2.InternalName);
        }

        [Fact]
        public void MapToCommon_Win32SerialPort_InputIsNull_ReturnsNull()
        {
            //Arrange

            //Act
            var result0 = _nullEntity_SerialPort.MapToCommon();

            //Assert
            Assert.Null(result0);
        }
    }
}
