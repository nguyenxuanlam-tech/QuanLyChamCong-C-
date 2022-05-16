using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChamCong
{
    public partial class frHeThong : Form
    {
        public frHeThong()
        {
            InitializeComponent();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frm_QLNhanVien nhanVien = new frm_QLNhanVien();
            nhanVien.Show();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            frm_QLChamCong chamCong = new frm_QLChamCong();
            chamCong.Show();
        }

        private void btnLuong_Click(object sender, EventArgs e)
        {
            frm_QLTinhLuong tinhLuong = new frm_QLTinhLuong();
            tinhLuong.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            frm_QLPhongBan phongBan = new frm_QLPhongBan();
            phongBan.Show();
        }
    }
}
