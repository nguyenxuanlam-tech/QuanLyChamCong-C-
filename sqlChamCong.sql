use master
go
if exists(select name from master..sysdatabases where name='QLNhanSu')
	drop database QlNhanSu
go

Use QlNhanSu
go


Create Table PhongBan
(
	MaPB int not null identity,
	TenPB nvarchar(20) not null,
	Primary Key (MaPB)
)
go

Create Table ChucVu
(
	MaCV int not null identity,
	TenCv nvarchar(20) not null,
	Primary Key (MaCV)
)
go

Create Table Luong
(
	HeSoLuong int not null,
	LuongCB int not null,
	Primary Key (HeSoLuong)
)
go

Create Table NhanVien
(
	MaNV varchar(5) not null,
	MaPB int not null,
	HeSoLuong int not null,
	TenNV nvarchar(100) not null,
	GioiTinh nvarchar(5) not null,
	NgaySinh date not null,
	SoCM Varchar(20) not null,
	DienThoai Varchar(20) not null,
	TrinhDoHV nvarchar(30) not null,
	DiaChi nvarchar(max) not null,
	Email varchar(20) null,
	Hinh Nvarchar(100) not null,
	TTHonNhan Nvarchar (10) not null,
	primary key (MaNV),
	FOREIGN KEY (MaPB) REFERENCES PhongBan(MaPB),
	FOREIGN KEY (HeSoLuong) REFERENCES Luong(HeSoLuong)
)
go

Create Table Taikhoan
(
	MaNV varchar(5) not null,
	TenDangNhap nvarchar(50) primary key not null,
	MatKhau nvarchar(50) not null,
	TenQuyenHan Nvarchar(20) not null,
	FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
)
go

Create Table ChamCong
(
	MaNV varchar(5) not null,
	Ngay date not null,
	TinhTrang Nvarchar(20) null,
	FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
)
go

Create Table ctChucVu
(
	MaNV varchar(5) null,
	MaCV int null,
	NgayBatDau date null,
	NgayKetThuc date null,
	LyDo nvarchar(100),
	FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
	FOREIGN KEY (MaCV) REFERENCES ChucVu(MaCV)
)
go

Create Table PhuCap
(
	MaNV Varchar(5) not null,
	LoaiPC nvarchar(50),
	Tien int,
	TuNgay date,
	DenNgay date
	FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
)
go