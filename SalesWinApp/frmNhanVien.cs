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
    public partial class frmNhanVien : Form
    {
        INhanVienRepository nhanVienRepository = new NhanVienRepository();
        BindingSource source;
        NhanVien nv;
        public NhanVien NhanVienInfo { get; set; }
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void txtQLNV_TextChanged(object sender, EventArgs e)
        {
            var nhanViens = nhanVienRepository.GetNhanVienByKeyword(txtQLNV.Text);
            try
            {
                source = new BindingSource();
                source.DataSource = nhanViens;

                dgvNhanVien.DataSource = null;
                dgvNhanVien.DataSource = source;
                if (nhanViens.Count() == 0)
                {
                    btnXoaNV.Enabled = false;
                    btnChinhSuaNV.Enabled = false;
                }
                else
                {
                    btnXoaNV.Enabled = true;
                    btnChinhSuaNV.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dgvNhanVien.Rows.Count - 1)
            // Kiểm tra nếu người dùng click vào một ô hợp lệ
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                var nhanVien = nhanVienRepository.GetNhanVienByTenNhanVien(row.Cells[0].Value.ToString());
                nv = new NhanVien()
                {
                    TenNhanVien = nhanVien.TenNhanVien,
                    MaNhanVien = nhanVien.MaNhanVien,
                    DiaChi = nhanVien.DiaChi,
                    DienThoai = nhanVien.DienThoai
                };
            }

        }

        public void LoadNhanVienList()
        {
            var nhanViens = nhanVienRepository.GetNhanViens();
            try
            {
                source = new BindingSource();
                source.DataSource = nhanViens;

                dgvNhanVien.DataSource = null;
                dgvNhanVien.DataSource = source;
                if (nhanViens.Count() == 0)
                {
                    btnXoaNV.Enabled = false;
                    btnChinhSuaNV.Enabled = false;
                }
                else
                {
                    btnXoaNV.Enabled = true;
                    btnChinhSuaNV.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnDongNV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            try
            {
                nhanVienRepository.DeleteNhanVien(nv);
                LoadNhanVienList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVienList();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            frmNhanVienUpdate frmNhanVienUpdate = new frmNhanVienUpdate()
            {
                Text = "Thêm mới Nhân Viên",
                InsertOrUpdate = false,
                NhanVienInfo = nv,
                NhanVienRepository = nhanVienRepository
            };
            frmNhanVienUpdate.Owner = this;
            if (frmNhanVienUpdate.ShowDialog() == DialogResult.OK)
            {
                LoadNhanVienList();
                source.Position = source.Count - 1;
            }
        }

        private void btnChinhSuaNV_Click(object sender, EventArgs e)
        {
            frmNhanVienUpdate frmNhanVienUpdate = new frmNhanVienUpdate()
            {
                Text = "Cập nhật Nhân Viên",
                InsertOrUpdate = true,
                NhanVienInfo = nv,
                NhanVienRepository = nhanVienRepository
            };
            frmNhanVienUpdate.Owner = this;
            if (frmNhanVienUpdate.ShowDialog() == DialogResult.OK)
            {
                LoadNhanVienList();
                source.Position = source.Count - 1;
            }
        }

        private void dgvNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnChinhSuaNV_Click(sender, e);
        }
    }
}
