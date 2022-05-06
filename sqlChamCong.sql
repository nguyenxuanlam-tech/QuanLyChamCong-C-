use master
go
if exists(select name from master..sysdatabases where name='ChamCong')
	drop database ChamCong
go

create database ChamCong
Use ChamCong
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
	MaLuong int not null identity,
	HeSo int not null,
	LuongCB int not null,
	Primary Key (MaLuong)
)
go

Create Table NhanVien
(
	MaNV varchar(5) not null,
	MaPB int not null,
	MaCV int not null,
	MaLuong int not null,
	TenNV nvarchar(100) not null,
	GioiTinh nvarchar(5),
	NgaySinh date,
	CMND varchar(20),
	DienThoai Varchar(20) not null,
	DiaChi nvarchar(max) not null,
	Email varchar(20),
	Hinh nvarchar(100),
	primary key (MaNV),
	FOREIGN KEY (MaPB) REFERENCES PhongBan(MaPB),
	FOREIGN KEY (MaCV) REFERENCES ChucVu(MaCV),
	FOREIGN KEY (MaLuong) REFERENCES Luong(MaLuong)
)
go

Create Table Taikhoan
(
	IDTK int primary key not null identity,
	MaNV varchar(5) not null,
	TenDangNhap nvarchar(50) not null,
	MatKhau nvarchar(50) not null,
	TenQuyenHan nvarchar(20) not null,
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

Create Table PhuCap
(
	MaNV varchar(5) not null,
	LoaiPC nvarchar(50),
	Tien int,
	TuNgay date,
	DenNgay date
	FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
)
go