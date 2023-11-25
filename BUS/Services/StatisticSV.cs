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
    public class StatisticSV : IStatisticSV
    {
        private StatisticRP statisticRP;
        public StatisticSV()
        {
            statisticRP = new StatisticRP();
        }
        public List<Hoadonchitiet> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
