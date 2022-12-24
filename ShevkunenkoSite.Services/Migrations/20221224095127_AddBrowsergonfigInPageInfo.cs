using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShevkunenkoSite.Services.Migrations
{
    public partial class AddBrowsergonfigInPageInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BrowserConfig",
                table: "PageInfo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "main.xml");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrowserConfig",
                table: "PageInfo");
        }
    }
}
