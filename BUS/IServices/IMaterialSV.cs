using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IMaterialSV
    {
        public List<Chatlieu> GetChatlieus();
    }
}
