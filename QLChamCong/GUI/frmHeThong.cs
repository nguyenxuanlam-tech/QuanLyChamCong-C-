using GUI.XemLich;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmHeThong : Form
    {
        public frmHeThong()
        {
            InitializeComponent();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            frmThemNV themNV = new frmThemNV();
            themNV.Show();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            frmChamCong chamCong = new frmChamCong();
            chamCong.Show();
        }

        private void btnXemLich_Click(object sender, EventArgs e)
        {
            frmXemLich xemLich = new frmXemLich();
            xemLich.Show();
        }
    }
}
