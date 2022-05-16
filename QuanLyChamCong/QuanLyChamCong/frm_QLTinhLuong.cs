using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyChamCong
{
    public partial class frm_QLTinhLuong : Form
    {
        DataView dv;
        SqlConnection cn = new SqlConnection(Program.ConnectionString);
        DataSet ds_QLLuong1 = new DataSet();
        BUS_Luong bus_luong;
        BUS_TinhLuong _bus;
        public void LoadLuong()
        {
            ds_QLLuong1 = new DataSet();
            SqlDataAdapter da_Khoa = new SqlDataAdapter("select * from QL_Luong", cn);
            da_Khoa.Fill(ds_QLLuong1, "QL_Luong");
            dgv_TinhLuong.DataSource = _bus.Load_Luong();

          
        }
        public frm_QLTinhLuong()
        {
            InitializeComponent();
            _bus = new BUS_TinhLuong();
            bus_luong = new BUS_Luong();
        }
        
   
       
        public void LoadData()
        {
            cboPhongBan.DataSource = _bus.Load_PhongBan();
            cboPhongBan.DisplayMember = "TenPhongBan";
            cboPhongBan.ValueMember = "MaPhongBan";


            dv = new DataView(_bus.Load_NhanVien());
            dgv_NhanVien.DataSource = dv;

          

        }
        public void LoadData2()
        {
            dgv_TinhLuong.DataSource = bus_luong.Load_NhanVien();
        }
        private void Enable_Clear(TableLayoutPanel tbl, bool en, bool clear = false)
        {
            foreach (Control c in tbl.Controls)
            {
                if (c is Label || c is DataGridView) continue;
                c.Enabled = en;
                if (clear)
                {
                    if (c is TextBox)
                        c.Text = string.Empty;
                    if (c is ComboBox)
                        ((ComboBox)c).SelectedIndex = 0;

                }
            }
        }

        private void frm_QLTinhLuong_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadLuong();
            LoadData2();
            dgv_TinhLuong.AutoGenerateColumns = false;
            dgv_NhanVien.AutoGenerateColumns = false;

            dgv_NhanVien.ReadOnly = true;

            dgv_NhanVien.AllowUserToAddRows = false;

            dgv_NhanVien.RowsDefaultCellStyle.BackColor = Color.White;
            dgv_NhanVien.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
        }

        

        private void dgv_NhanVien_SelectionChanged(object sender, MouseEventArgs e)
        {
            if (dgv_NhanVien.CurrentRow != null)
            {
                txtThanhTien.Clear();
                txt_MaPhieu.Text = dgv_NhanVien.CurrentRow.Cells[0].Value.ToString();
                txt_MaNV.Text = dgv_NhanVien.CurrentRow.Cells[1].Value.ToString();
                txtTenNV.Text = dgv_NhanVien.CurrentRow.Cells[2].Value.ToString();
                txtSoNC.Text = dgv_NhanVien.CurrentRow.Cells[6].Value.ToString();
                txtHeSoLuong.Text = dgv_NhanVien.CurrentRow.Cells[4].Value.ToString();
                txtHeSoChucVu.Text = dgv_NhanVien.CurrentRow.Cells[3].Value.ToString();
                txtLuongCoBan.Text = dgv_NhanVien.CurrentRow.Cells[5].Value.ToString();
                txtSoGioTangCa.Text = dgv_NhanVien.CurrentRow.Cells[7].Value.ToString();
                txtSoGioTre.Text = dgv_NhanVien.CurrentRow.Cells[8].Value.ToString();
                
            }
            btnLuu.Enabled = false;
        }

        private void btn_TinhLuong_Click(object sender, EventArgs e)
        {
   
            if (dgv_NhanVien.RowCount != 0)
            {
                int luongcoban = int.Parse(txtLuongCoBan.Text);
                int songaycc = int.Parse(txtSoNC.Text);
                float hesoluong = float.Parse(txtHeSoLuong.Text);
                float hesocv = float.Parse(txtHeSoChucVu.Text);
                int sogiotangca = int.Parse(txtSoGioTangCa.Text);
                int sogiotre = int.Parse(txtSoGioTre.Text);


                txtThanhTien.Text = ((int)(((songaycc*8+sogiotangca*1.5-sogiotre*1.5)*hesocv*hesoluong*(luongcoban/26/24)))).ToString("N0");

                btnLuu.Enabled = true;
            }
            else
                    MessageBox.Show("Chưa chọn nhân viên nào!");
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            DataRow dr = ds_QLLuong1.Tables["QL_Luong"].NewRow();
            dr["MaNhanVien"] = txt_MaNV.Text;
            dr["MaPhieu"] = txt_MaPhieu.Text;
            dr["TongLuong"] = txtThanhTien.Text;
            ds_QLLuong1.Tables["QL_Luong"].Rows.Add(dr);


            string caulenh = "select *from QL_Luong";
            SqlDataAdapter sqlda_Luong = new SqlDataAdapter(caulenh, cn);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(sqlda_Luong);
            sqlda_Luong.Update(ds_QLLuong1, "QL_Luong");
           
         
            if (bus_luong.KTTonTai(txt_MaPhieu.Text) == 1)
            {
                MessageBox.Show("Thành công");

            }
            else
            {
                MessageBox.Show("Thất bại");
            }
          
            frm_QLTinhLuong_Load(null, null);
        }

        private void dgv_TinhLuong_SelectionChanged(object sender, MouseEventArgs e)
        {
            if (dgv_TinhLuong.CurrentRow != null)
            {
                txt_MaPhieu.Text = dgv_TinhLuong.CurrentRow.Cells[0].Value.ToString();
                txt_MaNV.Text = dgv_TinhLuong.CurrentRow.Cells[1].Value.ToString();
                txtTenNV.Text = dgv_TinhLuong.CurrentRow.Cells[2].Value.ToString();
                txtSoNC.Text = dgv_TinhLuong.CurrentRow.Cells[8].Value.ToString();
                txtHeSoLuong.Text = dgv_TinhLuong.CurrentRow.Cells[4].Value.ToString();
                txtHeSoChucVu.Text = dgv_TinhLuong.CurrentRow.Cells[6].Value.ToString();
                txtLuongCoBan.Text = dgv_TinhLuong.CurrentRow.Cells[7].Value.ToString();
                txtSoGioTangCa.Text = dgv_TinhLuong.CurrentRow.Cells[9].Value.ToString();
                txtSoGioTre.Text = dgv_TinhLuong.CurrentRow.Cells[10].Value.ToString();
                txtThanhTien.Text = ((double)dgv_TinhLuong.CurrentRow.Cells[11].Value).ToString("N0");
            }
        }

        private void cbo_Phong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if( dv != null)
            {
                dv.RowFilter = string.Format("MaPhongBan like '" + cboPhongBan.SelectedValue.ToString().Replace("'", "''") + "'");
                dgv_NhanVien.DataSource = dv;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
