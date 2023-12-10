using DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRL.VIewModel
{
    public class WaitingBill
    {
        public Guid Id { get; set; }
        public DateTime Ngaytao { get; set; }
        public string? Ghichu { get; set; }
        public string? Trangthai { get; set; }
        public Guid Idkhachhang { get; set; }
        public Guid? Idkhuyenmai { get; set; }
    }
}
