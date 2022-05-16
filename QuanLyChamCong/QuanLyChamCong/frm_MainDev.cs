﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;

namespace QuanLyChamCong
{
    public partial class frm_MainDev : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frm_MainDev()
        {
            InitializeComponent();
        }

        string _MaNhom;

        public string MaNhom
        {
            get { return _MaNhom; }
            set { _MaNhom = value; }
        }

        public void duyet2(RibbonControl mnuItems)
        {
            foreach (RibbonPage menu in mnuItems.TotalPageCategory.Pages)
            {
                if (menu.Tag != null)
                {
                    if (string.Equals(menu.Tag.ToString().Trim(), _MaNhom.Trim()))
                    {
                        menu.Visible = false;
                    }
                }
            }
        }

        private void RibbonForm1_Load(object sender, EventArgs e)
        {
            duyet2(menu);
        }
            


        private void btn_NguoiDung_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_QLNguoiDung frm = new frm_QLNguoiDung();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btn_NhomND_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_QLNhomND frm = new frm_QLNhomND();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btn_NhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_QLNhanVien frm = new frm_QLNhanVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btn_ChamCong_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_QLChamCong frm = new frm_QLChamCong();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btn_TinhLuong_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_QLTinhLuong frm = new frm_QLTinhLuong();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btn_Dong_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dl = new DialogResult();
            dl = MessageBox.Show("Bạn có chắc muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_GioiThieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_GioiThieu frm = new frm_GioiThieu();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btn_PhongBan_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_QLPhongBan frm = new frm_QLPhongBan();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}