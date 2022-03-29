
namespace GUI
{
    partial class frmChamCong
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grLichSuChamCong = new System.Windows.Forms.GroupBox();
            this.dataLichSuChamCong = new System.Windows.Forms.DataGridView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grDanhSachNV = new System.Windows.Forms.GroupBox();
            this.dataDanhSanhNV = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.grLichSuChamCong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLichSuChamCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grDanhSachNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDanhSanhNV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(323, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chấm Công";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grLichSuChamCong);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 180);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết chấm công";
            // 
            // grLichSuChamCong
            // 
            this.grLichSuChamCong.Controls.Add(this.dataLichSuChamCong);
            this.grLichSuChamCong.ForeColor = System.Drawing.Color.Gainsboro;
            this.grLichSuChamCong.Location = new System.Drawing.Point(413, 22);
            this.grLichSuChamCong.Name = "grLichSuChamCong";
            this.grLichSuChamCong.Size = new System.Drawing.Size(276, 139);
            this.grLichSuChamCong.TabIndex = 5;
            this.grLichSuChamCong.TabStop = false;
            this.grLichSuChamCong.Text = "Lịch sử Chấm công";
            // 
            // dataLichSuChamCong
            // 
            this.dataLichSuChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLichSuChamCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLichSuChamCong.Location = new System.Drawing.Point(3, 19);
            this.dataLichSuChamCong.Name = "dataLichSuChamCong";
            this.dataLichSuChamCong.RowTemplate.Height = 25;
            this.dataLichSuChamCong.Size = new System.Drawing.Size(270, 117);
            this.dataLichSuChamCong.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(193, 138);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(180, 23);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "Chức danh";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(193, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(180, 23);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Tên Nhân viên";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(193, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 23);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Họ Nhân viên";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(193, 22);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(180, 23);
            this.txtMaNV.TabIndex = 1;
            this.txtMaNV.Text = "Mã Nhân viên: nv001";
            this.txtMaNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 115);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grDanhSachNV
            // 
            this.grDanhSachNV.Controls.Add(this.dataDanhSanhNV);
            this.grDanhSachNV.ForeColor = System.Drawing.Color.Gainsboro;
            this.grDanhSachNV.Location = new System.Drawing.Point(12, 255);
            this.grDanhSachNV.Name = "grDanhSachNV";
            this.grDanhSachNV.Size = new System.Drawing.Size(709, 210);
            this.grDanhSachNV.TabIndex = 2;
            this.grDanhSachNV.TabStop = false;
            this.grDanhSachNV.Text = "Danh sách Nhân viên";
            // 
            // dataDanhSanhNV
            // 
            this.dataDanhSanhNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDanhSanhNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataDanhSanhNV.Location = new System.Drawing.Point(3, 19);
            this.dataDanhSanhNV.Name = "dataDanhSanhNV";
            this.dataDanhSanhNV.RowTemplate.Height = 25;
            this.dataDanhSanhNV.Size = new System.Drawing.Size(703, 188);
            this.dataDanhSanhNV.TabIndex = 0;
            // 
            // frmChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.grDanhSachNV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChamCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChamCong";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grLichSuChamCong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLichSuChamCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grDanhSachNV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDanhSanhNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grLichSuChamCong;
        private System.Windows.Forms.DataGridView dataLichSuChamCong;
        private System.Windows.Forms.GroupBox grDanhSachNV;
        private System.Windows.Forms.DataGridView dataDanhSanhNV;
    }
}