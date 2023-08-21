using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesBussinessObject
{
    public class HangHoa
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaHangHoa { get; set; }
        public string TenHangHoa { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGiaNhap { get; set; }
        public decimal DonGiaBan { get; set; }
        public string Anh { get; set; }
        public string? GhiChu { get; set; }
    }
}
