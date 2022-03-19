using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using GUI.XemLich;

namespace GUI
{
    public partial class frmMain : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public frmMain()
        {
            InitializeComponent();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnNav.Height = btnHeThong.Height;
            pnNav.Top = btnHeThong.Top;
            pnNav.Left = btnHeThong.Left;
            btnHeThong.BackColor = Color.FromArgb(46, 51, 73);

            lbTitle.Text = "Hệ thống";
            this.pnFormLoad.Controls.Clear();
            frmHeThong loadHeThong = new frmHeThong() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadHeThong.FormBorderStyle = FormBorderStyle.None;
            this.pnFormLoad.Controls.Add(loadHeThong);
            loadHeThong.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            pnNav.Height = btnHeThong.Height;
            pnNav.Top = btnHeThong.Top;
            pnNav.Left = btnHeThong.Left;
            btnHeThong.BackColor = Color.FromArgb(46, 51, 73);

            lbTitle.Text = "Hệ thống";
            this.pnFormLoad.Controls.Clear();
            frmHeThong loadHeThong = new frmHeThong() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadHeThong.FormBorderStyle = FormBorderStyle.None;
            this.pnFormLoad.Controls.Add(loadHeThong);
            loadHeThong.Show();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            pnNav.Height = btnTaiKhoan.Height;
            pnNav.Top = btnTaiKhoan.Top;
            btnTaiKhoan.BackColor = Color.FromArgb(46, 51, 73);

            lbTitle.Text = "Tài khoản";
            this.pnFormLoad.Controls.Clear();
            frmThongKe loadThongKe = new frmThongKe() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadThongKe.FormBorderStyle = FormBorderStyle.None;
            this.pnFormLoad.Controls.Add(loadThongKe);
            loadThongKe.Show();
        }

        //private void btnCalender_Click(object sender, EventArgs e)
        //{
        //    pnNav.Height = btnCalender.Height;
        //    pnNav.Top = btnCalender.Top;
        //    btnCalender.BackColor = Color.FromArgb(46, 51, 73);

        //    lbTitle.Text = "Calender";
        //    //this.pnFormLoad.Controls.Clear();
        //    //frm loadDashboard = new frDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        //    //loadDashboard.FormBorderStyle = FormBorderStyle.None;
        //    //this.pnFromLoad.Controls.Add(loadDashboard);
        //    //loadDashboard.Show();
        //}

        private void btnLienHe_Click(object sender, EventArgs e)
        {
            pnNav.Height = btnLienHe.Height;
            pnNav.Top = btnLienHe.Top;
            btnLienHe.BackColor = Color.FromArgb(46, 51, 73);

            lbTitle.Text = "Lien he";
            this.pnFormLoad.Controls.Clear();
            frmLienHe loadLienHe = new frmLienHe() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadLienHe.FormBorderStyle = FormBorderStyle.None;
            this.pnFormLoad.Controls.Add(loadLienHe);
            loadLienHe.Show();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            pnNav.Height = btnChamCong.Height;
            pnNav.Top = btnChamCong.Top;
            btnChamCong.BackColor = Color.FromArgb(46, 51, 73);

            lbTitle.Text = "Chấm công";
            this.pnFormLoad.Controls.Clear();
            frmChamCong loadChamCong = new frmChamCong() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadChamCong.FormBorderStyle = FormBorderStyle.None;
            this.pnFormLoad.Controls.Add(loadChamCong);
            loadChamCong.Show();
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            pnNav.Height = btnLogout.Height;
            pnNav.Top = btnLogout.Top;
            btnLogout.BackColor = Color.FromArgb(46, 51, 73);

            lbTitle.Text = "Cai dat";
            this.pnFormLoad.Controls.Clear();
            //frmDangNhap loadLogOut = new frmDangNhap() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //loadLogOut.FormBorderStyle = FormBorderStyle.None;
            //this.pnFormLoad.Controls.Add(loadLogOut);
            //loadLogOut.Show();

            frmXemLich loadXemLich = new frmXemLich() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadXemLich.FormBorderStyle = FormBorderStyle.None;
            this.pnFormLoad.Controls.Add(loadXemLich);
            loadXemLich.Show();
        }

        private void btnHeThong_Leave(object sender, EventArgs e)
        {
            btnHeThong.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnTaiKhoan_Leave(object sender, EventArgs e)
        {
            btnTaiKhoan.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnLienHe_Leave(object sender, EventArgs e)
        {
            btnLienHe.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCaiDat_Leave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
