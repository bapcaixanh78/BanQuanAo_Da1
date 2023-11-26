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
    public class ColorSV : IColorSV
    {
        private ColorRP ColorRP;

            public ColorSV()
        {
            ColorRP = new ColorRP();
        }
        public List<Mauao> GetMauaos()
        {
            return ColorRP.GetMauaos();
        }
    }
}
