using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class update_anh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Anhs_Sanphams_SanphamId",
                table: "Anhs");

            migrationBuilder.DropColumn(
                name: "IdSanpham",
                table: "Anhs");

            migrationBuilder.AlterColumn<Guid>(
                name: "SanphamId",
                table: "Anhs",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Anhs_Sanphams_SanphamId",
                table: "Anhs",
                column: "SanphamId",
                principalTable: "Sanphams",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Anhs_Sanphams_SanphamId",
                table: "Anhs");

            migrationBuilder.AlterColumn<Guid>(
                name: "SanphamId",
                table: "Anhs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdSanpham",
                table: "Anhs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddForeignKey(
                name: "FK_Anhs_Sanphams_SanphamId",
                table: "Anhs",
                column: "SanphamId",
                principalTable: "Sanphams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
