using DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mydbcontext
{
    public class ShopDbcontext : DbContext
    {
        public ShopDbcontext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\sqlexpress;Initial Catalog=ShopQuanAo;Integrated Security=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedingData(modelBuilder);

            modelBuilder.Entity<Chitietsanpham>()
            .HasOne(p => p.Sanpham)
            .WithMany(c => c.Chitietsanphams)
            .HasForeignKey(p => p.Idsanpham)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Chitietsanpham>()
            .HasOne(p => p.Kichthuoc)
            .WithMany(c => c.Chitietsanphams)
            .HasForeignKey(p => p.Idkichthuoc)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Chitietsanpham>()
            .HasOne(p => p.Chatlieu)
            .WithMany(c => c.Chitietsanphams)
            .HasForeignKey(p => p.Idchatlieu)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Chitietsanpham>()
            .HasOne(p => p.Danhmuc)
            .WithMany(c => c.Chitietsanphams)
            .HasForeignKey(p => p.Iddanhmuc)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Chitietsanpham>()
            .HasOne(p => p.Mauao)
            .WithMany(c => c.Chitietsanphams)
            .HasForeignKey(p => p.Idmauao)
            .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Hoadon>()
            .HasOne(p => p.Nhanvien)
            .WithMany(c => c.Hoadons)
            .HasForeignKey(p => p.Idnhanvien)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Hoadon>()
            .HasOne(p => p.Khachhang)
            .WithMany(c => c.Hoadons)
            .HasForeignKey(p => p.Idkhachhang)
            .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Hoadon>()
            .HasOne(p => p.khuyenmai)
            .WithMany(c => c.Hoadons)
            .HasForeignKey(p => p.Idkhuyenmai)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Hoadonchitiet>()
            .HasOne(p => p.Hoadon)
            .WithMany(c => c.hoadonchitiets)
            .HasForeignKey(p => p.Idhoadon)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Hoadonchitiet>()
            .HasOne(p => p.chitietsanpham)
            .WithMany(c => c.hoadonchitiets)
            .HasForeignKey(p => p.Idchitietsanpham)
            .OnDelete(DeleteBehavior.Restrict);

        }

        public DbSet<Anh> Anhs { get; set; }
        public DbSet<Chatlieu> Chatlieus { get; set; }
        public DbSet<Chitietsanpham> Chitietsanphams { get; set; }
        public DbSet<Danhmuc> Danhmucs { get; set; }
        public DbSet<Hoadon> Hoadons { get; set; }
        public DbSet<Hoadonchitiet> Hoadonchitiets { get; set; }
        public DbSet<Khachhang> Khachhangs { get; set; }
        public DbSet<Khuyenmai> Khuyenmais { get; set; }
        public DbSet<Kichthuoc> Kichthuocs { get; set; }
        public DbSet<Mauao> Mauaos { get; set; }
        public DbSet<Nhanvien> Nhanvien { get; set; }
        public DbSet<Sanpham> Sanphams { get; set; }

        void SeedingData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sanpham>().HasData(
                new Sanpham
                {
                    Id = Guid.Parse("b69de1e9-ebaf-43e5-89db-56cf6d9265bd"),
                    Ten = "Áo Phông Graphic Vàng",
                },
                new Sanpham
                {
                    Id = Guid.NewGuid(),
                    Ten = "Áo Phông Trắng Unisex",
                },
                new Sanpham
                {
                    Id = Guid.NewGuid(),
                    Ten = "Áo Phông Đen Basic"
                },
                new Sanpham
                {
                    Id = Guid.NewGuid(),
                    Ten = "Áo Phông Oversized Xám"
                },
                new Sanpham
                {
                    Id = Guid.NewGuid(),
                    Ten = "Áo Phông Vintage Nâu"
                },
                new Sanpham
                {
                    Id = Guid.NewGuid(),
                    Ten = "Áo Phông 3 Màu",
                },
                new Sanpham
                {
                    Id = Guid.NewGuid(),
                    Ten = "Áo Phông Xám Basic",
                },
                new Sanpham
                {
                    Id = Guid.NewGuid(),
                    Ten = "Áo Phông Nâu Basic"
                },
                new Sanpham
                {
                    Id = Guid.NewGuid(),
                    Ten = "Áo Phông Vàng Basic"
                },
                new Sanpham
                {
                    Id = Guid.NewGuid(),
                    Ten = "Áo phông họa tiết dân tộc"
                }
                );


            modelBuilder.Entity<Chatlieu>().HasData(

                new Chatlieu
                {
                    Id = Guid.NewGuid(),
                    Ten = "Cotton",
                    Mota = "Có sự thoáng khí và thoải mái, phù hợp cho nhiều loại áo.",
                },
                new Chatlieu
                {
                    Id = Guid.NewGuid(),
                    Ten = "Polyester",
                    Mota = "Chất liệu nh kun, không nhăn, chống nhăn và nhanh khô, thích hợp cho áo phông thể thao và hoạt động vận động.",
                },
                new Chatlieu
                {
                    Id = Guid.NewGuid(),
                    Ten = "Blend ",
                    Mota = "Kết hợp giữa cotton và polyester hoặc các chất liệu khác, tạo ra sự kết hợp của các đặc tính khác nhau.",
                },
                new Chatlieu
                {
                    Id = Guid.NewGuid(),
                    Ten = "Linen (Lanh)",
                    Mota = "Nhẹ nhàng, mát mẻ, tuy nhiên, có thể nhăn nhanh hơn so với một số loại khác.",
                },
                new Chatlieu
                {
                    Id = Guid.NewGuid(),
                    Ten = "Bamboo",
                    Mota = "Áo phông làm từ sợi tre có khả năng thấm hút mồ hôi và khá mềm mại.",
                },
                new Chatlieu
                {
                    Id = Guid.NewGuid(),
                    Ten = "Spandex",
                    Mota = "Thường được thêm vào để tăng độ co giãn, phù hợp cho áo thể thao và áo ôm.",
                }
                );

            modelBuilder.Entity<Mauao>().HasData(
                new Mauao
                {
                    Id = Guid.NewGuid(),
                    Mau = "Trắng",
                }, new Mauao
                {
                    Id = Guid.NewGuid(),
                    Mau = "Đen"
                }, new Mauao
                {
                    Id = Guid.NewGuid(),
                    Mau = "Đỏ"
                }, new Mauao
                {
                    Id = Guid.NewGuid(),
                    Mau = "Hồng"
                }, new Mauao
                {
                    Id = Guid.NewGuid(),
                    Mau = "Xám"
                }, new Mauao
                {
                    Id = Guid.NewGuid(),
                    Mau = "Nâu"
                },
                 new Mauao
                 {
                     Id = Guid.NewGuid(),
                     Mau = "Xanh nước biển"
                 },
                  new Mauao
                  {
                      Id = Guid.NewGuid(),
                      Mau = "Xanh lá cây"
                  },
                   new Mauao
                   {
                       Id = Guid.NewGuid(),
                       Mau = "Xanh rêu"
                   },
                    new Mauao
                    {
                        Id = Guid.NewGuid(),
                        Mau = "Cam"
                    }, new Mauao
                    {
                        Id = Guid.NewGuid(),
                        Mau = "Vàng"
                    }, new Mauao
                    {
                        Id = Guid.NewGuid(),
                        Mau = "Kem"
                    }, new Mauao
                    {
                        Id = Guid.NewGuid(),
                        Mau = "Ghi"
                    }, new Mauao
                    {
                        Id = Guid.NewGuid(),
                        Mau = "Xanh navy"
                    }, new Mauao
                    {
                        Id = Guid.NewGuid(),
                        Mau = "Tím"
                    }
                );


            modelBuilder.Entity<Kichthuoc>().HasData(
                new Kichthuoc
                {
                    Id = Guid.NewGuid(),
                    Size = "XS"
                },
                new Kichthuoc
                {
                    Id = Guid.NewGuid(),
                    Size = "S"
                },
                new Kichthuoc
                {
                    Id = Guid.NewGuid(),
                    Size = "M"
                },
                new Kichthuoc
                {
                    Id = Guid.NewGuid(),
                    Size = "L"
                },
                new Kichthuoc
                {
                    Id = Guid.NewGuid(),
                    Size = "XL"
                },
                new Kichthuoc
                {
                    Id = Guid.NewGuid(),
                    Size = "XLL"
                }
                );

            modelBuilder.Entity<Khuyenmai>().HasData(
                new Khuyenmai
                {
                    Id = Guid.NewGuid(),
                    Tenmakhuyenmai = "Noel",
                    Thoigianbatdau = DateTime.Parse("10/12/2023"),
                    Thoigianketthuc = DateTime.Parse("15/12/2023"),
                    Trangthai = "Hoạt động"
                });
        }


    }
}
