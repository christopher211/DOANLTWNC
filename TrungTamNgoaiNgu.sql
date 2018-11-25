create database TTNN

create table ChucVu
(
	MaCV char(10) primary key not null,
	TenCV nvarchar(100) check(TenCV in (N'Giảng Viên', N'Giáo Vụ', N'Nhân Viên Văn Phòng', N'Giám Đốc')),
	TrangThai tinyint
)

insert into ChucVu values('CV01', N'Giám Đốc', 1)
insert into ChucVu values('CV02', N'Giáo Vụ', 1)
insert into ChucVu values('CV03', N'Nhân Viên văn Phòng', 1)
insert into ChucVu values('CV04', N'Giảng Viên', 1)

go
create table NhanVien
(
	MaNV char(10) primary key not null,
	HoNV nvarchar(50),
	TenNV nvarchar(50),
	GioiTinh nvarchar(10) check(GioiTinh in (N'Nam', N'Nữ')),
	NgaySinh date,
	NgayLamViec date,
	SDT char(10),
	Email nvarchar(50),
	DiaChi nvarchar(100),
	ChucVu char(10) foreign key(ChucVu) references ChucVu(MaCV),
	Luong bigint,	
	TrangThai tinyint,
)

insert into NhanVien values('NV11', N'Trần Thị', N'Ngọc', N'Nữ', '7-25-1990', '5-15-2013', '0123456789', 'aa@gmail.com', N'64 Pasteur, TP.HCM', 'CV04', null, 1)
insert into NhanVien values('NV02', N'Nguyễn Văn', N'Bảo', N'Nữ', '8-26-1991', '6-16-2012', '9876543210', 'bb@gmail.com', N'65 Hồ tùng Mậu, TP.HCM', 'CV04', null, 1)
insert into NhanVien values('NV03', N'Võ Trần', N'Chung', N'Nam', '9-27-1980', '7-17-2011', '0135792468', 'cc@gmail.com', N'66 Nguyễn Văn Nghi, TP.HCM', 'CV03', null, 1)
insert into NhanVien values('NV04', N'Phạm Thị', N'Dung', N'Nữ', '10-28-1985', '8-18-2010', '0246813579', 'dd@gmail.com', N'674 CMT8, TP.HCM', 'CV03', null, 1)
insert into NhanVien values('NV05', N'Hoàng Thị', N'Yến', N'Nam', '11-29-1975', '9-19-2009', '0147258369', 'ee@gmail.com', N'564 Trường Chinh, TP.HCM', 'CV02', null, 1)
insert into NhanVien values('NV06', N'Phan Thị', N'Thanh', N'Nữ', '12-30-1990', '10-20-2008', '0369258147', 'ff@gmail.com', N'164 Quang Trung, TP.HCM', 'CV01', null, 1)
insert into NhanVien values('NV07', N'Đinh Thị', N'Lan', N'Nữ', '1-31-1994', '11-21-2007', '0321654987', 'gg@gmail.com', N'3264 Nguyễn Trãi, Hà Nội', 'CV03', null, 1)
insert into NhanVien values('NV08', N'Nguyễn Minh', N'Hiếu', N'Nam', '2-1-1993', '12-22-2007', '0193764285', 'hh@gmail.com', N'364 Nguyễn Văn Quá, Hà Nội', 'CV03', null, 1)
insert into NhanVien values('NV09', N'Đoàn Văn', N'Khoa', N'Nam', '3-2-1992', '1-23-2007', '0134679852', 'ii@gmail.com', N'564 Hai Bà Trưng, Hà Nội', 'CV04', null, 1)
insert into NhanVien values('NV10', N'Huỳnh Thị', N'Châu', N'Nữ', '4-3-1991', '2-24-2007', '0316497258', 'kk@gmail.com', N'664 Pasteur, Hà Nội', 'CV04', null, 1)

go
create table PhongHoc
(
	MaPhong char(10) primary key not null,
	TenPhong nvarchar(50),
	TrangThai tinyint
)

insert into PhongHoc values('PH01', 'F1.1', 1)
insert into PhongHoc values('PH02', 'F1.2', 1)
insert into PhongHoc values('PH03', 'F1.3', 1)
insert into PhongHoc values('PH04', 'F1.4', 1)
insert into PhongHoc values('PH05', 'F1.5', 1)

go
create table KhoaHoc
(		
	MaKH char(10) primary key not null,
	TenKH nvarchar(50),
	NgayBatDau date,
	NgayKetThuc date,
	HocPhi int,
	TrangThai tinyint
)

insert into KhoaHoc values('KH01', 'IELTS', '1-1-2017', '5-30-2017', 4000000, 1)
--insert into KhoaHoc values('KH01', 'IELTS', '1-1-2017', '5-30-2017', 4000000, 1)
insert into KhoaHoc values('KH02', 'TOEFL-IBT',' 1-1-2018', '5-30-2018', 3000000, 1)
--insert into KhoaHoc values('KH02', 'TOEFL-IBT', '1-1-2018', '5-30-2018', 3000000, 1)
insert into KhoaHoc values('KH03', 'TOEIC', '1-1-2019', '5-30-2019', 2000000, 1)
--insert into KhoaHoc values('KH03', 'TOEIC', '1-1-2019', '5-30-2019', 2000000, 1)
go

create table Lop
(
	MaLop char(10) primary key not null,
	TenLop nvarchar(50),
	MaNV char(10) foreign key (MaNV) references NhanVien(MaNV),
	MaPhg char(10) foreign key (MaPhg) references PhongHoc(MaPhong),
	MaKhoaHoc char(10) foreign key (MaKhoaHoc) references KhoaHoc(MaKH),
	LichHoc nvarchar(50),
	GioBatDau char(10),
	GioKetThuc char(10),
	SoHV int,
	TrangThai tinyint
)

insert into Lop values('LH01', N'Ielts_1', 'NV02', 'PH01', 'KH01', 'T2-T4-T6', '5:00 PM', '7:30 PM', null, 1)
insert into Lop values('LH02', N'Ielts_2', 'NV09', 'PH02', 'KH01', 'T2-T4-T6', '1:00 PM', '3:30 PM', null, 1)
insert into Lop values('LH03', N'Ielts_3', 'NV10', 'PH03', 'KH01', 'T2-T4-T6', '5:00 PM', '7:30 PM', null, 1)

insert into Lop values('LH04', N'TOEFL-IBT_1', 'NV11', 'PH04', 'KH02', 'T3-T5-T7', '3:00 PM', '5:30 PM', null, 1)
insert into Lop values('LH05', N'TOEFL-IBT_2', 'NV09', 'PH05', 'KH02', 'T2-T4-T6', '5:00 PM', '7:30 PM', null, 1)
insert into Lop values('LH06', N'TOEFL-IBT_3', 'NV09', 'PH05', 'KH02', 'T3-T5-T7', '1:00 PM', '3:30 PM', null, 1)

insert into Lop values('LH07', N'TOEIC_1', 'NV02', 'PH04', 'KH03', 'T2-T4-T6', '7:00 AM', '12:00 AM', null, 1)
insert into Lop values('LH08', N'TOEIC_2', 'NV10', 'PH02', 'KH03', 'T2-T4-T6', '12:00 AM', '3:30 PM', null, 1)

go
create table HocVien
(
	MSHV char(10) primary key not null,
	Ho nvarchar(50),
	Ten nvarchar(50),
	GioiTinh nvarchar(10) check(GioiTinh in (N'Nam', N'Nữ')),
	NgaySinh date,
	SDT char(10),
	Email nvarchar(50),
	DiaChi nvarchar(100),
	MaKH char(10) foreign key (MaKH) references KhoaHoc(MaKH) not null,
	MaLop char(10) foreign key (MaLop) references Lop(MaLop) not null,
	HocPhi int,
	TrangThai tinyint,
	TrangThaiHocPhi tinyint
)

insert into HocVien values('HV01', N'Nguyen Van', N'Nam', 'Nam', '12-13-1998', '0123456789', 'a@gmail.com', N'65 Huỳnh Thúc Kháng', 'KH01','LH01',5000000,1,0 )
insert into HocVien values('HV02', N'Nguyễn Đức Công', N'Kiệt', 'Nam', '10-1-1998', '0123456789', 'b@gmail.com', N'66 Huỳnh Thúc Kháng', 'KH01','LH02',5000000,1,1 )
insert into HocVien values('HV03', N'Đoàn Ngọc', N'Long', 'Nam', '12-05-1998', '0123456789', 'c@gmail.com', N'67 Huỳnh Thúc Kháng', 'KH01','LH03',5000000,1,0 )
insert into HocVien values('HV04', N'Trần Như Gia', N'Bảo', 'Nam', '02-03-1998', '0123456789', 'ddds@gmail.com', N'68 Huỳnh Thúc Kháng', 'KH01','LH01',5000000,1,0 )
insert into HocVien values('HV05', N'Nguyễn Tấn', N'Liêm', 'Nam', '09-10-1998', '0123456789', 'e@gmail.com', N'69 Huỳnh Thúc Kháng', 'KH02','LH04',5000000,1,1 )
insert into HocVien values('HV06', N'Nguyễn Minh', N'Nhân', 'Nam', '02-25-1998', '0123456789', ' vc@gmail.com', N'70 Huỳnh Thúc Kháng', 'KH02','LH05',5000000,1,0 )
insert into HocVien values('HV07', N'Nguyễn Quốc', N'Toản', 'Nam', '07-03-1998', '0123456789', 'bh@gmail.com', N'71 Huỳnh Thúc Kháng', 'KH02','LH06',5000000,1,1 )
insert into HocVien values('HV08', N'Mai Thị Thúy', N'An', 'Nam', '07-07-1998', '0123456789', 'sdc@gmail.com', N'72 Huỳnh Thúc Kháng', 'KH02','LH04',5000000,1,1 )
insert into HocVien values('HV09', N'Lê Vinh', N'Định', 'Nam', '03-05-1998', '0123456789', 'uu@gmail.com', N'73 Huỳnh Thúc Kháng', 'KH02','LH05',5000000,1,0 )
insert into HocVien values('HV10', N'Bùi Quốc', N'Khánh', 'Nam', '08-20-1998', '0123456789', 'cc@gmail.com', N'74 Huỳnh Thúc Kháng', 'KH02','LH06',5000000,1,1 )
insert into HocVien values('HV11', N'Nguyễn Quốc', N'Thái', 'Nam', '12-25-1998', '0123456789', 'qq@gmail.com', N'75 Huỳnh Thúc Kháng', 'KH02','LH06',5000000,1,1 )
insert into HocVien values('HV12', N'Nguyễn Anh', N'Tuấn', 'Nam', '11-26-1998', '0123456789', 'pg@gmail.com', N'76 Huỳnh Thúc Kháng', 'KH03','LH07',5000000,1,0 )
insert into HocVien values('HV13', N'Phan Nguyễn Anh', N'Tú', 'Nam', '12-30-1998', '0123456789', 'hlo@gmail.com', N'78 Huỳnh Thúc Kháng', 'KH03','LH07',5000000,1,0 )
insert into HocVien values('HV14', N'Nguyễn Bình', N'Điền', 'Nam', '11-08-1998', '0123456789', 'sxd@gmail.com', N'79 Huỳnh Thúc Kháng', 'KH03','LH07',5000000,1,1 )
insert into HocVien values('HV15', N'Lê Thân Trần', N'Đủ', 'Nam', '03-04-1998', '0123456789', 'gbgf@gmail.com', N'80 Huỳnh Thúc Kháng', 'KH03','LH08',5000000,1,0 )
insert into HocVien values('HV16', N'Lữ Anh', 'Phong', 'Nam', '07-01-1998', '0123456789', 'avg@gmail.com', N'81 Huỳnh Thúc Kháng', 'KH03','LH07',5000000,1,1 )

go
create table Luong
(
	MaNV char(10) foreign key(MaNV) references NhanVien(MaNV),
	SoGio int,
	SoBuoi int,
	DonGia int,
	HeSoLuong int,
	TrangThai tinyint,
)

create table TaiKhoan
(
	ID int IDENTITY(1,1) not null,
	TenDangNhap char(50) PRIMARY KEY NOT NULL,
	MatKhau char(50) not null,	
	MaNV char(10) foreign key(MANV) references NhanVien(MaNV),
	TrangThai tinyint
)

--insert into TaiKhoan values('admin', 'admin', '', 1)
--insert into TaiKhoan values('giamdoc', 'giamdoc', 'Administrator', 1)
--insert into TaiKhoan values('mod', 'mod', 'Moderator', 1)
insert into TaiKhoan values('nhanvien1', 'nhanvien1','NV04', 1)
insert into TaiKhoan values('nhanvien2', 'nhanvien2','NV05', 1)
insert into TaiKhoan values('nhanvien3', 'nhanvien3','NV06', 1)

select * from TaiKhoan, NhanVien wHeRe TaiKhoan.MaNV = NhanVien.MaNV
SELECT * FROM TaiKhoan WHERE TenDangNhap = 'nhanvien1' AND MatKhau = 'nhanvien1' AND MaNV in (select MaNV from NhanVien where ChucVu = 'CV03')

create table ThongKe
(
	ID int IDENTITY(1,1) not null,
	MaTK char(10) PRIMARY KEY NOT NULL,
	Thang int,
	Nam int,
	SOHV bigint,
	TongDoanhThu bigint,
	TrangThai tinyint
)
insert into ThongKe values('TK01','01','2017',null, null, 1)
insert into ThongKe values('TK02','02','2017',null, null, 1)
insert into ThongKe values('TK03','03','2017',null, null, 1)
insert into ThongKe values('TK04','04','2017',null, null, 1)

create table Diem
(
	ID int IDENTITY(1,1) not null,
	MaHV char(10),
	TenHV nvarchar(100),
	MaKhoaHoc char(10),
	DiemHV int,
	TrangThai tinyint,
	primary key(MaHV, MaKhoaHoc)
)
create table hvKhoa
(
	MaHV char(10) foreign key(MaHV) references HocVien(MSHV),
	MaKH char(10)foreign key(MaKH) references KhoaHoc(MaKH),
	primary key(MaHV, MaKH)
)
insert into hvKhoa values('HV01','KH01')
insert into hvKhoa values('HV01','KH02')
insert into hvKhoa values('HV02','KH01')
insert into hvKhoa values('HV02','KH03')

create table BienLai
(
	MaBL char(10) primary key not null,
	MaKH char(10) foreign key(MaKH) references KhoaHoc(MaKH),
	MaHV char(10) foreign key(MaHV) references HocVien(MSHV),
	TongTien bigint,
	Thangnam char(20),
	trangThai tinyint
)
insert into BienLai values('BL01', 'HV02', '1000000','06-2017',1)
insert into BienLai values('BL02', 'HV03', '1000000','06-2017',1)
insert into BienLai values('BL03', 'HV01', '1500000','06-2017',1)

--select TenLop from lop, khoahoc where lop.MaKhoaHoc = khoahoc.MaKH and khoahoc.MaKH = 'KH01'


SELECT * from HocVien, KhoaHoc, Lop WHERE HocVien.MaKhoaHoc = KhoaHoc.MaKH AND HocVien.MaLop = Lop.MaLop AND HocVien.TrangThai = 1
select TenLop from lop,KhoaHoc where 