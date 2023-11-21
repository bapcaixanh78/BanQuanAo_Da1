using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class Updated_khoa_ngoai_end : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chatlieus_Chitietsanphams_ChitietsanphamId",
                table: "Chatlieus");

            migrationBuilder.DropForeignKey(
                name: "FK_Chitietsanphams_Danhmucs_DanhmucId",
                table: "Chitietsanphams");

            migrationBuilder.DropForeignKey(
                name: "FK_Chitietsanphams_Sanphams_SanphamId",
                table: "Chitietsanphams");

            migrationBuilder.DropForeignKey(
                name: "FK_Hoadonchitiets_Chitietsanphams_chitietsanphamId",
                table: "Hoadonchitiets");

            migrationBuilder.DropForeignKey(
                name: "FK_Hoadonchitiets_Hoadons_HoadonId",
                table: "Hoadonchitiets");

            migrationBuilder.DropForeignKey(
                name: "FK_Hoadons_Khachhangs_KhachhangId",
                table: "Hoadons");

            migrationBuilder.DropForeignKey(
                name: "FK_Hoadons_Nhanvien_NhanvienId",
                table: "Hoadons");

            migrationBuilder.DropForeignKey(
                name: "FK_Kichthuocs_Chitietsanphams_ChitietsanphamId",
                table: "Kichthuocs");

            migrationBuilder.DropForeignKey(
                name: "FK_Mauaos_Chitietsanphams_ChitietsanphamId",
                table: "Mauaos");

            migrationBuilder.DropForeignKey(
                name: "FK_Nhanvien_Quyens_quyenId",
                table: "Nhanvien");

            migrationBuilder.DropIndex(
                name: "IX_Nhanvien_quyenId",
                table: "Nhanvien");

            migrationBuilder.DropIndex(
                name: "IX_Hoadons_KhachhangId",
                table: "Hoadons");

            migrationBuilder.DropIndex(
                name: "IX_Hoadons_NhanvienId",
                table: "Hoadons");

            migrationBuilder.DropIndex(
                name: "IX_Hoadonchitiets_chitietsanphamId",
                table: "Hoadonchitiets");

            migrationBuilder.DropIndex(
                name: "IX_Hoadonchitiets_HoadonId",
                table: "Hoadonchitiets");

            migrationBuilder.DropIndex(
                name: "IX_Chitietsanphams_DanhmucId",
                table: "Chitietsanphams");

            migrationBuilder.DropIndex(
                name: "IX_Chitietsanphams_SanphamId",
                table: "Chitietsanphams");

            migrationBuilder.DropColumn(
                name: "quyenId",
                table: "Nhanvien");

            migrationBuilder.DropColumn(
                name: "Idchitietsanpham",
                table: "Mauaos");

            migrationBuilder.DropColumn(
                name: "IdChitietsanpham",
                table: "Kichthuocs");

            migrationBuilder.DropColumn(
                name: "KhachhangId",
                table: "Hoadons");

            migrationBuilder.DropColumn(
                name: "NhanvienId",
                table: "Hoadons");

            migrationBuilder.DropColumn(
                name: "HoadonId",
                table: "Hoadonchitiets");

            migrationBuilder.DropColumn(
                name: "chitietsanphamId",
                table: "Hoadonchitiets");

            migrationBuilder.DropColumn(
                name: "DanhmucId",
                table: "Chitietsanphams");

            migrationBuilder.DropColumn(
                name: "SanphamId",
                table: "Chitietsanphams");

            migrationBuilder.AlterColumn<Guid>(
                name: "ChitietsanphamId",
                table: "Mauaos",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "ChitietsanphamId",
                table: "Kichthuocs",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "ChitietsanphamId",
                table: "Chatlieus",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_Nhanvien_Idquyen",
                table: "Nhanvien",
                column: "Idquyen");

            migrationBuilder.CreateIndex(
                name: "IX_Hoadons_Idkhachhang",
                table: "Hoadons",
                column: "Idkhachhang");

            migrationBuilder.CreateIndex(
                name: "IX_Hoadons_Idnhanvien",
                table: "Hoadons",
                column: "Idnhanvien");

            migrationBuilder.CreateIndex(
                name: "IX_Hoadonchitiets_Idchitietsanpham",
                table: "Hoadonchitiets",
                column: "Idchitietsanpham");

            migrationBuilder.CreateIndex(
                name: "IX_Hoadonchitiets_Idhoadon",
                table: "Hoadonchitiets",
                column: "Idhoadon");

            migrationBuilder.CreateIndex(
                name: "IX_Chitietsanphams_Iddanhmuc",
                table: "Chitietsanphams",
                column: "Iddanhmuc");

            migrationBuilder.CreateIndex(
                name: "IX_Chitietsanphams_Idsanpham",
                table: "Chitietsanphams",
                column: "Idsanpham");

            migrationBuilder.AddForeignKey(
                name: "FK_Chatlieus_Chitietsanphams_ChitietsanphamId",
                table: "Chatlieus",
                column: "ChitietsanphamId",
                principalTable: "Chitietsanphams",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Chitietsanphams_Danhmucs_Iddanhmuc",
                table: "Chitietsanphams",
                column: "Iddanhmuc",
                principalTable: "Danhmucs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Chitietsanphams_Sanphams_Idsanpham",
                table: "Chitietsanphams",
                column: "Idsanpham",
                principalTable: "Sanphams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Hoadonchitiets_Chitietsanphams_Idchitietsanpham",
                table: "Hoadonchitiets",
                column: "Idchitietsanpham",
                principalTable: "Chitietsanphams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Hoadonchitiets_Hoadons_Idhoadon",
                table: "Hoadonchitiets",
                column: "Idhoadon",
                principalTable: "Hoadons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Hoadons_Khachhangs_Idkhachhang",
                table: "Hoadons",
                column: "Idkhachhang",
                principalTable: "Khachhangs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Hoadons_Nhanvien_Idnhanvien",
                table: "Hoadons",
                column: "Idnhanvien",
                principalTable: "Nhanvien",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Kichthuocs_Chitietsanphams_ChitietsanphamId",
                table: "Kichthuocs",
                column: "ChitietsanphamId",
                principalTable: "Chitietsanphams",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Mauaos_Chitietsanphams_ChitietsanphamId",
                table: "Mauaos",
                column: "ChitietsanphamId",
                principalTable: "Chitietsanphams",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Nhanvien_Quyens_Idquyen",
                table: "Nhanvien",
                column: "Idquyen",
                principalTable: "Quyens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chatlieus_Chitietsanphams_ChitietsanphamId",
                table: "Chatlieus");

            migrationBuilder.DropForeignKey(
                name: "FK_Chitietsanphams_Danhmucs_Iddanhmuc",
                table: "Chitietsanphams");

            migrationBuilder.DropForeignKey(
                name: "FK_Chitietsanphams_Sanphams_Idsanpham",
                table: "Chitietsanphams");

            migrationBuilder.DropForeignKey(
                name: "FK_Hoadonchitiets_Chitietsanphams_Idchitietsanpham",
                table: "Hoadonchitiets");

            migrationBuilder.DropForeignKey(
                name: "FK_Hoadonchitiets_Hoadons_Idhoadon",
                table: "Hoadonchitiets");

            migrationBuilder.DropForeignKey(
                name: "FK_Hoadons_Khachhangs_Idkhachhang",
                table: "Hoadons");

            migrationBuilder.DropForeignKey(
                name: "FK_Hoadons_Nhanvien_Idnhanvien",
                table: "Hoadons");

            migrationBuilder.DropForeignKey(
                name: "FK_Kichthuocs_Chitietsanphams_ChitietsanphamId",
                table: "Kichthuocs");

            migrationBuilder.DropForeignKey(
                name: "FK_Mauaos_Chitietsanphams_ChitietsanphamId",
                table: "Mauaos");

            migrationBuilder.DropForeignKey(
                name: "FK_Nhanvien_Quyens_Idquyen",
                table: "Nhanvien");

            migrationBuilder.DropIndex(
                name: "IX_Nhanvien_Idquyen",
                table: "Nhanvien");

            migrationBuilder.DropIndex(
                name: "IX_Hoadons_Idkhachhang",
                table: "Hoadons");

            migrationBuilder.DropIndex(
                name: "IX_Hoadons_Idnhanvien",
                table: "Hoadons");

            migrationBuilder.DropIndex(
                name: "IX_Hoadonchitiets_Idchitietsanpham",
                table: "Hoadonchitiets");

            migrationBuilder.DropIndex(
                name: "IX_Hoadonchitiets_Idhoadon",
                table: "Hoadonchitiets");

            migrationBuilder.DropIndex(
                name: "IX_Chitietsanphams_Iddanhmuc",
                table: "Chitietsanphams");

            migrationBuilder.DropIndex(
                name: "IX_Chitietsanphams_Idsanpham",
                table: "Chitietsanphams");

            migrationBuilder.AddColumn<Guid>(
                name: "quyenId",
                table: "Nhanvien",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ChitietsanphamId",
                table: "Mauaos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Idchitietsanpham",
                table: "Mauaos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ChitietsanphamId",
                table: "Kichthuocs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdChitietsanpham",
                table: "Kichthuocs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "KhachhangId",
                table: "Hoadons",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "NhanvienId",
                table: "Hoadons",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "HoadonId",
                table: "Hoadonchitiets",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "chitietsanphamId",
                table: "Hoadonchitiets",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "DanhmucId",
                table: "Chitietsanphams",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SanphamId",
                table: "Chitietsanphams",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ChitietsanphamId",
                table: "Chatlieus",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nhanvien_quyenId",
                table: "Nhanvien",
                column: "quyenId");

            migrationBuilder.CreateIndex(
                name: "IX_Hoadons_KhachhangId",
                table: "Hoadons",
                column: "KhachhangId");

            migrationBuilder.CreateIndex(
                name: "IX_Hoadons_NhanvienId",
                table: "Hoadons",
                column: "NhanvienId");

            migrationBuilder.CreateIndex(
                name: "IX_Hoadonchitiets_chitietsanphamId",
                table: "Hoadonchitiets",
                column: "chitietsanphamId");

            migrationBuilder.CreateIndex(
                name: "IX_Hoadonchitiets_HoadonId",
                table: "Hoadonchitiets",
                column: "HoadonId");

            migrationBuilder.CreateIndex(
                name: "IX_Chitietsanphams_DanhmucId",
                table: "Chitietsanphams",
                column: "DanhmucId");

            migrationBuilder.CreateIndex(
                name: "IX_Chitietsanphams_SanphamId",
                table: "Chitietsanphams",
                column: "SanphamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chatlieus_Chitietsanphams_ChitietsanphamId",
                table: "Chatlieus",
                column: "ChitietsanphamId",
                principalTable: "Chitietsanphams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Chitietsanphams_Danhmucs_DanhmucId",
                table: "Chitietsanphams",
                column: "DanhmucId",
                principalTable: "Danhmucs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Chitietsanphams_Sanphams_SanphamId",
                table: "Chitietsanphams",
                column: "SanphamId",
                principalTable: "Sanphams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hoadonchitiets_Chitietsanphams_chitietsanphamId",
                table: "Hoadonchitiets",
                column: "chitietsanphamId",
                principalTable: "Chitietsanphams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hoadonchitiets_Hoadons_HoadonId",
                table: "Hoadonchitiets",
                column: "HoadonId",
                principalTable: "Hoadons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hoadons_Khachhangs_KhachhangId",
                table: "Hoadons",
                column: "KhachhangId",
                principalTable: "Khachhangs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hoadons_Nhanvien_NhanvienId",
                table: "Hoadons",
                column: "NhanvienId",
                principalTable: "Nhanvien",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kichthuocs_Chitietsanphams_ChitietsanphamId",
                table: "Kichthuocs",
                column: "ChitietsanphamId",
                principalTable: "Chitietsanphams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mauaos_Chitietsanphams_ChitietsanphamId",
                table: "Mauaos",
                column: "ChitietsanphamId",
                principalTable: "Chitietsanphams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nhanvien_Quyens_quyenId",
                table: "Nhanvien",
                column: "quyenId",
                principalTable: "Quyens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
