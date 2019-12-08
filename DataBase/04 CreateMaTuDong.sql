
Use dbSoftQuanLyNhaHang;


-- Bảng : NHÂN VIÊN
delimiter //
Create function fcgetIdNhanVien()
returns varchar(10)
Begin
		Declare _IdNhanVien varchar(10);
		Declare _MaxIdNhanVien varchar(10);
		Declare _Max float;
		Select _MaxIdNhanVien = MAX(IdNhanVien) from NhanVien;
		if exists (select IdNhanVien from NhanVien) then
				set _Max = CAST( SUBSTRING(_MaxIdNhanVien,3,8) as decimal(10,3))  + 1;
		else set _Max= 1	;
        end if;
		if (_Max < 10) then 
                set _IdNhanVien = CONCAT('NV','0000000', Convert(_Max,char));
		elseif (_Max < 100) then
				set _IdNhanVien='NV' + '000000' + Convert(_Max,char(2));
		elseif (_Max < 1000) then
				set _IdNhanVien='NV' + '00000' + Convert(_Max,char(3));
		elseif (_Max < 10000) then
				set _IdNhanVien='NV' + '0000' + Convert(_Max,char(4));
		elseif (_Max < 100000) then
				set _IdNhanVien ='NV' + '000' + Convert(_Max,char(5));
		elseif (_Max < 1000000) then
				set _IdNhanVien  ='NV' + '00' + Convert(_Max,char(6));
		elseif (_Max < 10000000) then
				set _IdNhanVien ='NV' + '0' + Convert(_Max,char(7));
		else
				set _IdNhanVien ='NV' +  Convert(_Max,char(8));
		end if;
	Return _IdNhanVien;
End//
delimiter ;
    
	-- select IdNhanVien=dbo.fcgetIdNhanVien()
 ---- BANG KHACHHANG ----------------
delimiter //
Create function fcgetIdKhachHang()
returns varchar(10)
Begin
		Declare _IdKhachHang varchar(10);
		Declare _MaxIdKhachHang varchar(10);
		Declare _Max float;
		Select _MaxIdKhachHang = MAX(IdKhachHang) from KhachHang;
		if exists (select IdKhachHang from KhachHang) then
			set _Max = CAST( SUBSTRING(_MaxIdKhachHang,3,8) as decimal(10,3)) + 1;
		else
			set _Max=1	;
		end if;
		if (_Max < 10) then
			set _IdKhachHang ='KH' + '0000000' + Convert(_Max,char);
		elseif (_Max < 100) then
			set IdKhachHang='KH' + '000000' + Convert(_Max,char(2));
		elseif (_Max < 1000) then
			set _IdKhachHang='KH' + '00000' + Convert(_Max,char(3));
		elseif (_Max < 10000) then
			set _IdKhachHang='KH' + '0000' + Convert(_Max,char(4));
		elseif (_Max < 100000) then
			set _IdKhachHang ='KH' + '000' + Convert(_Max,char(5));
		elseif (_Max < 1000000) then
			set _IdKhachHang  ='KH' + '00' + Convert(_Max,char(6));
		elseif (_Max < 10000000) then
			set _IdKhachHang ='KH' + '0' +Convert(_Max,char(7));
		else
			set _IdKhachHang ='KH' +  Convert(_Max,char(8));
		end if;
	Return _IdKhachHang;
End//
delimiter ;
	-- select IdKhachHang=dbo.fcgetIdKhachHang()
	
	/*--------------- BANG KHU VUC ------------*/
delimiter //
Create function fcgetIdkhuVuc()
returns varchar(5)
Begin
		Declare _IdKhuVuc varchar(5);
		Declare _MaxIdKhuVuc varchar(5);
		Declare _Max float;
			
			
			Select _MaxIdKhuVuc = MAX(IdKhuVuc) from KhuVuc;
			
			if exists (select IdKhuVuc from KhuVuc) then
					set _Max = CAST( SUBSTRING(_MaxIdKhuVuc,3,3) as decimal(10,3)) + 1;
			else
						set _Max=1	;
			end if;
			if (_Max < 10) then
					set _IdKhuVuc='KV' + '00' + Convert(_Max,char(1));
			elseif (_Max < 100) then
						set _IdKhuVuc='KV' + '0' + Convert(_Max,char(2));
			else
						set _IdKhuVuc ='KV' +  Convert(_Max,char(3));
			end if;
			Return _IdKhuVuc;
	End //
    delimiter ;
	-- select IdKhachHang=dbo.fcgetIdKhuVuc()
	
					/*-------- BANG BAN ---------*/

	delimiter //
	Create function fcgetIdBan()
	returns varchar(5)
	Begin
			Declare _IdBan varchar(5);
			Declare _MaxIdBan varchar(5);
			Declare _Max float;
			Select _MaxIdBan = MAX(IdBan) from Ban;
			
			if exists (select IdBan from Ban) then
						set _Max = CAST( SUBSTRING(_MaxIdBan,4,2) as decimal(10,3)) + 1;
			else
						set _Max=1	;
			end if;
			if (_Max < 10) then
						set _IdBan='BAN' + '0' + Convert(_Max,char(1));
			else
						set _IdBan ='BAN' +  Convert(_Max,char(3));
			end if;
			Return _IdBan;
	End //
    delimiter ;
	-- select IdBan=dbo.fcgetIdBan()
	
			/*----- BANG LOAITHUCDON ----------*/
		delimiter //
	Create function fcgetIdLoaiThucDon()
	returns varchar(5)
	Begin
			Declare _IdLoaiThucDon		varchar(5);
			Declare _MaxIdLoaiThucDon	varchar(5);
			Declare _Max float;
			
			
			Select _MaxIdLoaiThucDon = MAX(IdLoaiThucDon) from LoaiThucDon;
			
			if exists (select IdLoaiThucDon from LoaiThucDon) then
						set _Max = CAST( SUBSTRING(_MaxIdLoaiThucDon,4,2) as decimal(10,3)) + 1;
			else
						set _Max=1	;
			end if;
			if (_Max < 10) then
						set _IdLoaiThucDon='LTD' + '0' + Convert(_Max,char(1));
			else
						set _IdLoaiThucDon ='LTD' +  Convert(_Max,char(3));
			end if;
			Return _IdLoaiThucDon;
	End //
    delimiter ;

	-- select IdLoaiThucDon=dbo.fcgetIdLoaiThucDon()
	
	
			/*----- BANG THUCDON ----------*/
		delimiter //
Create function fcgetIdThucDon()
returns varchar(5)
Begin
			Declare _IdThucDon		varchar(5);
			Declare _MaxIdThucDon	varchar(5);
			Declare _Max float;
			
			
			Select _MaxIdThucDon = MAX(IdThucDon) from ThucDon;
			
			if exists (select IdThucDon from ThucDon) then
						set _Max = CAST( SUBSTRING(_MaxIdThucDon,3,3) as decimal(10,3)) + 1;
			else
						set _Max=1	;
			end if;
			if (_Max < 10) then
						set _IdThucDon='TD' + '00' +Convert(_Max,char(1));
			elseif (_Max < 100) then
						set _IdThucDon='TD' + '0' + Convert(_Max,char(2));
			else
					set _IdThucDon ='TD' +  Convert(_Max,char(3));
			end if;
			Return _IdThucDon;
	End //
    delimiter ;
	-- select IdThucDon=dbo.fcgetIdThucDon()