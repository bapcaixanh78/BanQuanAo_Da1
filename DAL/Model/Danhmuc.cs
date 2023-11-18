using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Danhmuc
    {
        [Key]
        public Guid Id { get; set; }
        public string Ten { get; set; }
        public string Trangthai { get; set; }
        public string Ghichu { get; set; }
        
        //khoa ngoai
        public ICollection<Chitietsanpham> Chitietsanphams { get; set; }

    }
}
