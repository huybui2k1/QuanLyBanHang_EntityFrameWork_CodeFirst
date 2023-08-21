using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesBussinessObject
{
    public class NguoiDung
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public int LoaiNguoiDung { get; set; }
        public int? MaNguoiDung { get; set; }
    }
}
