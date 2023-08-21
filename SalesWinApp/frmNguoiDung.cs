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
    public partial class frmNguoiDung : Form
    {
        INguoiDungRepository nguoiDungRepository = new NguoiDungRepository();
        BindingSource source;
        NguoiDung nd;
        public NguoiDung NguoiDungInfo { get; set; }
        public frmNguoiDung()
        {
            InitializeComponent();
        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
            var nguoiDungs = nguoiDungRepository.GetNguoiDungByKeyword(txtTuKhoa.Text);
            try
            {
                source = new BindingSource();
                source.DataSource = nguoiDungs;

                dgvNguoidung.DataSource = null;
                dgvNguoidung.DataSource = source;
                if (nguoiDungs.Count() == 0)
                {
                    btnXoa.Enabled = false;
                    btnChinhSua.Enabled = false;
                }
                else
                {
                    btnXoa.Enabled = true;
                    btnChinhSua.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void dgvNguoidung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dgvNguoidung.Rows.Count - 1)
            // Kiểm tra nếu người dùng click vào một ô hợp lệ
            {
                DataGridViewRow row = dgvNguoidung.Rows[e.RowIndex];
                var nguoiDung = nguoiDungRepository.GetNguoiDungByTenDangNhap(row.Cells[0].Value.ToString());
                nd = new NguoiDung()
                {
                    TenDangNhap = nguoiDung.TenDangNhap,
                    MatKhau = nguoiDung.MatKhau,
                    LoaiNguoiDung = nguoiDung.LoaiNguoiDung,
                    MaNguoiDung = nguoiDung.MaNguoiDung
                };
            }
        }

        private void dgvNguoidung_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnChinhSua_Click(sender, e);
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            frmNguoiDungUpdate frmNguoiDungUpdate = new frmNguoiDungUpdate()
            {
                Text = "Cập nhật Người dùng",
                InsertOrUpdate = true,
                NguoiDungInfo = nd,
                NguoiDungRepository = nguoiDungRepository
            };
            frmNguoiDungUpdate.Owner = this;
            if (frmNguoiDungUpdate.ShowDialog() == DialogResult.OK)
            {
                LoadNguoiDungList();
                source.Position = source.Count - 1;
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmNguoiDungUpdate frmNguoiDungUpdate = new frmNguoiDungUpdate()
            {
                Text = "Cập nhật Người dùng",
                InsertOrUpdate = false,
                NguoiDungInfo = nd,
                NguoiDungRepository = nguoiDungRepository
            };
            frmNguoiDungUpdate.Owner = this;
            if (frmNguoiDungUpdate.ShowDialog() == DialogResult.OK)
            {
                LoadNguoiDungList();
                source.Position = source.Count - 1;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                nguoiDungRepository.DeleteNguoiDung(nd);
                LoadNguoiDungList();
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

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            LoadNguoiDungList();
        }

        public void LoadNguoiDungList()
        {
            var nguoiDungs = nguoiDungRepository.GetNguoiDungs();
            try
            {
                source = new BindingSource();
                source.DataSource = nguoiDungs;

                dgvNguoidung.DataSource = null;
                dgvNguoidung.DataSource = source;
                if (nguoiDungs.Count() == 0)
                {
                    btnXoa.Enabled = false;
                    btnChinhSua.Enabled = false;
                }
                else
                {
                    btnXoa.Enabled = true;
                    btnChinhSua.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        }
    }

