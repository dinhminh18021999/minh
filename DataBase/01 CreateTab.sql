-- drop database dbSoftQuanLyNhaHang;
create database dbSoftQuanLyNhaHang;

use dbSoftQuanLyNhaHang;

/*----------------- Bang DangNhap --------------------------*/
create table DangNhap
		(
			IdDangNhap	varchar(100) primary key,
			MatKhau			varchar(200) charset utf8mb4,
			TrangThai		bit
		);
insert into DangNhap 
	values('admin','a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3',1);

/*---------------- Bang NhanVien ---------------*/
create table NhanVien
(
		IdNhanVien			varchar(10)primary key,
		HoLot				varchar(100) charset utf8mb4,
		Ten					varchar(100) charset utf8mb4,
		Ngaysinh			datetime,
		GioiTinh			varchar (10) charset utf8mb4,
		DienThoai			varchar(15),
		Email				varchar(100),
		DiaChi				varchar(100) charset utf8mb4
);
     /*  
		insert into NhanVien values
		(N'NV00000001',N'Nguyễn Văn',N'Tuấn','09/09/1987','Nam','0905123456','',N'Huế'),
		(N'NV00000002',N'Hồ Thị',N'Bình','09/09/1992',N'Nữ','0905123456','',N'Hà Nội'),
		(N'NV00000003',N'Ngô Văn',N'Sơn','09/09/1993','Nam','0905123456','',N'Hải Phòng'),
		(N'NV00000004',N'Trần Ngọc',N'Anh','09/09/1989',N'Nữ','0905123456','',N'Đà Nẵng');
		
		*/
-- drop table NhanVien
/*------------------ Bang KhachHang ---------------------------- */
create table KhachHang
(
		IdKhachHang				varchar(10) primary key,
		TenKhachHang			varchar(100) charset utf8mb4,
		DienThoai				varchar(15),
		Email					varchar(100),
		DiaChi					varchar(100) charset utf8mb4
);
--		insert into KhachHang values 
--		('KH00000001',N'Nguyễn Hoàng Tuấn','0978665412','',N'Huế'),
--		('KH00000002',N'Đào Duy Từ','0978665412','',N'Quảng Nam'),
--		('KH00000003',N'Trương Ngọc Ánh','0978665412','',N'Phú Thọ'),
--		('KH00000004',N'Lê Lưu Ly','0978665412','',N'Gia Lai');
		
-- drop table KhachHang
/*--------------- Bang KhuVuc ----------------------*/
create table KhuVuc
(
		IdKhuVuc			varchar (5) primary key,
		TenKhuVuc			varchar(100) charset utf8mb4 unique, 
		DienGiai			varchar(100) charset utf8mb4,
		TrangThai			varchar(30) charset utf8mb4,
		constraint Unique_KhuVuc unique(TenKhuVuc)
);
--   drop table KhuVuc

		-- insert into KhuVuc values
		-- ('KV001',N'Trong nhà','',N'Hoạt động'),
		-- ('KV002',N'Tầng 2','',''),
		-- ('KV003',N'Sân vườn','','');
		
/*------------------- Bang Ban -----------------------*/
create table Ban
(

		IdBan			varchar (5) primary key,
		TenKhuVuc		varchar(100) charset utf8mb4 ,
		TenBan			varchar(100)  charset utf8mb4 unique,
		DienGiai		varchar(100) charset utf8mb4,
		TrangThai		varchar(30) charset utf8mb4,
		constraint Unique_Ban unique(TenBan),
        foreign key (TenKhuVuc) references KhuVuc(TenKhuVuc)
);
-- drop table Ban
/*
			insert into Ban values
			('BAN01',N'Trong nhà',N'Bàn 1','',N'Đã có khách'),
			('BAN02',N'Trong nhà',N'Bàn 2','',N'Đã có khách'),
			('BAN03',N'Trong nhà',N'Bàn 3','',N'Còn trống')
			
*/

/*-------------------- Bang LoaiThucDon ------------*/
create table LoaiThucDon
(
		IdLoaiThucDon			varchar (5) primary key,
		TenLoaiThucDon			varchar(100) charset utf8mb4 unique,
		DienGiai				varchar(100) charset utf8mb4,
		TrangThai				varchar(30) charset utf8mb4
);
-- drop table LoaiThucDon
/*
			insert into LoaiThucDon (IdLoaiThucDon,TenLoaiThucDon,DienGiai,TrangThai) values
			('LTD01','Cafe','','Còn hàng'),
			('LTD02',N'Sữa','','Còn hàng'),
			('LTD03',N'LipTon - Trà','','Còn hàng'),
			('LTD04',N'Nước đóng chai','','Còn hàng'),
			('LTD05',N'Nước đóng lon','','Còn hàng'),
			('LTD06',N'Sinh tố','','Còn hàng'),
			('LTD07',N'Tráng miệng','','Còn hàng'),
			('LTD08',N'Điểm tâm','','Còn hàng');
*/
/*-------------------- Bang ThucDon ------------*/
create table ThucDon
(
		IdThucDon			varchar(5) primary key,
		TenLoaiThucDon		varchar(100) charset utf8mb4,
		TenThucDon			varchar(100) charset utf8mb4 unique,
		DonViTinh			varchar(10) charset utf8mb4,
		SoLuongTon			float,
		DonGiaTon			float,
		TonToiThieu			float,
		TrangThai			varchar(30) charset utf8mb4,
        foreign key (TenLoaiThucDon) references LoaiThucDon(TenLoaiThucDon)
);
--  drop table ThucDon
/*
insert into ThucDon(IdThucDon,TenLoaiThucDon,TenThucDon,DonViTinh,SoLuongTon,DonGiaTon,TonToiThieu,TrangThai)values
				('TD001','Cafe','Cafe đen','Ly',100,6000,500,'Còn hàng'),
				('TD002','Cafe',N'Cafe Sữa','Ly',100,7000,500,'Còn hàng'),
				('TD003','Cafe',N'Cafe sài gòn','Ly',50,9000,500,'Còn hàng')
				
*/
/*---------------- Bang NguyenLieuThucDon --------------------*/	
create table NguyenLieuThucDon
(
		IdNguyenLieuThucDon			varchar(5),
		IdThucDon					varchar(5) ,
		SoLuong						float,
		DienGiai					varchar(100) charset utf8mb4,
		TrangThai					varchar(30) charset utf8mb4,
        foreign key (IdThucDon) references ThucDon(IdThucDon)
);
-- drop table NguyenLieuThucDon

	-- insert into NguyenLieuThucDon(IdNguyenLieuThucDon,IdThucDon,SoLuong,DienGiai,TrangThai) values
	-- ('NL001','TD001','150','','Còn hàng'),
	-- ('NL002','TD001','150','','Còn hàng'),
	-- ('NL003','TD001','150','','Còn hàng'),
	-- ('NL004','TD001','150','','Còn hàng')
	

/*---------------- Bang GoiMon --------------------*/	
create table GoiMon
(
	IdBan				varchar (5) ,
	IdThucDon			varchar(5) ,
	TenThucDon			varchar(100) charset utf8mb4,
	DonGiaTon			decimal ,
	SoLuong				int,
	ThoiGian			datetime,
	ThanhTien			decimal,
	constraint KhoaChinh_GoiMon	primary key (IdBan),
    foreign key (IdBan) references Ban(IdBan),
    foreign key (IdThucDon) references ThucDon (IdThucDon)
);
-- insert into GoiMon(IdBan,TenThucDon,DonGiaTon,SoLuong,ThoiGian,ThanhTien) values
--		('BAN01',N'Cafe đen','7000','2','09/05/2015','14000')
 -- drop table GoiMon

 /*---------------- Bang HoaDon --------------------*/	
create table HoaDon
(
		IdHoaDon			varchar (10) primary key,
		IdNhanVien			varchar(10),
		IdBan				varchar(5),
		NgayLap				datetime,
		DienGiai			varchar(100) charset utf8mb4,
		SoTien				decimal,
        foreign key (IdNhanVien	) references NhanVien(IdNhanVien),
        foreign key (IdBan) references Ban(IdBan)
);
-- drop table HoaDon

 /*---------------- Bang PhanQuyen --------------------*/	
create table PhanQuyen
(
		IdTaiKhoan			varchar (10),
		MatKhau				varchar(200),
		IdNhanVien			varchar(10) ,
		constraint KhoaChinh_PhanQuyen	primary key (IdTaiKhoan),
        foreign key (IdNhanVien	) references NhanVien(IdNhanVien)
);
	-- Insert into PhanQuyen values ('TK00000001','admin','NV00000001')
-- drop table PhanQuyen