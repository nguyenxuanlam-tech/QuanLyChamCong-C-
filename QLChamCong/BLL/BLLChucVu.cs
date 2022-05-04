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
    public class BLLChucVu
    {
        DALChucVu dalChucVu = new DALChucVu();

        public DataTable getChucVu()
        {
            return dalChucVu.getChucVu();
        }
        public bool themChucVu(DTOChuscVu cv)
        {
            return dalChucVu.themChucVu(cv);
        }
        public bool suaChucVu(DTOChucVu cv)
        {
            return dalChucVu.suaChucVu(cv);
        }
        public bool xoaCV(int maCV)
        {
            return dalChucVu.xoaCV(maCV);
        }
    }
}
