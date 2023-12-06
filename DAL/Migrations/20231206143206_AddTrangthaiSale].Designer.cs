﻿// <auto-generated />
using System;
using DAL.Mydbcontext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(ShopDbcontext))]
    [Migration("20231206143206_AddTrangthaiSale]")]
    partial class AddTrangthaiSale
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DAL.Model.Anh", b =>
                {
                    b.Property<Guid>("Idanh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Idanh");

                    b.ToTable("Anhs");
                });

            modelBuilder.Entity("DAL.Model.Chatlieu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Mota")
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Trangthai")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Chatlieus");
                });

            modelBuilder.Entity("DAL.Model.Chitietsanpham", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Giaban")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Gianhap")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("IdAnh")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Idchatlieu")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Iddanhmuc")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Idkichthuoc")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Idmauao")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Idsanpham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Mota")
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("Ngaycapnhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Ngaytao")
                        .HasColumnType("datetime2");

                    b.Property<int>("Soluongton")
                        .HasColumnType("int");

                    b.Property<string>("Trangthai")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.HasIndex("IdAnh");

                    b.HasIndex("Idchatlieu");

                    b.HasIndex("Iddanhmuc");

                    b.HasIndex("Idkichthuoc");

                    b.HasIndex("Idmauao");

                    b.HasIndex("Idsanpham");

                    b.ToTable("Chitietsanphams");
                });

            modelBuilder.Entity("DAL.Model.Danhmuc", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ghichu")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trangthai")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Danhmucs");
                });

            modelBuilder.Entity("DAL.Model.Hoadon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ghichu")
                        .HasColumnType("nvarchar(500)");

                    b.Property<Guid>("Idkhachhang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Idkhuyenmai")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Idnhanvien")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Ngaytao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Trangthai")
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.HasIndex("Idkhachhang");

                    b.HasIndex("Idkhuyenmai");

                    b.HasIndex("Idnhanvien");

                    b.ToTable("Hoadons");
                });

            modelBuilder.Entity("DAL.Model.Hoadonchitiet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Giaban")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("Idchitietsanpham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Idhoadon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Soluong")
                        .HasColumnType("int");

                    b.Property<string>("Trangthai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Idchitietsanpham");

                    b.HasIndex("Idhoadon");

                    b.ToTable("Hoadonchitiets");
                });

            modelBuilder.Entity("DAL.Model.Khachhang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Sdt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Khachhangs");
                });

            modelBuilder.Entity("DAL.Model.Khuyenmai", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Giamgia")
                        .HasColumnType("int");

                    b.Property<string>("Mota")
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Tenmakhuyenmai")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("Thoigianbatdau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Thoigianketthuc")
                        .HasColumnType("datetime2");

                    b.Property<string>("Trangthai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Khuyenmais");
                });

            modelBuilder.Entity("DAL.Model.Kichthuoc", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Trangthai")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Kichthuocs");
                });

            modelBuilder.Entity("DAL.Model.Mauao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Mau")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Trangthai")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Mauaos");
                });

            modelBuilder.Entity("DAL.Model.Nhanvien", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Diachi")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Matkhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Ngaytao")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quyen")
                        .HasColumnType("int");

                    b.Property<string>("Taikhoan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Trangthai")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Nhanvien");
                });

            modelBuilder.Entity("DAL.Model.Sanpham", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sanphams");
                });

            modelBuilder.Entity("DAL.Model.Chitietsanpham", b =>
                {
                    b.HasOne("DAL.Model.Anh", "Anhs")
                        .WithMany()
                        .HasForeignKey("IdAnh");

                    b.HasOne("DAL.Model.Chatlieu", "Chatlieu")
                        .WithMany("Chitietsanphams")
                        .HasForeignKey("Idchatlieu")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DAL.Model.Danhmuc", "Danhmuc")
                        .WithMany("Chitietsanphams")
                        .HasForeignKey("Iddanhmuc")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DAL.Model.Kichthuoc", "Kichthuoc")
                        .WithMany("Chitietsanphams")
                        .HasForeignKey("Idkichthuoc")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DAL.Model.Mauao", "Mauao")
                        .WithMany("Chitietsanphams")
                        .HasForeignKey("Idmauao")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DAL.Model.Sanpham", "Sanpham")
                        .WithMany("Chitietsanphams")
                        .HasForeignKey("Idsanpham")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Anhs");

                    b.Navigation("Chatlieu");

                    b.Navigation("Danhmuc");

                    b.Navigation("Kichthuoc");

                    b.Navigation("Mauao");

                    b.Navigation("Sanpham");
                });

            modelBuilder.Entity("DAL.Model.Hoadon", b =>
                {
                    b.HasOne("DAL.Model.Khachhang", "Khachhang")
                        .WithMany("Hoadons")
                        .HasForeignKey("Idkhachhang")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DAL.Model.Khuyenmai", "khuyenmai")
                        .WithMany("Hoadons")
                        .HasForeignKey("Idkhuyenmai")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DAL.Model.Nhanvien", "Nhanvien")
                        .WithMany("Hoadons")
                        .HasForeignKey("Idnhanvien")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Khachhang");

                    b.Navigation("Nhanvien");

                    b.Navigation("khuyenmai");
                });

            modelBuilder.Entity("DAL.Model.Hoadonchitiet", b =>
                {
                    b.HasOne("DAL.Model.Chitietsanpham", "chitietsanpham")
                        .WithMany("hoadonchitiets")
                        .HasForeignKey("Idchitietsanpham")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DAL.Model.Hoadon", "Hoadon")
                        .WithMany("hoadonchitiets")
                        .HasForeignKey("Idhoadon")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Hoadon");

                    b.Navigation("chitietsanpham");
                });

            modelBuilder.Entity("DAL.Model.Chatlieu", b =>
                {
                    b.Navigation("Chitietsanphams");
                });

            modelBuilder.Entity("DAL.Model.Chitietsanpham", b =>
                {
                    b.Navigation("hoadonchitiets");
                });

            modelBuilder.Entity("DAL.Model.Danhmuc", b =>
                {
                    b.Navigation("Chitietsanphams");
                });

            modelBuilder.Entity("DAL.Model.Hoadon", b =>
                {
                    b.Navigation("hoadonchitiets");
                });

            modelBuilder.Entity("DAL.Model.Khachhang", b =>
                {
                    b.Navigation("Hoadons");
                });

            modelBuilder.Entity("DAL.Model.Khuyenmai", b =>
                {
                    b.Navigation("Hoadons");
                });

            modelBuilder.Entity("DAL.Model.Kichthuoc", b =>
                {
                    b.Navigation("Chitietsanphams");
                });

            modelBuilder.Entity("DAL.Model.Mauao", b =>
                {
                    b.Navigation("Chitietsanphams");
                });

            modelBuilder.Entity("DAL.Model.Nhanvien", b =>
                {
                    b.Navigation("Hoadons");
                });

            modelBuilder.Entity("DAL.Model.Sanpham", b =>
                {
                    b.Navigation("Chitietsanphams");
                });
#pragma warning restore 612, 618
        }
    }
}
