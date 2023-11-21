 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Sanpham
    {
        [Key]
        public Guid Id { get; set; }
        public string Ten { get; set; }

        //khoa ngoai
        public virtual  ICollection<Anh> Anhs { get; set; }

        public virtual ICollection<Chitietsanpham> Chitietsanphams { get; set; }

    }
}
