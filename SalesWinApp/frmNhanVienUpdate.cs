﻿using SalesBussinessObject;
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
    public partial class frmNhanVienUpdate : Form
    {
        public INhanVienRepository NhanVienRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public NhanVien NhanVienInfo { get; set; }
        public frmNhanVienUpdate()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                var nv = new NhanVien
                {
                    MaNhanVien = Convert.ToInt32(txtManhanVien.Text == "" ? 0 : txtManhanVien.Text),
                    TenNhanVien = txtTennhanVien.Text,
                    DiaChi = txtDiachiNV.Text,
                    DienThoai = txtDienThoaiNV.Text


                };
                if (InsertOrUpdate = false)
                {
                    NhanVienRepository.InsertNhanVien(nv);
                    if (MessageBox.Show("Bạn đã tạo mới thành công!", "Thông tin") == DialogResult.OK)
                    {
                        this.Visible = false;
                        ((frmNhanVien)this.Owner).LoadNhanVienList();
                    }
                }
                else
                {
                    NhanVienRepository.InsertNhanVien(nv);
                    if (MessageBox.Show("Bạn đã cập nhật thành công!", "Thông tin") == DialogResult.OK)
                    {
                        this.Visible = false;
                        ((frmNhanVien)this.Owner).LoadNhanVienList();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void frmNhanVienUpdate_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate == true)
            {
               txtManhanVien.Text = NhanVienInfo.MaNhanVien.ToString();
                txtTennhanVien.Text = NhanVienInfo.TenNhanVien.ToString();
                txtDiachiNV.Text = NhanVienInfo.DiaChi.ToString();
                txtDienThoaiNV.Text = NhanVienInfo.DienThoai.ToString();

              
            };
            
        }
    }
}
