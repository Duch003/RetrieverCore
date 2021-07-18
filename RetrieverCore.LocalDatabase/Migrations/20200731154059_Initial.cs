using Microsoft.EntityFrameworkCore.Migrations;

namespace Databases.RetrieverCore.LocalDatabase.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mainboards",
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
                    table.PrimaryKey("PK_Mainboards", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Computers",
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
                    table.PrimaryKey("PK_Computers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Computers_Mainboards_MainboardID",
                        column: x => x.MainboardID,
                        principalTable: "Mainboards",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MainboardPorts",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    MainboardEntityID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainboardPorts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MainboardPorts_Mainboards_MainboardEntityID",
                        column: x => x.MainboardEntityID,
                        principalTable: "Mainboards",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Processors",
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
                    table.PrimaryKey("PK_Processors", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Processors_Mainboards_MainboardEntityID",
                        column: x => x.MainboardEntityID,
                        principalTable: "Mainboards",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Batteries",
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
                    table.PrimaryKey("PK_Batteries", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Batteries_Computers_ComputerEntityID",
                        column: x => x.ComputerEntityID,
                        principalTable: "Computers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DDRs",
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
                    table.PrimaryKey("PK_DDRs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DDRs_Computers_ComputerEntityID",
                        column: x => x.ComputerEntityID,
                        principalTable: "Computers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GPUs",
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
                    table.PrimaryKey("PK_GPUs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GPUs_Computers_ComputerEntityID",
                        column: x => x.ComputerEntityID,
                        principalTable: "Computers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NetworkInterfaces",
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
                    table.PrimaryKey("PK_NetworkInterfaces", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NetworkInterfaces_Computers_ComputerEntityID",
                        column: x => x.ComputerEntityID,
                        principalTable: "Computers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Storages",
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
                    table.PrimaryKey("PK_Storages", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Storages_Computers_ComputerEntityID",
                        column: x => x.ComputerEntityID,
                        principalTable: "Computers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Batteries_ComputerEntityID",
                table: "Batteries",
                column: "ComputerEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Computers_MainboardID",
                table: "Computers",
                column: "MainboardID");

            migrationBuilder.CreateIndex(
                name: "IX_DDRs_ComputerEntityID",
                table: "DDRs",
                column: "ComputerEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_GPUs_ComputerEntityID",
                table: "GPUs",
                column: "ComputerEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_MainboardPorts_MainboardEntityID",
                table: "MainboardPorts",
                column: "MainboardEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_NetworkInterfaces_ComputerEntityID",
                table: "NetworkInterfaces",
                column: "ComputerEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Processors_MainboardEntityID",
                table: "Processors",
                column: "MainboardEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Storages_ComputerEntityID",
                table: "Storages",
                column: "ComputerEntityID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Batteries");

            migrationBuilder.DropTable(
                name: "DDRs");

            migrationBuilder.DropTable(
                name: "GPUs");

            migrationBuilder.DropTable(
                name: "MainboardPorts");

            migrationBuilder.DropTable(
                name: "NetworkInterfaces");

            migrationBuilder.DropTable(
                name: "Processors");

            migrationBuilder.DropTable(
                name: "Storages");

            migrationBuilder.DropTable(
                name: "Computers");

            migrationBuilder.DropTable(
                name: "Mainboards");
        }
    }
}
