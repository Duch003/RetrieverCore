using Microsoft.EntityFrameworkCore.Migrations;

namespace RetrieverCore.IO.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MainboardEntity",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Manufacturer = table.Column<string>(nullable: true),
                    Socket = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    ProcessorID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainboardEntity", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ComputerEntity",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Vendor = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    MainboardID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerEntity", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ComputerEntity_MainboardEntity_MainboardID",
                        column: x => x.MainboardID,
                        principalTable: "MainboardEntity",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MainboardPortEntity",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    MainboardEntityID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainboardPortEntity", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MainboardPortEntity_MainboardEntity_MainboardEntityID",
                        column: x => x.MainboardEntityID,
                        principalTable: "MainboardEntity",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProcessorEntity",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Manufacturer = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    L2CacheSize = table.Column<double>(nullable: false),
                    L3CacheSize = table.Column<double>(nullable: false),
                    ClockSpeed = table.Column<double>(nullable: false),
                    Cores = table.Column<byte>(nullable: false),
                    LogicalProcessor = table.Column<byte>(nullable: false),
                    Socket = table.Column<string>(nullable: true),
                    Architecture = table.Column<string>(nullable: true),
                    MainboardEntityID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessorEntity", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProcessorEntity_MainboardEntity_MainboardEntityID",
                        column: x => x.MainboardEntityID,
                        principalTable: "MainboardEntity",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BatteryEntity",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Voltage = table.Column<double>(nullable: false),
                    Vendor = table.Column<string>(nullable: true),
                    MaxWearLevel = table.Column<double>(nullable: false),
                    ComputerEntityID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatteryEntity", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BatteryEntity_ComputerEntity_ComputerEntityID",
                        column: x => x.ComputerEntityID,
                        principalTable: "ComputerEntity",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DDREntity",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Capacity = table.Column<int>(nullable: false),
                    Clocking = table.Column<int>(nullable: false),
                    ComputerEntityID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DDREntity", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DDREntity_ComputerEntity_ComputerEntityID",
                        column: x => x.ComputerEntityID,
                        principalTable: "ComputerEntity",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GPUEntity",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Manufacturer = table.Column<string>(nullable: true),
                    MemorySize = table.Column<double>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    ScreenHeight = table.Column<int>(nullable: false),
                    ScreenWidth = table.Column<int>(nullable: false),
                    ComputerEntityID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GPUEntity", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GPUEntity_ComputerEntity_ComputerEntityID",
                        column: x => x.ComputerEntityID,
                        principalTable: "ComputerEntity",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NetworkInterfaceEntity",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Vendor = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    ComputerEntityID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NetworkInterfaceEntity", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NetworkInterfaceEntity_ComputerEntity_ComputerEntityID",
                        column: x => x.ComputerEntityID,
                        principalTable: "ComputerEntity",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StorageEntity",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Capacity = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    ComputerEntityID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageEntity", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StorageEntity_ComputerEntity_ComputerEntityID",
                        column: x => x.ComputerEntityID,
                        principalTable: "ComputerEntity",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BatteryEntity_ComputerEntityID",
                table: "BatteryEntity",
                column: "ComputerEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerEntity_MainboardID",
                table: "ComputerEntity",
                column: "MainboardID");

            migrationBuilder.CreateIndex(
                name: "IX_DDREntity_ComputerEntityID",
                table: "DDREntity",
                column: "ComputerEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_GPUEntity_ComputerEntityID",
                table: "GPUEntity",
                column: "ComputerEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_MainboardPortEntity_MainboardEntityID",
                table: "MainboardPortEntity",
                column: "MainboardEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_NetworkInterfaceEntity_ComputerEntityID",
                table: "NetworkInterfaceEntity",
                column: "ComputerEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessorEntity_MainboardEntityID",
                table: "ProcessorEntity",
                column: "MainboardEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_StorageEntity_ComputerEntityID",
                table: "StorageEntity",
                column: "ComputerEntityID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BatteryEntity");

            migrationBuilder.DropTable(
                name: "DDREntity");

            migrationBuilder.DropTable(
                name: "GPUEntity");

            migrationBuilder.DropTable(
                name: "MainboardPortEntity");

            migrationBuilder.DropTable(
                name: "NetworkInterfaceEntity");

            migrationBuilder.DropTable(
                name: "ProcessorEntity");

            migrationBuilder.DropTable(
                name: "StorageEntity");

            migrationBuilder.DropTable(
                name: "ComputerEntity");

            migrationBuilder.DropTable(
                name: "MainboardEntity");
        }
    }
}
