
--  drop procedure spInsertDangNhap

					/*-- BANG DANG NHAP -- */
					
/*-------------- Insert DangNhap -------------------------*/
delimiter //
create procedure spInsertDangNhap
(
			_IdDangNhap			varchar(100),
			_MatKhau			varchar(200),
			_TrangThai			bit
)
Begin
		insert into DangNhap(IdDangNhap, MatKhau, TrangThai)
		values (_IdDangNhap, _MatKhau, _TrangThai);
End //
delimiter ;
-- Gọi lại thủ tục:

call spInsertDangNhap		(	'toan2' ,'181210f8f9c779c26da1d9b2075bde0127302ee0e3fca38c9a83f5b1dd8e5d3b', 0);
call spInsertDangNhap		(	'toan3' ,'123', 0);



/*------------- Doi mat khau DangNhap ----------------*/
delimiter //
create procedure spUpdateDangNhap_MatKhau
(
			_IdDangNhap	varchar(100),
			_MatKhau   varchar(250)				
)
Begin
		   update DangNhap set MatKhau=@MatKhau
		   where IdDangNhap = _IdDangNhap;
End //
delimiter ;

/*---------------- Xoa DangNhap -------------------------*/
delimiter //
create procedure spDeleteDangNhapByIdDangNhap
(
		 _IdDangNhap	varchar(100)							
)
Begin
		 delete from DangNhap 
		 where IdDangNhap =_IdDangNhap;
End //
delimiter ;
/*----------- Tim kiem thong tin theo IdDangNhap ----------*/
delimiter //
create procedure spgetDangNhapByIdDangNhap
(
		 _IdDangNhap	varchar(100)							
)
Begin
		 select IdDangNhap, MatKhau, TrangThai
		 from DangNhap
		 where IdDangNhap =_IdDangNhap ;
End //
delimiter ;

/*--------- Hien thi thong tin DangNhap ----------------------*/ 
delimiter //
create procedure spgetDangNhap()
Begin
		 select IdDangNhap, MatKhau, TrangThai
		 from DangNhap	;	 
End //
delimiter ;

/*------------------ Kiem tra DangNhap -----------------------*/
delimiter //
create procedure spCheckDangNhap
(
		_IdDangNhap		varchar(100),
		_MatKhau		varchar(200) charset utf8
)
	Begin
				select	* from DangNhap dn
				where		dn.idDangNhap= _IdDangNhap
				and			dn.MatKhau=_MatKhau			;	
	End //
delimiter ;
						/*-- BANG NHAN VIEN  -- */
						
/*------------- Hien thi thong tin NhanVien -------------------*/

delimiter //
create procedure spgetNhanVien()
Begin
	select *from NhanVien;
	-- IdNhanVien as 'Id Nhân Viên ',HoLot + + Ten as ' Họ Tên ',Ngaysinh as 'Ngày Sinh',GioiTinh as 'Giới Tính',DienThoai as 'Điện Thoại',Email,DiaChi as 'Địa chỉ' 
End //
delimiter ;
-- drop procedure spgetNhanVien
/*----------- Hien thi thong tin NhanVien bang IdNhanVien --------------*/
delimiter //
create procedure spgetNhanVienByIdNhanVien
(
	_IdNhanVien varchar(10)
)
Begin
	select * from NhanVien where IdNhanVien =@IdNhanVien;
End //
delimiter ;


/*-------------- Insert NhanVien -----------------------------*/
delimiter //
create procedure spInsertNhanVien
( 
		_IdNhanVien			varchar(10),
		_HoLot				varchar(100) charset utf8,
		_Ten				varchar(100) charset utf8,
		_Ngaysinh			datetime,
		_GioiTinh			varchar(10) charset utf8,
		_DienThoai			varchar(15),
		_Email				varchar(100),
		_DiaChi				varchar(100)  charset utf8
)
Begin
	insert into NhanVien(IdNhanVien, HoLot, Ten, Ngaysinh, GioiTinh, DienThoai,Email,DiaChi)
	values(_IdNhanVien, _HoLot, _Ten, _Ngaysinh, _GioiTinh, _DienThoai,_Email,_DiaChi);
End //
delimiter ;
/*------------------- Update NhanVien -----------------------*/

delimiter //
create procedure spUpdateNhanVien
(
		_IdNhanVien			varchar(10),
		_HoLot				varchar(100) charset utf8,
		_Ten				varchar(100) charset utf8,
		_Ngaysinh			datetime,
		_GioiTinh			varchar(10) charset utf8,
		_DienThoai			varchar(15),
		_Email				varchar(100),
		_DiaChi				varchar(100) charset utf8 	 
)
Begin
	update NhanVien set 
						HoLot = _HoLot,
						Ten =_Ten,
						Ngaysinh =_Ngaysinh,
						GioiTinh =_GioiTinh,
						DienThoai =_DienThoai,
						Email	=_Email,
						DiaChi	=_DiaChi
											 
		where IdNhanVien =_IdNhanVien;
End //
delimiter ;
/*--------------- Delete NhanVien ---------------------*/
delimiter //
create procedure spDeleteNhanVien
(
	_idNhanVien varchar (10)
)
Begin
	delete from NhanVien where IdNhanVien=_idNhanVien;
End //
delimiter ;

/*--------------TIM KIEM NHAN VIEN THEO IDNHANVIEN -----------*/
delimiter //
create procedure spSearchNVByIdNV
(
	_IdNhanVien varchar (10)
)
Begin
	select *from NhanVien where IdNhanVien like  CONCAT('%',_IdNhanVien,'%');
End //
delimiter ;

-- drop  procedure spSearchNVByIdNV

/*--------------TIM KIEM NHAN VIEN THEO TEN -----------*/

delimiter //
create procedure spSearchNVByTenNV
(
	_Ten			varchar(100) CHARACTER SET utf8
)
Begin
	select * from NhanVien where Ten like  concat('%',_Ten,'%') ;
End //
delimiter ;
-- drop  procedure spSearchNVByTenNV

						/*-- BANG KHACH HANG -- */
						
/*--------- Hien thi thong tin KhachHang ----------------*/
delimiter //
create procedure spgetKhachHang()
Begin
	select IdKhachHang, TenKhachHang,  DienThoai, Email,DiaChi
	from Khachhang;
End //
delimiter //;

/*----------- Hien thi thong tin KhachHang bang IdKhachHang --------------*/
delimiter //
create procedure spgetKhachHangByIdKhachHang
(
	_IdKhachHang		varchar (10)
)
begin
	select * from Khachhang where IdKhachHang = @IdKhachHang;
end //
delimiter ;
/*---------------- Insert KhachHang -------------------*/
delimiter //
create procedure spInsertKhachHang
( 
		_IdKhachHang			varchar(10),
		_TenKhachHang			varchar(100) charset utf8,
		_DienThoai				varchar(15),
		_Email					varchar(100),
		_DiaChi					varchar(100) charset utf8
)
Begin
	insert into KhachHang(IdKhachHang, TenKhachHang, DienThoai, Email, DiaChi)
	values(_IdKhachHang, _TenKhachHang, _DienThoai, _Email, _DiaChi);
End //
delimiter ;


-- DROP PROCEDURE spgetKhachhang
/*---------------- Update KhachHang -----------------*/
delimiter //
create procedure spUpdateKhachHang
(
		_IdKhachHang			varchar(10),
		_TenKhachHang			varchar(100) charset utf8,
		_DienThoai				varchar(15),
		_Email					varchar(100),
		_DiaChi					varchar(100) charset utf8
)
Begin
	update Khachhang set 
						TenKhachHang = _TenKhachHang,
						DienThoai =_DienThoai,
						Email	=_Email,
						DiaChi	=_DiaChi
											 
		where IdKhachHang =_IdKhachHang;
End //
delimiter;

/*-------------------- Delete KhachHang -------------------*/
delimiter //
create procedure spDeleteKhachHang
(
	_IdKhachHang		varchar(10)
)
begin
	delete from Khachhang where IdKhachHang = _IdKhachHang;
end //
delimiter ;

						/*----------- BANG LOAITHUCDON --------------*/
						
/*--------- Hien thi thong tin LoaiThucDon ----------------*/
delimiter //
create procedure spgetLoaiThucDon()

Begin
	select * from LoaiThucDon;
End //
delimiter ;

/*----------- Hien thi thong tin LoaiThucDon bang IdLoaiThucDon --------------*/
delimiter //
create procedure spgetLoaiThucDonByIdLoaiThucDon
(
	_IdLoaiThucDon			varchar (5)
)
begin
	select * from LoaiThucDon where IdLoaiThucDon = _IdLoaiThucDon;
end //
delimiter ;

-- drop proc spgetLoaiThucDonByIdLoaiThucDon
/*---------------- Insert LoaiThucDon -------------------*/
delimiter //
create procedure spInsertLoaiThucDon
( 
		_IdLoaiThucDon			varchar (5),
		_TenLoaiThucDon			varchar(100) charset utf8,
		_DienGiai				varchar(100) charset utf8,
		_TrangThai				varchar(30) charset utf8
)
Begin
	insert into LoaiThucDon(IdLoaiThucDon,TenLoaiThucDon,DienGiai,TrangThai)
	values (_IdLoaiThucDon,_TenLoaiThucDon,_DienGiai,_TrangThai) ;
End //
delimiter ;


-- DROP PROCEDURE spInsertLoaiThucDon
/*---------------- Update LoaiThucDon -----------------*/
delimiter //

create procedure spUpdateLoaiThucDon
(
		p_IdLoaiThucDon			varchar (5),
		p_TenLoaiThucDon	    varchar(100) charset utf8,
		p_DienGiai				varchar(100) charset utf8,
		p_TrangThai				varchar(30) charset utf8
)
Begin
	update LoaiThucDon set 
						TenLoaiThucDon=p_TenLoaiThucDon,
						DienGiai=p_DienGiai,
						TrangThai=p_TrangThai						 
		where IdLoaiThucDon =p_IdLoaiThucDon;
End //

DELIMITER ;


-- drop procedure spUpdateLoaiThucDon
/*-------------------- Delete LoaiThucDon -------------------*/
delimiter //

create procedure spDeleteLoaiThucDon
(
	_IdLoaiThucDon			varchar (5)
)
begin
	delete from LoaiThucDon where IdLoaiThucDon = _IdLoaiThucDon;
end //

delimiter ;


/* ----------------------- Get TenLoaiThucDon ----------------*/
delimiter //

create procedure spgetTenLoaiThucDon()
begin
	select TenLoaiThucDon from LoaiThucDon;
end//

delimiter ;


							/*-- BANG THUC DON -- */
							
/*--------- Hien thi thong tin ThucDon ----------------*/
delimiter //

create procedure spgetThucDon()
Begin
	select IdThucDon,TenLoaiThucDon,TenThucDon,DonViTinh,SoLuongTon,DonGiaTon,TonToiThieu,TrangThai	
	from ThucDon;
End//

DELIMITER ;


-- drop proc spgetThucDon

/*--------- Hien thi thong tin ThucDon NOT TonToiThieu ----------------*/
delimiter //

create procedure spgetThucDonNotTTT()
Begin
	select IdThucDon,TenLoaiThucDon,TenThucDon,DonViTinh,SoLuongTon,DonGiaTon,TrangThai	
	from ThucDon;
End//

DELIMITER ;


-- drop proc spgetThucDonNotTTT
/*----------- Hien thi thong tin ThucDon bang IdThucDon --------------*/
delimiter //

create procedure spgetThucDonByIdThucDon
(
	p_IdThucDon		varchar (5)
)
begin
	select * from ThucDon where IdThucDon = p_IdThucDon;
end //

delimiter ;


/*---------------- Insert ThucDon -------------------*/
delimiter //

create procedure spInsertThucDon
( 
		p_IdThucDon			varchar(5) ,
		p_TenLoaiThucDon		varchar(100) charset utf8,
		p_TenThucDon			varchar(100) charset utf8,
		p_DonViTinh			varchar(10) charset utf8,
		p_SoLuongTon			double,
		p_DonGiaTon			double,
		p_TonToiThieu		double,
		p_TrangThai			varchar(30) charset utf8
)
Begin
	insert into ThucDon(IdThucDon,TenLoaiThucDon,TenThucDon,DonViTinh,SoLuongTon,DonGiaTon,TonToiThieu,TrangThai)
	values(p_IdThucDon,p_TenLoaiThucDon,p_TenThucDon,p_DonViTinh,p_SoLuongTon,p_DonGiaTon,p_TonToiThieu,p_TrangThai);
End//

DELIMITER ;



-- DROP PROCEDURE spgetThucDon
/*---------------- Update ThucDon -----------------*/
delimiter //

create procedure spUpdateThucDon
(
		p_IdThucDon			varchar(5) ,
		p_TenLoaiThucDon		varchar(100) charset utf8,
		p_TenThucDon			varchar(100) charset utf8,
		p_DonViTinh			 varchar(10) charset utf8,
		p_SoLuongTon			double,
		p_DonGiaTon			double,
		p_TonToiThieu		double,
		p_TrangThai			varchar(30) charset utf8
)
Begin
	update ThucDon set 
						TenLoaiThucDon=p_TenLoaiThucDon,
						TenThucDon=p_TenThucDon,
						DonViTinh=p_DonViTinh,
						SoLuongTon=p_SoLuongTon,
						DonGiaTon=p_DonGiaTon,
						TonToiThieu=p_TonToiThieu,
						TrangThai=p_TrangThai
											 
		where IdThucDon =p_IdThucDon;
End //

DELIMITER ;


-- --   drop proc spUpdateThucDon
/*-------------------- Delete ThucDon -------------------*/
delimiter //

create procedure spDeleteThucDon
(
	p_IdThucDon		varchar (5)
)
begin
	delete from ThucDon where IdThucDon = p_IdThucDon;
end //

delimiter ;


/*-------------------- get DonGiaTon tu TenThucDon -------------------*/
delimiter //

create procedure spgetDonGiaByTenThucDon
(
	p_TenThucDon			varchar(100) charset utf8
)
begin
	select DonGiaTon as 'Đơn giá' from ThucDon where TenThucDon=p_TenThucDon;
end //
							/*--- BANG KHU VUC ---*/

delimiter ;


							
/*--------- Hien thi thong tin KhuVuc ----------------*/
delimiter //

create procedure spgetKhuVuc()
Begin
	select * from KhuVuc;
End;
//

DELIMITER ;


/*----------- Hien thi thong tin KhuVuc bang IdKhuVuc --------------*/
delimiter //

create procedure spgetKhuVucByIdKhuVuc
(
	p_IdKhuVuc		varchar (5)
)
begin
	select * from KhuVuc where IdKhuVuc = p_IdKhuVuc;
end //

delimiter ;


-- drop proc spgetKhuVucByIdKhuVuc
/*---------------- Insert KhuVuc -------------------*/
delimiter //

create procedure spInsertKhuVuc
( 
		p_IdKhuVuc			varchar (5),
		p_TenKhuVuc			varchar(100) charset utf8,
		p_DienGiai			varchar(100) charset utf8,
		p_TrangThai			varchar(30) charset utf8
)
Begin
	insert into KhuVuc(IdKhuVuc, TenKhuVuc, DienGiai, TrangThai)
	values(p_IdKhuVuc, p_TenKhuVuc, p_DienGiai, p_TrangThai);
End //

DELIMITER ;



-- DROP PROCEDURE spInsertKhuVuc
/*---------------- Update KhuVuc -----------------*/
delimiter //

create procedure spUpdateKhuVuc
(
		p_IdKhuVuc			varchar (5) ,
		p_TenKhuVuc			varchar(100) charset utf8,
		p_DienGiai			varchar(100) charset utf8,
		p_TrangThai			varchar(30) charset utf8
)
Begin
	update KhuVuc set 
						TenKhuVuc=p_TenKhuVuc,
						DienGiai=p_DienGiai,
						TrangThai=p_TrangThai						 
		where IdKhuVuc =p_IdKhuVuc;
End //

DELIMITER ;


-- drop procedure spUpdateKhuVuc
/*-------------------- Delete KhuVuc -------------------*/
delimiter //

create procedure spDeleteKhuVuc
(
	p_IdKhuVuc		varchar(5)
)
begin
	delete from KhuVuc where IdKhuVuc = p_IdKhuVuc;
end //
-- drop procedure spDeleteKhuVuc

delimiter ;



						/*----------- BANG BAN --------------*/
						
/*--------- Hien thi thong tin Ban ----------------*/
delimiter //

create procedure spgetBan()
Begin
	select IdBan,TenBan,TenKhuVuc,DienGiai,TrangThai from Ban;
End //

DELIMITER ;


-- drop  procedure spgetBan
/*----------- Hien thi thong tin Ban bang IdBan --------------*/
delimiter //

create procedure spgetBanByIdBan
(
	p_IdBan	varchar (5)
)
begin
	select * from Ban where IdBan = p_IdBan;
end //

delimiter ;


-- drop proc spgetBanByIdBan
/*---------------- Insert Ban -------------------*/
delimiter //

create procedure spInsertBan
( 
		p_IdBan			varchar (5) ,
		p_TenKhuVuc		varchar(100) charset utf8,
		p_TenBan		varchar(100) charset utf8,
		p_DienGiai		varchar(100) charset utf8,
		p_TrangThai		varchar(30) charset utf8
)
Begin
	insert into Ban(IdBan,TenKhuVuc, TenBan, DienGiai, TrangThai)
	values(p_IdBan,p_TenKhuVuc,p_TenBan,p_DienGiai,p_TrangThai);
End//

DELIMITER ;



-- DROP PROCEDURE spInsertBan
/*---------------- Update Ban -----------------*/
delimiter //

create procedure spUpdateBan
(
		p_IdBan			varchar (5) ,
		p_TenKhuVuc		varchar(100) charset utf8 ,
		p_TenBan		varchar(100) charset utf8,
		p_DienGiai		varchar(100) charset utf8,
		p_TrangThai		varchar(30) charset utf8
)
Begin
	update Ban set		
						
			TenKhuVuc = p_TenKhuVuc,
			TenBan=p_TenBan,
			DienGiai=p_DienGiai,
			TrangThai=p_TrangThai						 
		where IdBan=p_IdBan;
End//

DELIMITER ;


-- drop procedure spUpdateBan
/*-------------------- Delete Ban -------------------*/
delimiter //

create procedure spDeleteBan
(
	p_IdBan		varchar(5)
)
begin
	delete from Ban where IdBan = p_IdBan;
end //

delimiter ;


/*-------------------- get TenBan  -------------------*/
delimiter //

create procedure spgetTenBan()
begin
	select TenBan from Ban;
end //

delimiter ;


-- drop procedure spDeleteBan
/* ----------------------- Get TenKhuVuc ------------------- */
delimiter //

create procedure spgetTenKhuVuc()
begin
	select TenKhuVuc from KhuVuc;
end //

delimiter ;



/*-------------------- get TenThucDon -------------------*/
delimiter //

create procedure spgetTenThucDon()
begin
	select TenThucDon from ThucDon;
end //

delimiter ;


/*-------------------- get DanhSachBan_GoiMon -------------------*/
delimiter //

create procedure spgetDanhSachBan_GoiMon()
begin
	select  DISTINCT b.IdBan as 'Id Bàn' , TenBan as 'Tên Bàn',  TenKhuVuc as 'Tên Khu Vực',DienGiai as 'Diễn Giải'
	from Ban b,GoiMon gm
	where b.IdBan = gm.IdBan
	ORDER BY b.IdBan;
end //

delimiter ;


-- drop proc spgetDanhSachBan_GoiMon

/*-------------------- get DanhSachBan_ChuaGoiMon -------------------*/
delimiter //

create procedure spgetDanhSachBan_ChuaGoiMon()
begin
	select  distinct IdBan as 'Id Bàn',TenBan as 'Tên Bàn',TenKhuVuc as 'Tên Khu Vực',DienGiai as 'Diễn Giải'
	from Ban where IdBan not in (select IdBan from GoiMon)
	ORDER BY IdBan,TenBan,TenKhuVuc,DienGiai;
end //
-- drop proc spgetDanhSachBan_ChuaGoiMon


delimiter ;


						/*----- BANG GOIMON-----*/

/*--------- Hien thi thong tin GoiMon ----------------*/
delimiter //

create procedure spgetGoiMon()
Begin
	select IdBan,TenThucDon,DonGiaTon,SoLuong,ThoiGian,(SoLuong*DonGiaTon)as ThanhTien
	from GoiMon
	ORDER BY IdBan;
End//

DELIMITER ;


-- drop procedure spgetGoiMon
/*----------- Hien thi thong tin GoiMon bang IdBan --------------*/
delimiter //

create procedure spgetGoiMonByIdBan
(
	p_IdBan	varchar (5)
)
begin
	select  IdBan as 'Id Bàn', TenThucDon as 'Tên Thực Đơn',DonGiaTon as 'Đơn Giá',SoLuong as 'Số Lượng ',ThoiGian as 'Thời Gian',(SoLuong*DonGiaTon)as 'Thành Tiền'
	from GoiMon where IdBan = p_IdBan;
end//

delimiter ;


-- drop proc spgetGoiMonByIdBan
/*---------------- Insert GoiMon -------------------*/
delimiter //

create procedure spInsertGoiMon
( 
		p_IdBan				varchar (5),
		p_TenThucDon		varchar(100) charset utf8,
		p_DonGiaTon			decimal(18,0) ,
		p_SoLuong			int,
		p_ThoiGian			datetime,
		p_ThanhTien			decimal(18,0)
)
Begin
	insert into GoiMon(IdBan,TenThucDon, DonGiaTon, SoLuong, ThoiGian,ThanhTien)
	values(p_IdBan,p_TenThucDon, p_DonGiaTon, p_SoLuong, p_ThoiGian,p_ThanhTien );
End//

DELIMITER ;



-- DROP PROCEDURE spInsertGoiMon
/*---------------- Update GoiMon -----------------*/
delimiter //

create procedure spUpdateGoiMon
(		
		p_IdBan				varchar (5),
		p_TenThucDon		varchar(100) charset utf8,
		p_DonGiaTon			decimal(18,0) ,
		p_SoLuong			int,
		p_ThoiGian			datetime,
		p_ThanhTien			decimal(18,0)
)
Begin
	update GoiMon set	
						TenThucDon = p_TenThucDon,
						DonGiaTon=p_DonGiaTon,
						SoLuong=p_SoLuong,
						ThoiGian=p_ThoiGian,
						ThanhTien=p_ThanhTien
	where IdBan = p_IdBan;			 
End//

DELIMITER ;


-- drop procedure spUpdateGoiMon
/*-------------------- Delete GoiMon -------------------*/
delimiter //

create procedure spDeleteGoiMon
(
	p_IdBan				varchar (5)
)
begin
	Delete from GoiMon where IdBan = p_IdBan;
end//

delimiter ;






/*---------- TRIGER RANG BUOC SO LUONG THUC DON ---------- */
delimiter //
create trigger trigger_Valid_insertUpdateGoiMon after
update on goimon for each row 
begin
	declare v_SoLuongBan int;
	declare v_SoLuongCon int;
	declare v_TenThucDon varchar(100) charset utf8 ;
	select SoLuong, TenThucDon into v_SoLuongBan, v_TenThucDon  from INSERTED;
	select  SoLuongTon into v_SoLuongCon from ThucDon where TenThucDon = v_TenThucDon; 
	if ((v_SoLuongCon-v_SoLuongBan)<0)  then
		delete from goimon where IdBan = (SELECT MAX(Idban) FROM goimon);
	else 
		update ThucDon set SoLuongTon = v_SoLuongCon -  v_SoLuongBan 
					where TenThucDon = v_TenThucDon;
	 end if; 	
end//
delimiter;

-- drop trigger  trigger_Valid_insertUpdateGoiMon


						/*----- BANG PHANQUYEN-----*/

/*--------- Hien thi thong tin PHANQUYEN ----------------*/
delimiter //

create procedure spgetPhanQuyen()
Begin
	select pq.IdTaiKhoan as 'Id Tài Khoản',MatKhau as 'Mật Khẩu',nv.IdNhanVien as 'Id Nhân Viên', HoLot +Ten as 'Họ Tên'
	from PhanQuyen pq,NhanVien nv
	where pq.IdNhanVien = nv.IdNhanVien;
End //

DELIMITER ;


-- drop procedure spgetPhanQuyen
/*----------- Hien thi thong tin spgetPhanQuyenByIdTaiKhoan --------------*/
delimiter //

create procedure spgetPhanQuyenByIdTaiKhoan
(
	p_IdTaiKhoan	varchar (10)
)
begin
	select pq.IdTaiKhoan,MatKhau,nv.IdNhanVien,HoLot +Ten as 'Họ Tên'
	from PhanQuyen pq,NhanVien nv
	where IdTaiKhoan = p_IdTaiKhoan;
end //

delimiter ;


 -- drop proc spgetPhanQuyenByIdTaiKhoan
/*---------------- Insert PHANQUYEN -------------------*/
delimiter //

create procedure spInsertPhanQuyen
( 
		p_IdTaiKhoan			varchar (10),
		p_MatKhau				varchar(200),
		p_IdNhanVien			varchar(10)
)
Begin
	insert into PhanQuyen
	values(p_IdTaiKhoan,p_MatKhau,p_IdNhanVien );
End //

DELIMITER ;



-- DROP PROCEDURE spInsertPhanQuyen
/*---------------- Update PHANQUYEN -----------------*/
delimiter //

create procedure spUpdatePhanQuyen
(		
		p_IdTaiKhoan			varchar (10),
		p_MatKhau			varchar(200),
		p_IdNhanVien			varchar(10)
)
Begin
	update PhanQuyen set	
						MatKhau = p_MatKhau,
						IdNhanVien=p_IdNhanVien
	where IdTaiKhoan = p_IdTaiKhoan;	 
End //

DELIMITER ;


-- drop procedure spUpdatePhanQuyen
/*-------------------- Delete PHANQUYEN -------------------*/
delimiter //

create procedure spDeletePhanQuyen
(
	p_IdTaiKhoan			varchar (10)
)
begin
	Delete from PhanQuyen where IdTaiKhoan = p_IdTaiKhoan	; 
end //

delimiter ;


-- drop proc spDeletePhanQuyen