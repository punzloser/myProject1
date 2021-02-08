CREATE DATABASE QuanLiDiem
GO
USE QuanLiDiem
GO

CREATE TABLE DangNhap
(
		UserName VARCHAR(30) PRIMARY KEY,
		Name NVARCHAR(50) NOT NULL,
		Pass VARCHAR(30) NOT NULL,
		Quyen VARCHAR(20)
)
GO

CREATE TABLE ThongTin
(
	ID SMALLINT IDENTITY(1,1),
	MaThongTin AS ('TT' + RIGHT('0000' + CAST(ID AS VARCHAR(4)),4)) PERSISTED PRIMARY KEY,
	Tinh NVARCHAR(50) NOT NULL,
	DonViChuQuan NVARCHAR(200) NOT NULL,
	TenTruong NVARCHAR(200) NOT NULL,
	KhoaHoc VARCHAR(20) NOT NULL,
	NganhHoc NVARCHAR(50) NOT NULL,
	ChuyenNganh NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE HocKy
(
	ID SMALLINT IDENTITY(1,1),
	MaHK AS ('HK' + RIGHT('0000' + CAST(ID AS VARCHAR(4)),4)) PERSISTED PRIMARY KEY,
	TenHK NCHAR(8)
)
GO

CREATE TABLE MonHP
(
	ID SMALLINT IDENTITY(1,1),
	MaMonHP AS ('HP' + RIGHT('0000' + CAST(ID AS VARCHAR(4)),4)) PERSISTED PRIMARY KEY,
	TenMonHP NVARCHAR(50),
	SoTin TINYINT,
	TietLT TINYINT,
	TietTH TINYINT,
	MaHK VARCHAR(6) 
	
	FOREIGN KEY (MaHK) REFERENCES dbo.HocKy (MaHK)
)
GO

CREATE TABLE HeDaoTao
(
	ID SMALLINT IDENTITY(1,1),
	MaHe AS ('DT' + RIGHT('0000' + CAST(ID AS VARCHAR(4)),4)) PERSISTED PRIMARY KEY,
	TenHe NVARCHAR(20)
)
GO

CREATE TABLE Lop
(
	ID SMALLINT IDENTITY(1,1),
	MaLop AS ('L0' + RIGHT('0000' + CAST(ID AS VARCHAR(4)),4)) PERSISTED PRIMARY KEY,
	TenLop CHAR(7),
	MaHe VARCHAR(6)

	FOREIGN KEY (MaHe) REFERENCES dbo.HeDaoTao (MaHe)
)
GO

CREATE TABLE TinhTrang
(
	ID SMALLINT IDENTITY(1,1),
	MaTinhTrang AS ('T0' + RIGHT('0000' + CAST(ID AS VARCHAR(4)),4)) PERSISTED PRIMARY KEY,
	TinhTrang NVARCHAR(20)
)
GO

CREATE TABLE SinhVien
(
	ID SMALLINT IDENTITY(1,1),
	--TienTo VARCHAR(50) NOT NULL,
	MaSV AS ('19' + RIGHT('0000' + CAST(ID AS VARCHAR(4)),4)) PERSISTED PRIMARY KEY,
	HoLot NVARCHAR(30),
	Ten NVARCHAR(7),
	NgaySinh DATETIME,
	GioiTinh NCHAR(4),
	NoiSinh NVARCHAR(30),
	DanToc NVARCHAR(20),
	MaLop VARCHAR(6),
	MaTinhTrang VARCHAR(6)

	FOREIGN KEY (MaLop) REFERENCES dbo.Lop (MaLop),
	FOREIGN KEY (MaTinhTrang) REFERENCES dbo.TinhTrang (MaTinhTrang)
)
GO

CREATE TABLE SinhVien_HinhAnh
(
	ID SMALLINT IDENTITY(1,1),
	SV_IMG AS ('IMG' + RIGHT('0000' + CAST(ID AS VARCHAR(5)),5)) PERSISTED PRIMARY KEY,
	IMG VARBINARY(MAX),
	MaSV VARCHAR(6),
	FileIMG NVARCHAR(100)
	FOREIGN KEY (MaSV) REFERENCES dbo.SinhVien (MaSV) 
)

CREATE TABLE DiemHP
(
	MaSV VARCHAR(6),
	MaMonHP VARCHAR(6),
	ChuyenCan FLOAT,
	GiuaKi FLOAT,
	DiemLan1 FLOAT,
	DiemLan2 FLOAT,
	--DiemChu CHAR(1),
	--XepLoai NVARCHAR(10),   dùng class trong C#
	--KetQua VARCHAR(10),
	GhiChu NVARCHAR(50)

	PRIMARY KEY (MaSV, MaMonHP)
	FOREIGN KEY (MaSV) REFERENCES dbo.SinhVien (MaSV),
	FOREIGN KEY (MaMonHP) REFERENCES dbo.MonHP (MaMonHP)
)
GO

CREATE TABLE GiaoVien
(
	ID SMALLINT IDENTITY(1,1),
	MaGV AS ('GV' + RIGHT('0000' + CAST(ID AS VARCHAR(4)),4)) PERSISTED PRIMARY KEY,
	TenGV NVARCHAR(40),
	TrinhDo NVARCHAR(10),
	NgaySinh DATETIME,
	GioiTinh NCHAR(4),
	NoiSinh NVARCHAR(30),
	DanToc NVARCHAR(20),
	ChucVu NVARCHAR(20),
)
GO

CREATE TABLE GV_PhanCong
(
	MaGV VARCHAR(6),
	MaMonHP VARCHAR(6),
	MaLop VARCHAR(6)

	PRIMARY KEY (MaGV, MaMonHP, MaLop)
	FOREIGN KEY (MaGV) REFERENCES dbo.GiaoVien (MaGV),
	FOREIGN KEY (MaMonHP) REFERENCES dbo.MonHP (MaMonHP),
	FOREIGN KEY (MaLop) REFERENCES dbo.Lop (MaLop)
)

CREATE TABLE GiaoVien_HinhAnh
(
	ID SMALLINT IDENTITY(1,1),
	GV_IMG AS ('IMG' + RIGHT('0000' + CAST(ID AS VARCHAR(5)),5)) PERSISTED PRIMARY KEY,
	IMG VARBINARY(MAX),
	MaGV VARCHAR(6),
	FileIMG2 NVARCHAR(100)
	FOREIGN KEY (MaGV) REFERENCES dbo.GiaoVien (MaGV) 
)
GO

CREATE TABLE PhanCong
(
	MaGV VARCHAR(6),
	MaMonHP VARCHAR(6),
	MaLop VARCHAR(6)

	PRIMARY KEY (MaGV, MaMonHP, MaLop)
	FOREIGN KEY (MaGV) REFERENCES dbo.GiaoVien (MaGV),
	FOREIGN KEY (MaMonHP) REFERENCES dbo.MonHP (MaMonHP),
	FOREIGN KEY (MaLop) REFERENCES dbo.Lop (MaLop)
)
GO
-----------------------------------

INSERT TinhTrang VALUES (N'Đang học')
INSERT TinhTrang VALUES (N'Nghỉ học')
INSERT TinhTrang VALUES (N'Bảo lưu')

INSERT HeDaoTao VALUES (N'Chính quy')
INSERT HeDaoTao VALUES (N'Vừa học vừa làm')
INSERT HeDaoTao VALUES (N'Ban đêm')

INSERT Lop (TenLop, MaHe) VALUES (N'K15CNTT', N'DT0001')
INSERT Lop (TenLop, MaHe) VALUES (N'K14CNTT', N'DT0001')

INSERT HocKy VALUES (N'Học kỳ 1')
INSERT HocKy VALUES (N'Học kỳ 2')
INSERT HocKy VALUES (N'Học kỳ 3')
INSERT HocKy VALUES (N'Học kỳ 4')
INSERT HocKy VALUES (N'Học kỳ 5')
INSERT HocKy VALUES (N'Học kỳ 6')
INSERT HocKy VALUES (N'Học kỳ 7')

INSERT MonHP (TenMonHP, SoTin, TietLT, TietTH, MaHK) VALUES (N'Giáo dục Quốc phòng và An ninh (*)', 0, 0, 30, N'HK0004')
INSERT MonHP (TenMonHP, SoTin, TietLT, TietTH, MaHK) VALUES (N'Chính trị', 4, 45, 30, N'HK0004')
INSERT MonHP (TenMonHP, SoTin, TietLT, TietTH, MaHK) VALUES (N'Tiếng Anh B1.1', 3, 30, 30, N'HK0004')
INSERT MonHP (TenMonHP, SoTin, TietLT, TietTH, MaHK) VALUES (N'Các hệ cơ sở dữ liệu', 3, 30, 30, N'HK0004')
INSERT MonHP (TenMonHP, SoTin, TietLT, TietTH, MaHK) VALUES (N'Lập trình .Net', 4, 45, 30, N'HK0004')
INSERT MonHP (TenMonHP, SoTin, TietLT, TietTH, MaHK) VALUES (N'Công nghệ phần mềm', 3, 30, 30, N'HK0004')
INSERT MonHP (TenMonHP, SoTin, TietLT, TietTH, MaHK) VALUES (N'PHP MySQL', 3, 30, 30, N'HK0005')
INSERT MonHP (TenMonHP, SoTin, TietLT, TietTH, MaHK) VALUES (N'Đồ án 1', 1, 0, 0, N'HK0005')
INSERT MonHP (TenMonHP, SoTin, TietLT, TietTH, MaHK) VALUES (N'Kiểm thử phần mềm', 3, 30, 30, N'HK0005')
INSERT MonHP (TenMonHP, SoTin, TietLT, TietTH, MaHK) VALUES (N'Phân tích thiết kế hướng đối tượng UML', 2, 15, 30, N'HK0005')
INSERT MonHP (TenMonHP, SoTin, TietLT, TietTH, MaHK) VALUES (N'Tiếng Anh B1.2', 3, 30, 30, N'HK0005')
INSERT MonHP (TenMonHP, SoTin, TietLT, TietTH, MaHK) VALUES (N'Thực tập nghề nghiệp', 1, 0, 45, N'HK0005')

INSERT SinhVien (HoLot, Ten, NgaySinh, GioiTinh, NoiSinh, DanToc, MaLop, MaTinhTrang) VALUES (N'Nguyễn Hoàng', N'Thanh', '1995-01-25', N'Nam ', N'Đồng Nai', N'Kinh', N'L00001', N'T00001')
INSERT SinhVien (HoLot, Ten, NgaySinh, GioiTinh, NoiSinh, DanToc, MaLop, MaTinhTrang) VALUES (N'Nguyễn Hoài', N'Anh', '2001-02-06', N'Nam ', N'Đồng Nai', N'Kinh', N'L00001', N'T00001')
INSERT SinhVien (HoLot, Ten, NgaySinh, GioiTinh, NoiSinh, DanToc, MaLop, MaTinhTrang) VALUES (N'Trần Tiến ', N'Đạt', '2001-03-19', N'Nam ', N'Đồng Nai', N'Kinh', N'L00001', N'T00001')
INSERT SinhVien (HoLot, Ten, NgaySinh, GioiTinh, NoiSinh, DanToc, MaLop, MaTinhTrang) VALUES (N'Đặng Sơn Ngọc Cát ', N'Phượng', '2001-07-04', N'Nữ  ', N'Đồng Nai', N'Kinh', N'L00001', N'T00001')
INSERT SinhVien (HoLot, Ten, NgaySinh, GioiTinh, NoiSinh, DanToc, MaLop, MaTinhTrang) VALUES (N'Dương Triệu', N'Vy', '2002-10-12', N'Nữ  ', N'Đồng Nai', N'Kinh', N'L00001', N'T00001')

INSERT DiemHP (MaSV, MaMonHP, ChuyenCan, GiuaKi, DiemLan1, DiemLan2, GhiChu) VALUES (N'190001', N'HP0001', NULL, NULL, 8.5, NULL, NULL)
INSERT DiemHP (MaSV, MaMonHP, ChuyenCan, GiuaKi, DiemLan1, DiemLan2, GhiChu) VALUES (N'190001', N'HP0004', 10, 10, 9, NULL, NULL)
INSERT DiemHP (MaSV, MaMonHP, ChuyenCan, GiuaKi, DiemLan1, DiemLan2, GhiChu) VALUES (N'190001', N'HP0005', 9, 9, 8, NULL, NULL)
INSERT DiemHP (MaSV, MaMonHP, ChuyenCan, GiuaKi, DiemLan1, DiemLan2, GhiChu) VALUES (N'190001', N'HP0006', 10, 10, 10, NULL, NULL)
INSERT DiemHP (MaSV, MaMonHP, ChuyenCan, GiuaKi, DiemLan1, DiemLan2, GhiChu) VALUES (N'190002', N'HP0001', NULL, NULL, 9, NULL, NULL)
INSERT DiemHP (MaSV, MaMonHP, ChuyenCan, GiuaKi, DiemLan1, DiemLan2, GhiChu) VALUES (N'190002', N'HP0004', 9, 9, 7, NULL, NULL)
INSERT DiemHP (MaSV, MaMonHP, ChuyenCan, GiuaKi, DiemLan1, DiemLan2, GhiChu) VALUES (N'190002', N'HP0005', 7, 7, 9, NULL, NULL)
INSERT DiemHP (MaSV, MaMonHP, ChuyenCan, GiuaKi, DiemLan1, DiemLan2, GhiChu) VALUES (N'190002', N'HP0006', 6, 4, 10, NULL, NULL)
INSERT DiemHP (MaSV, MaMonHP, ChuyenCan, GiuaKi, DiemLan1, DiemLan2, GhiChu) VALUES (N'190004', N'HP0001', NULL, NULL, 6, NULL, NULL)
INSERT DiemHP (MaSV, MaMonHP, ChuyenCan, GiuaKi, DiemLan1, DiemLan2, GhiChu) VALUES (N'190004', N'HP0004', 9, 5, 7, NULL, NULL)
INSERT DiemHP (MaSV, MaMonHP, ChuyenCan, GiuaKi, DiemLan1, DiemLan2, GhiChu) VALUES (N'190005', N'HP0001', NULL, NULL, 7, NULL, NULL)
INSERT DiemHP (MaSV, MaMonHP, ChuyenCan, GiuaKi, DiemLan1, DiemLan2, GhiChu) VALUES (N'190005', N'HP0004', 8, 5, 10, NULL, NULL)
INSERT DiemHP (MaSV, MaMonHP, ChuyenCan, GiuaKi, DiemLan1, DiemLan2, GhiChu) VALUES (N'190003', N'HP0001', NULL, NULL, 9, NULL, NULL)
INSERT DiemHP (MaSV, MaMonHP, ChuyenCan, GiuaKi, DiemLan1, DiemLan2, GhiChu) VALUES (N'190003', N'HP0004', 7, 6, 7, NULL, NULL)

----------------------------------------------------------------------------------------------------------------------------
-- Trigger
CREATE TRIGGER UpdateMaSVToSVHA ON dbo.SinhVien
AFTER INSERT
AS
BEGIN
DECLARE @MaSV VARCHAR(6)
SELECT @MaSV = a.MaSV FROM Inserted a
INSERT INTO dbo.SinhVien_HinhAnh(MaSV) VALUES (@MaSV)

END

CREATE TRIGGER UpdateMaGVToGVHA ON dbo.GiaoVien
AFTER INSERT
AS
BEGIN
DECLARE @MaGV VARCHAR(6)
SELECT @MaGV = a.MaGV FROM Inserted a
INSERT INTO dbo.GiaoVien_HinhAnh(MaGV) VALUES (@MaGV)

END
-------------

CREATE PROC TinhTrangInsert
@TinhTrang NVARCHAR(20)
AS
BEGIN
	INSERT TinhTrang (TinhTrang) VALUES (@TinhTrang)
END
GO

CREATE PROC TinhTrangUpdate
@MaTinhTrang VARCHAR(6),
@TinhTrang NVARCHAR(20)
AS
BEGIN
	UPDATE TinhTrang SET TinhTrang = @TinhTrang WHERE MaTinhTrang = @MaTinhTrang
END
GO

CREATE PROC TinhTrangDelete
@MaTinhTrang VARCHAR(6)
AS
BEGIN
	DELETE FROM dbo.TinhTrang WHERE MaTinhTrang = @MaTinhTrang
END
GO

CREATE PROC HeDaoTaoInsert
@TenHe NVARCHAR(20)
AS
BEGIN
	INSERT HeDaoTao (TenHe) VALUES (@TenHe)
END
GO

CREATE PROC HeDaoTaoUpdate
@MaHe VARCHAR(6),
@TenHe NVARCHAR(20)
AS
BEGIN
	UPDATE dbo.HeDaoTao SET TenHe = @TenHe WHERE MaHe = @MaHe
END
GO

CREATE PROC HeDaoTaoDelete
@MaHe VARCHAR(6)
AS
BEGIN
	DELETE FROM dbo.HeDaoTao WHERE MaHe = @MaHe
END
GO

CREATE PROC HocKyInsert
@TenHK NCHAR(8)
AS
BEGIN
	INSERT HocKy (TenHK) VALUES (@TenHK)
END
GO

CREATE PROC HocKyUpdate
@MaHK VARCHAR(6),
@TenHK NCHAR(8)
AS
BEGIN
	UPDATE dbo.HocKy SET TenHK = @TenHK WHERE MaHK = @MaHK
END
GO

CREATE PROC HocKyDelete
@MaHK VARCHAR(6)
AS
BEGIN
	DELETE dbo.HocKy WHERE MaHK = @MaHK
END
GO

CREATE PROC LopInsert
@TenLop CHAR(7),
@MaHe VARCHAR(6)
AS
BEGIN
	INSERT Lop (TenLop, MaHe) VALUES (@TenLop, @MaHe)
END
GO

CREATE PROC LopUpdate
@MaLop VARCHAR(6),
@TenLop CHAR(7)
AS
BEGIN
	UPDATE Lop SET TenLop = @TenLop WHERE MaLop = @MaLop
END
GO

CREATE PROC LopDelete
@MaLop VARCHAR(6)
AS
BEGIN
	DELETE FROM dbo.Lop WHERE MaLop = @MaLop
END
GO

CREATE PROC DiemHPInsert
@MaSV VARCHAR(6),
@MaMonHP VARCHAR(6),
@ChuyenCan FLOAT,
@GiuaKi FLOAT,
@DiemLan1 FLOAT,
@GhiChu NVARCHAR(50)
AS
BEGIN
	INSERT DiemHP (MaSV, MaMonHP, ChuyenCan, GiuaKi, DiemLan1, GhiChu)  VALUES (@MaSV, @MaMonHP, @ChuyenCan, @GiuaKi, @DiemLan1, @GhiChu)
END
GO

CREATE PROC DiemHPInsert_1
@MaMonHP VARCHAR(6),
@MaSV VARCHAR(6)
AS
BEGIN
	INSERT DiemHP (MaMonHP, MaSV)  VALUES (@MaMonHP, @MaSV)
END
GO

CREATE PROC DiemHPUpdate
@MaSV VARCHAR(6),
@MaMonHP VARCHAR(6),
@ChuyenCan FLOAT,
@GiuaKi FLOAT,
@DiemLan1 FLOAT,
@GhiChu NVARCHAR(50)
AS
BEGIN
	UPDATE dbo.DiemHP SET ChuyenCan = @ChuyenCan, GiuaKi = @GiuaKi, DiemLan1 = @DiemLan1, GhiChu = @GhiChu WHERE MaSV = @MaSV AND MaMonHP = @MaMonHP
END
GO

CREATE PROC DiemHPDelete
@MaSV VARCHAR(6),
@MaMonHP VARCHAR(6)
AS
BEGIN
	DELETE FROM dbo.DiemHP WHERE MaSV = @MaSV AND MaMonHP = @MaMonHP
END
GO

CREATE PROC MonHPInsert 'afaf', '', '', '', 'HK0001'
@TenMonHP NVARCHAR(50),
@SoTin TINYINT,
@TietLT TINYINT,
@TietTH TINYINT,
@MaHK VARCHAR(6)
AS
BEGIN
	INSERT MonHP (TenMonHP, SoTin, TietLT, TietTH, MaHK) VALUES (@TenMonHP, CASE WHEN (@SoTin) IS NULL OR (@SoTin) = '' THEN 0 ELSE (@SoTin) END, CASE WHEN (@TietLT) IS NULL OR (@TietLT) = '' THEN 0 ELSE (@TietLT) END, CASE WHEN (@TietTH) IS NULL OR (@TietTH) = '' THEN 0 ELSE (@TietTH) END, @MaHK)
END
GO

CREATE PROC MonHPUpdate
@MaMonHP VARCHAR(6),
@TenMonHP NVARCHAR(50),
@SoTin TINYINT,
@TietLT TINYINT,
@TietTH TINYINT
AS
BEGIN
	UPDATE dbo.MonHP SET TenMonHP = @TenMonHP, SoTin = @SoTin, TietLT = @TietLT, TietTH = @TietTH WHERE MaMonHP = @MaMonHP
END
GO

CREATE PROC MonHPDelete
@MaMonHP VARCHAR(6)
AS
BEGIN
	DELETE FROM dbo.MonHP WHERE MaMonHP = @MaMonHP
END
GO

CREATE PROC MonHPOnlySelect
@MaMonHP VARCHAR(6)
AS
BEGIN
	SELECT * FROM dbo.MonHP WHERE MaMonHP = @MaMonHP
END
GO

CREATE PROC MonHPSelectBySV
@MaSV VARCHAR(6)
AS
BEGIN
	SELECT dbo.MonHP.* FROM dbo.MonHP LEFT JOIN dbo.DiemHP ON DiemHP.MaMonHP = MonHP.MaMonHP
	WHERE MaSV = @MaSV
END

CREATE PROC SinhVienInsert 
@HoLot NVARCHAR(30),
@Ten NVARCHAR(7),
@NgaySinh DATETIME,
@GioiTinh NCHAR(4),
@NoiSinh NVARCHAR(30),
@DanToc NVARCHAR(20),
@MaLop VARCHAR(6),
@MaTinhTrang VARCHAR(6)
AS
BEGIN
	INSERT SinhVien (HoLot, Ten, NgaySinh, GioiTinh, NoiSinh, DanToc, MaLop, MaTinhTrang) VALUES (@HoLot, @Ten, @NgaySinh, @GioiTinh, @NoiSinh, @DanToc, @MaLop, CASE WHEN (@MaTinhTrang) IS NULL OR (@MaTinhTrang = '') THEN 'T00001' ELSE (@MaTinhTrang) END)
END
GO

CREATE PROC SinhVienInsert_1 
@HoLot NVARCHAR(30),
@Ten NVARCHAR(7),
@NgaySinh DATETIME,
@GioiTinh NCHAR(4),
@NoiSinh NVARCHAR(30),
@DanToc NVARCHAR(20),
@MaLop VARCHAR(6)
AS
BEGIN
	INSERT SinhVien (HoLot, Ten, NgaySinh, GioiTinh, NoiSinh, DanToc, MaLop) VALUES (@HoLot, @Ten, @NgaySinh, @GioiTinh, @NoiSinh, @DanToc, @MaLop)
END
GO

----8	190008	Trần Tiến 	Đạt	2001-03-19 00:00:00.000	Nam 	Đồng Nai	Kinh	L00002	T00001
--SinhVienUpdate '190008', N'Trần Tiến', N'Đạt', '2001-2-22', N'Nữ', N'Đồng Nai 2', N'Kinh 2' 

CREATE PROC SinhVienUpdate 
@MaSV VARCHAR(6),
@HoLot NVARCHAR(30),
@Ten NVARCHAR(7),
@NgaySinh DATETIME,
@GioiTinh NCHAR(4),
@NoiSinh NVARCHAR(30),
@DanToc NVARCHAR(20)
AS
BEGIN
	UPDATE dbo.SinhVien SET HoLot = @HoLot, Ten = @Ten, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, NoiSinh = @NoiSinh, DanToc = @DanToc WHERE MaSV = @MaSV
END
GO

CREATE PROC SinhVienDelete
@MaSV VARCHAR(6)
AS
BEGIN
	DELETE FROM dbo.SinhVien WHERE MaSV = @MaSV
END
GO

CREATE PROC LopSelectAll
AS
BEGIN
	SELECT * FROM dbo.Lop
END
GO

CREATE PROC LopSelectALLByHe
@MaHe VARCHAR(6)
AS
BEGIN
	SELECT * FROM dbo.Lop WHERE MaHe = @MaHe 
END
GO

CREATE PROC SinhVienSelectAllByLop
@MaLop VARCHAR(6)
AS
BEGIN
	SELECT * FROM dbo.SinhVien WHERE MaLop = @MaLop
END
GO

CREATE PROC SinhVienSelectAll
AS
BEGIN
	SELECT * FROM dbo.SinhVien
END
GO

CREATE PROC SinhVienSelectCheckNew
@HoLot NVARCHAR(30),
@Ten NVARCHAR(7)
AS
BEGIN
	SELECT dbo.SinhVien.HoLot, dbo.SinhVien.Ten, dbo.SinhVien.NgaySinh, dbo.SinhVien.GioiTinh, dbo.SinhVien.NoiSinh, dbo.SinhVien.DanToc FROM dbo.SinhVien
END
GO

CREATE PROC SinhVienSelectAllByID
@MaSV VARCHAR(6)
AS
BEGIN
	SELECT MaSV, HoLot + ' ' + Ten [HoTen], NgaySinh, GioiTinh, NoiSinh, DanToc FROM dbo.SinhVien WHERE MaSV = @MaSV
END
GO

CREATE PROC SinhVienSelectAllByLopDetail
@MaLop VARCHAR(6)
AS
BEGIN
	SELECT MaSV, HoLot + ' ' + Ten [HoTen], NgaySinh, GioiTinh, NoiSinh, DanToc FROM dbo.SinhVien WHERE MaLop = @MaLop
END
GO

CREATE PROC SinhVienSelectAllDetail
AS
BEGIN
	SELECT MaSV, HoLot + ' ' + Ten [HoTen], NgaySinh, GioiTinh, NoiSinh, DanToc FROM dbo.SinhVien 
END
GO

CREATE PROC SinhVienSelectAllDetail_1
AS
BEGIN
	SELECT MaSV, HoLot, Ten, NgaySinh, GioiTinh, NoiSinh, DanToc FROM dbo.SinhVien 
END
GO

CREATE PROC MonHPSelectAll
AS
BEGIN
	SELECT * FROM dbo.MonHP
END
GO

CREATE PROC HeSelectALL
AS
BEGIN
	SELECT * FROM dbo.HeDaoTao
END
GO

CREATE PROC HKSelectALL
AS
BEGIN
	SELECT * FROM dbo.HocKy
END
GO

CREATE PROC SinhVienHA_SelectALL
AS
BEGIN
	SELECT a.FileIMG, a.MaSV, a.SV_IMG, a.IMG, b.HoLot + ' ' + b.Ten [HoTenSV] FROM dbo.SinhVien_HinhAnh a
	RIGHT JOIN dbo.SinhVien b ON b.MaSV = a.MaSV 
END
GO

CREATE PROC SinhVienHA_SelectByLop
@MaLop VARCHAR(6)
AS
BEGIN
	SELECT a.FileIMG, a.MaSV, a.SV_IMG, a.IMG, b.HoLot + ' ' + b.Ten [HoTenSV] FROM dbo.SinhVien_HinhAnh a
	RIGHT JOIN dbo.SinhVien b ON b.MaSV = a.MaSV 
	RIGHT JOIN dbo.Lop c ON c.MaLop = b.MaLop
	WHERE b.MaLop = @MaLop
END
GO

CREATE PROC SinhVienHA_Update
@SV_IMG VARCHAR(8),
@IMG VARBINARY(MAX),
@FileIMG NVARCHAR(100)
AS
BEGIN
	UPDATE dbo.SinhVien_HinhAnh SET IMG = @IMG, FileIMG = @FileIMG WHERE SV_IMG = @SV_IMG
END
GO

CREATE PROC MonHP_SelectByHK
@MaHK VARCHAR(6)
AS
BEGIN
	SELECT * FROM dbo.MonHP WHERE dbo.MonHP.MaHK  = @MaHK
END
GO

CREATE PROC DiemHPSearch
@MaMonHP VARCHAR(6),
@MaSV VARCHAR(6)
AS
BEGIN
	SELECT dbo.DiemHP.*, SoTin FROM dbo.DiemHP
	LEFT JOIN dbo.MonHP ON MonHP.MaMonHP = DiemHP.MaMonHP
	WHERE MaSV = @MaSV AND dbo.DiemHP.MaMonHP = @MaMonHP
END
GO

CREATE PROC BangDiemHP
@MaLop VARCHAR(6),
@MaMonHP VARCHAR(6)
AS
BEGIN
	SELECT s.MaSV, s.HoLot + ' ' + s.Ten [HoTenSV], s.NgaySinh, hp.ChuyenCan, hp.GiuaKi, hp.DiemLan1, hp.DiemLan2, hp.GhiChu 
	FROM dbo.SinhVien s LEFT JOIN dbo.DiemHP hp ON  hp.MaSV = s.MaSV
	WHERE s.MaLop = @MaLop AND hp.MaMonHP = @MaMonHP
END
GO

ALTER PROC DiemLan1Update
@ChuyenCan FLOAT,
@GiuaKi FLOAT,
@DiemLan1 FLOAT,
@MaSV VARCHAR(6),
@MaMonHP VARCHAR(6)
AS
BEGIN
	UPDATE dbo.DiemHP SET ChuyenCan = @ChuyenCan, GiuaKi = @GiuaKi, DiemLan1 = @DiemLan1
	WHERE MaSV = @MaSV AND MaMonHP = @MaMonHP
END
GO

CREATE PROC ThongTinUpdate
@MaThongTin VARCHAR(6),
@DonViChuQuan NVARCHAR(200),
@TenTruong NVARCHAR(200),
@Tinh NVARCHAR(50),
@KhoaHoc VARCHAR(20),
@NganhHoc NVARCHAR(50),
@ChuyenNganh NVARCHAR(50)
AS
BEGIN
	UPDATE dbo.ThongTin SET Tinh = @Tinh, DonViChuQuan = @DonViChuQuan, TenTruong = @TenTruong, KhoaHoc = @KhoaHoc, NganhHoc = @NganhHoc, ChuyenNganh = @ChuyenNganh
	WHERE MaThongTin = @MaThongTin
END
GO












