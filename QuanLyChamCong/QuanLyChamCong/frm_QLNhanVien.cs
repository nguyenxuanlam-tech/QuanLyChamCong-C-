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
using QuanLyChamCong.DTO;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace QuanLyChamCong
{
    public partial class frm_QLNhanVien : Form
    {
        BUS_QLNhanVien bus_qlnv = new BUS_QLNhanVien();
        BUS_ChamCong busCC = new BUS_ChamCong();
        public static DataSet QuanLyChamCong = new DataSet();
        public static string strConnect = Program.ConnectionString;
        public SqlConnection cnn;
        public frm_QLNhanVien()
        {
            InitializeComponent();
        }
        public void Load_data()
        {
            cboPB.DataSource = bus_qlnv.Load_PhongBan();
            cboPB.DisplayMember = "TenPhongBan";
            cboPB.ValueMember = "MaPhongBan";

            cboCV.DataSource = bus_qlnv.Load_ChucVu();
            cboCV.DisplayMember = "TenChucVu";
            cboCV.ValueMember = "MaChucVu";

            dataGVNV.DataSource = bus_qlnv.Load_NhanVien();
        }

        public void Load_Enable(bool value)
        {
            cboPB.Enabled = value;
            cboCV.Enabled = value;
            cboGioiTinh.Enabled = value;
            txtMaNV.Enabled = value;
            txtTenNV.Enabled = value;
            txtDiaChi.Enabled = value;
            txtCMND.Enabled = value;
            txtSDT.Enabled = value;
            txtHeSo.Enabled = value;
            dateNgayVaoLam.Enabled = value;
            dateSinhNhat.Enabled = value;
        }

        private void frm_QLNhanVien_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            Load_data();
            Load_Enable(false);
        }

        private void dataGVNV_SelectionChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            if (dataGVNV.CurrentRow != null)
            {
                txtMaNV.Text = dataGVNV.CurrentRow.Cells[0].Value.ToString();
                txtTenNV.Text = dataGVNV.CurrentRow.Cells[1].Value.ToString();
                dateSinhNhat.Text = dataGVNV.CurrentRow.Cells[2].Value.ToString();
                txtDiaChi.Text = dataGVNV.CurrentRow.Cells[3].Value.ToString();
                cboGioiTinh.Text = dataGVNV.CurrentRow.Cells[4].Value.ToString();
                txtCMND.Text = dataGVNV.CurrentRow.Cells[5].Value.ToString();
                txtSDT.Text = dataGVNV.CurrentRow.Cells[6].Value.ToString();
                dateNgayVaoLam.Text = dataGVNV.CurrentRow.Cells[7].Value.ToString();
                cboPB.Text = dataGVNV.CurrentRow.Cells[8].Value.ToString();
                cboCV.Text = dataGVNV.CurrentRow.Cells[9].Value.ToString();
                txtHeSo.Text = dataGVNV.CurrentRow.Cells[10].Value.ToString();
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
           // TangMaTuDong();
           // txt_MaNV.Enabled = false;
            Load_data();
            Load_Enable(true);
            txtMaNV.Text = txtTenNV.Text = txtDiaChi.Text = txtCMND.Text = txtSDT.Text =txtHeSo.Text = "";
            cboGioiTinh.Text =string.Empty;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;


            for (int i = 0; i < dataGVNV.Rows.Count - 1; i++)
            {
                dataGVNV.Rows[i].ReadOnly = true;
            }
            dataGVNV.FirstDisplayedScrollingRowIndex = dataGVNV.Rows.Count - 1;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                QL_NhanVien nv = new QL_NhanVien();
                nv.MaNhanVien = txtMaNV.Text;
                nv.HoTen = txtTenNV.Text;
                nv.NgaySinh = dateSinhNhat.Text;
                nv.DiaChi = txtDiaChi.Text;
                nv.GioiTinh = cboGioiTinh.Text;
                nv.CMND = txtCMND.Text;
                nv.DienThoai = txtSDT.Text;
                nv.NgayVaoLam = dateNgayVaoLam.Text;
                nv.MaPhongBan = cboPB.Text;
                nv.MaChucVu = cboCV.Text;
                nv.HeSoLuong = txtHeSo.Text;

                if (bus_qlnv.Xoa_NhanVien(nv) == 1)
                {
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Nhân viên đang chấm công!");
                }
            }

            else
            {
                MessageBox.Show("Thất bại");
            }
            Load_data();
              
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Load_Enable(true);
            txtMaNV.Enabled = false;
            txtTenNV.Focus();
            btnLuu.Enabled = true;
            dataGVNV.AllowUserToAddRows = false;
            dataGVNV.ReadOnly = false;

            for (int i = 0; i < dataGVNV.Rows.Count - 1; i++)
            {
                dataGVNV.Rows[i].ReadOnly = false;
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Trim() == string.Empty || txtTenNV.Text.Trim() == string.Empty || txtCMND.Text.Trim() == string.Empty || dateSinhNhat.Text.Trim() == string.Empty || txtHeSo.Text.Trim() == string.Empty || dateNgayVaoLam.Text.Trim() == string.Empty || cboCV.Text.Trim() == string.Empty || cboGioiTinh.Text.Trim() == string.Empty || cboPB.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Bạn nhập thiếu dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCMND.Text.Length !=9 )
            {
                MessageBox.Show("Số CMND không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCMND.Focus();
                return;
            }
            if (txtSDT.Text.Length !=10 && txtSDT.Text.Length !=11)
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }
          
            QL_NhanVien pNhanVien = new QL_NhanVien();
            pNhanVien.MaNhanVien = txtMaNV.Text;
            pNhanVien.HoTen = txtTenNV.Text;
            pNhanVien.NgaySinh = dateSinhNhat.Text;
            pNhanVien.DiaChi = txtDiaChi.Text;
            pNhanVien.GioiTinh = cboGioiTinh.Text;
            pNhanVien.CMND = txtCMND.Text;
            pNhanVien.DienThoai = txtSDT.Text;
            pNhanVien.NgayVaoLam = dateNgayVaoLam.Text;
            pNhanVien.MaPhongBan = cboPB.SelectedValue.ToString();
            pNhanVien.MaChucVu = cboCV.SelectedValue.ToString();
            pNhanVien.HeSoLuong = txtHeSo.Text;

            if (txtMaNV.Enabled == true)
            {
                if (bus_qlnv.KTtontai(txtMaNV.Text) == 0)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (bus_qlnv.Them_NhanVien(pNhanVien) == 1)
                {
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
            else
            {
                if (bus_qlnv.Sua_NhanVien(pNhanVien) == 1)
                {
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }

            Load_data();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                return;
            }
            else
            {
                this.Close();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(bus_qlnv.Load_NhanVien());
            string ten = txtSearch.Text;
            dv.RowFilter = "HoTen like '" + "%" + ten + "%'";
            dataGVNV.DataSource = dv;
        }

        private void txt_SoCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txt_DienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txt_HeSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txt_TimKiem_Leave(object sender, EventArgs e)
        {
            Load_data();
        }

        private void txt_TenNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 65 || e.KeyChar > 122)
            {
                e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
