using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Chitietsanpham
    {
        [Key]
        public Guid Id { get; set; }
        public decimal Gianhap { get; set; }
        public decimal Giaban { get; set; }
        public DateTime Ngaytao { get; set; }
        public int Soluongton { get; set; }
        public string Mota { get; set; }
        public DateTime Ngaycapnhat { get; set; }
        public string Trangthai { get; set; }

        //khoa ngoai
        public Guid Idsanpham { get; set; }
        public Sanpham Sanpham { get; set; }

        public Guid Iddanhmuc { get; set; }
        public Danhmuc Danhmuc { get; set; }

        public ICollection<Mauao> Mauaos { get; set; }

        public ICollection<Chatlieu> chatlieus { get; set; } 

        public ICollection<Hoadonchitiet> hoadonchitiets { get; set; }  

        public ICollection<Kichthuoc> kichthuocs { get; set; }


    }
}
