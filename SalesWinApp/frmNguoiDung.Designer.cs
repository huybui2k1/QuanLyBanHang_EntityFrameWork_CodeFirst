namespace SalesWinApp
{
    partial class frmNguoiDung
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.lbManguoidung = new System.Windows.Forms.Label();
            this.lbDanhmuc = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.dgvNguoidung = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoidung)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(608, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 27);
            this.button1.TabIndex = 26;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTuKhoa.Location = new System.Drawing.Point(263, 111);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(312, 30);
            this.txtTuKhoa.TabIndex = 25;
            this.txtTuKhoa.TextChanged += new System.EventHandler(this.txtTuKhoa_TextChanged);
            // 
            // lbManguoidung
            // 
            this.lbManguoidung.AutoSize = true;
            this.lbManguoidung.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbManguoidung.Location = new System.Drawing.Point(84, 114);
            this.lbManguoidung.Name = "lbManguoidung";
            this.lbManguoidung.Size = new System.Drawing.Size(174, 23);
            this.lbManguoidung.TabIndex = 24;
            this.lbManguoidung.Text = "Từ khóa cần tìm kiếm";
            // 
            // lbDanhmuc
            // 
            this.lbDanhmuc.AutoSize = true;
            this.lbDanhmuc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbDanhmuc.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDanhmuc.ForeColor = System.Drawing.Color.Black;
            this.lbDanhmuc.Location = new System.Drawing.Point(263, 34);
            this.lbDanhmuc.Name = "lbDanhmuc";
            this.lbDanhmuc.Size = new System.Drawing.Size(313, 38);
            this.lbDanhmuc.TabIndex = 23;
            this.lbDanhmuc.Text = "QUẢN LÝ NGƯỜI DÙNG";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(629, 480);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(94, 36);
            this.btnDong.TabIndex = 22;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Location = new System.Drawing.Point(285, 480);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(94, 36);
            this.btnChinhSua.TabIndex = 21;
            this.btnChinhSua.Text = "Chỉnh sửa";
            this.btnChinhSua.UseVisualStyleBackColor = true;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(468, 480);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 36);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(84, 480);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(94, 36);
            this.btnThemMoi.TabIndex = 19;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // dgvNguoidung
            // 
            this.dgvNguoidung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguoidung.Location = new System.Drawing.Point(84, 171);
            this.dgvNguoidung.Name = "dgvNguoidung";
            this.dgvNguoidung.RowHeadersWidth = 51;
            this.dgvNguoidung.RowTemplate.Height = 29;
            this.dgvNguoidung.Size = new System.Drawing.Size(639, 289);
            this.dgvNguoidung.TabIndex = 18;
            this.dgvNguoidung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNguoidung_CellClick);
            this.dgvNguoidung.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNguoidung_CellDoubleClick);
            // 
            // frmNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.lbManguoidung);
            this.Controls.Add(this.lbDanhmuc);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.dgvNguoidung);
            this.Name = "frmNguoiDung";
            this.Text = "frmNguoiDung";
            this.Load += new System.EventHandler(this.frmNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoidung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox txtTuKhoa;
        private Label lbManguoidung;
        private Label lbDanhmuc;
        private Button btnDong;
        private Button btnChinhSua;
        private Button btnXoa;
        private Button btnThemMoi;
        private DataGridView dgvNguoidung;
    }
}