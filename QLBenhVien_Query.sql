-- TẠO CƠ SỞ DỮ LIỆU
CREATE DATABASE QuanLyBenhVien
ON PRIMARY 
(
	NAME = QLBV_Data,
	FILENAME = 'D:\HQTCSDL\BuiXuanHieu\QLBV_Data.mdf',
	SIZE = 10 MB,
	MAXSIZE = 50 MB,
	FILEGROWTH = 2 MB
)
LOG ON
(
	NAME = QLBenhVien_Log,
	FILENAME = 'D:\HQTCSDL\BuiXuanHieu\QLBV_Log.ldf',
	SIZE = 5 MB,
	MAXSIZE = 20MB,
	FILEGROWTH = 1 MB
)

--TẠO CÁC BẢNG 
CREATE TABLE KHOA
(
	MaKhoa	NVARCHAR(10) PRIMARY KEY,
	TenKhoa	NVARCHAR(30),
	SoNhanVien INT
)
ALTER TABLE KHOA
ADD CONSTRAINT DF_KHOA DEFAULT(0) FOR SoNhanVien

CREATE TABLE NHANVIEN
(
	MaNV	NVARCHAR(10) PRIMARY KEY,
	TenNV NVARCHAR(30),
	GioiTinh	NVARCHAR(10),
	NgaySinh	DATE,
	ChucVu		NVARCHAR(10),
	MaKhoa		NVARCHAR(10),
	DiaChi		NVARCHAR(30),
	
	CONSTRAINT CK_GioiTinh_NV CHECK (GioiTinh = N'Nam' OR GioiTinh = N'Nữ'),
	
	CONSTRAINT	FK_NV_MaKhoa
	FOREIGN KEY (MaKhoa) REFERENCES KHOA (MaKhoa) 
)

CREATE TABLE BENHNHAN
(
	MaBN	NVARCHAR(10) PRIMARY KEY,
	TenBN NVARCHAR(30),
	GioiTinh	NVARCHAR(10),
	NgaySinh	DATE,
	NgayKhamBenh	DATE,
	DiaChi		NVARCHAR(30),
	
	CONSTRAINT CK_GioiTinh_BN CHECK (GioiTinh = N'Nam' OR GioiTinh = N'Nữ')
)
alter table BENHAN add NgayKhamBenh date

CREATE TABLE DICHVU
(
	MaDV	NVARCHAR(10) PRIMARY KEY,
	TenDV	NVARCHAR(30),
	GiaDV	FLOAT	
)

CREATE TABLE NHACUNGCAP
(
	MaNCC	NVARCHAR(10) PRIMARY KEY,
	TenNCC	NVARCHAR(30),
	DiaChi	NVARCHAR(20)
)

CREATE TABLE THUOC
(
	MaThuoc	NVARCHAR(10) PRIMARY KEY,
	TenThuoc	NVARCHAR(30),
	MaNCC	NVARCHAR(10),
	SLCon	INT,
	GiaThuoc FLOAT,
	
	CONSTRAINT	FK_Thuoc_MaNCC
	FOREIGN KEY (MaNCC) REFERENCES NHACUNGCAP (MaNCC)
)

CREATE TABLE BENHAN
(
	MaBA	NVARCHAR(10) PRIMARY KEY,
	MaBN	NVARCHAR(10),
	MaNV	NVARCHAR(10),
	MaDV	NVARCHAR(10),
	ChanDoan	NVARCHAR(50),
	
	CONSTRAINT	FK_BA_MaBN
	FOREIGN KEY (MaBN) REFERENCES BENHNHAN (MaBN),
	
	CONSTRAINT	FK_BA_MaNV
	FOREIGN KEY (MaNV) REFERENCES NHANVIEN (MaNV),
	
	CONSTRAINT	FK_BA_MaDV
	FOREIGN KEY (MaDV) REFERENCES DICHVU (MaDV)
)

CREATE TABLE DONTHUOC
(
	MaDT	NVARCHAR(10) PRIMARY KEY,
	MaBA	NVARCHAR(10),
	MaThuoc	NVARCHAR(10),
	SoLuong	INT,
	
	CONSTRAINT	FK_DT_MaBA
	FOREIGN KEY (MaBA) REFERENCES BENHAN (MaBA),
	
	CONSTRAINT	FK_DT_MaThuoc
	FOREIGN KEY (MaThuoc) REFERENCES THUOC (MaThuoc)
)

CREATE TABLE HOADON
(
	
	MaDT	NVARCHAR(10),
	MaBA	NVARCHAR(10),
	TongTien	FLOAT,
	
	CONSTRAINT	FK_HD_MaDT
	FOREIGN KEY (MaDT) REFERENCES DONTHUOC (MaDT),
	
	CONSTRAINT	FK_HD_MaBA
	FOREIGN KEY (MaBA) REFERENCES BENHAN (MaBA),
	PRIMARY KEY(MaDT,MaBA)
)

--ĐỔ DỮ LIỆU
INSERT INTO KHOA(MaKhoa,TenKhoa,SoNhanVien)
VALUES  (N'K001',N'Khoa Nội',10),
		(N'K002',N'Khoa Ngoại',10),
		(N'K003',N'Khoa Nhi',10),
		(N'K004',N'Khoa Sản',10),
		(N'K005',N'Khoa Tai Mũi Họng',10)

INSERT INTO NHANVIEN(MaNV,MaKhoa,TenNV,GioiTinh,NgaySinh,DiaChi,ChucVu)
VALUES  (N'NV001',N'K001',N'Nguyễn Văn A',N'Nam','10/25/1980',N'Đống Đa - Hà Nội',N'Bác Sĩ'),
		(N'NV002',N'K001',N'Nguyễn Thị B',N'Nữ','9/22/1981',N'Ba Đình - Hà Nội',N'Y Tá'),
		(N'NV003',N'K002',N'Đinh Văn C',N'Nam','5/10/1995',N'Đống Đa - Hà Nội',N'Bác Sĩ'),
		(N'NV004',N'K002',N'Trần Thị D',N'Nữ','10/25/1997',N'Đống Đa - Hà Nội',N'Y Tá'),
		(N'NV005',N'K003',N'Nguyễn Văn E',N'Nam','11/25/1990',N'Đống Đa - Hà Nội',N'Bác Sĩ'),
		(N'NV006',N'K003',N'Vũ Văn F',N'Nam','10/10/1988',N'Đống Đa - Hà Nội',N'Bác Sĩ'),
		(N'NV007',N'K004',N'Nguyễn Thị G',N'Nữ','7/31/1970',N'Đống Đa - Hà Nội',N'Bác Sĩ'),
		(N'NV008',N'K004',N'Lê Văn H',N'Nam','10/15/1984',N'Đống Đa - Hà Nội',N'Bác Sĩ')
		
INSERT INTO DICHVU(MaDV,TenDV,GiaDV)
VALUES  (N'DV001',N'Chụp X-Quang',120000),
		(N'DV002',N'Chụp CT',1000000),
		(N'DV003',N'Nội Soi Dạ Dày',300000),
		(N'DV004',N'Nội Soi Dạ Dày Gây Mê',1300000),
		(N'DV005',N'Siêu Âm',100000)
		
INSERT INTO NHACUNGCAP(MaNCC,TenNCC,DiaChi)
VALUES  (N'NCC001',N'Dược TW3','Hà Nội'),
		(N'NCC002',N'Dược Tuệ Linh','Hà Nội'),
		(N'NCC003',N'Dược VinaCare','Hà Nội'),
		(N'NCC004',N'Dược Nhất Nhất','Hà Nội'),
		(N'NCC005',N'Dược Sao Thái Dương','Hà Nội')

INSERT INTO THUOC(MaThuoc,MaNCC,TenThuoc,GiaThuoc,SLCon)
VALUES  (N'T001',N'NCC001',N'DATADOL EXTRA',180000,1000),
		(N'T002',N'NCC001',N'CETECO DAMUC',100000,800),
		(N'T003',N'NCC002',N'Giải Độc Gan Tuệ Linh',300000,1000),
		(N'T004',N'NCC002',N'Giảo Cổ Lam Tuệ Linh',200000,1000),
		(N'T005',N'NCC003',N'Oremute 20',50000,1000),
		(N'T006',N'NCC003',N'Azecifex',20000,1000),
		(N'T007',N'NCC004',N'Hoạt Huyết Nhất Nhất',90000,1000),
		(N'T008',N'NCC004',N'Xương Khớp Nhất Nất',180000,1000),
		(N'T009',N'NCC005',N'Thuốc Xịt Mũi Thái Dương',50000,1000),
		(N'T010',N'NCC005',N'Bổ Tỳ Dưỡng Cốt',50000,1000)

-------------------------------------------------------------------------------------------------------------
--Bảo Mật & Phân Quyền
sp_addlogin 'thanhthuy505','Hieu9add1'
exec sp_grantdbaccess 'thanhthuy505','HIEU'
-------------------------------------------------------------------------------------------------------------
--HÀM TÍNH TIỀN THUỐC
CREATE FUNCTION f_TienThuoc ( @a nvarchar(10))
RETURNS FLOAT
AS
BEGIN
DECLARE @RT FLOAT
SET @RT = (SELECT DONTHUOC.SoLuong*THUOC.GiaThuoc
			FROM DONTHUOC,THUOC
			WHERE THUOC.MaThuoc=DONTHUOC.MaThuoc
			AND DONTHUOC.MaDT=@a)
RETURN @RT
END

-------------------------------------------------------------------------------------------------------------
--BỘ THỦ TỤC NHẬP DỮ LIỆU CHO CÁC BẢNG
--THỦ TỤC NHẬP DỮ LIỆU CHO BẢNG KHOA
CREATE PROC sp_Khoa_in
@ma nvarchar(10),@ten nvarchar(30),@SL int
AS
BEGIN
INSERT INTO KHOA(MaKhoa,TenKhoa,SoNhanVien)
VALUES(@ma,@ten,@SL)
END
--NHẬP DỮ LIỆU CHO BẢNG NHANVIEN
CREATE PROC sp_NhanVien_in
@MaNV nvarchar(10),@MaKhoa nvarchar(10),@Ten nvarchar(30),@GT nvarchar(10),@NS date,@DiaChi nvarchar(30),@ChucVu nvarchar(10)
AS
BEGIN
INSERT INTO NHANVIEN(MaNV,MaKhoa,TenNV,GioiTinh,NgaySinh,DiaChi,ChucVu)
VALUES(@MaNV,@MaKhoa,@Ten,@GT,@NS,@DiaChi,@ChucVu)
END
--THỦ TỤC CẬP NHẬT BẢNG NHÂN VIÊN
CREATE PROC sp_NhanVien_update
@MaNV nvarchar(10),@MaKhoa nvarchar(10),@Ten nvarchar(30),@GT nvarchar(10),@NS date,@DiaChi nvarchar(30),@ChucVu nvarchar(10)
AS
BEGIN
UPDATE NHANVIEN SET TenNV=@Ten,GioiTinh=@GT,NgaySinh=@NS,DiaChi=@DiaChi,ChucVu=@ChucVu,MaKhoa=@MaKhoa
WHERE MaNV=@MaNV
END
------------------------------------------------------------------------------------------------------------
--THỦ TỤC KHÁM BỆNH(TẠO BỆNH NHÂN, BỆNH ÁN)
CREATE PROC sp_KhamBenh
@MaBN nvarchar(10),@TenBN nvarchar(30),@GioiTinh nvarchar(10),@NgaySinh date,
@DiaChi nvarchar(30),@MaBA nvarchar(10),@MaNV nvarchar(10),@MaDV nvarchar(10)
AS
BEGIN
	INSERT INTO BENHNHAN(MaBN,TenBN,GioiTinh,NgaySinh,DiaChi)
	VALUES(@MaBN,@TenBN,@GioiTinh,@NgaySinh,@DiaChi)
	INSERT INTO BENHAN(MaBA,MaBN,MaNV,MaDV)
	VALUES(@MaBA,@MaBN,@MaNV,@MaDV)
END
--THỦ TỤC SỬA THÔNG TIN BỆNH NHÂN, BỆNH ÁN
CREATE PROC sp_KB_al
@MaBN nvarchar(10),@TenBN nvarchar(30),@GioiTinh nvarchar(10),@NgaySinh date,
@DiaChi nvarchar(30),@MaBA nvarchar(10),@MaNV nvarchar(10),@MaDV nvarchar(10)
AS
BEGIN
	UPDATE BENHNHAN SET TenBN=@TenBN,GioiTinh=@GioiTinh,NgaySinh=@NgaySinh,DiaChi=@DiaChi
	WHERE MaBN=@MaBN
	UPDATE BENHAN SET MaBN=@MaBN,MaNV=@MaNV,MaDV=@MaDV
	WHERE MaBA=@MaBA
END
--------------------------------------------------------------------------------
--TRIGGER
--TRIGGER CẬP NHẬT LƯỢNG THUỐC CÒN LẠI TRONG KHO SAU KHI TẠO ĐƠN THUỐC
CREATE TRIGGER in_trigger_Thuoc
ON DONTHUOC
FOR INSERT
AS
if((select SoLuong from inserted) is not null)
BEGIN
	UPDATE THUOC
	SET SLCon = (SELECT SLCon-SoLuong from THUOC,(select SoLuong,MaThuoc from inserted) as I where THUOC.MaThuoc=I.MaThuoc)
	from THUOC,(select MaThuoc from inserted) as I
	where THUOC.MaThuoc=I.MaThuoc	 
END


--TRIGGER TỰ ĐỘNG TÍNH TIỀN KHÁM BỆNH SAU KHI NHẬP HÓA ĐƠN
CREATE TRIGGER in_trigger_HD
ON HOADON
FOR INSERT
AS If((select MaBA from inserted) is not null)
begin
update HOADON
SET TongTien = (select DICHVU.GiaDV + dbo.f_TienThuoc(InS.MaDT)
				from DICHVU,BENHAN,DONTHUOC,(select MaDT,MaBA from inserted) as InS
				where DICHVU.MaDV = BENHAN.MaDV
				and BENHAN.MaBA = InS.MaBA
				and DONTHUOC.MaDT=InS.MaDT) 

end
drop trigger in_trigger_HD
--TRIGGER BỆNH ÁN
CREATE TRIGGER in_trigger_BA
ON BENHAN
FOR INSERT
AS IF((SELECT MaBA FROM inserted)IS NOT NULL)
BEGIN
IF((SELECT ChanDoan  from inserted) is null)
begin
update BENHAN
set ChanDoan=N'Không Có'
end
END
--TRIGGER TỰ NHẬP NGÀY KHÁM BỆNH
CREATE TRIGGER in_trigger_KB
ON BENHAN
FOR INSERT
AS IF((SELECT MaBN from inserted) is not null)
BEGIN
UPDATE BENHAN
SET NgayKhamBenh = GETDATE()
	from BENHAN,(select MaBA from inserted) as I
	where BENHAN.MaBA= I.MaBA
END

--------------------------------------------------------------------------
--VIEW
--VIEW THÔNG TIN BỆNH NHÂN
CREATE VIEW vw_ThongTinKhamBenh
AS
SELECT BENHNHAN.MaBN,BENHNHAN.TenBN,BENHNHAN.GioiTinh,BENHAN.NgayKhamBenh,BENHNHAN.NgaySinh,BENHNHAN.DiaChi,BENHAN.MaBA,BENHAN.MaNV,NHANVIEN.TenNV,DICHVU.MaDV,DICHVU.TenDV
FROM BENHAN,BENHNHAN,DICHVU,NHANVIEN
WHERE BENHAN.MaBN=BENHNHAN.MaBN
AND BENHAN.MaDV=DICHVU.MaDV
AND BENHAN.MaNV=NHANVIEN.MaNV
select * from vw_ThongTinKhamBenh
select * from DONTHUOC
