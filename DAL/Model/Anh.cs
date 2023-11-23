using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Anh
    {
        [Key]
        public Guid Idanh { get; set; }
        public string Ten { get; set; }
        public string Path { get; set; }

        

    }
}
