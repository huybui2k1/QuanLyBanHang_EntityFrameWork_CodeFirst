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
    public class NhanVienDB
    {
        //using singeton Pattern 
        private static NhanVienDB instance = null;
        private static readonly object instanceLock = new object();
        private NhanVienDB() { }
        public static NhanVienDB Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new NhanVienDB();

                    }
                    return instance;
                }
            }
        }
        public NhanVien GetInfo(string tenNhanVien, int maNhanVien)
        {
            NhanVien nv;
            try
            {
                using MySalesDbContext _context = new MySalesDbContext();
                // find category by category ID
                nv = _context.NhanViens.SingleOrDefault(c=>c.TenNhanVien == tenNhanVien && c.MaNhanVien == maNhanVien);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return nv;
        }

        public IEnumerable<NhanVien> GetNhanVienList()
        {
           
            var NhanViens = new List<NhanVien>();
            try
            {
                using MySalesDbContext _context = new MySalesDbContext();              
                NhanViens = _context.NhanViens.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
            return NhanViens;
        }

        public IEnumerable<NhanVien> GetNhanVienByKeyword(string tuKhoa)
        {
            var NhanViens = new List<NhanVien>();
            try
            {
                using MySalesDbContext _context = new MySalesDbContext();
                NhanViens = _context.NhanViens.Where(c => c.TenNhanVien.Contains(tuKhoa)).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
            return NhanViens;
        }

        public NhanVien GetNhanVienByTenNhanVien(string tenNhanVien)
        {
            NhanVien nv = null;
            try
            {
                using MySalesDbContext _context = new MySalesDbContext();
                nv = _context.NhanViens.Find(tenNhanVien);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return nv;
        }

        public void AddNew(NhanVien nv)
        {
            try
            {
                using MySalesDbContext _context = new MySalesDbContext();
                _context.NhanViens.Add(nv);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }

        public void Update(NhanVien nv)
        {
            try
            {
                using MySalesDbContext _context = new MySalesDbContext();
                _context.Entry<NhanVien>(nv).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public void Remove(NhanVien nv)
        {
            try
            {
                using MySalesDbContext _context = new MySalesDbContext();
                var NhanVien = _context.NhanViens.SingleOrDefault(c => c.MaNhanVien == nv.MaNhanVien);
                _context.NhanViens.Remove(NhanVien);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}
