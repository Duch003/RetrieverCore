//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;
//using Databases.RetrieverCore.Common.Models;
//using System.Collections.Generic;
//using GathererEngine.Database;
//using GathererEngine.Converters;

//namespace GathererEngine.Extensions
//{
//    public static class WmiResultsSetEntityExtensions
//    {
//        public static WmiResultsSetEntity Assign(this WmiResultsSetEntity entity, string win32Class, JToken token)
//        {
//            var serializer = new JsonSerializer();
//            serializer.Converters.Add(new CustomManagementDateTimeConverter());
//            serializer.Error += Serializer_Error;

//            switch (win32Class)
//            {
//                case "BatteryFullChargedCapacity":
//                    (entity.BatteryFullChargedCapacity as List<BatteryFullChargedCapacity>).Add(token.ToObject<BatteryFullChargedCapacity>(serializer));
//                    break;
//                case "BatteryStaticData":
//                    (entity.BatteryStaticData as List<BatteryStaticData>).Add(token.ToObject<BatteryStaticData>(serializer));
//                    break;
//                case "BatteryStatus":
//                    (entity.BatteryStatus as List<BatteryStatus>).Add(token.ToObject<BatteryStatus>(serializer));
//                    break;
//                case "CIM_Battery":
//                    (entity.CIM_Battery as List<CIM_Battery>).Add(token.ToObject<CIM_Battery>(serializer));
//                    break;
//                case "CIM_BIOSElement":
//                    (entity.CIM_BIOSElement as List<CIM_BIOSElement>).Add(token.ToObject<CIM_BIOSElement>(serializer));
//                    break;
//                case "CIM_Card":
//                    (entity.CIM_Card as List<CIM_Card>).Add(token.ToObject<CIM_Card>(serializer));
//                    break;
//                case "CIM_Chip":
//                    (entity.CIM_Chip as List<CIM_Chip>).Add(token.ToObject<CIM_Chip>(serializer));
//                    break;
//                case "CIM_ComputerSystem":
//                    (entity.CIM_ComputerSystem as List<CIM_ComputerSystem>).Add(token.ToObject<CIM_ComputerSystem>(serializer));
//                    break;
//                case "CIM_Controller":
//                    (entity.CIM_Controller as List<CIM_Controller>).Add(token.ToObject<CIM_Controller>(serializer));
//                    break;
//                case "CIM_CoolingDevice":
//                    (entity.CIM_CoolingDevice as List<CIM_CoolingDevice>).Add(token.ToObject<CIM_CoolingDevice>(serializer));
//                    break;
//                case "CIM_CurrentSensor":
//                    (entity.CIM_CurrentSensor as List<CIM_CurrentSensor>).Add(token.ToObject<CIM_CurrentSensor>(serializer));
//                    break;
//                case "CIM_DesktopMonitor":
//                    (entity.CIM_DesktopMonitor as List<CIM_DesktopMonitor>).Add(token.ToObject<CIM_DesktopMonitor>(serializer));
//                    break;
//                case "CIM_DiskDrive":
//                    (entity.CIM_DiskDrive as List<CIM_DiskDrive>).Add(token.ToObject<CIM_DiskDrive>(serializer));
//                    break;
//                case "CIM_DiskPartition":
//                    (entity.CIM_DiskPartition as List<CIM_DiskPartition>).Add(token.ToObject<CIM_DiskPartition>(serializer));
//                    break;
//                case "CIM_Display":
//                    (entity.CIM_Display as List<CIM_Display>).Add(token.ToObject<CIM_Display>(serializer));
//                    break;
//                case "CIM_Fan":
//                    (entity.CIM_Fan as List<CIM_Fan>).Add(token.ToObject<CIM_Fan>(serializer));
//                    break;
//                case "CIM_InstalledOS":
//                    (entity.CIM_InstalledOS as List<CIM_InstalledOS>).Add(token.ToObject<CIM_InstalledOS>(serializer));
//                    break;
//                case "CIM_Keyboard":
//                    (entity.CIM_Keyboard as List<CIM_Keyboard>).Add(token.ToObject<CIM_Keyboard>(serializer));
//                    break;
//                case "CIM_LogicalDisk":
//                    (entity.CIM_LogicalDisk as List<CIM_LogicalDisk>).Add(token.ToObject<CIM_LogicalDisk>(serializer));
//                    break;
//                case "CIM_Memory":
//                    (entity.CIM_Memory as List<CIM_Memory>).Add(token.ToObject<CIM_Memory>(serializer));
//                    break;
//                case "CIM_NetworkAdapter":
//                    (entity.CIM_NetworkAdapter as List<CIM_NetworkAdapter>).Add(token.ToObject<CIM_NetworkAdapter>(serializer));
//                    break;
//                case "CIM_NumericSensor":
//                    (entity.CIM_NumericSensor as List<CIM_NumericSensor>).Add(token.ToObject<CIM_NumericSensor>(serializer));
//                    break;
//                case "CIM_OperatingSystem":
//                    (entity.CIM_OperatingSystem as List<CIM_OperatingSystem>).Add(token.ToObject<CIM_OperatingSystem>(serializer));
//                    break;
//                case "CIM_PCVideoController":
//                    (entity.CIM_PCVideoController as List<CIM_PCVideoController>).Add(token.ToObject<CIM_PCVideoController>(serializer));
//                    break;
//                case "CIM_PhysicalConnector":
//                    (entity.CIM_PhysicalConnector as List<CIM_PhysicalConnector>).Add(token.ToObject<CIM_PhysicalConnector>(serializer));
//                    break;
//                case "CIM_PhysicalElement":
//                    (entity.CIM_PhysicalElement as List<CIM_PhysicalElement>).Add(token.ToObject<CIM_PhysicalElement>(serializer));
//                    break;
//                case "CIM_PhysicalMemory":
//                    (entity.CIM_PhysicalMemory as List<CIM_PhysicalMemory>).Add(token.ToObject<CIM_PhysicalMemory>(serializer));
//                    break;
//                case "CIM_PointingDevice":
//                    (entity.CIM_PointingDevice as List<CIM_PointingDevice>).Add(token.ToObject<CIM_PointingDevice>(serializer));
//                    break;
//                case "CIM_Printer":
//                    (entity.CIM_Printer as List<CIM_Printer>).Add(token.ToObject<CIM_Printer>(serializer));
//                    break;
//                case "CIM_Process":
//                    (entity.CIM_Process as List<CIM_Process>).Add(token.ToObject<CIM_Process>(serializer));
//                    break;
//                case "CIM_Processor":
//                    (entity.CIM_Processor as List<CIM_Processor>).Add(token.ToObject<CIM_Processor>(serializer));
//                    break;
//                case "CIM_Product":
//                    (entity.CIM_Product as List<CIM_Product>).Add(token.ToObject<CIM_Product>(serializer));
//                    break;
//                case "CIM_SCSIController":
//                    (entity.CIM_SCSIController as List<CIM_SCSIController>).Add(token.ToObject<CIM_SCSIController>(serializer));
//                    break;
//                case "CIM_Sensor":
//                    (entity.CIM_Sensor as List<CIM_Sensor>).Add(token.ToObject<CIM_Sensor>(serializer));
//                    break;
//                case "CIM_SerialController":
//                    (entity.CIM_SerialController as List<CIM_SerialController>).Add(token.ToObject<CIM_SerialController>(serializer));
//                    break;
//                case "CIM_Slot":
//                    (entity.CIM_Slot as List<CIM_Slot>).Add(token.ToObject<CIM_Slot>(serializer));
//                    break;
//                case "CIM_StorageVolume":
//                    (entity.CIM_StorageVolume as List<CIM_StorageVolume>).Add(token.ToObject<CIM_StorageVolume>(serializer));
//                    break;
//                case "CIM_System":
//                    (entity.CIM_System as List<CIM_System>).Add(token.ToObject<CIM_System>(serializer));
//                    break;
//                case "CIM_TemperatureSensor":
//                    (entity.CIM_TemperatureSensor as List<CIM_TemperatureSensor>).Add(token.ToObject<CIM_TemperatureSensor>(serializer));
//                    break;
//                case "CIM_UnitaryComputerSystem":
//                    (entity.CIM_UnitaryComputerSystem as List<CIM_UnitaryComputerSystem>).Add(token.ToObject<CIM_UnitaryComputerSystem>(serializer));
//                    break;
//                case "CIM_USBController":
//                    (entity.CIM_USBController as List<CIM_USBController>).Add(token.ToObject<CIM_USBController>(serializer));
//                    break;
//                case "CIM_USBDevice":
//                    (entity.CIM_USBDevice as List<CIM_USBDevice>).Add(token.ToObject<CIM_USBDevice>(serializer));
//                    break;
//                case "CIM_VideoController":
//                    (entity.CIM_VideoController as List<CIM_VideoController>).Add(token.ToObject<CIM_VideoController>(serializer));
//                    break;
//                case "CIM_VideoControllerResolution":
//                    (entity.CIM_VideoControllerResolution as List<CIM_VideoControllerResolution>).Add(token.ToObject<CIM_VideoControllerResolution>(serializer));
//                    break;
//                case "CIM_VideoSetting":
//                    (entity.CIM_VideoSetting as List<CIM_VideoSetting>).Add(token.ToObject<CIM_VideoSetting>(serializer));
//                    break;
//                case "CIM_VoltageSensor":
//                    (entity.CIM_VoltageSensor as List<CIM_VoltageSensor>).Add(token.ToObject<CIM_VoltageSensor>(serializer));
//                    break;
//                case "MSAcpi_ThermalZoneTemperature":
//                    (entity.MSAcpi_ThermalZoneTemperature as List<MSAcpi_ThermalZoneTemperature>).Add(token.ToObject<MSAcpi_ThermalZoneTemperature>(serializer));
//                    break;
//                case "MSFT_PhysicalDisk":
//                    (entity.MSFT_PhysicalDisk as List<MSFT_PhysicalDisk>).Add(token.ToObject<MSFT_PhysicalDisk>(serializer));
//                    break;
//                case "SoftwareLicensingProduct":
//                    (entity.SoftwareLicensingProduct as List<SoftwareLicensingProduct>).Add(token.ToObject<SoftwareLicensingProduct>(serializer));
//                    break;
//                case "SoftwareLicensingService":
//                    (entity.SoftwareLicensingService as List<SoftwareLicensingService>).Add(token.ToObject<SoftwareLicensingService>(serializer));
//                    break;
//                case "Win32_Account":
//                    (entity.Win32_Account as List<Win32_Account>).Add(token.ToObject<Win32_Account>(serializer));
//                    break;
//                case "Win32_AssociatedProcessorMemory":
//                    (entity.Win32_AssociatedProcessorMemory as List<Win32_AssociatedProcessorMemory>).Add(token.ToObject<Win32_AssociatedProcessorMemory>(serializer));
//                    break;
//                case "Win32_BaseBoard":
//                    (entity.Win32_BaseBoard as List<Win32_BaseBoard>).Add(token.ToObject<Win32_BaseBoard>(serializer));
//                    break;
//                case "Win32_Battery":
//                    (entity.Win32_Battery as List<Win32_Battery>).Add(token.ToObject<Win32_Battery>(serializer));
//                    break;
//                case "Win32_BIOS":
//                    (entity.Win32_BIOS as List<Win32_BIOS>).Add(token.ToObject<Win32_BIOS>(serializer));
//                    break;
//                case "Win32_Bus":
//                    (entity.Win32_Bus as List<Win32_Bus>).Add(token.ToObject<Win32_Bus>(serializer));
//                    break;
//                case "Win32_CacheMemory":
//                    (entity.Win32_CacheMemory as List<Win32_CacheMemory>).Add(token.ToObject<Win32_CacheMemory>(serializer));
//                    break;
//                case "Win32_CDROMDrive":
//                    (entity.Win32_CDROMDrive as List<Win32_CDROMDrive>).Add(token.ToObject<Win32_CDROMDrive>(serializer));
//                    break;
//                case "Win32_ComputerSystem":
//                    (entity.Win32_ComputerSystem as List<Win32_ComputerSystem>).Add(token.ToObject<Win32_ComputerSystem>(serializer));
//                    break;
//                case "Win32_DiskDrive":
//                    (entity.Win32_DiskDrive as List<Win32_DiskDrive>).Add(token.ToObject<Win32_DiskDrive>(serializer));
//                    break;
//                case "Win32_DiskPartition":
//                    (entity.Win32_DiskPartition as List<Win32_DiskPartition>).Add(token.ToObject<Win32_DiskPartition>(serializer));
//                    break;
//                case "Win32_Fan":
//                    (entity.Win32_Fan as List<Win32_Fan>).Add(token.ToObject<Win32_Fan>(serializer));
//                    break;
//                case "Win32_Keyboard":
//                    (entity.Win32_Keyboard as List<Win32_Keyboard>).Add(token.ToObject<Win32_Keyboard>(serializer));
//                    break;
//                case "Win32_LogicalDisk":
//                    (entity.Win32_LogicalDisk as List<Win32_LogicalDisk>).Add(token.ToObject<Win32_LogicalDisk>(serializer));
//                    break;
//                case "Win32_MotherboardDevice":
//                    (entity.Win32_MotherboardDevice as List<Win32_MotherboardDevice>).Add(token.ToObject<Win32_MotherboardDevice>(serializer));
//                    break;
//                case "Win32_NetworkAdapter":
//                    (entity.Win32_NetworkAdapter as List<Win32_NetworkAdapter>).Add(token.ToObject<Win32_NetworkAdapter>(serializer));
//                    break;
//                case "Win32_NetworkAdapterConfiguration":
//                    (entity.Win32_NetworkAdapterConfiguration as List<Win32_NetworkAdapterConfiguration>).Add(token.ToObject<Win32_NetworkAdapterConfiguration>(serializer));
//                    break;
//                case "Win32_OperatingSystem":
//                    (entity.Win32_OperatingSystem as List<Win32_OperatingSystem>).Add(token.ToObject<Win32_OperatingSystem>(serializer));
//                    break;
//                case "Win32_PhysicalMemory":
//                    (entity.Win32_PhysicalMemory as List<Win32_PhysicalMemory>).Add(token.ToObject<Win32_PhysicalMemory>(serializer));
//                    break;
//                case "Win32_PnPDevice":
//                    (entity.Win32_PnPDevice as List<Win32_PnPDevice>).Add(token.ToObject<Win32_PnPDevice>(serializer));
//                    break;
//                case "Win32_PnPEntity":
//                    (entity.Win32_PnPEntity as List<Win32_PnPEntity>).Add(token.ToObject<Win32_PnPEntity>(serializer));
//                    break;
//                case "Win32_PointingDevice":
//                    (entity.Win32_PointingDevice as List<Win32_PointingDevice>).Add(token.ToObject<Win32_PointingDevice>(serializer));
//                    break;
//                case "Win32_PortConnector":
//                    (entity.Win32_PortConnector as List<Win32_PortConnector>).Add(token.ToObject<Win32_PortConnector>(serializer));
//                    break;
//                case "Win32_PortResource":
//                    (entity.Win32_PortResource as List<Win32_PortResource>).Add(token.ToObject<Win32_PortResource>(serializer));
//                    break;
//                case "Win32_Printer":
//                    (entity.Win32_Printer as List<Win32_Printer>).Add(token.ToObject<Win32_Printer>(serializer));
//                    break;
//                case "Win32_Process":
//                    (entity.Win32_Process as List<Win32_Process>).Add(token.ToObject<Win32_Process>(serializer));
//                    break;
//                case "Win32_Processor":
//                    (entity.Win32_Processor as List<Win32_Processor>).Add(token.ToObject<Win32_Processor>(serializer));
//                    break;
//                case "Win32_SerialPort":
//                    (entity.Win32_SerialPort as List<Win32_SerialPort>).Add(token.ToObject<Win32_SerialPort>(serializer));
//                    break;
//                case "Win32_SoundDevice":
//                    (entity.Win32_SoundDevice as List<Win32_SoundDevice>).Add(token.ToObject<Win32_SoundDevice>(serializer));
//                    break;
//                case "Win32_TimeZone":
//                    (entity.Win32_TimeZone as List<Win32_TimeZone>).Add(token.ToObject<Win32_TimeZone>(serializer));
//                    break;
//                case "Win32_VideoController":
//                    (entity.Win32_VideoController as List<Win32_VideoController>).Add(token.ToObject<Win32_VideoController>(serializer));
//                    break;
//                case "Win32_VideoSettings":
//                    (entity.Win32_VideoSettings as List<Win32_VideoSettings>).Add(token.ToObject<Win32_VideoSettings>(serializer));
//                    break;
//                case "Win32_Volume":
//                    (entity.Win32_Volume as List<Win32_Volume>).Add(token.ToObject<Win32_Volume>(serializer));
//                    break;
//            }

//            return entity;
//        }

//        private static void Serializer_Error(object sender, Newtonsoft.Json.Serialization.ErrorEventArgs e)
//        {
//            e.ErrorContext.Handled = true;
//        }
//    }
//}
