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
    public class DetailBillSV : IDetailBillSV
    {
        private DetailBillRP detailBillRP;
        public DetailPRoductsSV _detaiprod;
        public ColorRP _colorsv;
        public SizeRP _sizesv;
        public MaterialRP _materialsv;
        public BillRP _billsv;
        public DetailBillSV()
        {
            _colorsv = new ColorRP();
            _materialsv = new MaterialRP();
            _sizesv = new SizeRP();
            _detaiprod = new DetailPRoductsSV();
            detailBillRP = new DetailBillRP();
            _billsv = new BillRP();
        }

        public string AddDetailBill(Hoadonchitiet hdct)
        {
            if (detailBillRP.Add(hdct) == true)
            {
                return "You have added successfully";
            }
            else
            {
                return "You have failed to add";
            }
        }

        public decimal DoanhThuMangVe(Guid idnv)
        {
            //lấy ra tất cả id hóa đơn của 1 thằng nhân viên bán được
            var lstbill = _billsv.GetAll().Where(c => c.Idnhanvien == idnv).Select(c => c.Id).ToList();
            decimal tongtien = 0;
            foreach (var bill in lstbill)
            {
                tongtien += GetAllHoaDonChiTiet().FirstOrDefault(c => c.Idhoadon == bill).Giaban;
            }
            return tongtien;
        }

        public List<Hoadonchitiet> GetAllHoaDonChiTiet()
        {
            return detailBillRP.GetAll();
        }

        public string GetMauAo(Guid idctsp)
        {
            var ctsp = _detaiprod.GetAll(null).FirstOrDefault(c=>c.Id == idctsp);
            var cl = _colorsv.GetMauaos().FirstOrDefault(c => c.Id == ctsp.Idmauao);
            return cl.Mau;
        }

        public string GetSize(Guid idctsp)
        {
            var ctsp = _detaiprod.GetAll(null).FirstOrDefault(c => c.Id == idctsp);
            var cl = _sizesv.GetKichthuocs().FirstOrDefault(c => c.Id == ctsp.Idkichthuoc);
            return cl.Size;
        }

        public string GetChatLieu(Guid idctsp)
        {
            var ctsp = _detaiprod.GetAll(null).FirstOrDefault(c => c.Id == idctsp);
            var cl = _materialsv.GetChatlieus().FirstOrDefault(c => c.Id == ctsp.Idchatlieu);
            return cl.Ten;
        }
    }
}
