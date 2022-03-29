if not exists(select * from sys.databases where name = 'QLChamCong')
begin 
	create database QLChamCong
	use QLChamCong

	create table ChucVu
	(
		maCV int primary key,
		tenCV nvarchar(50),
		ghiChu text
	)

	create table PhongBan
	(
		maPB int primary key,
		tenPB nvarchar(50),
		ghiChu text
	)

	create table NhanVien
	(
		maNV int primary key,
		maCV int ,
		maPB int ,
		hoNV nvarchar(50),
		tenNV nvarchar(10),
		gioiTinh bit,
		ngaySinh dateTime,
		diaChi text,
		soCMND varchar(15),
		noiSinh text,
		sdt varchar(10),
		ngayVaoLam dateTime,
		ghiChu text

		constraint fr_NhanVien foreign key (maCV) references ChucVu(maCV),
		constraint fr_PhongBan foreign key (maPB) references PhongBan(maPB)
	)
	
	create table Luong
	(
		maLuong int primary key,
		maNV int,
		luong varchar(20),
		thuong varchar(20),
		phucap varchar(10),
		ungLuong varchar(10),
		ghiChu text

		constraint fr_Luong foreign key (maNV) references NhanVien(maNV)
	)

	create table ChamCong
	(
		maCC int primary key,
		maNV int, 
		ngayCong dateTime,
		phanCa nvarchar(50),
		nghiPhep nvarchar(50),
		tangCa nvarchar(50),
		ghiChu text

		constraint fr_ChamCong foreign key (maNV) references NhanVien(maNV)
	)

	create table TaiKhoan
	(
		maTK int primary key,
		maNV int,
		taiKhoan varchar(10),
		matKhau varchar(15)

		constraint fr_TaiKhoan foreign key (maNV) references NhanVien(maNV)
	)
end