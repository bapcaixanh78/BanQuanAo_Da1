using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class _12H50PM2311 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ten",
                table: "Khuyenmais",
                newName: "Tenmakhuyenmai");

            migrationBuilder.AddColumn<DateTime>(
                name: "Thoigianbatdau",
                table: "Khuyenmais",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Thoigianketthuc",
                table: "Khuyenmais",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Thoigianbatdau",
                table: "Khuyenmais");

            migrationBuilder.DropColumn(
                name: "Thoigianketthuc",
                table: "Khuyenmais");

            migrationBuilder.RenameColumn(
                name: "Tenmakhuyenmai",
                table: "Khuyenmais",
                newName: "Ten");
        }
    }
}
