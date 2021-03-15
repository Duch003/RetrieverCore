using GathererEngine.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GathererEngine.Database
{
    public class WmiResultsSetEntity
    {
        [Key]
        public int ID { get; set; }
        public string Model { get; set; }
        public string Vendor { get; set; }
        public IEnumerable<BatteryFullChargedCapacity> BatteryFullChargedCapacity { get; set; } = new List<BatteryFullChargedCapacity>();
        public IEnumerable<BatteryStaticData> BatteryStaticData { get; set; } = new List<BatteryStaticData>();
        public IEnumerable<BatteryStatus> BatteryStatus { get; set; } = new List<BatteryStatus>();
        public IEnumerable<CIM_Battery> CIM_Battery { get; set; } = new List<CIM_Battery>();
        public IEnumerable<CIM_BIOSElement> CIM_BIOSElement { get; set; } = new List<CIM_BIOSElement>();
        public IEnumerable<CIM_Card> CIM_Card { get; set; } = new List<CIM_Card>();
        public IEnumerable<CIM_Chip> CIM_Chip { get; set; } = new List<CIM_Chip>();
        public IEnumerable<CIM_ComputerSystem> CIM_ComputerSystem { get; set; } = new List<CIM_ComputerSystem>();
        public IEnumerable<CIM_Controller> CIM_Controller { get; set; } = new List<CIM_Controller>();
        public IEnumerable<CIM_CoolingDevice> CIM_CoolingDevice { get; set; } = new List<CIM_CoolingDevice>();
        public IEnumerable<CIM_CurrentSensor> CIM_CurrentSensor { get; set; } = new List<CIM_CurrentSensor>();
        public IEnumerable<CIM_DesktopMonitor> CIM_DesktopMonitor { get; set; } = new List<CIM_DesktopMonitor>();
        public IEnumerable<CIM_DiskDrive> CIM_DiskDrive { get; set; } = new List<CIM_DiskDrive>();
        public IEnumerable<CIM_DiskPartition> CIM_DiskPartition { get; set; } = new List<CIM_DiskPartition>();
        public IEnumerable<CIM_Display> CIM_Display { get; set; } = new List<CIM_Display>();
        public IEnumerable<CIM_Fan> CIM_Fan { get; set; } = new List<CIM_Fan>();
        public IEnumerable<CIM_InstalledOS> CIM_InstalledOS { get; set; } = new List<CIM_InstalledOS>();
        public IEnumerable<CIM_Keyboard> CIM_Keyboard { get; set; } = new List<CIM_Keyboard>();
        public IEnumerable<CIM_LogicalDisk> CIM_LogicalDisk { get; set; } = new List<CIM_LogicalDisk>();
        public IEnumerable<CIM_Memory> CIM_Memory { get; set; } = new List<CIM_Memory>();
        public IEnumerable<CIM_NetworkAdapter> CIM_NetworkAdapter { get; set; } = new List<CIM_NetworkAdapter>();
        public IEnumerable<CIM_NumericSensor> CIM_NumericSensor { get; set; } = new List<CIM_NumericSensor>();
        public IEnumerable<CIM_OperatingSystem> CIM_OperatingSystem { get; set; } = new List<CIM_OperatingSystem>();
        public IEnumerable<CIM_PCVideoController> CIM_PCVideoController { get; set; } = new List<CIM_PCVideoController>();
        public IEnumerable<CIM_PhysicalConnector> CIM_PhysicalConnector { get; set; } = new List<CIM_PhysicalConnector>();
        public IEnumerable<CIM_PhysicalElement> CIM_PhysicalElement { get; set; } = new List<CIM_PhysicalElement>();
        public IEnumerable<CIM_PhysicalMemory> CIM_PhysicalMemory { get; set; } = new List<CIM_PhysicalMemory>();
        public IEnumerable<CIM_PointingDevice> CIM_PointingDevice { get; set; } = new List<CIM_PointingDevice>();
        public IEnumerable<CIM_Printer> CIM_Printer { get; set; } = new List<CIM_Printer>();
        public IEnumerable<CIM_Process> CIM_Process { get; set; } = new List<CIM_Process>();
        public IEnumerable<CIM_Processor> CIM_Processor { get; set; } = new List<CIM_Processor>();
        public IEnumerable<CIM_Product> CIM_Product { get; set; } = new List<CIM_Product>();
        public IEnumerable<CIM_SCSIController> CIM_SCSIController { get; set; } = new List<CIM_SCSIController>();
        public IEnumerable<CIM_Sensor> CIM_Sensor { get; set; } = new List<CIM_Sensor>();
        public IEnumerable<CIM_SerialController> CIM_SerialController { get; set; } = new List<CIM_SerialController>();
        public IEnumerable<CIM_Slot> CIM_Slot { get; set; } = new List<CIM_Slot>();
        public IEnumerable<CIM_StorageVolume> CIM_StorageVolume { get; set; } = new List<CIM_StorageVolume>();
        public IEnumerable<CIM_System> CIM_System { get; set; } = new List<CIM_System>();
        public IEnumerable<CIM_TemperatureSensor> CIM_TemperatureSensor { get; set; } = new List<CIM_TemperatureSensor>();
        public IEnumerable<CIM_UnitaryComputerSystem> CIM_UnitaryComputerSystem { get; set; } = new List<CIM_UnitaryComputerSystem>();
        public IEnumerable<CIM_USBController> CIM_USBController { get; set; } = new List<CIM_USBController>();
        public IEnumerable<CIM_USBDevice> CIM_USBDevice { get; set; } = new List<CIM_USBDevice>();
        public IEnumerable<CIM_VideoController> CIM_VideoController { get; set; } = new List<CIM_VideoController>();
        public IEnumerable<CIM_VideoControllerResolution> CIM_VideoControllerResolution { get; set; } = new List<CIM_VideoControllerResolution>();
        public IEnumerable<CIM_VideoSetting> CIM_VideoSetting { get; set; } = new List<CIM_VideoSetting>();
        public IEnumerable<CIM_VoltageSensor> CIM_VoltageSensor { get; set; } = new List<CIM_VoltageSensor>();
        public IEnumerable<MSAcpi_ThermalZoneTemperature> MSAcpi_ThermalZoneTemperature { get; set; } = new List<MSAcpi_ThermalZoneTemperature>();
        public IEnumerable<MSFT_PhysicalDisk> MSFT_PhysicalDisk { get; set; } = new List<MSFT_PhysicalDisk>();
        public IEnumerable<SoftwareLicensingProduct> SoftwareLicensingProduct { get; set; } = new List<SoftwareLicensingProduct>();
        public IEnumerable<SoftwareLicensingService> SoftwareLicensingService { get; set; } = new List<SoftwareLicensingService>();
        public IEnumerable<Win32_Account> Win32_Account { get; set; } = new List<Win32_Account>();
        public IEnumerable<Win32_AssociatedProcessorMemory> Win32_AssociatedProcessorMemory { get; set; } = new List<Win32_AssociatedProcessorMemory>();
        public IEnumerable<Win32_BaseBoard> Win32_BaseBoard { get; set; } = new List<Win32_BaseBoard>();
        public IEnumerable<Win32_Battery> Win32_Battery { get; set; } = new List<Win32_Battery>();
        public IEnumerable<Win32_BIOS> Win32_BIOS { get; set; } = new List<Win32_BIOS>();
        public IEnumerable<Win32_Bus> Win32_Bus { get; set; } = new List<Win32_Bus>();
        public IEnumerable<Win32_CacheMemory> Win32_CacheMemory { get; set; } = new List<Win32_CacheMemory>();
        public IEnumerable<Win32_CDROMDrive> Win32_CDROMDrive { get; set; } = new List<Win32_CDROMDrive>();
        public IEnumerable<Win32_ComputerSystem> Win32_ComputerSystem { get; set; } = new List<Win32_ComputerSystem>();
        public IEnumerable<Win32_DiskDrive> Win32_DiskDrive { get; set; } = new List<Win32_DiskDrive>();
        public IEnumerable<Win32_DiskPartition> Win32_DiskPartition { get; set; } = new List<Win32_DiskPartition>();
        public IEnumerable<Win32_Fan> Win32_Fan { get; set; } = new List<Win32_Fan>();
        public IEnumerable<Win32_Keyboard> Win32_Keyboard { get; set; } = new List<Win32_Keyboard>();
        public IEnumerable<Win32_LogicalDisk> Win32_LogicalDisk { get; set; } = new List<Win32_LogicalDisk>();
        public IEnumerable<Win32_MotherboardDevice> Win32_MotherboardDevice { get; set; } = new List<Win32_MotherboardDevice>();
        public IEnumerable<Win32_NetworkAdapter> Win32_NetworkAdapter { get; set; } = new List<Win32_NetworkAdapter>();
        public IEnumerable<Win32_NetworkAdapterConfiguration> Win32_NetworkAdapterConfiguration { get; set; } = new List<Win32_NetworkAdapterConfiguration>();
        public IEnumerable<Win32_OperatingSystem> Win32_OperatingSystem { get; set; } = new List<Win32_OperatingSystem>();
        public IEnumerable<Win32_PhysicalMemory> Win32_PhysicalMemory { get; set; } = new List<Win32_PhysicalMemory>();
        public IEnumerable<Win32_PnPDevice> Win32_PnPDevice { get; set; } = new List<Win32_PnPDevice>();
        public IEnumerable<Win32_PnPEntity> Win32_PnPEntity { get; set; } = new List<Win32_PnPEntity>();
        public IEnumerable<Win32_PointingDevice> Win32_PointingDevice { get; set; } = new List<Win32_PointingDevice>();
        public IEnumerable<Win32_PortConnector> Win32_PortConnector { get; set; } = new List<Win32_PortConnector>();
        public IEnumerable<Win32_PortResource> Win32_PortResource { get; set; } = new List<Win32_PortResource>();
        public IEnumerable<Win32_Printer> Win32_Printer { get; set; } = new List<Win32_Printer>();
        public IEnumerable<Win32_Process> Win32_Process { get; set; } = new List<Win32_Process>();
        public IEnumerable<Win32_Processor> Win32_Processor { get; set; } = new List<Win32_Processor>();
        public IEnumerable<Win32_SerialPort> Win32_SerialPort { get; set; } = new List<Win32_SerialPort>();
        public IEnumerable<Win32_SoundDevice> Win32_SoundDevice { get; set; } = new List<Win32_SoundDevice>();
        public IEnumerable<Win32_TimeZone> Win32_TimeZone { get; set; } = new List<Win32_TimeZone>();
        public IEnumerable<Win32_VideoController> Win32_VideoController { get; set; } = new List<Win32_VideoController>();
        public IEnumerable<Win32_VideoSettings> Win32_VideoSettings { get; set; } = new List<Win32_VideoSettings>();
        public IEnumerable<Win32_Volume> Win32_Volume { get; set; } = new List<Win32_Volume>();
    }
}
