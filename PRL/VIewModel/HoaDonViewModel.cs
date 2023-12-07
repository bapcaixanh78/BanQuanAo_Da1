using DAL.Model;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRL.VIewModel
{
    public class HoadonViewModel
    {
        public Guid Id { get; set; }
        public DateTime Ngaytao { get; set; }

        public string? Ghichu { get; set; }

        public string? Trangthai { get; set; }

        public decimal TongTienCuaHoaDon { get;set; }
        public Guid Idnhanvien { get; set; }

        public Guid Idkhachhang { get; set; }

        public Guid? Idkhuyenmai { get; set; }
        public virtual Khuyenmai khuyenmai { get; set; }
    }
}
