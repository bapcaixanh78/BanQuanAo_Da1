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
            optionsBuilder.UseSqlServer(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=ShopQuanAo;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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


            //modelBuilder.Entity<Chitietsanpham>()
            //.HasOne(p => p.Anhs)
            //.WithOne(d => d.chitiet)
            //.HasForeignKey<Anh>(d => d.Idanh);


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

            modelBuilder.Entity<Nhanvien>()
            .HasOne(p => p.quyen)
            .WithMany(c => c.Nhanviens)
            .HasForeignKey(p => p.Idquyen)
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
        public DbSet<Quyen> Quyens { get; set; }
        public DbSet<Sanpham> Sanphams { get; set; }




    }
}
