using Microsoft.EntityFrameworkCore.Migrations;

namespace Databases.RetrieverCore.MasterDatabase.Migrations
{
    public partial class UpdatedWmiResultsSetEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "WmiResultsSet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "WmiResultsSet",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Model",
                table: "WmiResultsSet");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "WmiResultsSet");
        }
    }
}
