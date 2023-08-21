using SalesBussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDataAccess.Repository
{
    public class HangHoaRepository : IHangHoaRepository
    {
        public HangHoa GetHangHoaLogin(string TenHangHoa, int MaHangHoa) => HangHoaDB.Instance.GetInfo(TenHangHoa, MaHangHoa);
        public IEnumerable<HangHoa> GetHangHoas() => HangHoaDB.Instance.GetHangHoaList();
        public IEnumerable<HangHoa> GetHangHoaByKeyword(string keyword) => HangHoaDB.Instance.GetHangHoaByKeyword(keyword);
        public HangHoa GetHangHoaByTenHangHoa(string tenHangHoa) => HangHoaDB.Instance.GetHangHoaByTenHangHoa(tenHangHoa);
        public void InsertHangHoa(HangHoa HangHoa) => HangHoaDB.Instance.AddNew(HangHoa);
        public void UpdateHangHoa(HangHoa HangHoa) => HangHoaDB.Instance.Update(HangHoa);
        public void DeleteHangHoa(HangHoa HangHoa) => HangHoaDB.Instance.Remove(HangHoa);
    }
}

