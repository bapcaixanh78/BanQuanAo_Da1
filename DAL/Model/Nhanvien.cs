using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Nhanvien
    {
        [Key]
        public Guid Id { get; set; }
        public string Ten { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Diachi { get; set; }
        public DateTime Ngaytao { get; set; }
        public string Trangthai { get; set; }

        //khoa ngoai
        public Guid Idquyen { get; set; }
        public Quyen quyen { get; set; }

        public ICollection<Hoadon> Hoadons { get; set; }
        

    }
}
