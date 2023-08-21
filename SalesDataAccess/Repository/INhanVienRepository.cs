using SalesBussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDataAccess.Repository
{
    public interface INhanVienRepository

    {
        NhanVien GetNhanVienLogin(string TenNhanVien, int MaNhanVien);
        IEnumerable<NhanVien> GetNhanViens();
        IEnumerable<NhanVien> GetNhanVienByKeyword(string keyword);
        NhanVien GetNhanVienByTenNhanVien(string tenNhanVien);
        void InsertNhanVien(NhanVien nhanVien);
        void UpdateNhanVien(NhanVien nhanVien);
        void DeleteNhanVien(NhanVien nhanVien);
    }
}
