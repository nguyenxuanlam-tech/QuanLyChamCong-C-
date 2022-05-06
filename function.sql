use ChamCong
go

-----------------------------------------------------------------------
-- TRIGGER INSERT NV
-----------------------------Phong Ban---------------------------------
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'insertPB')
	DROP PROC insertPB
GO
create procedure insertPB
( 
	@TENPB		nvarchar(20) 
)
AS
BEGIN
IF EXISTS(SELECT TenPB FROM PhongBan WHERE TenPB = @TENPB)
	BEGIN
		RAISERROR(N'Tên Phòng Ban: %s này đã tồn tại!!!!...Lêu Lêu', 16, 1, @TENPB)
	END
	ELSE
	BEGIN
	INSERT INTO PhongBan(TenPB)
	VALUES(@TENPB)
	RAISERROR(N'Thêm Phòng Ban: %s - %s MỚI này thành công!!!', 16, 1, @TENPB)
	END
END
GO

select * from PhongBan

-- update NV
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'updatePB')
	DROP PROC updatePB
GO
CREATE PROCEDURE updatePB
( 
	@MAPB	int,
	@TENPB	nvarchar(20)   
)
AS
BEGIN
IF NOT EXISTS(SELECT MaPB FROM PhongBan WHERE MaPB = @MAPB)
	BEGIN
		RAISERROR(N'Mã Phòng Ban: %s này không tồn tại!!!!', 16, 1, @MAPB)
	END
	ELSE
	BEGIN
	UPDATE PhongBan SET 
						MaPB = @MAPB,
						TenPB = @TENPB 											 
		WHERE MaPB = @MAPB
		RAISERROR(N'Cập nhật Phòng Ban: %s - %s Mới này thành công!!!', 16, 1, @MAPB, @TENPB)
	END
END
GO

-- delete pb
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'deletePB')
	DROP PROC deletePB
GO
CREATE PROCEDURE deletePB
(
	@MAPB int
)
AS
BEGIN
	DELETE FROM  PhongBan WHERE MaPB = @MAPB	
END
GO
-----------------------------------------------------------------------
--------------------------Chuc Vu--------------------------------------

IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'insertCV')
	DROP PROC insertCV
GO
create procedure insertCV
( 
	@TENCV		nvarchar(20) 
)
AS
BEGIN
IF EXISTS(SELECT TenCv FROM ChucVu WHERE TenCv = @TENCV)
	BEGIN
		RAISERROR(N'Tên Chức Vụ: %s này đã tồn tại!!!!', 16, 1, @TENCV)
	END
	ELSE
	BEGIN
	INSERT INTO ChucVu(TenCv)
	VALUES(@TENCV)
	RAISERROR(N'Thêm Chức Vụ: %s - %s Mới này thành công!!!', 16, 1, @TENCV)
	END
END
GO

select * from ChucVu

-- update NV
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'updateCV')
	DROP PROC updateCV
GO
CREATE PROCEDURE updateCV
( 
	@MACV	int,
	@TENCV	nvarchar(20)   
)
AS
BEGIN
IF NOT EXISTS(SELECT MaCV FROM ChucVu WHERE MaCV = @MACV)
	BEGIN
		RAISERROR(N'Mã Chức Vụ: %s này không tồn tại!!!!', 16, 1, @MACV)
	END
	ELSE
	BEGIN
	UPDATE ChucVu SET 
					MaCV = @MACV,
					TenCv = @TENCV 											 
		WHERE MaCV = @MACV
		RAISERROR(N'Cập nhật Chức Vụ: %s - %s Mới này thành công!!!', 16, 1, @MACV, @TENCV)
	END
END
GO

-- delete nv
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'deleteCV')
	DROP PROC deleteCV
GO
CREATE PROCEDURE deleteCV
(
	@MACV int
)
AS
BEGIN
	DELETE FROM  ChucVu WHERE MaCV = @MACV	
END
GO
-----------------------------------------------------------------------
--------------------------Luong--------------------------------------
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'insertLuong')
	DROP PROC insertLuong
GO
create procedure insertLuong
( 
	@HESOLUONG	int,
	@LUONGCB	int
)
AS
BEGIN
IF EXISTS(SELECT HeSoLuong, LuongCB FROM Luong WHERE HeSoLuong = @HESOLUONG and LuongCB = @LUONGCB)
	BEGIN
		RAISERROR(N'Thông số Lương: %s này đã tồn tại!!!!', 16, 1, @HESOLUONG,@LUONGCB)
	END
	ELSE
		BEGIN
			INSERT INTO Luong(HeSoLuong, LuongCB)
			VALUES(@HESOLUONG, @LUONGCB)
			RAISERROR(N'Thêm Chức Vụ: %s - %s Mới này thành công!!!', 16, 1, @TENCV)
		END
END
GO

select * from Luong

-- update Luong
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'updateLuong')
	DROP PROC updateLuong
GO
CREATE PROCEDURE updateLuong
( 
	@MALUONG int,
	@HESOLUONG	int,
	@LUONGCB	int   
)
AS
BEGIN
IF NOT EXISTS(SELECT MaLuong FROM Luong WHERE MaLuong = @MALUONG)
	BEGIN
		RAISERROR(N'Thông số Lương: %s này không tồn tại!!!!', 16, 1, @HESOLUONG)
	END
	ELSE
	BEGIN
	UPDATE Luong SET 
					HeSoLuong = @HESOLUONG,
					LuongCB = @LUONGCB 											 
		WHERE MaLuong = @MALUONG
		RAISERROR(N'Cập nhật thông số Lương: %s - %s Mới này thành công!!!', 16, 1, @MALUONG, @LUONGCB)
	END
END
GO

-- delete Luong
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'deleteLuong')
	DROP PROC deleteLuong
GO
CREATE PROCEDURE deleteLuong
(
	@MALUONG int
)
AS
BEGIN
	DELETE FROM  Luong WHERE MaLuong = @MALUONG	
END
GO

-----------------------------------------------------------------------
--------------------------Nhân viên--------------------------------------
--Ma Nhan Vien
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'DBO.AUTO_MANV()')
	DROP PROC DBO.AUTO_MANV()
GO

CREATE FUNCTION AUTO_MANV()
RETURNS VARCHAR(5)
AS
BEGIN
	DECLARE @ID VARCHAR(5)
	IF (SELECT COUNT(MaNV) FROM NhanVien) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaNV, 3)) FROM NhanVien
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'NV00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'NV0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
--

IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'insertNV')
	DROP PROC insertNV
GO
create procedure insertNV
( 
	@MANV varchar(5),
	@MAPB int,
	@HESOLUONG int,
	@TENNV nvarchar(100),
	@GIOITINH nvarchar(5),
	@NGAYSINH date,
	@SOCM Varchar(20),
	@DIENTHOAI Varchar(20),
	@TRINHDOHV nvarchar(30),
	@DIACHI nvarchar(max),
	@EMAIL varchar(20),
	@HINH Nvarchar(100),
	@TTHONNHAN Nvarchar(10) 
)
AS
BEGIN
IF EXISTS(SELECT MaNV FROM NhanVien WHERE MaNV = @MANV)
	BEGIN
		RAISERROR(N'Nhân viên: %s này đã tồn tại!!!!', 16, 1, @MANV)
	END
	ELSE
		BEGIN
			INSERT INTO NhanVien(MaNV,MaPB,HeSoLuong,TenNV,GioiTinh,NgaySinh,SoCM,DienThoai,TrinhDoHV,DiaChi,Email,Hinh,TTHonNhan)
			VALUES(@MANV,@MAPB,@HESOLUONG,@TENNV,@GIOITINH,@NGAYSINH,@SOCM,@DIENTHOAI,@TRINHDOHV,@DIACHI,@EMAIL,@HINH,@TTHONNHAN)
			RAISERROR(N'Thêm Nhân viên: %s - %s Mới này thành công!!!', 16, 1, @MANV)
		END
END
GO

select * from NhanVien

-- update NV
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'updateNV')
	DROP PROC updateNV
GO
CREATE PROCEDURE updateNV
( 
	@MANV varchar(5),
	@MAPB int,
	@HESOLUONG int,
	@TENNV nvarchar(100),
	@GIOITINH nvarchar(5),
	@NGAYSINH date,
	@SOCM Varchar(20),
	@DIENTHOAI Varchar(20),
	@TRINHDOHV nvarchar(30),
	@DIACHI nvarchar(max),
	@EMAIL varchar(20),
	@HINH Nvarchar(100),
	@TTHONNHAN Nvarchar(10)   
)
AS
BEGIN
IF NOT EXISTS(SELECT MaNV FROM NhanVien WHERE MaNV = @MANV)
	BEGIN
		RAISERROR(N'Mã Nhân viên: %s này không tồn tại!!!!', 16, 1, @MANV)
	END
	ELSE
	BEGIN
	UPDATE NhanVien SET 
					MaPB = @MAPB,
					HeSoLuong = @HESOLUONG,
					TenNV = @TENNV,
					GioiTinh = @GIOITINH,
					NgaySinh=@NGAYSINH,
					SoCM=@SOCM,
					DienThoai=@DIENTHOAI,
					TrinhDoHV=@TRINHDOHV,
					DiaChi=@DIACHI,
					Email=@EMAIL,
					Hinh=@HINH,
					TTHonNhan=@TTHONNHAN
		WHERE MaNV = @MANV
		RAISERROR(N'Cập nhật Nhân viên: %s - %s thành công!!!', 16, 1, @MANV)
	END
END
GO

-- delete nv
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'deleteNV')
	DROP PROC deleteNV
GO
CREATE PROCEDURE deleteNV
(
	@MANV varchar(5)
)
AS
BEGIN
	DELETE FROM  NhanVien WHERE MaNV = @MANV	
END
GO

-----------------------------------------------------------------------
--------------------------Tai Khoan--------------------------------------


IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'insertTK')
	DROP PROC insertTK
GO
create procedure insertTK
( 
	@MANV varchar(5),
	@TENDANGNHAP nvarchar(50),
	@MATKHAU nvarchar(50),
	@TENQUYENHAN nvarchar(20)
)
AS
BEGIN
IF EXISTS(SELECT MaNV FROM Taikhoan WHERE MaNV = @MANV)
	BEGIN
		RAISERROR(N'Nhân viên: %s này đã tồn tại Tài Khoản!!!!', 16, 1, @MANV, @TENDANGNHAP)
	END
	ELSE
		BEGIN
			INSERT INTO Taikhoan(MaNV,TenDangNhap,MatKhau,TenQuyenHan)
			VALUES(@MANV,@TENDANGNHAP,@MATKHAU,@TENQUYENHAN)
			RAISERROR(N'Thêm Tài Khoản: %s - %s Mới này thành công!!!', 16, 1, @MANV, @TENDANGNHAP)
		END
END
GO

select * from Taikhoan

-- update TK
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'updateTK')
	DROP PROC updateTK
GO
CREATE PROCEDURE updateTK
( 
	@MANV varchar(5),
	@TENDANGNHAP nvarchar(50),
	@MATKHAU nvarchar(50),
	@TENQUYENHAN nvarchar(20) 
)
AS
BEGIN
IF NOT EXISTS(SELECT MaNV FROM Taikhoan WHERE MaNV = @MANV)
	BEGIN
		RAISERROR(N'Mã Nhân viên: %s này không tồn tại chưa có Tài Khoản!!!!', 16, 1, @MANV)
	END
	ELSE
	BEGIN
	UPDATE Taikhoan SET 
					MaNV = @MANV,
					TenDangNhap = @TENDANGNHAP,
					MatKhau = @MATKHAU,
					TenQuyenHan = @TENQUYENHAN
		WHERE MaNV = @MANV
		RAISERROR(N'Cập nhật Tài Khoản: %s - %s thành công!!!', 16, 1, @MANV, @TENDANGNHAP)
	END
END
GO

-- delete TK
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'deleteTK')
	DROP PROC deleteTK
GO
CREATE PROCEDURE deleteTK
(
	@MANV varchar(5)
)
AS
BEGIN
	DELETE FROM  Taikhoan WHERE MaNV = @MANV	
END
GO

-----------------------------------------------------------------------
--------------------------Cham Cong--------------------------------------


IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME = 'insertCC')
	DROP PROC insertCC
GO
create procedure insertCC
( 
	@MANV varchar(5),
	@NGAY date,
	@TINHTRANG nvarchar(20)
)
AS
BEGIN
IF EXISTS(SELECT MaNV FROM ChamCong WHERE MaNV = @MANV)
	BEGIN
		RAISERROR(N'Chấm Công: %s Nhân Viên này không tồn tại!!!!', 16, 1, @NGAY, @TINHTRANG)
	END
	ELSE
		BEGIN
			INSERT INTO ChamCong(MaNV,Ngay,TinhTrang)
			VALUES(@MANV,@NGAY,@TINHTRANG)
			RAISERROR(N'Chấm Công: %s - %s thành công!!!', 16, 1, @MANV, @NGAY, @TINHTRANG)
		END
END
GO
