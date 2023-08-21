using SalesBussinessObject;
using SalesDataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmHangHoa : Form
    {
        IHangHoaRepository hangHoaRepository = new HangHoaRepository();
        BindingSource source;
        HangHoa hh;
        public HangHoa HangHoaInfo { get; set; }
        public frmHangHoa()
        {
            InitializeComponent();
        }

        private void txtTimKiemHh_TextChanged(object sender, EventArgs e)
        {
            var hangHoas = hangHoaRepository.GetHangHoaByKeyword(txtTimKiemHh.Text);
            try
            {
                source = new BindingSource();
                source.DataSource = hangHoas;

                dgvHangHoa.DataSource = null;
                dgvHangHoa.DataSource = source;
                if (hangHoas.Count() == 0)
                {
                    btnXoaHangHoa.Enabled = false;
                    btnSuaHangHoa.Enabled = false;
                }
                else
                {
                    btnXoaHangHoa.Enabled = true;
                    btnSuaHangHoa.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dgvHangHoa.Rows.Count - 1)
            // Kiểm tra nếu người dùng click vào một ô hợp lệ
            {
                DataGridViewRow row = dgvHangHoa.Rows[e.RowIndex];
                var hangHoa = hangHoaRepository.GetHangHoaByTenHangHoa(row.Cells[0].Value.ToString());
                hh = new HangHoa()
                {
                    TenHangHoa = hangHoa.TenHangHoa,
                    MaHangHoa = hangHoa.MaHangHoa,
                    SoLuong = hangHoa.SoLuong,
                    DonGiaNhap = hangHoa.DonGiaNhap,
                    DonGiaBan = hangHoa.DonGiaBan,
                    Anh = hangHoa.Anh,
                    GhiChu = hangHoa.GhiChu
                };
            }
        }

        private void dgvHangHoa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSuaHangHoa_Click(sender, e);
        }

        private void btnSuaHangHoa_Click(object sender, EventArgs e)
        {
            frmHangHoaUpdate frmHangHoaUpdate = new frmHangHoaUpdate()
            {
                Text = "Thêm mới hàng hóa",
                InsertOrUpdate = true,
                HangHoaInfo = hh,
                HangHoaRepository = hangHoaRepository
            };
            frmHangHoaUpdate.Owner = this;
            if (frmHangHoaUpdate.ShowDialog() == DialogResult.OK)
            {
                LoadHangHoaList();
                source.Position = source.Count - 1;
            }
        }
        public void LoadHangHoaList()
        {
            var hangHoas = hangHoaRepository.GetHangHoas();
            try
            {
                source = new BindingSource();
                source.DataSource = hangHoas;

                dgvHangHoa.DataSource = null;
                dgvHangHoa.DataSource = source;
                if (hangHoas.Count() == 0)
                {
                    btnXoaHangHoa.Enabled = false;
                    btnSuaHangHoa.Enabled = false;
                }
                else
                {
                    btnXoaHangHoa.Enabled = true;
                    btnSuaHangHoa.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnDongHangHoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoaHangHoa_Click(object sender, EventArgs e)
        {
            try
            {
                hangHoaRepository.DeleteHangHoa(hh);
                LoadHangHoaList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            LoadHangHoaList();
        }

        private void btnThemHangHoa_Click(object sender, EventArgs e)
        {
            frmHangHoaUpdate frmHangHoaUpdate = new frmHangHoaUpdate()
            {
                Text = "Thêm mới hàng hóa",
                InsertOrUpdate = false,
                HangHoaInfo = hh,
                HangHoaRepository = hangHoaRepository
            };
            frmHangHoaUpdate.Owner = this;
            if (frmHangHoaUpdate.ShowDialog() == DialogResult.OK)
            {
                LoadHangHoaList();
                source.Position = source.Count - 1;
            }
        }
    }
}
