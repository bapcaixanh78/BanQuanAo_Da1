using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Quyen
    {
        public Guid Id { get; set; }   
        public string Ten { get; set; }
        public string Trangthai { get; set; }

        //khoa ngoai
        public ICollection<Nhanvien> Nhanviens { get; set; }
    }
}
