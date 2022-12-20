using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShevkunenkoSite.Services.Migrations
{
    public partial class PageInfoRelImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PageInfo_ImageFile_ImageFileModelImageId",
                table: "PageInfo");

            migrationBuilder.DropIndex(
                name: "IX_PageInfo_ImageFileModelImageId",
                table: "PageInfo");

            migrationBuilder.DropColumn(
                name: "ImageFileModelImageId",
                table: "PageInfo");

            migrationBuilder.RenameColumn(
                name: "ImageId",
                table: "PageInfo",
                newName: "ImageFileModelId");

            migrationBuilder.CreateIndex(
                name: "IX_PageInfo_ImageFileModelId",
                table: "PageInfo",
                column: "ImageFileModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_PageInfo_ImageFile_ImageFileModelId",
                table: "PageInfo",
                column: "ImageFileModelId",
                principalTable: "ImageFile",
                principalColumn: "ImageFileId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PageInfo_ImageFile_ImageFileModelId",
                table: "PageInfo");

            migrationBuilder.DropIndex(
                name: "IX_PageInfo_ImageFileModelId",
                table: "PageInfo");

            migrationBuilder.RenameColumn(
                name: "ImageFileModelId",
                table: "PageInfo",
                newName: "ImageId");

            migrationBuilder.AddColumn<Guid>(
                name: "ImageFileModelImageId",
                table: "PageInfo",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_PageInfo_ImageFileModelImageId",
                table: "PageInfo",
                column: "ImageFileModelImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_PageInfo_ImageFile_ImageFileModelImageId",
                table: "PageInfo",
                column: "ImageFileModelImageId",
                principalTable: "ImageFile",
                principalColumn: "ImageFileId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
