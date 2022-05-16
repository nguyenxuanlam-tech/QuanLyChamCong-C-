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
    public partial class frm_GioiThieu : Form
    {
        public frm_GioiThieu()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbContent.Location = new Point(lbContent.Location.X, lbContent.Location.Y - 1);
            if (lbContent.Location.Y + lbContent.Height < 0)
            {
                lbContent.Location = new Point(lbContent.Location.X, panelAbout.Height);
            }
        }

        private void frm_GioiThieu_Load(object sender, EventArgs e)
        {
            lbContent.ForeColor = Color.Gainsboro;
            lbContent.Text = "Báo cáo thực tập: Phần mềm quản lý Chấm công\nNgười thực hiện: Nguyễn Xuân Lâm\nLớp: 18DTH1C";
            timer1.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
