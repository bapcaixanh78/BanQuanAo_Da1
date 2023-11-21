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
