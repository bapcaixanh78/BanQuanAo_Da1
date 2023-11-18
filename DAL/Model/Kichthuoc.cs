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

        //khoa ngoai
        public Guid IdChitietsanpham { get; set; }  
        public Chitietsanpham Chitietsanpham { get; set; }
    }
}
