namespace SalesWinApp
{
    partial class frmKhachHangUpdate
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtDienThoai = new System.Windows.Forms.MaskedTextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtTenkhachhang = new System.Windows.Forms.TextBox();
            this.txtMakhachhang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDanhmuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThoat.ForeColor = System.Drawing.Color.DeepPink;
            this.btnThoat.Location = new System.Drawing.Point(405, 343);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(89, 34);
            this.btnThoat.TabIndex = 36;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCapNhat.ForeColor = System.Drawing.Color.DeepPink;
            this.btnCapNhat.Location = new System.Drawing.Point(235, 343);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(95, 34);
            this.btnCapNhat.TabIndex = 35;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDienThoai.Location = new System.Drawing.Point(231, 275);
            this.txtDienThoai.Mask = "(00)000.000.000";
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(263, 30);
            this.txtDienThoai.TabIndex = 34;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDiachi.Location = new System.Drawing.Point(231, 227);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(263, 30);
            this.txtDiachi.TabIndex = 33;
            // 
            // txtTenkhachhang
            // 
            this.txtTenkhachhang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTenkhachhang.Location = new System.Drawing.Point(231, 179);
            this.txtTenkhachhang.Name = "txtTenkhachhang";
            this.txtTenkhachhang.Size = new System.Drawing.Size(263, 30);
            this.txtTenkhachhang.TabIndex = 32;
            // 
            // txtMakhachhang
            // 
            this.txtMakhachhang.Enabled = false;
            this.txtMakhachhang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMakhachhang.Location = new System.Drawing.Point(231, 127);
            this.txtMakhachhang.Name = "txtMakhachhang";
            this.txtMakhachhang.Size = new System.Drawing.Size(263, 30);
            this.txtMakhachhang.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(74, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "Điện thoại\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(74, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(74, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tên Khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(74, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mã khách hàng";
            // 
            // lbDanhmuc
            // 
            this.lbDanhmuc.AutoSize = true;
            this.lbDanhmuc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbDanhmuc.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDanhmuc.ForeColor = System.Drawing.Color.Black;
            this.lbDanhmuc.Location = new System.Drawing.Point(145, 51);
            this.lbDanhmuc.Name = "lbDanhmuc";
            this.lbDanhmuc.Size = new System.Drawing.Size(334, 38);
            this.lbDanhmuc.TabIndex = 26;
            this.lbDanhmuc.Text = "CẬP NHẬT KHÁCH HÀNG";
            // 
            // frmKhachHangUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 433);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtTenkhachhang);
            this.Controls.Add(this.txtMakhachhang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDanhmuc);
            this.Name = "frmKhachHangUpdate";
            this.Text = "frmKhachHangUpdate";
            this.Load += new System.EventHandler(this.frmKhachHangUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnThoat;
        private Button btnCapNhat;
        private MaskedTextBox txtDienThoai;
        private TextBox txtDiachi;
        private TextBox txtTenkhachhang;
        private TextBox txtMakhachhang;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lbDanhmuc;
    }
}