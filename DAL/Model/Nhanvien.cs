using FSharp.Data.Runtime.StructuralTypes;
using Microsoft.EntityFrameworkCore;
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
    public class Nhanvien
    {
        [Key]
        public Guid Id { get; set; }
        [Column(TypeName = "nvarchar(500)")]

        public string Ten { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        [Column(TypeName = "nvarchar(500)")]

        public string Diachi { get; set; }
        public DateTime Ngaytao { get; set; }

        public int Quyen { get; set; }

        public string Taikhoan { get; set; }
        public string Matkhau { get; set; }

        [Column(TypeName = "nvarchar(500)")]

        public string Trangthai { get; set; }

        //khoa ngoai

        public virtual ICollection<Hoadon> Hoadons { get; set; }
        

    }
}
