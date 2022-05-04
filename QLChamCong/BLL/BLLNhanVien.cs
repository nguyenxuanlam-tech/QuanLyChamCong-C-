using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLNhanVien
    {
        DALNhanVien dalNhanVien = new DALNhanVien();
        public DataTable getNhanVien()
        {
            return dalNhanVien.getNV();
        }
        public bool themNhanVien(DTONhanVien nv)
        {
            return dalNhanVien.themNV(nv);
        }
        public bool suaNhanVien(DTONhanVien nv)
        {
            return dalNhanVien.suaNV(nv);
        }
        public bool xoaNhanVien(string maNV)
        {
            return dalNhanVien.xoaNV(maNV);
        }
    }
}
