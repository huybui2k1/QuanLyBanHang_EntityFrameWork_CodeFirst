using SalesBussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDataAccess.Repository
{
    public class NguoiDungRepository : INguoiDungRepository
    {
        public NguoiDung GetNguoiDungLogin(string TenDangNhap, string MatKhau) => UsersDB.Instance.GetInfo(TenDangNhap, MatKhau);
        public IEnumerable<NguoiDung> GetNguoiDungs() => UsersDB.Instance.GetNguoiDungList();
        public IEnumerable<NguoiDung> GetNguoiDungByKeyword(string keyword) => UsersDB.Instance.GetNguoiDungByKeyword(keyword);
        public NguoiDung GetNguoiDungByTenDangNhap(string tenDangNhap) => UsersDB.Instance.GetNguoiDungByTenDangNhap(tenDangNhap);
        public void InsertNguoiDung(NguoiDung nguoiDung) => UsersDB.Instance.AddNew(nguoiDung);
        public void UpdateNguoiDung(NguoiDung nguoiDung) => UsersDB.Instance.Update(nguoiDung);
        public void DeleteNguoiDung(NguoiDung nguoiDung) => UsersDB.Instance.Remove(nguoiDung);
    }
}
