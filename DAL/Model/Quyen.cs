using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Quyen
    {
        public Guid Id { get; set; }

        [Column(TypeName = "nvarchar")]
        public string Ten { get; set; }

        //khoa ngoai
        public virtual ICollection<Nhanvien> Nhanviens { get; set; }
    }
}
