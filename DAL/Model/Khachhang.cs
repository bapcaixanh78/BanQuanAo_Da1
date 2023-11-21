using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Khachhang
    {
        [Key]
        public Guid Id { get; set; }
        public string Ten { get; set; }
        public string Sdt { get; set; }
        public string Trangthai { get; set; }

        //khoa ngoai
        public virtual ICollection<Hoadon> Hoadons { get; set; }

    }
}
