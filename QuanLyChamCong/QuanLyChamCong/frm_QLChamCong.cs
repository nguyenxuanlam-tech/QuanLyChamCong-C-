using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyChamCong.BUS;

namespace QuanLyChamCong
{
    public partial class frm_QLChamCong : Form
    {
        BUS_ChamCong busCC;
        public frm_QLChamCong()
        {
            InitializeComponent();
            busCC = new BUS_ChamCong();
           
        }

        private void frm_QLChamCong_Load(object sender, EventArgs e)
        {
            cboPB.DataSource = busCC.LoadPB();
            cboPB.DisplayMember = "TenPhongBan";
            cboPB.ValueMember = "MaPhongBan";
            cboNam.Text = DateTime.Now.Year.ToString();
            cboThang.Text = DateTime.Now.Month.ToString();
            cboNgay.Text = DateTime.Now.Day.ToString();
            cboPB.SelectedIndex = 0;
            txtGioTangCa.Text = "0";
            txtGioTre.Text = "0";
            xem();

        }

        void xem()
        {
            dataGridView1_MouseClick(null, null);
            try
            {
                dataChamCong.DataSource = busCC.LoadNV(cboPB.SelectedValue.ToString(), int.Parse(cboThang.Text), int.Parse(cboNam.Text));
            }
            catch { }
        }

        private void cbo_PhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboPB.SelectedValue == null || cboThang.Text==""||cboNam.Text=="" )
                    return;
                dataChamCong.DataSource = busCC.LoadNV(cboPB.SelectedValue.ToString(), int.Parse(cboThang.Text), int.Parse(cboNam.Text));
                cboNV.DataSource = busCC.LoadNV_PB(cboPB.SelectedValue.ToString());
                cboNV.DisplayMember = "HoTen";
                cboNV.ValueMember = "MaNhanVien";
            }
            catch 
            { 
                MessageBox.Show("Lỗi:");
            }
        }



        private void cbo_Thang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataChamCong.DataSource = busCC.LoadNV(cboPB.SelectedValue.ToString(), int.Parse(cboThang.Text), int.Parse(cboNam.Text));
            }
            catch { }
        }

        private void cbo_Nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataChamCong.DataSource = busCC.LoadNV(cboPB.SelectedValue.ToString(), int.Parse(cboThang.Text), int.Parse(cboNam.Text));
            }
            catch { }
        }


        private void toolStripThoat_Click(object sender, EventArgs e)
        {
            DialogResult dl = new DialogResult();
            dl = MessageBox.Show("Bạn có chắc muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
                this.Close();
        }

                
        int chon = 0;
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataChamCong.RowCount == 0)
                return;
            chon = 1;
            string Manv = dataChamCong.CurrentRow.Cells["MaNhanVien"].Value.ToString();
            int Thang = int.Parse(dataChamCong.CurrentRow.Cells["Thang"].Value.ToString());
            int Nam = int.Parse(dataChamCong.CurrentRow.Cells["Nam"].Value.ToString());
            cboNam.Text = dataChamCong.CurrentRow.Cells["Nam"].Value.ToString();
            cboThang.Text = dataChamCong.CurrentRow.Cells["Thang"].Value.ToString();
            cboNV.SelectedValue = Manv;
            dataChitiet.DataSource = busCC.LoadCTCC(busCC.GetMaPhieu(Manv, Nam, Thang).ToString());
        }

        private void dgvChitiet_MouseClick(object sender, MouseEventArgs e)
        {
            chon = 2;
            if (dataChitiet.RowCount > 0)
            {
                txtGioTre.Text = dataChitiet.CurrentRow.Cells["GioTre"].Value.ToString();
                txtGioTangCa.Text = txtGioTangCa.Text = dataChitiet.CurrentRow.Cells["GioTangCa"].Value.ToString();
                cboNgay.Text = dataChitiet.CurrentRow.Cells["Ngay"].Value.ToString();
                checkin.Checked = (bool)dataChitiet.CurrentRow.Cells["NgayCong"].FormattedValue;
            }
        }

        //private void toolStripSua_Click(object sender, EventArgs e)
        //{
        //    if (cboNV.SelectedValue.ToString() != string.Empty || cboNam.Text != string.Empty || cboThang.Text != string.Empty || cboNgay.Text != string.Empty
        //       || txtGioTangCa.Text != string.Empty || txtGioTre.Text != string.Empty || checkin.Checked == false)
        //    {
        //        if (busCC.Sua(cboNV.SelectedValue.ToString(), int.Parse(cboNam.Text), int.Parse(cboThang.Text), int.Parse(cboNgay.Text), int.Parse(txtGioTangCa.Text), int.Parse(txtGioTre.Text), checkin.Checked))
        //            MessageBox.Show("Sửa thành công");
        //        else
        //            MessageBox.Show("Sửa thất bại");
        //    }
        //    else
        //        MessageBox.Show("Thiếu thông tin");
        //    xem();
        //}

        private void txtGioTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGioTre_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && int.Parse(txtGioTre.Text.ToString()) <= 12)
            {
                e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtGioTangCa.Text = "0";
            txtGioTre.Text = "0";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (chon == 2)
            {
                if (MessageBox.Show("Bạn muốn xóa chi tiết này", "Xóa chi tiết", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    if (busCC.ooDeleteChiTietCC(busCC.GetMaPhieu(cboNV.SelectedValue.ToString(), int.Parse(cboNam.Text), int.Parse(cboThang.Text)), int.Parse(cboNgay.Text)) > 0)
                        MessageBox.Show("Xóa thành công");
            }
            else
            {
                if (MessageBox.Show("Bạn muốn xóa phiếu chấm công", "Phiếu chấm công", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    if (busCC.ooDelCC(busCC.GetMaPhieu(cboNV.SelectedValue.ToString(), int.Parse(cboNam.Text), int.Parse(cboThang.Text))) == 0)
                        MessageBox.Show("Xóa thành công");
            }
            xem();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cboNV.SelectedValue.ToString() != string.Empty || cboNam.Text != string.Empty || cboThang.Text != string.Empty || cboNgay.Text != string.Empty
               || txtGioTangCa.Text != string.Empty || txtGioTre.Text != string.Empty || checkin.Checked == false)
            {
                if (busCC.Sua(cboNV.SelectedValue.ToString(), int.Parse(cboNam.Text), int.Parse(cboThang.Text), int.Parse(cboNgay.Text), int.Parse(txtGioTangCa.Text), int.Parse(txtGioTre.Text), checkin.Checked))
                    MessageBox.Show("Sửa thành công");
                else
                    MessageBox.Show("Sửa thất bại");
            }
            else
                MessageBox.Show("Thiếu thông tin");
            xem();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DataTable sdt = busCC.LoadCTCC(busCC.GetMaPhieu(cboNV.SelectedValue.ToString(), int.Parse(cboNam.Text), int.Parse(cboThang.Text)).ToString());
            foreach (DataRow row in sdt.Rows)
            {
                if (row["Ngay"].ToString() == cboNgay.Text)
                {
                    MessageBox.Show("Đã chấm công ngày này rồi!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (cboNV.SelectedValue.ToString() != string.Empty || cboNam.Text != string.Empty || cboThang.Text != string.Empty || cboNgay.Text != string.Empty
                || txtGioTangCa.Text != string.Empty || txtGioTre.Text != string.Empty || checkin.Checked == false)
            {
                if (busCC.Luu(cboNV.SelectedValue.ToString(), int.Parse(cboNam.Text), int.Parse(cboThang.Text), int.Parse(cboNgay.Text), int.Parse(txtGioTangCa.Text), int.Parse(txtGioTre.Text), checkin.Checked))
                    MessageBox.Show("Lưu thành công");
                else
                    MessageBox.Show("Lưu thất bại");
            }
            else
                MessageBox.Show("Thiếu thông tin");
            xem();
        }
    }      
    }

