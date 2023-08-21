using SalesBussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDataAccess.Repository
{
    public interface IHangHoaRepository
    {
        HangHoa GetHangHoaLogin(string TenHangHoa, int MaHangHoa);
        IEnumerable<HangHoa> GetHangHoas();
        IEnumerable<HangHoa> GetHangHoaByKeyword(string keyword);
        HangHoa GetHangHoaByTenHangHoa(string tenHangHoa);
        void InsertHangHoa(HangHoa HangHoa);
        void UpdateHangHoa(HangHoa HangHoa);
        void DeleteHangHoa(HangHoa HangHoa);
    }
}
