using BUS.IServices;
using DAL.Model;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class MaterialSV : IMaterialSV
    {
        private MaterialRP materialRP;
        public MaterialSV()
        {
            materialRP = new MaterialRP();
        }
        public List<Chatlieu> GetChatlieus()
        {
            return materialRP.GetChatlieus();
        }
    }
}
