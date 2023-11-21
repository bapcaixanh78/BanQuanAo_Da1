using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Chatlieu
    {
        [Key]
        public Guid Id { get; set; }
        public string Ten { get; set; }
        public string Mota { get; set; }
        public string Trangthai { get; set; }

        //khoa ngoai
        public Guid Idchitietsanpham { get; set; }

    }
}
