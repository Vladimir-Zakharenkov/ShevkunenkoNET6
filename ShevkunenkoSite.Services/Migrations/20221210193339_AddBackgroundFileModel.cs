using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShevkunenkoSite.Services.Migrations
{
    public partial class AddBackgroundFileModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BackgroundFile",
                columns: table => new
                {
                    BackgroundFileModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LeftBackground = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RightBackground = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackgroundFile", x => x.BackgroundFileModelId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BackgroundFile");
        }
    }
}
