using DAL.IRepositories;
using DAL.Model;
using DAL.Mydbcontext;

namespace DAL.Repositories
{
    public class SaleRP : ISaleRP
    {
        private ShopDbcontext _dbcontext;

        public SaleRP()
        {
            _dbcontext = new ShopDbcontext();
        }

        public bool Add(Khuyenmai KM)
        {
            _dbcontext.Add(KM);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(Khuyenmai KM)
        {
            _dbcontext.Remove(KM);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<Khuyenmai> GetAll()
        {
            return _dbcontext.Khuyenmais.ToList();
        }

        public List<Khuyenmai> GetKhuyemaiByName(string name)
        {
            return _dbcontext.Khuyenmais.Where(x => x.Tenmakhuyenmai.Contains(name)).ToList();
        }

        public bool Update(Khuyenmai KM)
        {
            _dbcontext.Update(KM);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}