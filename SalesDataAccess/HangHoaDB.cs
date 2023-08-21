using SalesBussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDataAccess
{
    public class HangHoaDB
    {
        //using singeton Pattern 
        private static HangHoaDB instance = null;
        private static readonly object instanceLock = new object();
        private HangHoaDB() { }
        public static HangHoaDB Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new HangHoaDB();

                    }
                    return instance;
                }
            }
        }

        public HangHoa GetInfo(string tenHangHoa, int maHangHoa)
        {
            HangHoa hh;
            try
            {
                using MySalesDbContext _context = new MySalesDbContext();
                // find category by category ID
                hh = _context.HangHoas.SingleOrDefault(c => c.TenHangHoa == tenHangHoa && c.MaHangHoa == maHangHoa);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return hh;
        }

        public IEnumerable<HangHoa> GetHangHoaList()
        {

            var HangHoas = new List<HangHoa>();
            try
            {
                using MySalesDbContext _context = new MySalesDbContext();
                HangHoas = _context.HangHoas.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return HangHoas;
        }

        public IEnumerable<HangHoa> GetHangHoaByKeyword(string tuKhoa)
        {
            var HangHoas = new List<HangHoa>();
            try
            {
                using MySalesDbContext _context = new MySalesDbContext();
                HangHoas = _context.HangHoas.Where(c => c.TenHangHoa.Contains(tuKhoa)).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return HangHoas;
        }

        public HangHoa GetHangHoaByTenHangHoa(string tenHangHoa)
        {
            HangHoa hh = null;
            try
            {
                using MySalesDbContext _context = new MySalesDbContext();
                hh = _context.HangHoas.Find(tenHangHoa);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return hh;
        }

        public void AddNew(HangHoa hh)
        {
            try
            {
                using MySalesDbContext _context = new MySalesDbContext();
                _context.HangHoas.Add(hh);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void Update(HangHoa hh)
        {
            try
            {
                using MySalesDbContext _context = new MySalesDbContext();
                _context.Entry<HangHoa>(hh).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public void Remove(HangHoa hh)
        {
            try
            {
                using MySalesDbContext _context = new MySalesDbContext();
                var HangHoa = _context.HangHoas.SingleOrDefault(c => c.MaHangHoa == hh.MaHangHoa);
                _context.HangHoas.Remove(HangHoa);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
