using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRL.VIewModel
{
    public class Revenue_By_Staff
    {
        public Guid IdNhanVien { get; set; }
        public string Ten { get; set; }
        public string Account { get; set; }
        public string Email { get; set; }
        public int Soluonghoadon { get; set; }
        public decimal DoanhThuMangVe { get; set; }
    }
}
