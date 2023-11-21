using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Hoadonchitiet
    {
        [Key]
        public Guid Id { get; set; }
        public int Soluong {get; set; }
        public decimal Giaban { get; set; }

        //khoa ngoai 
        public Guid Idhoadon { get; set; }
        public virtual Hoadon Hoadon { get; set; }

        public Guid Idchitietsanpham { get; set; }
        public virtual Chitietsanpham chitietsanpham { get; set; }
    }
}
