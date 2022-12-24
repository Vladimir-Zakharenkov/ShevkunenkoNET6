using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShevkunenkoSite.Services.Migrations
{
    public partial class AddManifestInPageInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Manifest",
                table: "PageInfo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "main.json");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Manifest",
                table: "PageInfo");
        }
    }
}
