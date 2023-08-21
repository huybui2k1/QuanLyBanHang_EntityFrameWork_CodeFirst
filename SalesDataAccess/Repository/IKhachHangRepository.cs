using SalesBussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDataAccess.Repository
{
    public interface IKhachHangRepository
    {
        KhachHang GetKhachHangLogin(string TenKhachHang, int MaKhachHang);
        IEnumerable<KhachHang> GetKhachHangs();
        IEnumerable<KhachHang> GetKhachHangByKeyword(string keyword);
        KhachHang GetKhachHangByTenKhachHang(string tenKhachHang);
        void InsertKhachHang(KhachHang khachHang);
        void UpdateKhachHang(KhachHang khachHang);
        void DeleteKhachHang(KhachHang khachHang);
    }
}
