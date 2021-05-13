using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RetrieverCore.MasterDatabase.Migrations
{
    public partial class UpdateGuidAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "Win32_Volume",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "Win32_VideoSettings",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "Win32_VideoController",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "Win32_TimeZone",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "Win32_SoundDevice",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "Win32_SerialPort",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "Win32_Processor",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "Win32_Process",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "Win32_Printer",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "Win32_PortResource",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "Win32_PortConnector",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "Win32_PointingDevice",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "Win32_PnPEntity",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "Win32_PnPDevice",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "Win32_PhysicalMemory",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "Win32_OperatingSystem",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "Win32_NetworkAdapterConfiguration",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "Win32_NetworkAdapter",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "Win32_MotherboardDevice",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "Win32_LogicalDisk",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "Win32_Keyboard",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "Win32_Fan",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "Win32_DiskPartition",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "Win32_DiskDrive",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "Win32_ComputerSystem",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "Win32_CDROMDrive",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "Win32_CacheMemory",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "Win32_Bus",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "Win32_BIOS",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "Win32_Battery",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "Win32_BaseBoard",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "Win32_AssociatedProcessorMemory",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "Win32_Account",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "SoftwareLicensingService",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "SoftwareLicensingProduct",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "MSFT_PhysicalDisk",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "MSAcpi_ThermalZoneTemperature",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_VoltageSensor",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_VideoSetting",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_VideoControllerResolution",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_VideoController",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_USBDevice",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_USBController",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_UnitaryComputerSystem",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_TemperatureSensor",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_System",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_StorageVolume",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_Slot",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_SerialController",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_Sensor",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_SCSIController",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_Product",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_Processor",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_Process",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_Printer",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_PointingDevice",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_PhysicalMemory",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_PhysicalElement",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_PhysicalConnector",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_PCVideoController",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_OperatingSystem",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_NumericSensor",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_NetworkAdapter",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_Memory",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_LogicalDisk",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_Keyboard",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_InstalledOS",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_Fan",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_Display",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_DiskPartition",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_DiskDrive",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_DesktopMonitor",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_CurrentSensor",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_CoolingDevice",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_Controller",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_ComputerSystem",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_Chip",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_Card",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_BIOSElement",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "CIM_Battery",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "BatteryStatus",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "BatteryStaticData",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "BatteryFullChargedCapacity",
                type: "uniqueidentifier",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "Win32_Volume");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "Win32_VideoSettings");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "Win32_VideoController");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "Win32_TimeZone");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "Win32_SoundDevice");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "Win32_SerialPort");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "Win32_Processor");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "Win32_Process");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "Win32_Printer");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "Win32_PortResource");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "Win32_PortConnector");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "Win32_PointingDevice");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "Win32_PnPEntity");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "Win32_PnPDevice");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "Win32_PhysicalMemory");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "Win32_OperatingSystem");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "Win32_NetworkAdapterConfiguration");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "Win32_NetworkAdapter");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "Win32_MotherboardDevice");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "Win32_LogicalDisk");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "Win32_Keyboard");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "Win32_Fan");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "Win32_DiskPartition");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "Win32_DiskDrive");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "Win32_ComputerSystem");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "Win32_CacheMemory");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "Win32_Bus");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "Win32_BIOS");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "Win32_Battery");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "Win32_BaseBoard");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "Win32_AssociatedProcessorMemory");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "Win32_Account");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "SoftwareLicensingService");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "SoftwareLicensingProduct");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "MSFT_PhysicalDisk");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "MSAcpi_ThermalZoneTemperature");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_VoltageSensor");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_VideoSetting");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_VideoControllerResolution");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_VideoController");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_USBDevice");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_USBController");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_UnitaryComputerSystem");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_TemperatureSensor");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_System");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_StorageVolume");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_Slot");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_SerialController");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_Sensor");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_SCSIController");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_Product");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_Processor");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_Process");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_Printer");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_PointingDevice");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_PhysicalMemory");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_PhysicalElement");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_PhysicalConnector");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_PCVideoController");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_OperatingSystem");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_NumericSensor");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_NetworkAdapter");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_Memory");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_LogicalDisk");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_Keyboard");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_InstalledOS");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_Fan");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_Display");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_DiskPartition");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_DiskDrive");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_DesktopMonitor");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_CurrentSensor");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_CoolingDevice");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_Controller");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_ComputerSystem");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_Chip");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_Card");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_BIOSElement");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "CIM_Battery");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "BatteryStatus");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "BatteryStaticData");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "BatteryFullChargedCapacity");
        }
    }
}
