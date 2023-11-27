using BUS.IServices;
using DAL.Model;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BUS.Services
{
    public class MaterialSV : IMaterialSV
    {
        private MaterialRP materialRP;
        public MaterialSV()
        {
            materialRP = new MaterialRP();
        }

        public Guid convertGUID(Guid? guid)
        {
            return guid ?? Guid.Empty;
        }

        public Guid FindIDbyName(string name)
        {
            return materialRP.GetChatlieus().FirstOrDefault(c => c.Ten == name).Id;
        }

        public string FindNamebyID(Guid id)
        {
            return materialRP.GetChatlieus().FirstOrDefault(c => c.Id == id).Ten;
        }

        public List<Chatlieu> GetChatlieus()
        {
            return materialRP.GetChatlieus();
        }
    }
}
