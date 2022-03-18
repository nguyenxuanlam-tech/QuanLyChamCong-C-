
namespace GUI
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnLeft = new System.Windows.Forms.Panel();
            this.pnNav = new System.Windows.Forms.Panel();
            this.btnCaiDat = new System.Windows.Forms.Button();
            this.btnLienHe = new System.Windows.Forms.Button();
            this.btnCalender = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnHeThong = new System.Windows.Forms.Button();
            this.pnProfile = new System.Windows.Forms.Panel();
            this.lbJob = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.ptAvatar = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnFormLoad = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnLeft.SuspendLayout();
            this.pnProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnLeft.Controls.Add(this.pnNav);
            this.pnLeft.Controls.Add(this.btnCaiDat);
            this.pnLeft.Controls.Add(this.btnLienHe);
            this.pnLeft.Controls.Add(this.btnCalender);
            this.pnLeft.Controls.Add(this.btnThongKe);
            this.pnLeft.Controls.Add(this.btnHeThong);
            this.pnLeft.Controls.Add(this.pnProfile);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(186, 577);
            this.pnLeft.TabIndex = 0;
            // 
            // pnNav
            // 
            this.pnNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnNav.Location = new System.Drawing.Point(0, 193);
            this.pnNav.Name = "pnNav";
            this.pnNav.Size = new System.Drawing.Size(3, 100);
            this.pnNav.TabIndex = 6;
            // 
            // btnCaiDat
            // 
            this.btnCaiDat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCaiDat.FlatAppearance.BorderSize = 0;
            this.btnCaiDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaiDat.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCaiDat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCaiDat.Image = global::GUI.Properties.Resources.setting;
            this.btnCaiDat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCaiDat.Location = new System.Drawing.Point(0, 517);
            this.btnCaiDat.Name = "btnCaiDat";
            this.btnCaiDat.Size = new System.Drawing.Size(186, 60);
            this.btnCaiDat.TabIndex = 5;
            this.btnCaiDat.Text = "Cài đặt";
            this.btnCaiDat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCaiDat.UseVisualStyleBackColor = true;
            this.btnCaiDat.Click += new System.EventHandler(this.btnCaiDat_Click);
            this.btnCaiDat.Leave += new System.EventHandler(this.btnCaiDat_Leave);
            // 
            // btnLienHe
            // 
            this.btnLienHe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLienHe.FlatAppearance.BorderSize = 0;
            this.btnLienHe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLienHe.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLienHe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnLienHe.Image = global::GUI.Properties.Resources.contacts;
            this.btnLienHe.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLienHe.Location = new System.Drawing.Point(0, 324);
            this.btnLienHe.Name = "btnLienHe";
            this.btnLienHe.Size = new System.Drawing.Size(186, 60);
            this.btnLienHe.TabIndex = 4;
            this.btnLienHe.Text = "Liên hệ";
            this.btnLienHe.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLienHe.UseVisualStyleBackColor = true;
            this.btnLienHe.Click += new System.EventHandler(this.btnLienHe_Click);
            this.btnLienHe.Leave += new System.EventHandler(this.btnLienHe_Leave);
            // 
            // btnCalender
            // 
            this.btnCalender.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalender.FlatAppearance.BorderSize = 0;
            this.btnCalender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalender.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCalender.Image = global::GUI.Properties.Resources.ca;
            this.btnCalender.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalender.Location = new System.Drawing.Point(0, 264);
            this.btnCalender.Name = "btnCalender";
            this.btnCalender.Size = new System.Drawing.Size(186, 60);
            this.btnCalender.TabIndex = 3;
            this.btnCalender.Text = "Calender";
            this.btnCalender.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCalender.UseVisualStyleBackColor = true;
            this.btnCalender.Click += new System.EventHandler(this.btnCalender_Click);
            this.btnCalender.Leave += new System.EventHandler(this.btnCalender_Leave);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnThongKe.Image = global::GUI.Properties.Resources.Analytics;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongKe.Location = new System.Drawing.Point(0, 204);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(186, 60);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            this.btnThongKe.Leave += new System.EventHandler(this.btnThongKe_Leave);
            // 
            // btnHeThong
            // 
            this.btnHeThong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHeThong.FlatAppearance.BorderSize = 0;
            this.btnHeThong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeThong.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHeThong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnHeThong.Image = global::GUI.Properties.Resources.home;
            this.btnHeThong.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHeThong.Location = new System.Drawing.Point(0, 144);
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.Size = new System.Drawing.Size(186, 60);
            this.btnHeThong.TabIndex = 1;
            this.btnHeThong.Text = "Hệ thống";
            this.btnHeThong.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHeThong.UseVisualStyleBackColor = true;
            this.btnHeThong.Click += new System.EventHandler(this.btnHeThong_Click);
            this.btnHeThong.Leave += new System.EventHandler(this.btnHeThong_Leave);
            // 
            // pnProfile
            // 
            this.pnProfile.Controls.Add(this.lbJob);
            this.pnProfile.Controls.Add(this.lbName);
            this.pnProfile.Controls.Add(this.ptAvatar);
            this.pnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnProfile.Location = new System.Drawing.Point(0, 0);
            this.pnProfile.Name = "pnProfile";
            this.pnProfile.Size = new System.Drawing.Size(186, 144);
            this.pnProfile.TabIndex = 0;
            // 
            // lbJob
            // 
            this.lbJob.AutoSize = true;
            this.lbJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.lbJob.Location = new System.Drawing.Point(37, 115);
            this.lbJob.Name = "lbJob";
            this.lbJob.Size = new System.Drawing.Size(101, 12);
            this.lbJob.TabIndex = 2;
            this.lbJob.Text = "Fontend Deverloop";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(159)))));
            this.lbName.Location = new System.Drawing.Point(49, 99);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(74, 16);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Xuan Lam";
            // 
            // ptAvatar
            // 
            this.ptAvatar.Image = global::GUI.Properties.Resources.face;
            this.ptAvatar.Location = new System.Drawing.Point(60, 22);
            this.ptAvatar.Name = "ptAvatar";
            this.ptAvatar.Size = new System.Drawing.Size(63, 63);
            this.ptAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptAvatar.TabIndex = 0;
            this.ptAvatar.TabStop = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.lbTitle.Location = new System.Drawing.Point(216, 22);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(137, 32);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Hệ thống";
            // 
            // pnFormLoad
            // 
            this.pnFormLoad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnFormLoad.Location = new System.Drawing.Point(186, 100);
            this.pnFormLoad.Name = "pnFormLoad";
            this.pnFormLoad.Size = new System.Drawing.Size(765, 477);
            this.pnFormLoad.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSearch.Location = new System.Drawing.Point(552, 24);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(292, 30);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.Text = "Search for some thing...";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(890, 27);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pnFormLoad);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pnLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnLeft.ResumeLayout(false);
            this.pnProfile.ResumeLayout(false);
            this.pnProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnProfile;
        private System.Windows.Forms.PictureBox ptAvatar;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbJob;
        private System.Windows.Forms.Button btnHeThong;
        private System.Windows.Forms.Button btnCaiDat;
        private System.Windows.Forms.Button btnLienHe;
        private System.Windows.Forms.Button btnCalender;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Panel pnNav;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnFormLoad;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnClose;
    }
}

