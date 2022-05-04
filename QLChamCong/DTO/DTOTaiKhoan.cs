using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOTaiKhoan
    {
        public string _manv;
        public string _tendangnhap;
        public string _matkhau;
        public string _tenquyenhan;

        public string MANV
        {
            get => _manv;
            set => _manv = value;
        }
        public string TENDANGNHAP
        {
            get => _tendangnhap;
            set => _tendangnhap = value;
        }
        public string MATKHAU
        {
            get => _matkhau;
            set => _matkhau = value;
        }
        public string TENQUYENHAN
        {
            get => _tenquyenhan;
            set => _tenquyenhan = value;
        }
        public DTOTaiKhoan()
        {

        }
        public DTOTaiKhoan(string manv)
        {

        }
        public DTOTaiKhoan(string manv, string tendangnhap, string matkhau, string tenquyenhan)
        {
            this.MANV = manv;
            this.TENDANGNHAP = tendangnhap;
            this.MATKHAU = matkhau;
            this.TENQUYENHAN = tenquyenhan;
        }
    }
}
