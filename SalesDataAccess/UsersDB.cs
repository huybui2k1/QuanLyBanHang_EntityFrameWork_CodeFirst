using Microsoft.Data.SqlClient;
using SalesBussinessObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SalesDataAccess
{
    public class UsersDB
    {
        //using singeton Pattern 
        private static UsersDB instance = null;
        private static readonly object instanceLock = new object();
        private UsersDB() { }
        public static UsersDB Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UsersDB();

                    }
                    return instance;
                }
            }
        }
        public NguoiDung GetInfo(string tenDangNhap, string matKhau)
        {
            NguoiDung nd;
            try
            {
                using MySalesDbContext _context = new MySalesDbContext();
                // find category by category ID
                nd = _context.NguoiDungs.SingleOrDefault(c=>c.TenDangNhap== tenDangNhap && c.MatKhau == matKhau);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return nd;
        }

        public IEnumerable<NguoiDung> GetNguoiDungList()
        {
           
            var nguoiDungs = new List<NguoiDung>();
            try
            {
                using MySalesDbContext _context = new MySalesDbContext();              
                nguoiDungs = _context.NguoiDungs.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
            return nguoiDungs;
        }

        public IEnumerable<NguoiDung> GetNguoiDungByKeyword(string tuKhoa)
        {
            var nguoiDungs = new List<NguoiDung>();
            try
            {
                using MySalesDbContext _context = new MySalesDbContext();
                nguoiDungs = _context.NguoiDungs.Where(c=>c.TenDangNhap.Contains(tuKhoa)).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
            return nguoiDungs;
        }

        public NguoiDung GetNguoiDungByTenDangNhap(string tenDangNhap)
        {
            NguoiDung nd = null;
            try
            {
                using MySalesDbContext _context = new MySalesDbContext();
                nd = _context.NguoiDungs.Find(tenDangNhap);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return nd;
        }

        public void AddNew(NguoiDung nd)
        {
            try
            {
                using MySalesDbContext _context = new MySalesDbContext();
                _context.NguoiDungs.Add(nd);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }

        public void Update(NguoiDung nd)
        {
            try
            {
                using MySalesDbContext _context = new MySalesDbContext();
                _context.Entry<NguoiDung>(nd).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public void Remove(NguoiDung nd)
        {
            try
            {
                using MySalesDbContext _context = new MySalesDbContext();
                var nguoiDung = _context.NguoiDungs.SingleOrDefault(c => c.TenDangNhap == nd.TenDangNhap);
                _context.NguoiDungs.Remove(nguoiDung);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}
