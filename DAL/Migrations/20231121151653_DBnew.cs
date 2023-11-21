﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class DBnew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chatlieus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trangthai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chatlieus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Danhmucs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trangthai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ghichu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Danhmucs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Khachhangs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sdt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trangthai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khachhangs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Khuyenmais",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Giamgia = table.Column<int>(type: "int", nullable: false),
                    Kieugiamgia = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khuyenmais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kichthuocs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trangthai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kichthuocs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mauaos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Mau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trangthai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mauaos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Quyens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trangthai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quyens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sanphams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sanphams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nhanvien",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diachi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ngaytao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Trangthai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idquyen = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nhanvien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nhanvien_Quyens_Idquyen",
                        column: x => x.Idquyen,
                        principalTable: "Quyens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Chitietsanphams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Gianhap = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Giaban = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Ngaytao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Soluongton = table.Column<int>(type: "int", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ngaycapnhat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Trangthai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idsanpham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Iddanhmuc = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Idmauao = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Idchatlieu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Idkichthuoc = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chitietsanphams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chitietsanphams_Chatlieus_Idchatlieu",
                        column: x => x.Idchatlieu,
                        principalTable: "Chatlieus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chitietsanphams_Danhmucs_Iddanhmuc",
                        column: x => x.Iddanhmuc,
                        principalTable: "Danhmucs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chitietsanphams_Kichthuocs_Idkichthuoc",
                        column: x => x.Idkichthuoc,
                        principalTable: "Kichthuocs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chitietsanphams_Mauaos_Idmauao",
                        column: x => x.Idmauao,
                        principalTable: "Mauaos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chitietsanphams_Sanphams_Idsanpham",
                        column: x => x.Idsanpham,
                        principalTable: "Sanphams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Hoadons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ngaytao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ghichu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trangthai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idnhanvien = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Idkhachhang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Idkhuyenmai = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    khuyenmaiId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hoadons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hoadons_Khachhangs_Idkhachhang",
                        column: x => x.Idkhachhang,
                        principalTable: "Khachhangs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Hoadons_Khuyenmais_khuyenmaiId",
                        column: x => x.khuyenmaiId,
                        principalTable: "Khuyenmais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hoadons_Nhanvien_Idnhanvien",
                        column: x => x.Idnhanvien,
                        principalTable: "Nhanvien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Anhs",
                columns: table => new
                {
                    Idanh = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FK_Chitietsanpham = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anhs", x => x.Idanh);
                    table.ForeignKey(
                        name: "FK_Anhs_Chitietsanphams_Idanh",
                        column: x => x.Idanh,
                        principalTable: "Chitietsanphams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hoadonchitiets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Soluong = table.Column<int>(type: "int", nullable: false),
                    Giaban = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Idhoadon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Idchitietsanpham = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hoadonchitiets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hoadonchitiets_Chitietsanphams_Idchitietsanpham",
                        column: x => x.Idchitietsanpham,
                        principalTable: "Chitietsanphams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Hoadonchitiets_Hoadons_Idhoadon",
                        column: x => x.Idhoadon,
                        principalTable: "Hoadons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chitietsanphams_Idchatlieu",
                table: "Chitietsanphams",
                column: "Idchatlieu");

            migrationBuilder.CreateIndex(
                name: "IX_Chitietsanphams_Iddanhmuc",
                table: "Chitietsanphams",
                column: "Iddanhmuc");

            migrationBuilder.CreateIndex(
                name: "IX_Chitietsanphams_Idkichthuoc",
                table: "Chitietsanphams",
                column: "Idkichthuoc");

            migrationBuilder.CreateIndex(
                name: "IX_Chitietsanphams_Idmauao",
                table: "Chitietsanphams",
                column: "Idmauao");

            migrationBuilder.CreateIndex(
                name: "IX_Chitietsanphams_Idsanpham",
                table: "Chitietsanphams",
                column: "Idsanpham");

            migrationBuilder.CreateIndex(
                name: "IX_Hoadonchitiets_Idchitietsanpham",
                table: "Hoadonchitiets",
                column: "Idchitietsanpham");

            migrationBuilder.CreateIndex(
                name: "IX_Hoadonchitiets_Idhoadon",
                table: "Hoadonchitiets",
                column: "Idhoadon");

            migrationBuilder.CreateIndex(
                name: "IX_Hoadons_Idkhachhang",
                table: "Hoadons",
                column: "Idkhachhang");

            migrationBuilder.CreateIndex(
                name: "IX_Hoadons_Idnhanvien",
                table: "Hoadons",
                column: "Idnhanvien");

            migrationBuilder.CreateIndex(
                name: "IX_Hoadons_khuyenmaiId",
                table: "Hoadons",
                column: "khuyenmaiId");

            migrationBuilder.CreateIndex(
                name: "IX_Nhanvien_Idquyen",
                table: "Nhanvien",
                column: "Idquyen");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anhs");

            migrationBuilder.DropTable(
                name: "Hoadonchitiets");

            migrationBuilder.DropTable(
                name: "Chitietsanphams");

            migrationBuilder.DropTable(
                name: "Hoadons");

            migrationBuilder.DropTable(
                name: "Chatlieus");

            migrationBuilder.DropTable(
                name: "Danhmucs");

            migrationBuilder.DropTable(
                name: "Kichthuocs");

            migrationBuilder.DropTable(
                name: "Mauaos");

            migrationBuilder.DropTable(
                name: "Sanphams");

            migrationBuilder.DropTable(
                name: "Khachhangs");

            migrationBuilder.DropTable(
                name: "Khuyenmais");

            migrationBuilder.DropTable(
                name: "Nhanvien");

            migrationBuilder.DropTable(
                name: "Quyens");
        }
    }
}
