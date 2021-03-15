using GathererEngine.Models;
using System.Collections.Generic;

namespace RetrieverCore.TestDataGenerator.WindowsEntities
{
    public static class Win32_SerialPortFactory
    {
        public static List<Win32_SerialPort> GetForMainboardPortServiceTests()
        {
            var output = new List<Win32_SerialPort>();

            output.Add(new Win32_SerialPort
            {
                ProviderType = "RS232 Serial Port",
                DeviceID = "COM3",
                Name = "Intel(R) Active Management Technology - SOL (COM3)"
            });
            output.Add(new Win32_SerialPort
            {
                ProviderType = "RS232 Serial Port",
                DeviceID = "COM4",
                Name = "Standardowy port szeregowy przez link Bluetooth (COM4)"
            });
            output.Add(new Win32_SerialPort
            {
                ProviderType = null,
                DeviceID = "COM5",
                Name = "Standardowy port szeregowy przez link Bluetooth (COM5)"
            });

            return output;
        }

        public static List<Win32_SerialPort> GetForWin32_SerialPortExtensionTests()
        {
            var output = new List<Win32_SerialPort>();

            output.Add(new Win32_SerialPort
            {
                ProviderType = "RS232 Serial Port",
                DeviceID = "COM3",
                Name = "Intel(R) Active Management Technology - SOL (COM3)"
            });
            output.Add(new Win32_SerialPort
            {
                ProviderType = "RS232 Serial Port",
                DeviceID = "COM4",
                Name = "Standardowy port szeregowy przez link Bluetooth (COM4)"
            });
            output.Add(new Win32_SerialPort
            {
                ProviderType = null,
                DeviceID = "COM5",
                Name = "Standardowy port szeregowy przez link Bluetooth (COM5)"
            });

            return output;
        }
    }
}
