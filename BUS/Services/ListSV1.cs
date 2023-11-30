using BUS.IServices;
using DAL.Model;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FSharp.Data.Runtime.HtmlObjectDescription;

namespace BUS.Services
{
    public class ListSV1 : IListSV1
    {
        private List1RP list1RP;

        public ListSV1()
        {
            list1RP = new List1RP();
        }
        public Guid convertGUID(Guid? guid)
        {
            return guid ?? Guid.Empty;
        }

        public Guid FindIDbyName(string name)
        {
            return list1RP.GetDanhmucs().FirstOrDefault(c => c.Ten == name).Id; ;
        }

        public string FindNamebyID(Guid id)
        {
            return list1RP.GetDanhmucs().FirstOrDefault(c => c.Id == id).Ten;
        }

        public List<Danhmuc> GetDanhmucs()
        {
            return list1RP.GetDanhmucs();
        }
    }
}
