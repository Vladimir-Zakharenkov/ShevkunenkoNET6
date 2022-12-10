using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShevkunenkoSite.Services.Migrations
{
    public partial class PageInfoRelBackgroundFile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BackgroundFileModelId",
                table: "PageInfo",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_PageInfo_BackgroundFileModelId",
                table: "PageInfo",
                column: "BackgroundFileModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_PageInfo_BackgroundFile_BackgroundFileModelId",
                table: "PageInfo",
                column: "BackgroundFileModelId",
                principalTable: "BackgroundFile",
                principalColumn: "BackgroundFileId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PageInfo_BackgroundFile_BackgroundFileModelId",
                table: "PageInfo");

            migrationBuilder.DropIndex(
                name: "IX_PageInfo_BackgroundFileModelId",
                table: "PageInfo");

            migrationBuilder.DropColumn(
                name: "BackgroundFileModelId",
                table: "PageInfo");
        }
    }
}
