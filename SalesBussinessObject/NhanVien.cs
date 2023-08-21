using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesBussinessObject
{
    public class NhanVien
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
       
    }
}
