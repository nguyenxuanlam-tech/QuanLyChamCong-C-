﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChamCong
{
    static class Program
    {
        public static frmMain mainForm = null;
        public static frm_DangNhap loginForm = null;
        public static string ConnectionString = @"Data Source=DESKTOP-1ICQ6GR;Initial Catalog=QuanLyChamCong;Integrated Security=True";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_DangNhap());
            //Application.Run(new frm_DangNhap());
        }
    }
}
