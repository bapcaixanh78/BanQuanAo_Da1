using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Kichthuoc
    {
        public Guid Id { get; set; }
        [Column(TypeName = "nvarchar(500)")]

        public string Size { get; set; }
        [Column(TypeName = "nvarchar(500)")]

        public string Trangthai { get; set; }

        public virtual ICollection<Chitietsanpham> Chitietsanphams { get; set; }

    }
}
