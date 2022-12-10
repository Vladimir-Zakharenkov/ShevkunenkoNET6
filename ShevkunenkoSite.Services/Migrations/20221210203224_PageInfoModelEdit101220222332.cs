using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShevkunenkoSite.Services.Migrations
{
    public partial class PageInfoModelEdit101220222332 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PageInfoModelId",
                table: "PageInfo",
                newName: "PageInfoId");

            migrationBuilder.CreateTable(
                name: "BackgroundFile",
                columns: table => new
                {
                    BackgroundFileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LeftBackground = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RightBackground = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackgroundFile", x => x.BackgroundFileId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BackgroundFile");

            migrationBuilder.RenameColumn(
                name: "PageInfoId",
                table: "PageInfo",
                newName: "PageInfoModelId");
        }
    }
}
