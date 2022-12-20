using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShevkunenkoSite.Services.Migrations
{
    public partial class AddImageFileModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ImageFile",
                columns: table => new
                {
                    ImageFileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageCaption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageContentUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageWidth = table.Column<int>(type: "int", nullable: false),
                    ImageHeight = table.Column<int>(type: "int", nullable: false),
                    ImageThumbnailUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageThumbnailWidth = table.Column<int>(type: "int", nullable: false),
                    ImageThumbnailHeight = table.Column<int>(type: "int", nullable: false),
                    ImageAlt = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageFile", x => x.ImageFileId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImageFile");
        }
    }
}
