using BUS.IServices;
using DAL.Model;
using DAL.Repositories;

namespace BUS.Services
{
    public class StaffSV : IStaffSV
    {
        private StaffRP staffRP;

        public StaffSV()
        {
            staffRP = new StaffRP();
        }

        public string Add(Nhanvien NV)
        {
            if (staffRP.Add(NV))
            {
                return "You have added successfully";
            }
            else
            {
                return "You have failed to add";
            }
        }

        public List<Nhanvien> GetAll()
        {
            return staffRP.GetAll();
        }

        public List<Nhanvien> GetStaffByName(string name)
        {
            return staffRP.GetStaffByName(name);
        }

        public string Lock(Guid id)
        {
            var nhanvien = staffRP.GetAll().FirstOrDefault(x => x.Id == id);
            if(nhanvien.Trangthai=="Hoạt động")
            {
                nhanvien.Trangthai = "Vô hiệu hóa";
            }
            else
            {
                nhanvien.Trangthai = "Hoạt động";
            }
            
            if (staffRP.Update(nhanvien) == true)
            {
                return "Lock Successfully";
            }
            else
            {
                return "Lock failed";
            }
        }

        public string Update(Guid id, Nhanvien NVUpdate)
        {
            var nhanvien = staffRP.GetAll().FirstOrDefault(x => x.Id == id);
            nhanvien.Ten = NVUpdate.Ten;
            nhanvien.Taikhoan = NVUpdate.Taikhoan;
            nhanvien.Matkhau = NVUpdate.Matkhau;
            nhanvien.Diachi = NVUpdate.Diachi;
            nhanvien.Email = NVUpdate.Email;
            nhanvien.Quyen = NVUpdate.Quyen;
            if (staffRP.Update(nhanvien) == true)
            {
                return "Update thành công";
            }
            else
            {
                return "Update thất bại";
            }
        }
    }
}