using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesBussinessObject
{
    public class KhachHang
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
    }
}
