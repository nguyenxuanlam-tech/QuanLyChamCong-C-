using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTONhanVien
    {
		private string _maNV;
		private int _maPB;
		private int _maCV;
		private int _maLuong;
		private string _tenNV;
		private string _gioiTinh;
		private DateTime _ngaySinh;
		private string _cmnd;
		private string _dienthoai;
		private string _diachi;
		private string _email;
		private string _hinh;

		public string MaNV
		{
			get => _maNV;
			set => _maNV = value;
		}
		public int MaPB
		{
			get => _maPB;
			set => _maPB = value;
		}
		public int MaCV
		{
			get => _maCV;
			set => _maCV = value;
		}
		public int MaLuong
		{
			get => _maLuong;
			set => _maLuong = value;
		}
		public string TenNV
		{
			get => _tenNV;
			set => _tenNV = value;
		}
		public string GioiTinh
		{
			get => _gioiTinh;
			set => _gioiTinh = value;
		}
		public DateTime NgaySinh
		{
			get => _ngaySinh;
			set => _ngaySinh = value;
		}
		private string CMND
		{
			get => _cmnd;
			set => _cmnd = value;
		}
		public string SDT
		{
			get => _dienthoai;
			set => _dienthoai = value;
		}
		public string DiaChi
		{
			get => _diachi;
			set => _diachi = value;
		}
		public string Email
		{
			get => _email;
			set => _email = value;
		}
		public string Hinh
		{
			get => _hinh;
			set => _hinh = value;
		}
		public DTONhanVien()
		{

		}

		public DTONhanVien(string maNV)
		{

		}
		public DTONhanVien(string maNV, int maPB, int maCV, int maLuong, string tenNV, string gioiTinh, DateTime ngaySinh, string soCM,
							string dienThoai, string diaChi, string email, string hinh)
		{
			this.MaNV = maNV;
			this.MaPB = maPB;
			this.MaCV = maCV;
			this.MaLuong = maLuong;
			this.TenNV = tenNV;
			this.GioiTinh = gioiTinh;
			this.NgaySinh = ngaySinh;
			this.CMND = soCM;
			this.SDT = dienThoai;
			this.DiaChi = diaChi;
			this.Email = email;
			this.Hinh = hinh;
		}
	}
}
