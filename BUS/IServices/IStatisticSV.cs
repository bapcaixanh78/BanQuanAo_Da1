using DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    internal interface IStatisticSV
    {
        public List<Hoadonchitiet> GetAll();
    }
}
