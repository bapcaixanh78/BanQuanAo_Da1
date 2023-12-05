using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRL.VIewModel
{
    public class HoaDonViewModel
    {
        public Guid Id { get; set; }
        public int Soluong { get; set; }
        public decimal Giaban { get; set; }
        public DateTime Ngaytao { get; set; }

        public Guid Idnhanvien { get; set; }
        public Guid Idkhachhang { get; set; }
        public Guid? Idkhuyenmai { get; set; }
    }
}
