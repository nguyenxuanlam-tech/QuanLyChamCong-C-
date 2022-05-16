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

namespace QuanLyChamCong
{
    public partial class frmMain : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
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
            panNavigate.Height = btnHeThong.Height;
            panNavigate.Top = btnHeThong.Top;
            panNavigate.Left = btnHeThong.Left;
            btnHeThong.BackColor = Color.FromArgb(46, 51, 73);

            lbTitle.Text = btnHeThong.Text;
            this.panelLoad.Controls.Clear();
            frHeThong heThong = new frHeThong() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            heThong.FormBorderStyle = FormBorderStyle.None;
            this.panelLoad.Controls.Add(heThong);
            heThong.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                return;
            }
            else
            {
                this.Hide();
                frm_DangNhap dangNhap = new frm_DangNhap();
                dangNhap.Show();
            }
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            panNavigate.Height = btnHeThong.Height;
            panNavigate.Top = btnHeThong.Top;
            panNavigate.Left = btnHeThong.Left;
            btnHeThong.BackColor = Color.FromArgb(46, 51, 73);

            lbTitle.Text = btnHeThong.Text;
            this.panelLoad.Controls.Clear();
            frHeThong heThong = new frHeThong() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            heThong.FormBorderStyle = FormBorderStyle.None;
            this.panelLoad.Controls.Add(heThong);
            heThong.Show();
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            panNavigate.Height = btnNV.Height;
            panNavigate.Top = btnNV.Top;
            panNavigate.Left = btnNV.Left;
            btnNV.BackColor = Color.FromArgb(46, 51, 73);

            lbTitle.Text = btnNV.Text;
            this.panelLoad.Controls.Clear();
            frm_QLNhanVien nhanVien = new frm_QLNhanVien() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            nhanVien.FormBorderStyle = FormBorderStyle.None;
            this.panelLoad.Controls.Add(nhanVien);
            nhanVien.Show();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            panNavigate.Height = btnCheckIn.Height;
            panNavigate.Top = btnCheckIn.Top;
            panNavigate.Left = btnCheckIn.Left;
            btnCheckIn.BackColor = Color.FromArgb(46, 51, 73);

            lbTitle.Text = btnCheckIn.Text;
            this.panelLoad.Controls.Clear();
            frm_QLChamCong chamCong = new frm_QLChamCong() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            chamCong.FormBorderStyle = FormBorderStyle.None;
            this.panelLoad.Controls.Add(chamCong);
            chamCong.Show();
        }

        private void btnGioiThieu_Click(object sender, EventArgs e)
        {
            panNavigate.Height = btnGioiThieu.Height;
            panNavigate.Top = btnGioiThieu.Top;
            panNavigate.Left = btnGioiThieu.Left;
            btnGioiThieu.BackColor = Color.FromArgb(46, 51, 73);

            lbTitle.Text = btnGioiThieu.Text;
            this.panelLoad.Controls.Clear();
            frm_GioiThieu gioiThieu = new frm_GioiThieu() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            gioiThieu.FormBorderStyle = FormBorderStyle.None;
            this.panelLoad.Controls.Add(gioiThieu);
            gioiThieu.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            panNavigate.Height = btnDangXuat.Height;
            panNavigate.Top = btnDangXuat.Top;
            panNavigate.Left = btnDangXuat.Left;
            btnDangXuat.BackColor = Color.FromArgb(46, 51, 73);

            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                return;
            }
            else
            {
                this.Hide();
                frm_DangNhap dangNhap = new frm_DangNhap();
                dangNhap.ShowDialog();
            }

            
        }

        private void btnHeThong_Leave(object sender, EventArgs e)
        {
            btnHeThong.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnNV_Leave(object sender, EventArgs e)
        {
            btnNV.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCheckIn_Leave(object sender, EventArgs e)
        {
            btnCheckIn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnGioiThieu_Leave(object sender, EventArgs e)
        {
            btnGioiThieu.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnDangXuat_Leave(object sender, EventArgs e)
        {
            btnDangXuat.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
