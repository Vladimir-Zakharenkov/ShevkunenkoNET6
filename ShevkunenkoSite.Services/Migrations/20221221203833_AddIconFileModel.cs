using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShevkunenkoSite.Services.Migrations
{
    public partial class AddIconFileModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IconFile",
                columns: table => new
                {
                    IconFileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IconPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconFileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconFileNameExtension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconMimeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconFileSize = table.Column<long>(type: "bigint", nullable: false),
                    IconWidth = table.Column<long>(type: "bigint", nullable: false),
                    IconHeight = table.Column<long>(type: "bigint", nullable: false),
                    IconRel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IconFile", x => x.IconFileId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IconFile");
        }
    }
}
