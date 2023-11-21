using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Kichthuoc
    {
        public Guid Id { get; set; }
        public string Size { get; set; }
        public string Trangthai { get; set; }

        public virtual ICollection<Chitietsanpham> Chitietsanphams { get; set; }

    }
}
