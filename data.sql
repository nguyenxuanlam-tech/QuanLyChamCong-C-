use QlNhanSu
go
-----------------------------------------------------------------------------------------------------------------------
insert into PhongBan(TenPB) values(N'Phòng Giám Đốc')
insert into PhongBan(TenPB) values(N'Phòng Phó Giám Đốc')
insert into PhongBan(TenPB) values(N'Phòng Kinh Doanh')
insert into PhongBan(TenPB) values(N'Phòng Kế Toán')
insert into PhongBan(TenPB) values(N'Phòng Kỹ Thuật')

-----------------------------------------------------------------------------------------------------------------------
insert into ChucVu( TenCV) values(N'Giám Đốc')
insert into ChucVu( TenCV) values(N'Phó Giám Đốc')
insert into ChucVu( TenCV) values(N'Trưởng Phòng')
insert into ChucVu( TenCV) values(N'Phó Phòng')
insert into ChucVu( TenCV) values(N'Nhân Viên')

-----------------------------------------------------------------------------------------------------------------------
insert into Luong(HeSoLuong, LuongCB) values(10,15000000)
insert into Luong(HeSoLuong, LuongCB) values(9,12000000)
insert into Luong(HeSoLuong, LuongCB) values(8,10000000)
insert into Luong(HeSoLuong, LuongCB) values(7,7000000)
insert into Luong(HeSoLuong, LuongCB) values(6,5000000)
insert into Luong(HeSoLuong, LuongCB) values(5,4500000)
insert into Luong(HeSoLuong, LuongCB) values(4,4000000)
insert into Luong(HeSoLuong, LuongCB) values(3,3800000)
insert into Luong(HeSoLuong, LuongCB) values(2,3700000)
insert into Luong(HeSoLuong, LuongCB) values(1,3500000)

-----------------------------------------------------------------------------------------------------------------------
Insert Into NhanVien(MaNV, MaPB, HeSoLuong, TenNV, GioiTinh, NgaySinh, SoCM, DienThoai, TrinhDoHV, DiaChi, Email, TTHonNhan, Hinh)
				Values('NV01',1,10,N'Trần Dũng Lộc',N'Nam','1985/09/02',88888888,01638345699,N'Đại Học',N'Biên Hòa, Đồng nai','@gmail.com',N'Đã Kết Hôn','Hinh/TaoTaikhoan.png')
Insert Into NhanVien(MaNV, MaPB, HeSoLuong, TenNV, GioiTinh, NgaySinh, SoCM, DienThoai, TrinhDoHV, DiaChi, Email, TTHonNhan, Hinh)
		Values('NV02',2,9,N'Trần Thanh Hiền',N'Nam','1985/09/02',88888888,01638345699,N'Đại Học',N'Biên Hòa, Đồng nai','@gmail.com',N'Đã Kết Hôn','Hinh/TaoTaikhoan.png')

Insert Into NhanVien(MaNV, MaPB, HeSoLuong, TenNV, GioiTinh, NgaySinh, SoCM, DienThoai, TrinhDoHV, DiaChi, Email, TTHonNhan, Hinh)
		Values('NV03',3,8,N'Trương Minh Sang',N'Nam','1985/09/02',88888888,01638345699,N'Đại Học',N'Biên Hòa, Đồng nai','@gmail.com',N'Đã Kết Hôn','Hinh/TaoTaikhoan.png')
Insert Into NhanVien(MaNV, MaPB, HeSoLuong, TenNV, GioiTinh, NgaySinh, SoCM, DienThoai, TrinhDoHV, DiaChi, Email, TTHonNhan, Hinh)
		Values('NV04',4,8,N'Nguyễn Thị Lệ Thu',N'Nữ','1985/09/02',88888888,01638345699,N'Đại Học',N'Biên Hòa, Đồng nai','@gmail.com',N'Đã Kết Hôn','Hinh/TaoTaikhoan.png')
Insert Into NhanVien(MaNV, MaPB, HeSoLuong, TenNV, GioiTinh, NgaySinh, SoCM, DienThoai, TrinhDoHV, DiaChi, Email, TTHonNhan, Hinh)
		Values('NV05',5,8,N'Trần Minh Siêu',N'Nam','1985/09/02',88888888,01638345699,N'Đại Học',N'Biên Hòa, Đồng nai','@gmail.com',N'Đã Kết Hôn','Hinh/TaoTaikhoan.png')

Insert Into NhanVien(MaNV, MaPB, HeSoLuong, TenNV, GioiTinh, NgaySinh, SoCM, DienThoai, TrinhDoHV, DiaChi, Email, TTHonNhan, Hinh)
		Values('NV06',3,7,N'Trần Ngọc Tuyết',N'Nữ','1985/09/02',88888888,01638345699,N'Đại Học',N'Biên Hòa, Đồng nai','@gmail.com',N'Đã Kết Hôn','Hinh/TaoTaikhoan.png')
Insert Into NhanVien(MaNV, MaPB, HeSoLuong, TenNV, GioiTinh, NgaySinh, SoCM, DienThoai, TrinhDoHV, DiaChi, Email, TTHonNhan, Hinh)
		Values('NV07',5,7,N'Nguyễn Hữu Minh',N'Nam','1985/09/02',88888888,01638345699,N'Đại Học',N'Biên Hòa, Đồng nai','@gmail.com',N'Đã Kết Hôn','Hinh/TaoTaikhoan.png')

Insert Into NhanVien(MaNV, MaPB, HeSoLuong, TenNV, GioiTinh, NgaySinh, SoCM, DienThoai, TrinhDoHV, DiaChi, Email, TTHonNhan, Hinh)
		Values('NV08',3,6,N'Huỳnh Thị Yến Lê',N'Nữ','1985/09/02',88888888,01638345699,N'Đại Học',N'Biên Hòa, Đồng nai','@gmail.com',N'Đã Kết Hôn','Hinh/TaoTaikhoan.png')
Insert Into NhanVien(MaNV, MaPB, HeSoLuong, TenNV, GioiTinh, NgaySinh, SoCM, DienThoai, TrinhDoHV, DiaChi, Email, TTHonNhan, Hinh)
		Values('NV09',3,6,N'Nguyễn Thị Kim Thoa',N'Nữ','1985/09/02',88888888,01638345699,N'Đại Học',N'Biên Hòa, Đồng nai','@gmail.com',N'Đã Kết Hôn','Hinh/TaoTaikhoan.png')
Insert Into NhanVien(MaNV, MaPB, HeSoLuong, TenNV, GioiTinh, NgaySinh, SoCM, DienThoai, TrinhDoHV, DiaChi, Email, TTHonNhan, Hinh)
		Values('NV10',3,6,N'Nguyễn Thị Bích Hằng',N'Nữ','1985/09/02',88888888,01638345699,N'Đại Học',N'Biên Hòa, Đồng nai','@gmail.com',N'Đã Kết Hôn','Hinh/TaoTaikhoan.png')
Insert Into NhanVien(MaNV, MaPB, HeSoLuong, TenNV, GioiTinh, NgaySinh, SoCM, DienThoai, TrinhDoHV, DiaChi, Email, TTHonNhan, Hinh)
		Values('NV11',3,6,N'Hồ Mạnh Tiến',N'Nam','1985/09/02',88888888,01638345699,N'Đại Học',N'Biên Hòa, Đồng nai','@gmail.com',N'Đã Kết Hôn','Hinh/TaoTaikhoan.png')
Insert Into NhanVien(MaNV, MaPB, HeSoLuong, TenNV, GioiTinh, NgaySinh, SoCM, DienThoai, TrinhDoHV, DiaChi, Email, TTHonNhan, Hinh)
		Values('NV12',3,6,N'Nguyễn Tăng Quốc',N'Nam','1985/09/02',88888888,01638345699,N'Đại Học',N'Biên Hòa, Đồng nai','@gmail.com',N'Đã Kết Hôn','Hinh/TaoTaikhoan.png')

Insert Into NhanVien(MaNV, MaPB, HeSoLuong, TenNV, GioiTinh, NgaySinh, SoCM, DienThoai, TrinhDoHV, DiaChi, Email, TTHonNhan, Hinh)
		Values('NV13',4,6,N'Lê Thị Tịnh',N'Nữ','1985/09/02',88888888,01638345699,N'Đại Học',N'Biên Hòa, Đồng nai','@gmail.com',N'Đã Kết Hôn','Hinh/TaoTaikhoan.png')
Insert Into NhanVien(MaNV, MaPB, HeSoLuong, TenNV, GioiTinh, NgaySinh, SoCM, DienThoai, TrinhDoHV, DiaChi, Email, TTHonNhan, Hinh)
		Values('NV14',4,6,N'Bùi Thị Sương',N'Nữ','1985/09/02',88888888,01638345699,N'Đại Học',N'Biên Hòa, Đồng nai','@gmail.com',N'Đã Kết Hôn','Hinh/TaoTaikhoan.png')

Insert Into NhanVien(MaNV, MaPB, HeSoLuong, TenNV, GioiTinh, NgaySinh, SoCM, DienThoai, TrinhDoHV, DiaChi, Email, TTHonNhan, Hinh)
		Values('NV15',5,6,N'Bùi Văn Long',N'Nam','1985/09/02',88888888,01638345699,N'Đại Học',N'Biên Hòa, Đồng nai','@gmail.com',N'Đã Kết Hôn','Hinh/TaoTaikhoan.png')
Insert Into NhanVien(MaNV, MaPB, HeSoLuong, TenNV, GioiTinh, NgaySinh, SoCM, DienThoai, TrinhDoHV, DiaChi, Email, TTHonNhan, Hinh)
		Values('NV16',5,6,N'Đỗ Hữu Tiến',N'Nam','1985/09/02',88888888,01638345699,N'Đại Học',N'Biên Hòa, Đồng nai','@gmail.com',N'Đã Kết Hôn','Hinh/TaoTaikhoan.png')
Insert Into NhanVien(MaNV, MaPB, HeSoLuong, TenNV, GioiTinh, NgaySinh, SoCM, DienThoai, TrinhDoHV, DiaChi, Email, TTHonNhan, Hinh)
		Values('NV17',5,6,N'Phạm Văn Mạnh',N'Nam','1985/09/02',88888888,01638345699,N'Đại Học',N'Biên Hòa, Đồng nai','@gmail.com',N'Đã Kết Hôn','Hinh/TaoTaikhoan.png')


		select * from NhanVien
-----------------------------------------------------------------------------------------------------------------------
insert into Taikhoan(MaNV, TenQuyenHan, TenDangNhap, MatKhau) values('NV01','Super Admin','admin','admin')
insert into Taikhoan(MaNV, TenQuyenHan, TenDangNhap, MatKhau) values('NV02','Admin','admin1','admin')

-----------------------------------------------------------------------------------------------------------------------
insert into ctChucVu(MaNV, MaCV, NgayBatDau, LyDo) values('NV01',1,'10/01/2014',N'Tuyển Nhân Viên')
insert into ctChucVu(MaNV, MaCV, NgayBatDau, LyDo) values('NV02',2,'10/01/2014',N'Tuyển Nhân Viên')
insert into ctChucVu(MaNV, MaCV, NgayBatDau, LyDo) values('NV03',3,'10/01/2014',N'Tuyển Nhân Viên')
insert into ctChucVu(MaNV, MaCV, NgayBatDau, LyDo) values('NV04',3,'10/01/2014',N'Tuyển Nhân Viên')
insert into ctChucVu(MaNV, MaCV, NgayBatDau, LyDo) values('NV05',3,'10/01/2014',N'Tuyển Nhân Viên')
insert into ctChucVu(MaNV, MaCV, NgayBatDau, LyDo) values('NV06',4,'10/01/2014',N'Tuyển Nhân Viên')
insert into ctChucVu(MaNV, MaCV, NgayBatDau, LyDo) values('NV07',4,'10/01/2014',N'Tuyển Nhân Viên')
insert into ctChucVu(MaNV, MaCV, NgayBatDau, LyDo) values('NV08',5,'10/01/2014',N'Tuyển Nhân Viên')
insert into ctChucVu(MaNV, MaCV, NgayBatDau, LyDo) values('NV09',5,'10/01/2014',N'Tuyển Nhân Viên')
insert into ctChucVu(MaNV, MaCV, NgayBatDau, LyDo) values('NV10',5,'10/01/2014',N'Tuyển Nhân Viên')
insert into ctChucVu(MaNV, MaCV, NgayBatDau, LyDo) values('NV11',5,'10/01/2014',N'Tuyển Nhân Viên')
insert into ctChucVu(MaNV, MaCV, NgayBatDau, LyDo) values('NV12',5,'10/01/2014',N'Tuyển Nhân Viên')
insert into ctChucVu(MaNV, MaCV, NgayBatDau, LyDo) values('NV13',5,'10/01/2014',N'Tuyển Nhân Viên')
insert into ctChucVu(MaNV, MaCV, NgayBatDau, LyDo) values('NV14',5,'10/01/2014',N'Tuyển Nhân Viên')
insert into ctChucVu(MaNV, MaCV, NgayBatDau, LyDo) values('NV15',5,'10/01/2014',N'Tuyển Nhân Viên')
insert into ctChucVu(MaNV, MaCV, NgayBatDau, LyDo) values('NV16',5,'10/01/2014',N'Tuyển Nhân Viên')
insert into ctChucVu(MaNV, MaCV, NgayBatDau, LyDo) values('NV17',5,'10/01/2014',N'Tuyển Nhân Viên')

-----------------------------------------------------------------------------------------------------------------------

-----------------------------------------------------------------------------------------------------------------------

-----------------------------------------------------------------------------------------------------------------------