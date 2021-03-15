using Microsoft.EntityFrameworkCore.Migrations;

namespace RetrieverCore.MasterDatabase.Migrations
{
    public partial class UpdatedWin32_CDROMDriveProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "MediaLoaded",
                table: "Win32_CDROMDrive",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "MediaLoaded",
                table: "Win32_CDROMDrive",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);
        }
    }
}
