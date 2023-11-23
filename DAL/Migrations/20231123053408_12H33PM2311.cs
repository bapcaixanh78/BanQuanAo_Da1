using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class _12H33PM2311 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hoadons_Khuyenmais_khuyenmaiId",
                table: "Hoadons");

            migrationBuilder.DropIndex(
                name: "IX_Hoadons_khuyenmaiId",
                table: "Hoadons");

            migrationBuilder.DropColumn(
                name: "Trangthai",
                table: "Quyens");

            migrationBuilder.DropColumn(
                name: "Kieugiamgia",
                table: "Khuyenmais");

            migrationBuilder.DropColumn(
                name: "Trangthai",
                table: "Khachhangs");

            migrationBuilder.DropColumn(
                name: "khuyenmaiId",
                table: "Hoadons");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Anhs",
                newName: "Path");

            migrationBuilder.CreateIndex(
                name: "IX_Hoadons_Idkhuyenmai",
                table: "Hoadons",
                column: "Idkhuyenmai");

            migrationBuilder.AddForeignKey(
                name: "FK_Hoadons_Khuyenmais_Idkhuyenmai",
                table: "Hoadons",
                column: "Idkhuyenmai",
                principalTable: "Khuyenmais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hoadons_Khuyenmais_Idkhuyenmai",
                table: "Hoadons");

            migrationBuilder.DropIndex(
                name: "IX_Hoadons_Idkhuyenmai",
                table: "Hoadons");

            migrationBuilder.RenameColumn(
                name: "Path",
                table: "Anhs",
                newName: "Url");

            migrationBuilder.AddColumn<string>(
                name: "Trangthai",
                table: "Quyens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Kieugiamgia",
                table: "Khuyenmais",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Trangthai",
                table: "Khachhangs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "khuyenmaiId",
                table: "Hoadons",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Hoadons_khuyenmaiId",
                table: "Hoadons",
                column: "khuyenmaiId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hoadons_Khuyenmais_khuyenmaiId",
                table: "Hoadons",
                column: "khuyenmaiId",
                principalTable: "Khuyenmais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
