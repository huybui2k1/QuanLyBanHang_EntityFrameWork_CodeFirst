using SalesBussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDataAccess.Repository
{
    public class NhanVienRepository : INhanVienRepository
    {
        public NhanVien GetNhanVienLogin(string TenNhanVien, int MaNhanVien) => NhanVienDB.Instance.GetInfo(TenNhanVien, MaNhanVien);
        public IEnumerable<NhanVien> GetNhanViens() => NhanVienDB.Instance.GetNhanVienList();
        public IEnumerable<NhanVien> GetNhanVienByKeyword(string keyword) => NhanVienDB.Instance.GetNhanVienByKeyword(keyword);
        public NhanVien GetNhanVienByTenNhanVien(string tenNhanVien) => NhanVienDB.Instance.GetNhanVienByTenNhanVien(tenNhanVien);
        public void InsertNhanVien(NhanVien NhanVien) => NhanVienDB.Instance.AddNew(NhanVien);
        public void UpdateNhanVien(NhanVien NhanVien) => NhanVienDB.Instance.Update(NhanVien);
        public void DeleteNhanVien(NhanVien NhanVien) => NhanVienDB.Instance.Remove(NhanVien);
    }
}
