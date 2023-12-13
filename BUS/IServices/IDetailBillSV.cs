using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IDetailBillSV
    {
        public string AddDetailBill(Hoadonchitiet hdct);
        public string Update(Hoadonchitiet hdct);
        public List<Hoadonchitiet> GetAllHoaDonChiTiet();
        public decimal DoanhThuMangVe(Guid idnv);
        public string GetMauAo(Guid idctsp);
        public string GetSize(Guid idctsp);
        public string GetChatLieu(Guid idctsp);
    }
}
