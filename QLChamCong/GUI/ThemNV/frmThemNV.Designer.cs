
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
            this.txtPB = new System.Windows.Forms.TextBox();
            this.txtCV = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtDanToc = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNu = new System.Windows.Forms.RadioButton();
            this.btnNam = new System.Windows.Forms.RadioButton();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtTeNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.btnThuMuc = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtNoiSinh = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.grThongTinNV.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.grThongTinNV.Controls.Add(this.txtPB);
            this.grThongTinNV.Controls.Add(this.txtCV);
            this.grThongTinNV.Controls.Add(this.textBox2);
            this.grThongTinNV.Controls.Add(this.txtDanToc);
            this.grThongTinNV.Controls.Add(this.panel1);
            this.grThongTinNV.Controls.Add(this.txtTenNV);
            this.grThongTinNV.Controls.Add(this.txtTeNV);
            this.grThongTinNV.Controls.Add(this.txtMaNV);
            this.grThongTinNV.Controls.Add(this.btnThuMuc);
            this.grThongTinNV.Controls.Add(this.pictureBox1);
            this.grThongTinNV.ForeColor = System.Drawing.Color.Gainsboro;
            this.grThongTinNV.Location = new System.Drawing.Point(12, 44);
            this.grThongTinNV.Name = "grThongTinNV";
            this.grThongTinNV.Size = new System.Drawing.Size(709, 195);
            this.grThongTinNV.TabIndex = 1;
            this.grThongTinNV.TabStop = false;
            this.grThongTinNV.Text = "Thông tin Nhân Viên";
            // 
            // txtPB
            // 
            this.txtPB.Location = new System.Drawing.Point(433, 140);
            this.txtPB.Name = "txtPB";
            this.txtPB.Size = new System.Drawing.Size(180, 23);
            this.txtPB.TabIndex = 9;
            this.txtPB.Text = "Mã Phòng ban: pb001";
            this.txtPB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCV
            // 
            this.txtCV.Location = new System.Drawing.Point(433, 103);
            this.txtCV.Name = "txtCV";
            this.txtCV.Size = new System.Drawing.Size(180, 23);
            this.txtCV.TabIndex = 8;
            this.txtCV.Text = "Mã chức vụ: cv001";
            this.txtCV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(433, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 23);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Họ Nhân viên";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDanToc
            // 
            this.txtDanToc.Location = new System.Drawing.Point(433, 20);
            this.txtDanToc.Name = "txtDanToc";
            this.txtDanToc.Size = new System.Drawing.Size(180, 23);
            this.txtDanToc.TabIndex = 6;
            this.txtDanToc.Text = "Số CMND";
            this.txtDanToc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNu);
            this.panel1.Controls.Add(this.btnNam);
            this.panel1.Location = new System.Drawing.Point(193, 132);
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
            this.txtTenNV.Location = new System.Drawing.Point(193, 103);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(180, 23);
            this.txtTenNV.TabIndex = 4;
            this.txtTenNV.Text = "Tên Nhân viên";
            this.txtTenNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTeNV
            // 
            this.txtTeNV.Location = new System.Drawing.Point(193, 63);
            this.txtTeNV.Name = "txtTeNV";
            this.txtTeNV.Size = new System.Drawing.Size(180, 23);
            this.txtTeNV.TabIndex = 3;
            this.txtTeNV.Text = "Họ Nhân viên";
            this.txtTeNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(193, 20);
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
            this.btnThuMuc.Location = new System.Drawing.Point(33, 159);
            this.btnThuMuc.Name = "btnThuMuc";
            this.btnThuMuc.Size = new System.Drawing.Size(100, 30);
            this.btnThuMuc.TabIndex = 1;
            this.btnThuMuc.Text = "Thư mục";
            this.btnThuMuc.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(33, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 106);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtNoiSinh);
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(12, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 140);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Liên Lạc";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(21, 105);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(260, 23);
            this.txtDiaChi.TabIndex = 11;
            this.txtDiaChi.Text = "Địa chỉ";
            this.txtDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(21, 22);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(260, 23);
            this.txtSDT.TabIndex = 9;
            this.txtSDT.Text = "SDT";
            this.txtSDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.Location = new System.Drawing.Point(21, 65);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(260, 23);
            this.txtNoiSinh.TabIndex = 10;
            this.txtNoiSinh.Text = "Nơi sinh";
            this.txtNoiSinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Location = new System.Drawing.Point(417, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 140);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Liên Lạc";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLuu.Location = new System.Drawing.Point(430, 430);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 30);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu lại";
            this.btnLuu.UseVisualStyleBackColor = false;
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
            // 
            // frmThemNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grThongTinNV);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThemNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThemNV";
            this.grThongTinNV.ResumeLayout(false);
            this.grThongTinNV.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grThongTinNV;
        private System.Windows.Forms.Button btnThuMuc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton btnNu;
        private System.Windows.Forms.RadioButton btnNam;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtTeNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtCV;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtDanToc;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtNoiSinh;
        private System.Windows.Forms.TextBox txtPB;
    }
}