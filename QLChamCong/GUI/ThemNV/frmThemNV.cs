using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmThemNV : Form
    {
        Image file;
        BLLNhanVien bllNhanVien = new BLLNhanVien();

        public frmThemNV()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "" && cboLuong.Text != "" && txtTenNV.Text != "" && txtCMND.Text != "" && txtSDT.Text != "")
            {
                //string GioiTinh;
                //if (btnNam.Checked == true) {
                //    GioiTinh = "Nam";
                //} else {
                //    GioiTinh = "Nữ";
                //}
                //int luong = Int32.Parse(cboLuong.Text.Trim());
                //// Tạo DTo
                //DTONhanVien nv = new DTONhanVien(txtMaNV.Text.Trim(),0,
                //     luong,txtTenNV.Text.Trim(),GioiTinh,dateTimeNgaySinh.Value,txtCMND.Text.Trim(),
                //     txtSDT.Text,txtDiaChi.Text.Trim(),txtEmail.Text.Trim(),
                //     ""); // Vì ID tự tăng nên để ID số gì cũng dc

                //// Them
                //if (bllNhanVien.themNhanVien(nv))
                //{
                //    MessageBox.Show("Thêm thành công");
                //    dtgvnv.DataSource = bllNhanVien.getNhanVien(); // refresh datagridview
                //}
                //else
                //{
                //    MessageBox.Show("Thêm ko thành công");
                //}
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void btnThuMuc_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG (*.JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                file = Image.FromFile(f.FileName);
                pictureAVT.Image = file;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "JPG (*.JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                file.Save(f.FileName);
            }
        }

        private void frmThemNV_Load(object sender, EventArgs e)
        {
            dtgvnv.DataSource = bllNhanVien.getNhanVien();
        }

        private void dtgvnv_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dtgvnv.SelectedRows[0];

            txtMaNV.Text = row.Cells[1].Value.ToString();
            //cboPhongBan
            //cboCV
            //cboLuong
            txtTenNV.Text = row.Cells[2].Value.ToString();
            //GioiTinh
            //dateTimeNgaySinh.Value = row.Cells[7].Value.ToString();
            txtCMND.Text = row.Cells[3].Value.ToString();
            txtSDT.Text = row.Cells[4].Value.ToString();
            txtDiaChi.Text = row.Cells[5].Value.ToString();
            txtEmail.Text = row.Cells[6].Value.ToString();
            //Hinh
        }
    }
}
