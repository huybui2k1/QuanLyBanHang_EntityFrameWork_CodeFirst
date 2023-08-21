using SalesBussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDataAccess.Repository
{
    public class KhachHangRepository : IKhachHangRepository
    {
        public KhachHang GetKhachHangLogin(string TenKhachHang, int MaKhachHang) => CustomerDB.Instance.GetInfo(TenKhachHang, MaKhachHang);
        public IEnumerable<KhachHang> GetKhachHangs() => CustomerDB.Instance.GetKhachHangList();
        public IEnumerable<KhachHang> GetKhachHangByKeyword(string keyword) => CustomerDB.Instance.GetKhachHangByKeyword(keyword);
        public KhachHang GetKhachHangByTenKhachHang(string tenKhachHang) => CustomerDB.Instance.GetKhachHangByTenKhachHang(tenKhachHang);
        public void InsertKhachHang(KhachHang KhachHang) => CustomerDB.Instance.AddNew(KhachHang);
        public void UpdateKhachHang(KhachHang KhachHang) => CustomerDB.Instance.Update(KhachHang);
        public void DeleteKhachHang(KhachHang KhachHang) => CustomerDB.Instance.Remove(KhachHang);
    }
}
