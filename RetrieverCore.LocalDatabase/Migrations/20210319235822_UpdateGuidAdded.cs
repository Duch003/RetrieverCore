using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RetrieverCore.LocalDatabase.Migrations
{
    public partial class UpdateGuidAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MainboardPorts_Mainboards_MainboardEntityID",
                table: "MainboardPorts");

            migrationBuilder.DropForeignKey(
                name: "FK_Processors_Mainboards_MainboardEntityID",
                table: "Processors");

            migrationBuilder.DropColumn(
                name: "ProcessorID",
                table: "Mainboards");

            migrationBuilder.DropColumn(
                name: "MaxWearLevel",
                table: "Batteries");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Storages",
                newName: "UpdateID");

            migrationBuilder.RenameColumn(
                name: "MainboardEntityID",
                table: "Processors",
                newName: "ComputerEntityID");

            migrationBuilder.RenameColumn(
                name: "LogicalProcessor",
                table: "Processors",
                newName: "LogicalProcessors");

            migrationBuilder.RenameIndex(
                name: "IX_Processors_MainboardEntityID",
                table: "Processors",
                newName: "IX_Processors_ComputerEntityID");

            migrationBuilder.RenameColumn(
                name: "Vendor",
                table: "NetworkInterfaces",
                newName: "UpdateID");

            migrationBuilder.RenameColumn(
                name: "Model",
                table: "NetworkInterfaces",
                newName: "ProductName");

            migrationBuilder.RenameColumn(
                name: "Socket",
                table: "Mainboards",
                newName: "Version");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "MainboardPorts",
                newName: "UpdateID");

            migrationBuilder.RenameColumn(
                name: "MainboardEntityID",
                table: "MainboardPorts",
                newName: "ComputerEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_MainboardPorts_MainboardEntityID",
                table: "MainboardPorts",
                newName: "IX_MainboardPorts_ComputerEntityID");

            migrationBuilder.RenameColumn(
                name: "Clocking",
                table: "DDRs",
                newName: "SetClocking");

            migrationBuilder.RenameColumn(
                name: "Voltage",
                table: "Batteries",
                newName: "DesignedCapacity");

            migrationBuilder.RenameColumn(
                name: "Vendor",
                table: "Batteries",
                newName: "UpdateID");

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "Processors",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdapterType",
                table: "NetworkInterfaces",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Caption",
                table: "NetworkInterfaces",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Manufacturer",
                table: "NetworkInterfaces",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NetworkInterfaceType",
                table: "NetworkInterfaces",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "Mainboards",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExternalName",
                table: "MainboardPorts",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InternalName",
                table: "MainboardPorts",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PortType",
                table: "MainboardPorts",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "GPUs",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DesignedClocking",
                table: "DDRs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "DDRs",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateID",
                table: "Computers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MainboardPorts_Computers_ComputerEntityID",
                table: "MainboardPorts",
                column: "ComputerEntityID",
                principalTable: "Computers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Processors_Computers_ComputerEntityID",
                table: "Processors",
                column: "ComputerEntityID",
                principalTable: "Computers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MainboardPorts_Computers_ComputerEntityID",
                table: "MainboardPorts");

            migrationBuilder.DropForeignKey(
                name: "FK_Processors_Computers_ComputerEntityID",
                table: "Processors");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "Processors");

            migrationBuilder.DropColumn(
                name: "AdapterType",
                table: "NetworkInterfaces");

            migrationBuilder.DropColumn(
                name: "Caption",
                table: "NetworkInterfaces");

            migrationBuilder.DropColumn(
                name: "Manufacturer",
                table: "NetworkInterfaces");

            migrationBuilder.DropColumn(
                name: "NetworkInterfaceType",
                table: "NetworkInterfaces");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "Mainboards");

            migrationBuilder.DropColumn(
                name: "ExternalName",
                table: "MainboardPorts");

            migrationBuilder.DropColumn(
                name: "InternalName",
                table: "MainboardPorts");

            migrationBuilder.DropColumn(
                name: "PortType",
                table: "MainboardPorts");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "GPUs");

            migrationBuilder.DropColumn(
                name: "DesignedClocking",
                table: "DDRs");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "DDRs");

            migrationBuilder.DropColumn(
                name: "UpdateID",
                table: "Computers");

            migrationBuilder.RenameColumn(
                name: "UpdateID",
                table: "Storages",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "LogicalProcessors",
                table: "Processors",
                newName: "LogicalProcessor");

            migrationBuilder.RenameColumn(
                name: "ComputerEntityID",
                table: "Processors",
                newName: "MainboardEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_Processors_ComputerEntityID",
                table: "Processors",
                newName: "IX_Processors_MainboardEntityID");

            migrationBuilder.RenameColumn(
                name: "UpdateID",
                table: "NetworkInterfaces",
                newName: "Vendor");

            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "NetworkInterfaces",
                newName: "Model");

            migrationBuilder.RenameColumn(
                name: "Version",
                table: "Mainboards",
                newName: "Socket");

            migrationBuilder.RenameColumn(
                name: "UpdateID",
                table: "MainboardPorts",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ComputerEntityID",
                table: "MainboardPorts",
                newName: "MainboardEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_MainboardPorts_ComputerEntityID",
                table: "MainboardPorts",
                newName: "IX_MainboardPorts_MainboardEntityID");

            migrationBuilder.RenameColumn(
                name: "SetClocking",
                table: "DDRs",
                newName: "Clocking");

            migrationBuilder.RenameColumn(
                name: "UpdateID",
                table: "Batteries",
                newName: "Vendor");

            migrationBuilder.RenameColumn(
                name: "DesignedCapacity",
                table: "Batteries",
                newName: "Voltage");

            migrationBuilder.AddColumn<int>(
                name: "ProcessorID",
                table: "Mainboards",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "MaxWearLevel",
                table: "Batteries",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddForeignKey(
                name: "FK_MainboardPorts_Mainboards_MainboardEntityID",
                table: "MainboardPorts",
                column: "MainboardEntityID",
                principalTable: "Mainboards",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Processors_Mainboards_MainboardEntityID",
                table: "Processors",
                column: "MainboardEntityID",
                principalTable: "Mainboards",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
