using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class _5h40PM2211 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Anhs_Chitietsanphams_Idanh",
                table: "Anhs");

            migrationBuilder.AddColumn<Guid>(
                name: "IdAnh",
                table: "Chitietsanphams",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Chitietsanphams_IdAnh",
                table: "Chitietsanphams",
                column: "IdAnh");

            migrationBuilder.AddForeignKey(
                name: "FK_Chitietsanphams_Anhs_IdAnh",
                table: "Chitietsanphams",
                column: "IdAnh",
                principalTable: "Anhs",
                principalColumn: "Idanh",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chitietsanphams_Anhs_IdAnh",
                table: "Chitietsanphams");

            migrationBuilder.DropIndex(
                name: "IX_Chitietsanphams_IdAnh",
                table: "Chitietsanphams");

            migrationBuilder.DropColumn(
                name: "IdAnh",
                table: "Chitietsanphams");

            migrationBuilder.AddForeignKey(
                name: "FK_Anhs_Chitietsanphams_Idanh",
                table: "Anhs",
                column: "Idanh",
                principalTable: "Chitietsanphams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
