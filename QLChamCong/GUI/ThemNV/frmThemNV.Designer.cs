
namespace GUI
{
    partial class frmThemNV
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
            this.label1 = new System.Windows.Forms.Label();
            this.grThongTinNV = new System.Windows.Forms.GroupBox();
            this.cboLuong = new System.Windows.Forms.ComboBox();
            this.cboCV = new System.Windows.Forms.ComboBox();
            this.dateTimeNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cboPhongBan = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNu = new System.Windows.Forms.RadioButton();
            this.btnNam = new System.Windows.Forms.RadioButton();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.btnThuMuc = new System.Windows.Forms.Button();
            this.pictureAVT = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvnv = new System.Windows.Forms.DataGridView();
            this.grThongTinNV.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAVT)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvnv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(310, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm Nhân Viên ";
            // 
            // grThongTinNV
            // 
            this.grThongTinNV.Controls.Add(this.cboLuong);
            this.grThongTinNV.Controls.Add(this.cboCV);
            this.grThongTinNV.Controls.Add(this.dateTimeNgaySinh);
            this.grThongTinNV.Controls.Add(this.cboPhongBan);
            this.grThongTinNV.Controls.Add(this.btnSave);
            this.grThongTinNV.Controls.Add(this.txtCMND);
            this.grThongTinNV.Controls.Add(this.panel1);
            this.grThongTinNV.Controls.Add(this.txtTenNV);
            this.grThongTinNV.Controls.Add(this.txtMaNV);
            this.grThongTinNV.Controls.Add(this.btnThuMuc);
            this.grThongTinNV.Controls.Add(this.pictureAVT);
            this.grThongTinNV.ForeColor = System.Drawing.Color.Gainsboro;
            this.grThongTinNV.Location = new System.Drawing.Point(12, 44);
            this.grThongTinNV.Name = "grThongTinNV";
            this.grThongTinNV.Size = new System.Drawing.Size(709, 195);
            this.grThongTinNV.TabIndex = 1;
            this.grThongTinNV.TabStop = false;
            this.grThongTinNV.Text = "Thông tin Nhân Viên";
            // 
            // cboLuong
            // 
            this.cboLuong.FormattingEnabled = true;
            this.cboLuong.Location = new System.Drawing.Point(485, 63);
            this.cboLuong.Name = "cboLuong";
            this.cboLuong.Size = new System.Drawing.Size(180, 23);
            this.cboLuong.TabIndex = 16;
            // 
            // cboCV
            // 
            this.cboCV.FormattingEnabled = true;
            this.cboCV.Location = new System.Drawing.Point(485, 144);
            this.cboCV.Name = "cboCV";
            this.cboCV.Size = new System.Drawing.Size(180, 23);
            this.cboCV.TabIndex = 15;
            // 
            // dateTimeNgaySinh
            // 
            this.dateTimeNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNgaySinh.Location = new System.Drawing.Point(245, 100);
            this.dateTimeNgaySinh.Name = "dateTimeNgaySinh";
            this.dateTimeNgaySinh.Size = new System.Drawing.Size(180, 23);
            this.dateTimeNgaySinh.TabIndex = 14;
            // 
            // cboPhongBan
            // 
            this.cboPhongBan.FormattingEnabled = true;
            this.cboPhongBan.Location = new System.Drawing.Point(485, 105);
            this.cboPhongBan.Name = "cboPhongBan";
            this.cboPhongBan.Size = new System.Drawing.Size(180, 23);
            this.cboPhongBan.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(133, 157);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(485, 20);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(180, 23);
            this.txtCMND.TabIndex = 6;
            this.txtCMND.Text = "Số CMND";
            this.txtCMND.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNu);
            this.panel1.Controls.Add(this.btnNam);
            this.panel1.Location = new System.Drawing.Point(245, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 44);
            this.panel1.TabIndex = 5;
            // 
            // btnNu
            // 
            this.btnNu.AutoSize = true;
            this.btnNu.Location = new System.Drawing.Point(128, 12);
            this.btnNu.Name = "btnNu";
            this.btnNu.Size = new System.Drawing.Size(41, 19);
            this.btnNu.TabIndex = 1;
            this.btnNu.TabStop = true;
            this.btnNu.Text = "Nữ";
            this.btnNu.UseVisualStyleBackColor = true;
            // 
            // btnNam
            // 
            this.btnNam.AutoSize = true;
            this.btnNam.Location = new System.Drawing.Point(10, 12);
            this.btnNam.Name = "btnNam";
            this.btnNam.Size = new System.Drawing.Size(51, 19);
            this.btnNam.TabIndex = 0;
            this.btnNam.TabStop = true;
            this.btnNam.Text = "Nam";
            this.btnNam.UseVisualStyleBackColor = true;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(245, 63);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(180, 23);
            this.txtTenNV.TabIndex = 3;
            this.txtTenNV.Text = "Tên Nhân viên";
            this.txtTenNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(245, 20);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(180, 23);
            this.txtMaNV.TabIndex = 2;
            this.txtMaNV.Text = "Mã Nhân viên: nv001";
            this.txtMaNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnThuMuc
            // 
            this.btnThuMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnThuMuc.FlatAppearance.BorderSize = 0;
            this.btnThuMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThuMuc.Location = new System.Drawing.Point(26, 157);
            this.btnThuMuc.Name = "btnThuMuc";
            this.btnThuMuc.Size = new System.Drawing.Size(80, 30);
            this.btnThuMuc.TabIndex = 1;
            this.btnThuMuc.Text = "Thư mục";
            this.btnThuMuc.UseVisualStyleBackColor = false;
            this.btnThuMuc.Click += new System.EventHandler(this.btnThuMuc_Click);
            // 
            // pictureAVT
            // 
            this.pictureAVT.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureAVT.Location = new System.Drawing.Point(71, 22);
            this.pictureAVT.Name = "pictureAVT";
            this.pictureAVT.Size = new System.Drawing.Size(100, 120);
            this.pictureAVT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAVT.TabIndex = 0;
            this.pictureAVT.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(12, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 163);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Liên Lạc";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(21, 99);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(233, 23);
            this.txtDiaChi.TabIndex = 11;
            this.txtDiaChi.Text = "Địa chỉ";
            this.txtDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(21, 22);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(233, 23);
            this.txtSDT.TabIndex = 9;
            this.txtSDT.Text = "SDT";
            this.txtSDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(21, 62);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(233, 23);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.Text = "Email";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThem.Location = new System.Drawing.Point(88, 430);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 30);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHuy.Location = new System.Drawing.Point(621, 430);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 30);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(696, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSua.Location = new System.Drawing.Point(219, 430);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 30);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnXoa.Location = new System.Drawing.Point(352, 430);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 30);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvnv);
            this.panel2.Location = new System.Drawing.Point(292, 269);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 156);
            this.panel2.TabIndex = 13;
            // 
            // dtgvnv
            // 
            this.dtgvnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvnv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvnv.Location = new System.Drawing.Point(0, 0);
            this.dtgvnv.Name = "dtgvnv";
            this.dtgvnv.RowTemplate.Height = 25;
            this.dtgvnv.Size = new System.Drawing.Size(429, 156);
            this.dtgvnv.TabIndex = 0;
            this.dtgvnv.Click += new System.EventHandler(this.dtgvnv_Click);
            // 
            // frmThemNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grThongTinNV);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThemNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThemNV";
            this.Load += new System.EventHandler(this.frmThemNV_Load);
            this.grThongTinNV.ResumeLayout(false);
            this.grThongTinNV.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAVT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvnv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grThongTinNV;
        private System.Windows.Forms.Button btnThuMuc;
        private System.Windows.Forms.PictureBox pictureAVT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton btnNu;
        private System.Windows.Forms.RadioButton btnNam;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvnv;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboPhongBan;
        private System.Windows.Forms.DateTimePicker dateTimeNgaySinh;
        private System.Windows.Forms.ComboBox cboCV;
        private System.Windows.Forms.ComboBox cboLuong;
    }
}