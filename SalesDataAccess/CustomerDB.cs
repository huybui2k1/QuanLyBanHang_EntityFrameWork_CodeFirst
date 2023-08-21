using Microsoft.Data.SqlClient;
using SalesBussinessObject;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SalesDataAccess
{
    public class CustomerDB
    {
        //using singeton Pattern 
        private static CustomerDB instance = null;
        private static readonly object instanceLock = new object();
        private CustomerDB() { }
        public static CustomerDB Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CustomerDB();

                    }
                    return instance;
                }
            }
        }
        public KhachHang GetInfo(string tenKhachHang, int maKhachHang)
        {
            KhachHang kh;
            try
            {
                using MySalesDbContext _context = new MySalesDbContext();
                // find category by category ID
                kh = _context.KhachHangs.SingleOrDefault(c=>c.TenKhachHang == tenKhachHang && c.MaKhachHang == maKhachHang);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return kh;
        }

        public IEnumerable<KhachHang> GetKhachHangList()
        {
           
            var KhachHangs = new List<KhachHang>();
            try
            {
                using MySalesDbContext _context = new MySalesDbContext();              
                KhachHangs = _context.KhachHangs.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
            return KhachHangs;
        }

        public IEnumerable<KhachHang> GetKhachHangByKeyword(string tuKhoa)
        {
            var KhachHangs = new List<KhachHang>();
            try
            {
                using MySalesDbContext _context = new MySalesDbContext();
                KhachHangs = _context.KhachHangs.Where(c => c.TenKhachHang.Contains(tuKhoa)).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
            return KhachHangs;
        }

        public KhachHang GetKhachHangByTenKhachHang(string tenKhachHang)
        {
            KhachHang kh = null;
            try
            {
                using MySalesDbContext _context = new MySalesDbContext();
                kh = _context.KhachHangs.Find(tenKhachHang);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return kh;
        }

        public void AddNew(KhachHang kh)
        {
            try
            {
                using MySalesDbContext _context = new MySalesDbContext();
                _context.KhachHangs.Add(kh);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }

        public void Update(KhachHang kh)
        {
            try
            {
                using MySalesDbContext _context = new MySalesDbContext();
                _context.Entry<KhachHang>(kh).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public void Remove(KhachHang kh)
        {
            try
            {
                using MySalesDbContext _context = new MySalesDbContext();
                var KhachHang = _context.KhachHangs.SingleOrDefault(c => c.MaKhachHang == kh.MaKhachHang);
                _context.KhachHangs.Remove(KhachHang);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}
