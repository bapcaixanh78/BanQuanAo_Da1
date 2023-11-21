﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Khuyenmai
    {
        [Key]
        public Guid Id { get; set; }
        public string Ten { get; set; }
        public string Mota { get; set; }
        public int Giamgia { get; set; }
        public string Kieugiamgia { get; set; }

        //khoa ngoai
        public virtual ICollection<Hoadon> Hoadons { get; set; }

    }
}