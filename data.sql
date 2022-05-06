use ChamCong
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
insert into Luong(HeSo, LuongCB) values(10,15000000)
insert into Luong(HeSo, LuongCB) values(9,12000000)
insert into Luong(HeSo, LuongCB) values(8,10000000)
insert into Luong(HeSo, LuongCB) values(7,7000000)
insert into Luong(HeSo, LuongCB) values(6,5000000)
insert into Luong(HeSo, LuongCB) values(5,4500000)
insert into Luong(HeSo, LuongCB) values(4,4000000)
insert into Luong(HeSo, LuongCB) values(3,3800000)
insert into Luong(HeSo, LuongCB) values(2,3700000)
insert into Luong(HeSo, LuongCB) values(1,3500000)

-----------------------------------------------------------------------------------------------------------------------
Insert Into NhanVien(MaNV,MaPB, MaCV,MaLuong,TenNV,GioiTinh,NgaySinh,CMND,DienThoai,DiaChi,Email,Hinh)
				Values(DBO.AUTO_MANV(),1,1,10,N'Trần Dũng Lộc',N'Nam','1985/09/02',88888888,01638345699,N'Biên Hòa, Đồng nai','@gmail.com','Hinh/TaoTaikhoan.png')
Insert Into NhanVien(MaNV,MaPB, MaCV,MaLuong,TenNV,GioiTinh,NgaySinh,CMND,DienThoai,DiaChi,Email,Hinh)
		Values(DBO.AUTO_MANV(),2,2,9,N'Trần Thanh Hiền',N'Nam','1985/09/02',88888888,01638345699,N'Biên Hòa, Đồng nai','@gmail.com','Hinh/TaoTaikhoan.png')

Insert Into NhanVien(MaNV,MaPB, MaCV,MaLuong,TenNV,GioiTinh,NgaySinh,CMND,DienThoai,DiaChi,Email,Hinh)
		Values(DBO.AUTO_MANV(),3,3,8,N'Trương Minh Sang',N'Nam','1985/09/02',88888888,01638345699,N'Biên Hòa, Đồng nai','@gmail.com','Hinh/TaoTaikhoan.png')
Insert Into NhanVien(MaNV,MaPB, MaCV,MaLuong,TenNV,GioiTinh,NgaySinh,CMND,DienThoai,DiaChi,Email,Hinh)
		Values(DBO.AUTO_MANV(),4,4,8,N'Nguyễn Thị Lệ Thu',N'Nữ','1985/09/02',88888888,01638345699,N'Biên Hòa, Đồng nai','@gmail.com','Hinh/TaoTaikhoan.png')
Insert Into NhanVien(MaNV,MaPB, MaCV,MaLuong,TenNV,GioiTinh,NgaySinh,CMND,DienThoai,DiaChi,Email,Hinh)
		Values(DBO.AUTO_MANV(),5,5,8,N'Trần Minh Siêu',N'Nam','1985/09/02',88888888,01638345699,N'Biên Hòa, Đồng nai','@gmail.com','Hinh/TaoTaikhoan.png')

Insert Into NhanVien(MaNV,MaPB, MaCV,MaLuong,TenNV,GioiTinh,NgaySinh,CMND,DienThoai,DiaChi,Email,Hinh)
		Values(DBO.AUTO_MANV(),3,3,7,N'Trần Ngọc Tuyết',N'Nữ','1985/09/02',88888888,01638345699,N'Biên Hòa, Đồng nai','@gmail.com','Hinh/TaoTaikhoan.png')
Insert Into NhanVien(MaNV,MaPB, MaCV,MaLuong,TenNV,GioiTinh,NgaySinh,CMND,DienThoai,DiaChi,Email,Hinh)
		Values(DBO.AUTO_MANV(),5,4,7,N'Nguyễn Hữu Minh',N'Nam','1985/09/02',88888888,01638345699,N'Biên Hòa, Đồng nai','@gmail.com','Hinh/TaoTaikhoan.png')

Insert Into NhanVien(MaNV,MaPB, MaCV,MaLuong,TenNV,GioiTinh,NgaySinh,CMND,DienThoai,DiaChi,Email,Hinh)
		Values(DBO.AUTO_MANV(),3,5,6,N'Huỳnh Thị Yến Lê',N'Nữ','1985/09/02',88888888,01638345699,N'Biên Hòa, Đồng nai','@gmail.com','Hinh/TaoTaikhoan.png')
Insert Into NhanVien(MaNV,MaPB, MaCV,MaLuong,TenNV,GioiTinh,NgaySinh,CMND,DienThoai,DiaChi,Email,Hinh)
		Values(DBO.AUTO_MANV(),3,3,6,N'Nguyễn Thị Kim Thoa',N'Nữ','1985/09/02',88888888,01638345699,N'Biên Hòa, Đồng nai','@gmail.com','Hinh/TaoTaikhoan.png')
Insert Into NhanVien(MaNV,MaPB, MaCV,MaLuong,TenNV,GioiTinh,NgaySinh,CMND,DienThoai,DiaChi,Email,Hinh)
		Values(DBO.AUTO_MANV(),3,4,6,N'Nguyễn Thị Bích Hằng',N'Nữ','1985/09/02',88888888,01638345699,N'Biên Hòa, Đồng nai','@gmail.com','Hinh/TaoTaikhoan.png')
Insert Into NhanVien(MaNV,MaPB, MaCV,MaLuong,TenNV,GioiTinh,NgaySinh,CMND,DienThoai,DiaChi,Email,Hinh)
		Values(DBO.AUTO_MANV(),3,5,6,N'Hồ Mạnh Tiến',N'Nam','1985/09/02',88888888,01638345699,N'Biên Hòa, Đồng nai','@gmail.com','Hinh/TaoTaikhoan.png')
Insert Into NhanVien(MaNV,MaPB, MaCV,MaLuong,TenNV,GioiTinh,NgaySinh,CMND,DienThoai,DiaChi,Email,Hinh)
		Values(DBO.AUTO_MANV(),3,3,6,N'Nguyễn Tăng Quốc',N'Nam','1985/09/02',88888888,01638345699,N'Biên Hòa, Đồng nai','@gmail.com','Hinh/TaoTaikhoan.png')

Insert Into NhanVien(MaNV,MaPB, MaCV,MaLuong,TenNV,GioiTinh,NgaySinh,CMND,DienThoai,DiaChi,Email,Hinh)
		Values(DBO.AUTO_MANV(),4,4,6,N'Lê Thị Tịnh',N'Nữ','1985/09/02',88888888,01638345699,N'Biên Hòa, Đồng nai','@gmail.com','Hinh/TaoTaikhoan.png')
Insert Into NhanVien(MaNV,MaPB, MaCV,MaLuong,TenNV,GioiTinh,NgaySinh,CMND,DienThoai,DiaChi,Email,Hinh)
		Values(DBO.AUTO_MANV(),4,5,6,N'Bùi Thị Sương',N'Nữ','1985/09/02',88888888,01638345699,N'Biên Hòa, Đồng nai','@gmail.com','Hinh/TaoTaikhoan.png')

Insert Into NhanVien(MaNV,MaPB, MaCV,MaLuong,TenNV,GioiTinh,NgaySinh,CMND,DienThoai,DiaChi,Email,Hinh)
		Values(DBO.AUTO_MANV(),5,3,6,N'Bùi Văn Long',N'Nam','1985/09/02',88888888,01638345699,N'Biên Hòa, Đồng nai','@gmail.com','Hinh/TaoTaikhoan.png')
Insert Into NhanVien(MaNV,MaPB, MaCV,MaLuong,TenNV,GioiTinh,NgaySinh,CMND,DienThoai,DiaChi,Email,Hinh)
		Values(DBO.AUTO_MANV(),5,4,6,N'Đỗ Hữu Tiến',N'Nam','1985/09/02',88888888,01638345699,N'Biên Hòa, Đồng nai','@gmail.com','Hinh/TaoTaikhoan.png')
Insert Into NhanVien(MaNV,MaPB, MaCV,MaLuong,TenNV,GioiTinh,NgaySinh,CMND,DienThoai,DiaChi,Email,Hinh)
		Values(DBO.AUTO_MANV(),5,5,6,N'Phạm Văn Mạnh',N'Nam','1985/09/02',88888888,01638345699,N'Biên Hòa, Đồng nai','@gmail.com','Hinh/TaoTaikhoan.png')


		select * from NhanVien
-----------------------------------------------------------------------------------------------------------------------
insert into Taikhoan(MaNV,TenDangNhap,MatKhau,TenQuyenHan) values('NV001','Super Admin','admin','admin')
insert into Taikhoan(MaNV,TenDangNhap,MatKhau,TenQuyenHan) values('NV002','Admin','admin1','admin')

-----------------------------------------------------------------------------------------------------------------------

-----------------------------------------------------------------------------------------------------------------------

-----------------------------------------------------------------------------------------------------------------------

-----------------------------------------------------------------------------------------------------------------------