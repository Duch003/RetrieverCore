using Microsoft.EntityFrameworkCore.Migrations;

namespace Databases.RetrieverCore.MasterDatabase.Migrations
{
    public partial class UpdatedWmiResultsSetEntityExtension : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Model",
                table: "Win32_Volume");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "Win32_Volume");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Win32_VideoSettings");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "Win32_VideoSettings");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Win32_VideoController");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "Win32_VideoController");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Win32_TimeZone");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "Win32_TimeZone");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Win32_SoundDevice");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "Win32_SoundDevice");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Win32_SerialPort");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "Win32_SerialPort");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Win32_Processor");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "Win32_Processor");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Win32_Process");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "Win32_Process");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Win32_Printer");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "Win32_Printer");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Win32_PortResource");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "Win32_PortResource");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "Win32_PortConnector");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Win32_PointingDevice");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "Win32_PointingDevice");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Win32_PnPEntity");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "Win32_PnPEntity");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Win32_PnPDevice");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "Win32_PnPDevice");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "Win32_PhysicalMemory");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Win32_OperatingSystem");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "Win32_OperatingSystem");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Win32_NetworkAdapterConfiguration");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "Win32_NetworkAdapterConfiguration");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Win32_NetworkAdapter");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "Win32_NetworkAdapter");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Win32_MotherboardDevice");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "Win32_MotherboardDevice");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Win32_LogicalDisk");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "Win32_LogicalDisk");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Win32_Keyboard");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "Win32_Keyboard");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Win32_Fan");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "Win32_Fan");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Win32_DiskPartition");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "Win32_DiskPartition");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "Win32_DiskDrive");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "Win32_ComputerSystem");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Win32_CacheMemory");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "Win32_CacheMemory");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Win32_Bus");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "Win32_Bus");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Win32_BIOS");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "Win32_BIOS");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Win32_Battery");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "Win32_Battery");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "Win32_BaseBoard");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Win32_AssociatedProcessorMemory");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "Win32_AssociatedProcessorMemory");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Win32_Account");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "Win32_Account");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "SoftwareLicensingService");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "SoftwareLicensingService");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "SoftwareLicensingProduct");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "SoftwareLicensingProduct");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "MSFT_PhysicalDisk");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "MSAcpi_ThermalZoneTemperature");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "MSAcpi_ThermalZoneTemperature");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "CIM_VoltageSensor");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_VoltageSensor");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "CIM_VideoSetting");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_VideoSetting");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "CIM_VideoControllerResolution");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_VideoControllerResolution");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "CIM_VideoController");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_VideoController");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "CIM_USBDevice");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_USBDevice");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "CIM_USBController");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_USBController");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_UnitaryComputerSystem");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "CIM_TemperatureSensor");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_TemperatureSensor");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_System");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "CIM_StorageVolume");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_StorageVolume");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_Slot");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "CIM_SerialController");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_SerialController");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "CIM_Sensor");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_Sensor");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "CIM_SCSIController");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_SCSIController");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "CIM_Product");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "CIM_Processor");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_Processor");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "CIM_Process");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_Process");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "CIM_Printer");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_Printer");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "CIM_PointingDevice");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_PointingDevice");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_PhysicalMemory");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_PhysicalElement");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_PhysicalConnector");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "CIM_PCVideoController");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_PCVideoController");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "CIM_OperatingSystem");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_OperatingSystem");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "CIM_NumericSensor");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_NumericSensor");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "CIM_NetworkAdapter");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_NetworkAdapter");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "CIM_Memory");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_Memory");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "CIM_LogicalDisk");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_LogicalDisk");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "CIM_Keyboard");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_Keyboard");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "CIM_InstalledOS");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_InstalledOS");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "CIM_Fan");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_Fan");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "CIM_Display");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_Display");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "CIM_DiskPartition");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_DiskPartition");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_DiskDrive");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "CIM_DesktopMonitor");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_DesktopMonitor");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "CIM_CurrentSensor");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_CurrentSensor");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "CIM_CoolingDevice");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_CoolingDevice");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "CIM_Controller");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_Controller");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_ComputerSystem");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_Chip");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_Card");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "CIM_BIOSElement");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_BIOSElement");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "CIM_Battery");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "CIM_Battery");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "BatteryStatus");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "BatteryStatus");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "BatteryStaticData");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "BatteryStaticData");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "BatteryFullChargedCapacity");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "BatteryFullChargedCapacity");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Win32_Volume",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "Win32_Volume",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Win32_VideoSettings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "Win32_VideoSettings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Win32_VideoController",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "Win32_VideoController",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Win32_TimeZone",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "Win32_TimeZone",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Win32_SoundDevice",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "Win32_SoundDevice",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Win32_SerialPort",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "Win32_SerialPort",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Win32_Processor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "Win32_Processor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Win32_Process",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "Win32_Process",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Win32_Printer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "Win32_Printer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Win32_PortResource",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "Win32_PortResource",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "Win32_PortConnector",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Win32_PointingDevice",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "Win32_PointingDevice",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Win32_PnPEntity",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "Win32_PnPEntity",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Win32_PnPDevice",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "Win32_PnPDevice",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "Win32_PhysicalMemory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Win32_OperatingSystem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "Win32_OperatingSystem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Win32_NetworkAdapterConfiguration",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "Win32_NetworkAdapterConfiguration",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Win32_NetworkAdapter",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "Win32_NetworkAdapter",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Win32_MotherboardDevice",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "Win32_MotherboardDevice",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Win32_LogicalDisk",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "Win32_LogicalDisk",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Win32_Keyboard",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "Win32_Keyboard",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Win32_Fan",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "Win32_Fan",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Win32_DiskPartition",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "Win32_DiskPartition",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "Win32_DiskDrive",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "Win32_ComputerSystem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Win32_CDROMDrive",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "Win32_CDROMDrive",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Win32_CacheMemory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "Win32_CacheMemory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Win32_Bus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "Win32_Bus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Win32_BIOS",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "Win32_BIOS",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Win32_Battery",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "Win32_Battery",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "Win32_BaseBoard",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Win32_AssociatedProcessorMemory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "Win32_AssociatedProcessorMemory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Win32_Account",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "Win32_Account",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "SoftwareLicensingService",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "SoftwareLicensingService",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "SoftwareLicensingProduct",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "SoftwareLicensingProduct",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "MSFT_PhysicalDisk",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "MSAcpi_ThermalZoneTemperature",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "MSAcpi_ThermalZoneTemperature",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "CIM_VoltageSensor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_VoltageSensor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "CIM_VideoSetting",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_VideoSetting",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "CIM_VideoControllerResolution",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_VideoControllerResolution",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "CIM_VideoController",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_VideoController",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "CIM_USBDevice",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_USBDevice",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "CIM_USBController",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_USBController",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_UnitaryComputerSystem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "CIM_TemperatureSensor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_TemperatureSensor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_System",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "CIM_StorageVolume",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_StorageVolume",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_Slot",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "CIM_SerialController",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_SerialController",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "CIM_Sensor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_Sensor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "CIM_SCSIController",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_SCSIController",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "CIM_Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "CIM_Processor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_Processor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "CIM_Process",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_Process",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "CIM_Printer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_Printer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "CIM_PointingDevice",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_PointingDevice",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_PhysicalMemory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_PhysicalElement",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_PhysicalConnector",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "CIM_PCVideoController",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_PCVideoController",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "CIM_OperatingSystem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_OperatingSystem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "CIM_NumericSensor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_NumericSensor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "CIM_NetworkAdapter",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_NetworkAdapter",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "CIM_Memory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_Memory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "CIM_LogicalDisk",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_LogicalDisk",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "CIM_Keyboard",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_Keyboard",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "CIM_InstalledOS",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_InstalledOS",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "CIM_Fan",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_Fan",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "CIM_Display",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_Display",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "CIM_DiskPartition",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_DiskPartition",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_DiskDrive",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "CIM_DesktopMonitor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_DesktopMonitor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "CIM_CurrentSensor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_CurrentSensor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "CIM_CoolingDevice",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_CoolingDevice",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "CIM_Controller",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_Controller",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_ComputerSystem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_Chip",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_Card",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "CIM_BIOSElement",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_BIOSElement",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "CIM_Battery",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "CIM_Battery",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "BatteryStatus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "BatteryStatus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "BatteryStaticData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "BatteryStaticData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "BatteryFullChargedCapacity",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "BatteryFullChargedCapacity",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
