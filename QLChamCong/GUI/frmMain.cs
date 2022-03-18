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

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            pnNav.Height = btnThongKe.Height;
            pnNav.Top = btnThongKe.Top;
            btnThongKe.BackColor = Color.FromArgb(46, 51, 73);

            lbTitle.Text = "Thong ke";
            this.pnFormLoad.Controls.Clear();
            frmThongKe loadThongKe = new frmThongKe() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadThongKe.FormBorderStyle = FormBorderStyle.None;
            this.pnFormLoad.Controls.Add(loadThongKe);
            loadThongKe.Show();
        }

        private void btnCalender_Click(object sender, EventArgs e)
        {
            pnNav.Height = btnCalender.Height;
            pnNav.Top = btnCalender.Top;
            btnCalender.BackColor = Color.FromArgb(46, 51, 73);

            lbTitle.Text = "Calender";
            //this.pnFormLoad.Controls.Clear();
            //frm loadDashboard = new frDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //loadDashboard.FormBorderStyle = FormBorderStyle.None;
            //this.pnFromLoad.Controls.Add(loadDashboard);
            //loadDashboard.Show();
        }

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

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            pnNav.Height = btnCaiDat.Height;
            pnNav.Top = btnCaiDat.Top;
            btnCaiDat.BackColor = Color.FromArgb(46, 51, 73);

            lbTitle.Text = "Cai dat";
            this.pnFormLoad.Controls.Clear();
            frmCaiDat loadCaiDat = new frmCaiDat() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadCaiDat.FormBorderStyle = FormBorderStyle.None;
            this.pnFormLoad.Controls.Add(loadCaiDat);
            loadCaiDat.Show();
        }

        private void btnHeThong_Leave(object sender, EventArgs e)
        {
            btnHeThong.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnThongKe_Leave(object sender, EventArgs e)
        {
            btnThongKe.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCalender_Leave(object sender, EventArgs e)
        {
            btnCalender.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnLienHe_Leave(object sender, EventArgs e)
        {
            btnLienHe.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCaiDat_Leave(object sender, EventArgs e)
        {
            btnCaiDat.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
