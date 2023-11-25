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
    public class Danhmuc
    {
        [Key]
        public Guid Id { get; set; }
        public string Ten { get; set; }
        [Column(TypeName = "nvarchar(500)")]

        public string Trangthai { get; set; }
        [Column(TypeName = "nvarchar(500)")]

        public string Ghichu { get; set; }
        
        //khoa ngoai
        public virtual ICollection<Chitietsanpham> Chitietsanphams { get; set; }

    }
}
