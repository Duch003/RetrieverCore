using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Databases.RetrieverCore.MasterDatabase.Migrations
{
    public partial class UpdatedWin32_CDROMDrive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Availability",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Capabilities",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CapabilityDescriptions",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Caption",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompressionMethod",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ConfigManagerErrorCode",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ConfigManagerUserConfig",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreationClassName",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "DefaultBlockSize",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeviceID",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Drive",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DriveIntegrity",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ErrorCleared",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ErrorDescription",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ErrorMethodology",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FileSystemFlags",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "FileSystemFlagsEx",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InstallDate",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastErrorCode",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Manufacturer",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MaxBlockSize",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MaxMediaSize",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "MaximumComponentLength",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "MediaLoaded",
                table: "Win32_CDROMDrive",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "MediaType",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MfrAssignedRevisionLevel",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MinBlockSize",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "NeedsCleaning",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "NumberOfMediaSupported",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PNPDeviceID",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PowerManagementCapabilities",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PowerManagementSupported",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionLevel",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SCSIBus",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SCSILogicalUnit",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SCSIPort",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SCSITargetId",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SerialNumber",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Size",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusInfo",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SystemCreationClassName",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SystemName",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TransferRate",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VolumeName",
                table: "Win32_CDROMDrive",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VolumeSerialNumber",
                table: "Win32_CDROMDrive",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Availability",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "Capabilities",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "CapabilityDescriptions",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "Caption",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "CompressionMethod",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "ConfigManagerErrorCode",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "ConfigManagerUserConfig",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "CreationClassName",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "DefaultBlockSize",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "DeviceID",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "Drive",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "DriveIntegrity",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "ErrorCleared",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "ErrorDescription",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "ErrorMethodology",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "FileSystemFlags",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "FileSystemFlagsEx",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "InstallDate",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "LastErrorCode",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "Manufacturer",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "MaxBlockSize",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "MaxMediaSize",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "MaximumComponentLength",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "MediaLoaded",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "MediaType",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "MfrAssignedRevisionLevel",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "MinBlockSize",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "NeedsCleaning",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "NumberOfMediaSupported",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "PNPDeviceID",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "PowerManagementCapabilities",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "PowerManagementSupported",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "RevisionLevel",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "SCSIBus",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "SCSILogicalUnit",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "SCSIPort",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "SCSITargetId",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "SerialNumber",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "StatusInfo",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "SystemCreationClassName",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "SystemName",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "TransferRate",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "VolumeName",
                table: "Win32_CDROMDrive");

            migrationBuilder.DropColumn(
                name: "VolumeSerialNumber",
                table: "Win32_CDROMDrive");
        }
    }
}
