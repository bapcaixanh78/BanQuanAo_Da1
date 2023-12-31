﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Khuyenmai
    {
        [Key]
        public Guid Id { get; set; }
        [Column(TypeName = "nvarchar(500)")]

        public string Tenmakhuyenmai { get; set; }
        public DateTime Thoigianbatdau { get; set; }
        public DateTime Thoigianketthuc { get; set; }
        public int Giamgia { get; set; }
        [Column(TypeName = "nvarchar(500)")]

        public string? Mota { get; set; }
        public string Trangthai { get; set; }

        //khoa ngoai
        public virtual ICollection<Hoadon> Hoadons { get; set; }

    }
}
