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
    public partial class frmKhachHang : Form
    {
        IKhachHangRepository khachHangRepository = new KhachHangRepository();
        BindingSource source;
        KhachHang kh;
        public KhachHang KhachHangInfo { get; set; }
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void txtKhachHang_TextChanged(object sender, EventArgs e)
        {
            var khachHangs = khachHangRepository.GetKhachHangByKeyword(txtKhachHang.Text);
            try
            {
                source = new BindingSource();
                source.DataSource = khachHangs;

                dgvKhachHang.DataSource = null;
                dgvKhachHang.DataSource = source;
                if (khachHangs.Count() == 0)
                {
                    btnXoa.Enabled = false;
                    btnChinhSuaKh.Enabled = false;
                }
                else
                {
                    btnXoa.Enabled = true;
                    btnChinhSuaKh.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dgvKhachHang.Rows.Count - 1)
            // Kiểm tra nếu người dùng click vào một ô hợp lệ
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
                var khachHang = khachHangRepository.GetKhachHangByTenKhachHang(row.Cells[0].Value.ToString());
                kh = new KhachHang()
                {
                    TenKhachHang = khachHang.TenKhachHang,
                    MaKhachHang = khachHang.MaKhachHang,
                    DiaChi = khachHang.DiaChi,
                    DienThoai = khachHang.DienThoai
                };
            }
        }

        private void dgvKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnChinhSuaKh_Click(sender, e);
        }

        public void LoadKhachHangList()
        {
            var khachHangs = khachHangRepository.GetKhachHangs();
            try
            {
                source = new BindingSource();
                source.DataSource = khachHangs;

                dgvKhachHang.DataSource = null;
                dgvKhachHang.DataSource = source;
                if (khachHangs.Count() == 0)
                {
                    btnXoa.Enabled = false;
                    btnChinhSuaKh.Enabled = false;
                }
                else
                {
                    btnXoa.Enabled = true;
                    btnChinhSuaKh.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                khachHangRepository.DeleteKhachHang(kh);
                LoadKhachHangList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHangList();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmKhachHangUpdate frmKhachHangUpdate = new frmKhachHangUpdate()
            {
                Text = "Thêm mới Khách hàng",
                InsertOrUpdate = false,
                KhachHangInfo = kh,
                KhachHangRepository = khachHangRepository
            };
            frmKhachHangUpdate.Owner = this;
            if (frmKhachHangUpdate.ShowDialog() == DialogResult.OK)
            {
                LoadKhachHangList();
                source.Position = source.Count - 1;
            }
        }

        private void btnChinhSuaKh_Click(object sender, EventArgs e)
        {
            frmKhachHangUpdate frmKhachHangUpdate = new frmKhachHangUpdate()
            {
                Text = "Cập nhật Khách Hàng",
                InsertOrUpdate = true,
                KhachHangInfo = kh,
                KhachHangRepository = khachHangRepository
            };
            frmKhachHangUpdate.Owner = this;
            if (frmKhachHangUpdate.ShowDialog() == DialogResult.OK)
            {
                LoadKhachHangList();
                source.Position = source.Count - 1;
            }
        }
    }
}
