/*
create database BanHang
go
*/

use BanHang
go



create table KhachHang
(
	MaKH nvarchar(10) not null constraint pk_mkh primary key,
	HoTen nvarchar(50) not null,
	SoDT char(10) not null,
	DiaChi nvarchar(50) not null,
	TenDangNhap char(30) not null,
	MatKhau char(30) not null
)

create table Menu
(
	STT int not null,
	MaSP char(10) constraint pk_mm primary key,
	TenSP nvarchar(50) not null,
	Gia int not null,
	SoLuong int not null,
	Loai nvarchar(20) not null,
	HinhAnh varchar(30) not null
)

//Cần thêm mã khách hàng
create table HoaDon
(
	MaHD char(10) constraint pk_mahd primary key,
	MaKH nvarchar(10) constraint fk_mm foreign key references KhachHang(MaKH) on delete cascade on update cascade,
	NgayBan Date not null,
	TongTien int not null
)

//Cần thêm mã khách hàng và thêm mã khách hàng cũng là khóa chính 
create table CTHD
(
	MaHD char(10) constraint fk_mhd foreign key references HOADON(MaHD) on delete cascade on update cascade,
	MaSP char(10) constraint fk_mmcthd foreign key references Menu(MaSP) on delete cascade on update cascade,
	MaKH nvarchar(10),
	SoLuong int not null,
	Gia int not null,
	primary key(MaHD, MaSP)
)

create table TrangThai
(
	MaHD char(10) constraint fk_mhdtt foreign key references HoaDon(MaHD) on delete cascade on update cascade,
	TinhTrang nvarchar(40)
	primary key(MaHD)
)

create table GioHang
(
	STT int,
	MaKH nvarchar(10) constraint fk_mkhgh foreign key references KhachHang(MaKH) on delete cascade on update cascade,
	MaSP char(10) constraint fk_msp foreign key references Menu(MaSP) on delete cascade on update cascade,
	TenSP nvarchar(50) not null,
	Gia int not null,
	SoLuong int not null,
	Loai nvarchar(20) not null,
	HinhAnh varchar(30) not null,
	primary key(MaKH, MaSP)
)

select * from Menu

insert into CTHD values('HD1', 'DH1', 'KH1',5,15000)
insert into CTHD values('HD1','GB2','KH1',5,80000)
insert into CTHD values('HD2','DH2','KH1',1,200000)
insert into CTHD values('HD3','QCT2','KH1',1,150000)
insert into CTHD values('HD3','HN3','KH1',2,100000)

insert into HoaDon values ('HD1', 'KH1', '10/10/2023', 13000000)
insert into HoaDon values ('HD2', 'KH1', '1/11/2023', 200000)
insert into HoaDon values ('HD3', 'KH1', '2/11/2023', 350000)

insert into KhachHang values ('KH1', 'Le An', '0983728394', 'Quy Nhon', 'lean', '1111')

insert into GioHang values(1, 'KH1','DH1',N'Đồng hồ cát đồng 3 trụ',150000,2,N'Đồng hồ','dh3tru')
insert into GioHang values(2, 'KH1','HN3',N'Hộp nhạc tàu anh qua núi',100000,	3,	N'Hộp nhạc',	N'hntauanhquanui')

insert into TrangThai values('HD1', N'Chờ xác nhận')
insert into TrangThai values('HD2', N'Đã giao')
insert into TrangThai values('HD3', N'Đang giao')

/*
insert into Menu values (1,'DH1',N'Đồng hồ cát đồng 3 trụ',150000,20,N'Đồng hồ','dh3tru.png')
insert into Menu values( 2,'DH2',N'Đồng hồ cát vòng xoay',200000,20,N'Đồng hồ','dhcatvongxoay.png')
insert into Menu values(3,'DH3',N'Đồng hồ cát gỗ màu nâu',80000,15,N'Đồng hồ','dhmaunau.png')
insert into Menu values(4,'DH4',N'Đồng hồ xe đạp 2 mặt',220000,6,N'Đồng hồ','dhxedap.png')                       
insert into Menu values(5,'GB1',N'Doremon',200000,20,	N'Gấu', N'Doremon.png')                       
insert into Menu values(6,'GB2',N'Teddy Nhỏ',80000,20,N'Gấu',N'teddynho.png')                      
insert into Menu values(7,'GB3',N'Gấu Mèo',80000,20,N'Gấu',N'meo.png')                           
insert into Menu values(8,'GB4',N'Gấu Bear',130000,20,N'Gấu',N'bear.png')                        
insert into Menu values(9,'HN1',N'Hộp nhạc bốt điện thoại',160000,20,	N'Hộp nhạc',N'hnbotdienthoai.png')                
insert into Menu values(10,'HN2',N'Hộp nhạc gỗ trái tim',130000,20,N'Hộp nhạc',N'hngotraitim.png' )                  
insert into Menu values(11,'HN3',N'Hộp nhạc tàu anh qua núi',100000,	15,	N'Hộp nhạc',	N'hntauanhquanui.png')                
insert into Menu values(12,'PL1',N'Pha lê cỏ 4 lá',140000,	15,	N'Pha lê',	N'phaleco4la.png')                    
insert into Menu values(13,'PL2',N'Pha lê bồ công anh',130000,	15,	N'Pha lê',	N'plboconganh.png')                   
insert into Menu values(14,'PL3',N'Pha lê cỏ 4 lá tròn',140000,15,	N'Pha lê',	N'plco4la.png')                       
insert into Menu values(15,'PL4',N'Pha lê hoa hồng',160000,20,	N'Pha lê',	N'plhoahong.png')                     
insert into Menu values(16,'PL5',N'Pha lê thiên hà',120000,20,	N'Pha lê',	N'plthienha.png')                     
insert into Menu values(17,'QCT1',N'Quả cầu tuyết Love',150000,20,	N'Quả cầu tuyết',	N'qctlove.png')                       
insert into Menu values(18,'QCT2',N'Quả cầu tuyết gấu tím',150000,25,	N'Quả cầu tuyết',	N'qctgautim.png' )                    
insert into Menu values(19,'QCT3',N'Quả cầu tuyết Doremon',160000,20,	N'Quả cầu tuyết',	N'qctdoremon.png')                    
*/
/*
drop table KhachHang
drop table HoaDon
drop table Menu
drop table CTHD
drop table TrangThai
drop table GioHang
*/