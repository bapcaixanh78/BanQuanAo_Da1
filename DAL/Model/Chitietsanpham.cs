using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Column(TypeName = "nvarchar(500)")]

        public string? Mota { get; set; }
        public DateTime Ngaycapnhat { get; set; }
        [Column(TypeName = "nvarchar(500)")]

        public string Trangthai { get; set; }

        //khoa ngoai
        public Guid? IdAnh { get; set; }
        [ForeignKey("IdAnh")]
        public virtual Anh Anhs { get; set; }
        public Guid Idsanpham { get; set; }
        public virtual Sanpham Sanpham { get; set; }

        public Guid? Iddanhmuc { get; set; }
        public virtual Danhmuc Danhmuc { get; set; }

        public Guid? Idmauao { get; set; }
        public virtual Mauao Mauao { get; set; }

        public Guid? Idchatlieu { get; set; }
        public virtual Chatlieu Chatlieu { get; set; }
        public Guid? Idkichthuoc { get; set; }
        public virtual Kichthuoc Kichthuoc { get; set; }

        public virtual ICollection<Hoadonchitiet> hoadonchitiets { get; set; }


    }
}
