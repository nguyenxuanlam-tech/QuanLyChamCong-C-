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
		private int _hesoLuong;
		private string _tenNV;
		private string _gioiTinh;
		private DateTime _ngaySinh;
		private string _soCM;
		private string _dienthoai;
		private string _trinhDoHV;
		private string _diachi;
		private string _email;
		private string _hinh;
		private string _ttHonNhan;

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
		public int HeSoLuong
		{
			get => _hesoLuong;
			set => _hesoLuong = value;
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
		private string SoCMND
		{
			get => _soCM;
			set => _soCM = value;
		}
		public string SDT
		{
			get => _dienthoai;
			set => _dienthoai = value;
		}
		public string TrinhDoHV
		{
			get => _trinhDoHV;
			set => _trinhDoHV = value;
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
		public string TTHonNhan
		{
			get => _ttHonNhan;
			set => _ttHonNhan = value;
		}
		public DTONhanVien()
		{

		}

		public DTONhanVien(string maNV)
		{

		}
		public DTONhanVien(string maNV, int maPB, int maCV, int hesoLuong, string tenNV, string gioiTinh, DateTime ngaySinh, string soCM,
							string dienThoai, string trinhDoHV, string diaChi, string email, string hinh, string ttHonNhan)
		{
			this.MaNV = maNV;
			this.MaPB = maPB;
			this.MaCV = maCV;
			this.HeSoLuong = hesoLuong;
			this.TenNV = tenNV;
			this.GioiTinh = gioiTinh;
			this.NgaySinh = ngaySinh;
			this.SoCMND = soCM;
			this.SDT = dienThoai;
			this.TrinhDoHV = trinhDoHV;
			this.DiaChi = diaChi;
			this.Email = email;
			this.Hinh = hinh;
			this.TTHonNhan = ttHonNhan;
		}
	}
}
