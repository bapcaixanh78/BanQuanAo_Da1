using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Idquyen = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    quyenId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nhanvien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nhanvien_Quyens_quyenId",
                        column: x => x.quyenId,
                        principalTable: "Quyens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Anhs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdSanpham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SanphamId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anhs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Anhs_Sanphams_SanphamId",
                        column: x => x.SanphamId,
                        principalTable: "Sanphams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    SanphamId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Iddanhmuc = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DanhmucId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chitietsanphams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chitietsanphams_Danhmucs_DanhmucId",
                        column: x => x.DanhmucId,
                        principalTable: "Danhmucs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chitietsanphams_Sanphams_SanphamId",
                        column: x => x.SanphamId,
                        principalTable: "Sanphams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    NhanvienId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Idkhachhang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KhachhangId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Idkhuyenmai = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    khuyenmaiId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hoadons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hoadons_Khachhangs_KhachhangId",
                        column: x => x.KhachhangId,
                        principalTable: "Khachhangs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hoadons_Khuyenmais_khuyenmaiId",
                        column: x => x.khuyenmaiId,
                        principalTable: "Khuyenmais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hoadons_Nhanvien_NhanvienId",
                        column: x => x.NhanvienId,
                        principalTable: "Nhanvien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chatlieus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trangthai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idchitietsanpham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChitietsanphamId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chatlieus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chatlieus_Chitietsanphams_ChitietsanphamId",
                        column: x => x.ChitietsanphamId,
                        principalTable: "Chitietsanphams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kichthuocs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trangthai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdChitietsanpham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChitietsanphamId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kichthuocs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kichthuocs_Chitietsanphams_ChitietsanphamId",
                        column: x => x.ChitietsanphamId,
                        principalTable: "Chitietsanphams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mauaos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Mau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trangthai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idchitietsanpham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChitietsanphamId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mauaos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mauaos_Chitietsanphams_ChitietsanphamId",
                        column: x => x.ChitietsanphamId,
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
                    HoadonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Idchitietsanpham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    chitietsanphamId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hoadonchitiets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hoadonchitiets_Chitietsanphams_chitietsanphamId",
                        column: x => x.chitietsanphamId,
                        principalTable: "Chitietsanphams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hoadonchitiets_Hoadons_HoadonId",
                        column: x => x.HoadonId,
                        principalTable: "Hoadons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anhs_SanphamId",
                table: "Anhs",
                column: "SanphamId");

            migrationBuilder.CreateIndex(
                name: "IX_Chatlieus_ChitietsanphamId",
                table: "Chatlieus",
                column: "ChitietsanphamId");

            migrationBuilder.CreateIndex(
                name: "IX_Chitietsanphams_DanhmucId",
                table: "Chitietsanphams",
                column: "DanhmucId");

            migrationBuilder.CreateIndex(
                name: "IX_Chitietsanphams_SanphamId",
                table: "Chitietsanphams",
                column: "SanphamId");

            migrationBuilder.CreateIndex(
                name: "IX_Hoadonchitiets_chitietsanphamId",
                table: "Hoadonchitiets",
                column: "chitietsanphamId");

            migrationBuilder.CreateIndex(
                name: "IX_Hoadonchitiets_HoadonId",
                table: "Hoadonchitiets",
                column: "HoadonId");

            migrationBuilder.CreateIndex(
                name: "IX_Hoadons_KhachhangId",
                table: "Hoadons",
                column: "KhachhangId");

            migrationBuilder.CreateIndex(
                name: "IX_Hoadons_khuyenmaiId",
                table: "Hoadons",
                column: "khuyenmaiId");

            migrationBuilder.CreateIndex(
                name: "IX_Hoadons_NhanvienId",
                table: "Hoadons",
                column: "NhanvienId");

            migrationBuilder.CreateIndex(
                name: "IX_Kichthuocs_ChitietsanphamId",
                table: "Kichthuocs",
                column: "ChitietsanphamId");

            migrationBuilder.CreateIndex(
                name: "IX_Mauaos_ChitietsanphamId",
                table: "Mauaos",
                column: "ChitietsanphamId");

            migrationBuilder.CreateIndex(
                name: "IX_Nhanvien_quyenId",
                table: "Nhanvien",
                column: "quyenId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anhs");

            migrationBuilder.DropTable(
                name: "Chatlieus");

            migrationBuilder.DropTable(
                name: "Hoadonchitiets");

            migrationBuilder.DropTable(
                name: "Kichthuocs");

            migrationBuilder.DropTable(
                name: "Mauaos");

            migrationBuilder.DropTable(
                name: "Hoadons");

            migrationBuilder.DropTable(
                name: "Chitietsanphams");

            migrationBuilder.DropTable(
                name: "Khachhangs");

            migrationBuilder.DropTable(
                name: "Khuyenmais");

            migrationBuilder.DropTable(
                name: "Nhanvien");

            migrationBuilder.DropTable(
                name: "Danhmucs");

            migrationBuilder.DropTable(
                name: "Sanphams");

            migrationBuilder.DropTable(
                name: "Quyens");
        }
    }
}
