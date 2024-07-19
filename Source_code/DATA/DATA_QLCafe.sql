create database QL_Cafe;
use QL_Cafe;
create table Staff(
Id              int identity(1,1) not null ,
IdStaff         nvarchar(20) not null,
FullName        nvarchar(50) not null,
ImageStaff      nvarchar(500) not null,
Email           nvarchar(50) not null,
PasswordStaff   nvarchar(50) not null,
RoleStaff       int not null,
StatusStaff     int not null,
Primary key (IdStaff)
)

create table Voucher(
IdVoucher  nvarchar(10) not null,
NameVoucher nvarchar(100) not null,
PercentVoucher int not null,
StatusVoucher int not null,
Primary key (IdVoucher)
)

create table ProductType(
IdPT nvarchar(10) not null,
NamePT nvarchar(50) not null,
StatusPT int not null,
Primary key(IdPT)
)

create table TableCF(
IdTable nvarchar(10) not null,
NameTable nvarchar(20) not null,
StatusTable int not null,
Primary key (IdTable)
)

create table Payment(
IdPayment nvarchar(20) not null,
TypePayment nvarchar(20) not null,
StatusPayment int not null
Primary key (IdPayment)
)

create table Product(
IdProduct nvarchar(20) not null,
NameProduct nvarchar(20) not null,
Price float not null,
ImageProduct nvarchar(500) not null,
StatusProduct int not null,
IdPT nvarchar(10) not null,
Primary key (IdProduct)
)

create table Bill (
IdBill          nvarchar(20) not null,
IdPayment       nvarchar(20) not null,
IdTable         nvarchar(10) not null,
IdStaff         nvarchar(20) not null,
IdVoucher       nvarchar(10) not null,
StatusBill  int not null,
Primary key (IdBill)
)

create table DetailBill (
IdBill nvarchar(20) not null,
IdProduct nvarchar(20) not null,
TotalPrice float not null,
Amount int not null,
Primary key (IdBill, IdProduct)
)

alter table Product
add constraint fk_pt_p
Foreign key (IdPT) references ProductType(IdPT) 

alter table DetailBill 
add constraint fk_p_db
Foreign key (IdProduct) references Product(IdProduct)

alter table DetailBill 
add constraint fk_b_db
Foreign key (IdBill) references Bill(IdBill)

alter table Bill
add constraint fk_b_tb
Foreign key (IdTable) references TableCF(IdTable)

alter table Bill 
add constraint fk_b_p
Foreign key (IdPayment) references Payment(IdPayment) 

alter table Bill
add constraint fk_b_v
Foreign key (IdVoucher) references Voucher(IdVoucher)

alter table Bill
add constraint fk_b_st
Foreign key (IdStaff) references Staff(IdStaff)

insert into Staff(IdStaff, FullName, ImageStaff, Email, PasswordStaff, RoleStaff,StatusStaff) values
('NV4',N'Lý Minh Hoàng','C:\Users\ADMIN\Pictures\hinh-nen-anime-chill-full-hd_012439279.png','hungntps38090@gmail.com','123',1,0),
('NV1',N'Lý Bảo Hoàng','C:\Users\ADMIN\Pictures\hinh-nen-anime-chill-full-hd_012439279.png','hungntps38090@gmail.com','123',1,0),
('NV2',N'Nguyễn Tuấn Hùng','C:\Users\ADMIN\Pictures\hinh-nen-anime-chill-full-hd_012439279.png','nguyenhunghocmon02@gmail.com','123',0,0),
('NV3',N'Nguyễn Duy Thanh','C:\Users\ADMIN\Pictures\hinh-nen-anime-chill-full-hd_012439279.png','dthanhnd999@gmail.com','thanh999',1,1)
	
update Staff set RoleStaff = 1 where IdStaff = 'NV3'
	
('NV4',N'Lý Minh Hoàng','C:\Users\ADMIN\Pictures\hinh-nen-anime-chill-full-hd_012439279.png','hoanglbps38288@gmail.com','123',1,0)

go
	
insert into TableCF (IdTable, NameTable, StatusTable) values
('B01',N'Bàn 1',0),
('B02',N'Bàn 2',0),
('B03',N'Bàn 3',0),
('B04',N'Bàn 4',0),
('B05',N'Bàn 5',0),
('B06',N'Bàn 6',0),
('B07',N'Bàn 7',0),
('B08',N'Bàn 8',0),
('B09',N'Bàn 9',0),
('B10',N'Bàn 10',0),
('B11',N'Bàn 11',0),
('B12',N'Bàn 12',0),
('B13',N'Bàn 13',0),
('B14',N'Bàn 14',0),
('B15',N'Bàn 15',0),
('B16',N'Bàn 16',0),
('B17',N'Bàn 17',0),
('B18',N'Bàn 18',0),
('B19',N'Bàn 19',0),
('B20',N'Bàn 20',0),
('B21',N'Bàn 21',0),
('B22',N'Bàn 22',0),
('B23',N'Bàn 23',0),
('B24',N'Bàn 24',0),
('B25',N'Bàn 25',0),
('B26',N'Bàn 26',0),
('B27',N'Bàn 27',0),
('B28',N'Bàn 28',0),
('B29',N'Bàn 29',0),
('B30',N'Bàn 30',0)
	
update Staff set PasswordStaff='196145663720616991136127245362061123820032'
where IdStaff='NV1'
go

--Thêm loại sản phẩm--
insert into ProductType (IdPT, NamePT, StatusPT) values
('TEA',N'Trà',1),
('CFE',N'Cà phê',1),
('STO',N'Sinh tố',1),
('JUC',N'Nước ép',1)

delete from Product

--Thêm sản phẩm--
/*Trà*/
insert into Product (IdProduct, NameProduct, Price, ImageProduct, StatusProduct, IdPT) values
	('TEA1', N'Hồng trà đặc cam', 65000, '\img\Product\f881c559678a3d3fd31e4284b351c9a3.jpg', 1, 'TEA'),
	('TEA2', N'Trà lại đặc thơm', 50000, '\img\Product\f881c559678a3d3fd31e4284b351c9a3.jpg', 1, 'TEA'),
	('TEA3', N'Hồng trà chanh', 45000, '\img\Product\f881c559678a3d3fd31e4284b351c9a3.jpg', 1, 'TEA'),
	('TEA4', N'Hồng trà sữa', 50000, '\img\Product\f881c559678a3d3fd31e4284b351c9a3.jpg', 1, 'TEA'),
	('TEA5', N'Trà sữa Truyền Thống', 50000, '\img\Product\f881c559678a3d3fd31e4284b351c9a3.jpg', 1, 'TEA')

/*Cà phê*/
insert into Product (IdProduct, NameProduct, Price, ImageProduct, StatusProduct, IdPT) values
	('CFE1', N'Cà phê Cappuchino', 35000, '\img\Product\f881c559678a3d3fd31e4284b351c9a3.jpg', 1, 'CFE'),
	('CFE2', N'Cà phê Expresso', 30000, '\img\Product\f881c559678a3d3fd31e4284b351c9a3.jpg', 1, 'CFE'),
	('CFE3', N'Cà phê kem tươi', 40000, '\img\Product\f881c559678a3d3fd31e4284b351c9a3.jpg', 1, 'CFE'),
	('CFE4', N'Cà phê Vanilla', 40000, '\img\Product\f881c559678a3d3fd31e4284b351c9a3.jpg', 1, 'CFE'),
	('CFE5', N'Cà phê Caramel ', 40000, '\img\Product\f881c559678a3d3fd31e4284b351c9a3.jpg', 1, 'CFE')

/*Sinh tố*/
insert into Product (IdProduct, NameProduct, Price, ImageProduct, StatusProduct, IdPT) values
	('STO1', N'Sinh tố dâu', 55000, '\img\Product\f881c559678a3d3fd31e4284b351c9a3.jpg', 1, 'STO'),
	('STO2', N'Sinh tố chanh', 45000, '\img\Product\f881c559678a3d3fd31e4284b351c9a3.jpg', 1, 'STO'),
	('STO3', N'Sinh tố xoài', 50000, '\img\Product\f881c559678a3d3fd31e4284b351c9a3.jpg', 1, 'STO'),
	('STO4', N'Sinh tố nhiệt đới', 55000, '\img\Product\f881c559678a3d3fd31e4284b351c9a3.jpg', 1, 'STO'),
	('STO5', N'Sinh tố cà rốt', 40000, '\img\Product\f881c559678a3d3fd31e4284b351c9a3.jpg', 1, 'STO')

/*Nước ép*/
insert into Product (IdProduct, NameProduct, Price, ImageProduct, StatusProduct, IdPT) values
	('JUC1', N'Dâu ép', 55000, '\img\Product\f881c559678a3d3fd31e4284b351c9a3.jpg', 1, 'JUC'),
	('JUC2', N'Táo ép', 40000, '\img\Product\f881c559678a3d3fd31e4284b351c9a3.jpg', 1, 'JUC'),
	('JUC3', N'Táo và dâu ép i', 50000, '\img\Product\f881c559678a3d3fd31e4284b351c9a3.jpg', 1, 'JUC'),
	('JUC4', N'Thơm ép', 55000, '\img\Product\f881c559678a3d3fd31e4284b351c9a3.jpg', 1, 'JUC'),
	('JUC5', N'Bưởi ép', 40000, '\img\Product\f881c559678a3d3fd31e4284b351c9a3.jpg', 1, 'JUC')

--Đăng nhập
create proc DangNhap (@email nvarchar(50), @password nvarchar(50))
as
begin
	select * from staff where email = @Email and PasswordStaff = @password and StatusStaff = 1;
end
go

--Lấy vai trò
create proc VaiTro (@email nvarchar(50))
as
begin
	select RoleStaff from staff where email = @email
end
go


--Kiểm tra email có trong db hay không
create proc KiemTraEmail(@email nvarchar(50))
as
begin
	SELECT COUNT(email) FROM staff WHERE email = @Email
end

	-- Thay đổi mật khẩu
create procedure ChangePass (@email nvarchar(50),
                                  @opwd nvarchar(50),
				  @npwd nvarchar(50))
as
  declare @op nvarchar(50)
  select @op = PasswordStaff from Staff where Email = @email
  if @op = @opwd
  begin
       update Staff set PasswordStaff = @npwd where Email = @email
	   return 1
  end
  else 
       return -1
go


--Quên mật khẩu
create proc NewPass (@email nvarchar(50), @password nvarchar(50))
as
begin
	update Staff set PasswordStaff = @password where Email = @email
end

-- Xử lí bàn (Lý Bảo Hoàng) --
/*Danh sách bàn*/
create or alter proc TableList as
	select * from TableCF
	-- Xử lý bàn
create or alter proc TableList as
	select * from TableCF

/*Thông tin bàn*/
create or alter proc TableInfo (@IdTable nvarchar(10)) as
	select * from TableCF where IdTable = @IdTable

/*Load menu (hien danh sach thuc an theo loai)*/
create or alter proc ListMenu (@IdPT nvarchar(10)) as
	select IdProduct, NameProduct, Price, ImageProduct from Product where IdPT = @IdPT

/*Thông tin đồ ăn*/
create or alter proc TagProduct (@IdProduct nvarchar(20)) as
	select NameProduct, Price, IdProduct from Product where IdProduct = @IdProduct

-- Lấy danh sách nhân viên
create proc GetStaff
as
begin
	select Email, FullName, RoleStaff, StatusStaff, ImageStaff from Staff where StatusStaff = 1;
end

-- Thêm nhân viên
create proc InsertStaff
(@Id nvarchar(20), @FullName nvarchar(50), @ImageStaff nvarchar(50), 
@Password nvarchar(50), @Email nvarchar(50), @Role int, @Status int)
as
begin
	DECLARE @IdStaff VARCHAR(20);
	DECLARE @stt INT;
	SELECT @stt = ISNULL(MAX(ID),0) + 1 FROM Staff
	SELECT @IdStaff = 'NV' + RIGHT(CAST (@stt AS VARCHAR(4)), 4)

	DECLARE @PASSWORD nvarchar(50)

	if (@Role = 1)
		begin
			Set @PASSWORD = '196145663720616991136127245362061123820032'
		end
	else
		begin
			Set @PASSWORD = '196145663720616991136127245362061123820032'
		end

	Insert into Staff (IdStaff, FullName, ImageStaff, PasswordStaff, Email, RoleStaff, StatusStaff) 
	values (@IdStaff, @FullName, @ImageStaff, @Password, @Email, @Role, @Status)

end


-- Sửa nhân viên
create proc UpdateStaff(@Id nvarchar(20), @FullName nvarchar(50), @ImageStaff nvarchar(50), 
@Password nvarchar(50), @Email nvarchar(50), @Role int, @Status int)
as
begin

	Update Staff 
	Set 
	FullName = @FullName, 
	ImageStaff = @ImageStaff, 
	PasswordStaff = @Password, Email = @Email, 
	RoleStaff = @Role, StatusStaff = @Status
	where IdStaff = @Id

end

-- Xóa nhân viên

create proc DeleteStaff (@Id nvarchar(20))
as
begin
	
	Delete from Staff where IdStaff = @Id

end

-- Danh sách sản phẩm
create proc GetProduct
as 
  begin 
      select IdProduct, NameProduct, Price, ImageProduct, StatusProduct from Product
 end 

 -- Thêm sản phẩm

 create proc InsertProduct (@idProduct nvarchar(20),
                            @nameProduct nvarchar(100),
							@price float,
							@imageProduct nvarchar(500),
							@statusProduct int,
							@idpt nvarchar(10))
as 
  begin
       insert into Product  (IdProduct, NameProduct, Price, ImageProduct, StatusProduct, IdPT )
	   values 
	   (@idProduct, @nameProduct, @price, @imageProduct, @statusProduct, @idpt)
  end

-- Sửa sản phẩm
  create proc UpdateProduct (@idProduct nvarchar(20),
                            @nameProduct nvarchar(100),
							@price float,
							@imageProduct nvarchar(500),
							@statusProduct int,
							@idpt nvarchar(10))
as 
 begin 
     update Product set
	 NameProduct= @nameProduct, Price = @price, ImageProduct= @imageProduct, IdPT=@idpt
	 where IdProduct=@idProduct
end

-- Xóa sửa phẩm
create proc DeleteProcduct (@id nvarchar(20))
as
  begin 
      update Product set StatusProduct = 0 
	  where IdProduct = @id
end
