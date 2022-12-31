using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShevkunenkoSite.Services.Migrations
{
    public partial class AddAccess : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Access",
                columns: table => new
                {
                    AccessModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Access", x => x.AccessModelId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Access");
        }
    }
}
