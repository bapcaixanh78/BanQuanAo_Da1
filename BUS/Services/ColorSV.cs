using BUS.IServices;
using DAL.Model;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BUS.Services
{
    public class ColorSV : IColorSV
    {
        private ColorRP ColorRP;

        public ColorSV()
        {
            ColorRP = new ColorRP();
        }

        public Guid convertGUID(Guid? guid)
        {
            return guid ?? Guid.Empty;
        }

        public Guid FindIDbyName(string name)
        {
            return ColorRP.GetMauaos().FirstOrDefault(c => c.Mau == name).Id;
        }

        public string FindNamebyID(Guid id)
        {
            
                
            return ColorRP.GetMauaos().FirstOrDefault(c => c.Id == id).Mau;


        }

        public List<Mauao> GetMauaos()
        {
            return ColorRP.GetMauaos();
        }
    }
}
