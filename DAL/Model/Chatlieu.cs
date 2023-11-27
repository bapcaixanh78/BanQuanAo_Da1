using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Chatlieu
    {
        [Key]
        public Guid Id { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        public string Ten { get; set; }
        [Column(TypeName = "nvarchar(500)")]

        public string? Mota { get; set; }
        [Column(TypeName = "nvarchar(500)")]

        public string Trangthai { get; set; }

        public virtual ICollection<Chitietsanpham> Chitietsanphams { get; set; }
    }
}
