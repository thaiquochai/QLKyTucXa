CREATE DATABASE quanlythuvien
go
use quanlythuvien
go

CREATE TABLE sach
(
 masach nchar(10),
 nhande nvarchar(30),
 sotrang int,
 soluong int,
 namxb int,
 lanxb int,
 solanmuon int,
 loaisach nvarchar(30),
 nxb nvarchar(30),
 tacgia nvarchar(30),
 ngaynhap date,

 PRIMARY KEY(masach)
)

CREATE TABLE docgia
(
madocgia nchar(10),
hoten nvarchar(30),
ngaysinh date,
makhoa nchar(10),
diachi nvarchar(30),
ngaylapthe date

 PRIMARY KEY(madocgia)
)

CREATE TABLE khoa
(
 makhoa nchar(10),
 tenkhoa nvarchar(30),
 diachi nvarchar(30),
 sdt int,

  PRIMARY KEY(makhoa)
)

CREATE TABLE  nhanvien
(
manhanvien nchar(10),
hoten nvarchar(30),
diachi nvarchar(30),
tendangnhap nvarchar(30),
matkhau nvarchar(30),
quyenhan nvarchar(30)

 PRIMARY KEY(manhanvien)
)

CREATE TABLE  phieumuon
(
 maphieumuon nchar(10),
 madocgia nchar(10),
 ngaymuon date,
 masach nchar(10),
 manhanvien nchar(10),
 soluong int,

  PRIMARY KEY(maphieumuon)
)

--SACH

insert into sach values ('MASACH1',N'GDCD',139,15,2014,2,5,'SACH XA HOI',N'nxb1',N'tacgia1','2020/11/10')
insert into sach values ('MASACH2',N'TOAN',354,20,2014,2,5,'SACH TU NHIEN',N'nxb2',N'tacgia2','2019/05/09')
insert into sach values ('MASACH3',N'LY',124,27,2014,2,5,'SACH TU NHIEN',N'nxb3',N'tacgia3','2020/06/09')
insert into sach values ('MASACH4',N'HOA',69,9,2014,2,5,'SACH TU NHIEN',N'nxb4',N'tacgia4','2019/11/10')

--DOCGIA
INSERT INTO docgia values ('DOCGIA1',N'LE TUAN ANH','2000/11/15','MAKHOA 1',N'TANG 1','2021/10/12')
INSERT INTO docgia values ('DOCGIA2',N'VO THANH THONG','2000/10/28','MAKHOA 2',N'TANG 1','2021/09/11')
INSERT INTO docgia values ('DOCGIA3',N'BUI NGOC SON','2000/05/17','MAKHOA 3',N'TANG 2','2021/08/25')
INSERT INTO docgia values ('DOCGIA4',N'VANG MINH GIOI','2000/09/06','MAKHOA 4',N'TANG 3','2021/12/12')

--KHOA
INSERT INTO khoa values ('MAKHOA 1',N'KHOA HOC XA HOI','TANG 1',0355847082)
INSERT INTO khoa values ('MAKHOA 2',N'KHOA HOC TU NHIEN','TANG 1',0965847038)
INSERT INTO khoa values ('MAKHOA 3',N'KHOA HOC XA HOI','TANG 2',0353549082)
INSERT INTO khoa values ('MAKHOA 4',N'KHOA HOC TU NHIEN','TANG 1',0675847382)

--NHANVIEN
INSERT INTO nhanvien values ('NV1',N'LUU BA BON',N'AN GIANG',N'TAOKHONGBIET',N'MO DI',N'NHANVIEN')
INSERT INTO nhanvien values ('NV2',N'THAI SU TU',N'AN GIANG',N'THAISUTU',N'HAYDOIDAY',N'NHANVIEN')
INSERT INTO nhanvien values ('NV3',N'LU BO',N'AN GIANG',N'LUBO',N'TUANANHCUTE',N'NHANVIEN')
INSERT INTO nhanvien values ('NV4',N'DIEU THUYEN',N'AN GIANG',N'DIEUTHUYEN',N'CAMON',N'NHANVIEN')

--PHIEUMUON
INSERT INTO phieumuon VALUES('PHIEUMUON 1','DOCGIA1','2021/06/03','MASACH1','NV1',2)
INSERT INTO phieumuon VALUES('PHIEUMUON 2','DOCGIA2','2021/06/03','MASACH2','NV2',2)
INSERT INTO phieumuon VALUES('PHIEUMUON 3','DOCGIA3','2021/06/03','MASACH3','NV3',2)
INSERT INTO phieumuon VALUES('PHIEUMUON 4','DOCGIA4','2021/06/03','MASACH4','NV4',2)