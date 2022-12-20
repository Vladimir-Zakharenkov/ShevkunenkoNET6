using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShevkunenkoSite.Services.Migrations
{
    public partial class EditImageFileModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageThumbnailHeight",
                table: "ImageFile");

            migrationBuilder.DropColumn(
                name: "ImageThumbnailWidth",
                table: "ImageFile");

            migrationBuilder.RenameColumn(
                name: "ImageThumbnailUrl",
                table: "ImageFile",
                newName: "ImagePath");

            migrationBuilder.RenameColumn(
                name: "ImageContentUrl",
                table: "ImageFile",
                newName: "ImageMimeType");

            migrationBuilder.RenameColumn(
                name: "ImageAlt",
                table: "ImageFile",
                newName: "ImageFileNameExtension");

            migrationBuilder.AlterColumn<long>(
                name: "ImageWidth",
                table: "ImageFile",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "ImageHeight",
                table: "ImageFile",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ImageDescription",
                table: "ImageFile",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ImageCaption",
                table: "ImageFile",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "IconFileName",
                table: "ImageFile",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IconFileNameExtension",
                table: "ImageFile",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "IconFileSize",
                table: "ImageFile",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "IconHeight",
                table: "ImageFile",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "IconMimeType",
                table: "ImageFile",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "IconWidth",
                table: "ImageFile",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "ImageAltTitle",
                table: "ImageFile",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageFileName",
                table: "ImageFile",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "ImageFileSize",
                table: "ImageFile",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IconFileName",
                table: "ImageFile");

            migrationBuilder.DropColumn(
                name: "IconFileNameExtension",
                table: "ImageFile");

            migrationBuilder.DropColumn(
                name: "IconFileSize",
                table: "ImageFile");

            migrationBuilder.DropColumn(
                name: "IconHeight",
                table: "ImageFile");

            migrationBuilder.DropColumn(
                name: "IconMimeType",
                table: "ImageFile");

            migrationBuilder.DropColumn(
                name: "IconWidth",
                table: "ImageFile");

            migrationBuilder.DropColumn(
                name: "ImageAltTitle",
                table: "ImageFile");

            migrationBuilder.DropColumn(
                name: "ImageFileName",
                table: "ImageFile");

            migrationBuilder.DropColumn(
                name: "ImageFileSize",
                table: "ImageFile");

            migrationBuilder.RenameColumn(
                name: "ImagePath",
                table: "ImageFile",
                newName: "ImageThumbnailUrl");

            migrationBuilder.RenameColumn(
                name: "ImageMimeType",
                table: "ImageFile",
                newName: "ImageContentUrl");

            migrationBuilder.RenameColumn(
                name: "ImageFileNameExtension",
                table: "ImageFile",
                newName: "ImageAlt");

            migrationBuilder.AlterColumn<int>(
                name: "ImageWidth",
                table: "ImageFile",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "ImageHeight",
                table: "ImageFile",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "ImageDescription",
                table: "ImageFile",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<string>(
                name: "ImageCaption",
                table: "ImageFile",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AddColumn<int>(
                name: "ImageThumbnailHeight",
                table: "ImageFile",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ImageThumbnailWidth",
                table: "ImageFile",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
