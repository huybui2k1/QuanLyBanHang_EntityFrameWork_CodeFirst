using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SalesBussinessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDataAccess
{
    public class MySalesDbContext : DbContext
    {
        public MySalesDbContext() { }
        [Key]

        public DbSet<NguoiDung> NguoiDungs { get;set; }
        public DbSet<LoaiNguoiDung> LoaiNguoiDungs { get;set; }
        public DbSet<NhanVien> NhanViens { get;set; }
        public DbSet<KhachHang> KhachHangs { get;set; }
        public DbSet<HangHoa> HangHoas { get;set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("QLBHTest_V2_2108"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //using fluent API instead of attributes
            //to limit the length of a category name to under 40
            modelBuilder.Entity<NguoiDung>()
                .Property(category => category.TenDangNhap)
                .IsRequired() //not null
                .HasMaxLength(100);

            //modelBuilder.Entity<NhanVien>()
            //    .Property(tenNhanVien => tenNhanVien.TenNhanVien)
            //    .IsRequired() //not null
            //    .HasMaxLength(100);

            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //insert data for categories table
            //modelBuilder.Entity<NguoiDung>().HasData(
            //    new NguoiDung { TenDangNhap = 1, CategoryName = "Beverages" },
            //    new NguoiDung { TenDangNhap = 2, CategoryName = "Condiments" };

        }

    }
}
