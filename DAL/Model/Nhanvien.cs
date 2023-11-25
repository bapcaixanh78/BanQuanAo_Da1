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
        [Column(TypeName = "nvarchar")]
        public string Ten { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        [Column(TypeName = "nvarchar")]
        public string Diachi { get; set; }
        public DateTime Ngaytao { get; set; }
        [Column(TypeName = "nvarchar")]
        public string Trangthai { get; set; }

        //khoa ngoai
        public Guid Idquyen { get; set; }
        public virtual Quyen quyen { get; set; }

        public virtual ICollection<Hoadon> Hoadons { get; set; }
        

    }
}
