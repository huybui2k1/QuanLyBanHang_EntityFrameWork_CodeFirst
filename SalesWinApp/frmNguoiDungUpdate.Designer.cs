namespace SalesWinApp
{
    partial class frmNguoiDungUpdate
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
            this.label6 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtMaNguoiDung = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDanhmuc = new System.Windows.Forms.Label();
            this.cboLoaiNguoiDung = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(149, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 23);
            this.label6.TabIndex = 53;
            this.label6.Text = "Loại Người Dùng";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThoat.ForeColor = System.Drawing.Color.DeepPink;
            this.btnThoat.Location = new System.Drawing.Point(473, 319);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(93, 41);
            this.btnThoat.TabIndex = 51;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCapNhat.ForeColor = System.Drawing.Color.DeepPink;
            this.btnCapNhat.Location = new System.Drawing.Point(299, 319);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(99, 41);
            this.btnCapNhat.TabIndex = 50;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtMaNguoiDung
            // 
            this.txtMaNguoiDung.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaNguoiDung.Location = new System.Drawing.Point(303, 201);
            this.txtMaNguoiDung.Name = "txtMaNguoiDung";
            this.txtMaNguoiDung.Size = new System.Drawing.Size(263, 30);
            this.txtMaNguoiDung.TabIndex = 48;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMatKhau.Location = new System.Drawing.Point(303, 153);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(263, 30);
            this.txtMatKhau.TabIndex = 47;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTenDangNhap.Location = new System.Drawing.Point(303, 101);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(263, 30);
            this.txtTenDangNhap.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(146, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 23);
            this.label3.TabIndex = 44;
            this.label3.Text = "Mã Người Dùng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(146, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 43;
            this.label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(146, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 42;
            this.label1.Text = "Tên Đăng Nhập";
            // 
            // lbDanhmuc
            // 
            this.lbDanhmuc.AutoSize = true;
            this.lbDanhmuc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbDanhmuc.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDanhmuc.ForeColor = System.Drawing.Color.Black;
            this.lbDanhmuc.Location = new System.Drawing.Point(212, 26);
            this.lbDanhmuc.Name = "lbDanhmuc";
            this.lbDanhmuc.Size = new System.Drawing.Size(333, 38);
            this.lbDanhmuc.TabIndex = 41;
            this.lbDanhmuc.Text = "CẬP NHẬT NGƯỜI DÙNG";
            // 
            // cboLoaiNguoiDung
            // 
            this.cboLoaiNguoiDung.FormattingEnabled = true;
            this.cboLoaiNguoiDung.Location = new System.Drawing.Point(303, 256);
            this.cboLoaiNguoiDung.Name = "cboLoaiNguoiDung";
            this.cboLoaiNguoiDung.Size = new System.Drawing.Size(263, 28);
            this.cboLoaiNguoiDung.TabIndex = 56;
            // 
            // frmNguoiDungUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 396);
            this.Controls.Add(this.cboLoaiNguoiDung);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtMaNguoiDung);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDanhmuc);
            this.Name = "frmNguoiDungUpdate";
            this.Text = "frmNguoiDungUpdate";
            this.Load += new System.EventHandler(this.frmNguoiDungUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label6;
        private Button btnThoat;
        private Button btnCapNhat;
        private TextBox txtMaNguoiDung;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lbDanhmuc;
        private ComboBox cboLoaiNguoiDung;
    }
}