using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Hoadon
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime Ngaytao { get; set; }
        [Column(TypeName = "nvarchar(500)")]

        public string? Ghichu { get; set; }
        [Column(TypeName = "nvarchar(500)")]

        public string Trangthai { get; set; }

        //khoa ngoai
        public Guid Idnhanvien { get;set; }
        public virtual Nhanvien Nhanvien { get; set; }

        public Guid Idkhachhang { get; set; }
        public virtual Khachhang Khachhang { get; set; }

        public virtual ICollection<Hoadonchitiet> hoadonchitiets { get; set; }

        public Guid Idkhuyenmai { get; set; }
        public virtual Khuyenmai khuyenmai { get;set; }

         

    }
}
