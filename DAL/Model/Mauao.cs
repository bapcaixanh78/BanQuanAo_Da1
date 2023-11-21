using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Mauao
    {
        [Key]
        public Guid Id { get; set; }
        public string Mau { get; set; }
        public string Trangthai { get; set; }

        public virtual ICollection<Chitietsanpham> Chitietsanphams { get; set; }

    }
}
