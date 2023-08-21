namespace SalesWinApp
{
    partial class frmKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTimKiemKH = new System.Windows.Forms.Button();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.lbMaKhachHang = new System.Windows.Forms.Label();
            this.lbDanhmuc = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.btnChinhSuaKh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiemKH
            // 
            this.btnTimKiemKH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTimKiemKH.Location = new System.Drawing.Point(612, 110);
            this.btnTimKiemKH.Name = "btnTimKiemKH";
            this.btnTimKiemKH.Size = new System.Drawing.Size(115, 32);
            this.btnTimKiemKH.TabIndex = 26;
            this.btnTimKiemKH.Text = "Tìm Kiếm";
            this.btnTimKiemKH.UseVisualStyleBackColor = true;
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKhachHang.Location = new System.Drawing.Point(267, 112);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(312, 30);
            this.txtKhachHang.TabIndex = 25;
            this.txtKhachHang.TextChanged += new System.EventHandler(this.txtKhachHang_TextChanged);
            // 
            // lbMaKhachHang
            // 
            this.lbMaKhachHang.AutoSize = true;
            this.lbMaKhachHang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMaKhachHang.Location = new System.Drawing.Point(88, 115);
            this.lbMaKhachHang.Name = "lbMaKhachHang";
            this.lbMaKhachHang.Size = new System.Drawing.Size(174, 23);
            this.lbMaKhachHang.TabIndex = 24;
            this.lbMaKhachHang.Text = "Từ khóa cần tìm kiếm";
            // 
            // lbDanhmuc
            // 
            this.lbDanhmuc.AutoSize = true;
            this.lbDanhmuc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbDanhmuc.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDanhmuc.ForeColor = System.Drawing.Color.Black;
            this.lbDanhmuc.Location = new System.Drawing.Point(267, 38);
            this.lbDanhmuc.Name = "lbDanhmuc";
            this.lbDanhmuc.Size = new System.Drawing.Size(314, 38);
            this.lbDanhmuc.TabIndex = 23;
            this.lbDanhmuc.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(633, 481);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(94, 36);
            this.btnDong.TabIndex = 22;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(472, 481);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 36);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(88, 481);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(94, 36);
            this.btnThemMoi.TabIndex = 19;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Location = new System.Drawing.Point(88, 172);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 29;
            this.dgvKhachHang.Size = new System.Drawing.Size(639, 289);
            this.dgvKhachHang.TabIndex = 18;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            this.dgvKhachHang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellDoubleClick);
            // 
            // btnChinhSuaKh
            // 
            this.btnChinhSuaKh.Location = new System.Drawing.Point(252, 487);
            this.btnChinhSuaKh.Name = "btnChinhSuaKh";
            this.btnChinhSuaKh.Size = new System.Drawing.Size(117, 27);
            this.btnChinhSuaKh.TabIndex = 27;
            this.btnChinhSuaKh.Text = "Chỉnh Sửa";
            this.btnChinhSuaKh.UseVisualStyleBackColor = true;
            this.btnChinhSuaKh.Click += new System.EventHandler(this.btnChinhSuaKh_Click);
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.btnChinhSuaKh);
            this.Controls.Add(this.btnTimKiemKH);
            this.Controls.Add(this.txtKhachHang);
            this.Controls.Add(this.lbMaKhachHang);
            this.Controls.Add(this.lbDanhmuc);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.dgvKhachHang);
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnTimKiemKH;
        private TextBox txtKhachHang;
        private Label lbMaKhachHang;
        private Label lbDanhmuc;
        private Button btnDong;
        private Button btnXoa;
        private Button btnThemMoi;
        private DataGridView dgvKhachHang;
        private Button btnChinhSuaKh;
    }
}