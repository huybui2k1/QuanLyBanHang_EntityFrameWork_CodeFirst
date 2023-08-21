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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnu_NhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frm_nv = new frmNhanVien();
            frm_nv.MdiParent = this;
            frm_nv.Show();
        }

        private void qLNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNguoiDung frm_nd = new frmNguoiDung();
            frm_nd.MdiParent = this;
            frm_nd.Show();
        }

        private void mnu_DangNhap_Click(object sender, EventArgs e)
        {
            frmLogin frm_login = new frmLogin();
            frm_login.MdiParent = this;
            frm_login.Show();
        }

        private void mnu_KhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang frm_kh = new frmKhachHang();
            frm_kh.MdiParent = this;
            frm_kh.Show();
        }

        private void mnu_HangHoa_Click(object sender, EventArgs e)
        {
            frmHangHoa frm_hh = new frmHangHoa();
            frm_hh.MdiParent = this;
            frm_hh.Show();
        }
    }
}
