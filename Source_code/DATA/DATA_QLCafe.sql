﻿create database QL_Cafe;
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

ALTER TABLE Staff
ALTER COLUMN RoleStaff  nvarchar(50)

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
DateCheckIn	datetime,
DateCheckOut	datetime,
StatusBill  int not null,
Primary key (IdBill)
)
	
--Drop detail bill và bill để thêm datecheckin checkout
alter table DetailBill
drop constraint fk_b_db

drop table DetailBill
drop table Bill

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
('NV1',N'Lý Bảo Hoàng','C:\Users\ADMIN\Pictures\hinh-nen-anime-chill-full-hd_012439279.png','hungntps38090@gmail.com','123',N'Quản trị',0),
('NV2',N'Nguyễn Tuấn Hùng','C:\Users\ADMIN\Pictures\hinh-nen-anime-chill-full-hd_012439279.png','nguyenhunghocmon02@gmail.com','123',N'Nhân viên',0),
('NV3',N'Nguyễn Duy Thanh','C:\Users\ADMIN\Pictures\hinh-nen-anime-chill-full-hd_012439279.png','dthanhnd999@gmail.com','thanh999',N'Quản trị',1),
('NV4',N'Lý Minh Hoàng','C:\Users\ADMIN\Pictures\hinh-nen-anime-chill-full-hd_012439279.png','hungntps38090@gmail.com','123',N'Quản trị',0),
('NV5',N'Lý Minh Hoàng','C:\Users\ADMIN\Pictures\hinh-nen-anime-chill-full-hd_012439279.png','hoanglbps38288@gmail.com','123',1,0)

update Staff set RoleStaff = N'Nhân viên' where IdStaff = 'NV2'
	
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
create procedure ChangePass(
@email nvarchar(50),
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
	select IdProduct, NameProduct, Price, ImageProduct from Product where IdPT = @IdPT and StatusProduct = 1

/*Thông tin đồ ăn*/
create or alter proc TagProduct (@IdProduct nvarchar(20)) as
	select NameProduct, Price, IdProduct from Product where IdProduct = @IdProduct

	select * from Staff

-- Lấy danh sách nhân viên
alter proc GetStaff (@status int)
as
begin
	select IdStaff, Email, FullName, RoleStaff, StatusStaff, ImageStaff from Staff where StatusStaff = @status;
end


--Thêm NV
ALTER proc InsertStaff
(@FullName nvarchar(50), @ImageStaff nvarchar(500), @Email nvarchar(50), @Role int, @Status int)
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
alter proc UpdateStaff(@Id nvarchar(20), @FullName nvarchar(50), @ImageStaff nvarchar(500), @Email nvarchar(50), @Role int, @Status int)
as
begin

	Update Staff 
	Set
	FullName = @FullName, 
	ImageStaff = @ImageStaff,
	Email = @Email, 
	RoleStaff = @Role, 
	StatusStaff = @Status
	where IdStaff = @Id

end

-- Xóa nhân viên

create proc DeleteStaff (@Id nvarchar(20))
as
begin
	
	Delete from Staff where IdStaff = @Id

end

--Tìm kiếm nhân viên (tìm tất cả cột nếu combobox rỗng)
alter PROCEDURE SearchStaff
    @column VARCHAR(30),
    @value NVARCHAR(100),
    @status INT,
    @pageNumber INT,
    @pageSize INT,
    @totalRows INT OUTPUT,
    @totalPages INT OUTPUT
AS
BEGIN
    -- Declare variables for pagination
    DECLARE @offset INT, @fetch INT;

    -- Calculate offset and fetch values
    SET @offset = (@pageNumber - 1) * @pageSize;
    SET @fetch = @pageSize;

    -- Get total rows
    SELECT @totalRows = COUNT(*)
    FROM Staff
    WHERE 
        -- Ensure that StatusStaff is filtered correctly
        StatusStaff = @status AND
        (   -- Apply search condition based on the column parameter
            (@column = 'rong' AND 
             (IdStaff LIKE '%' + @value + '%' OR
              Email LIKE '%' + @value + '%' OR
              FullName LIKE '%' + @value + '%' OR
              RoleStaff LIKE '%' + @value + '%'))
            OR
            (@column <> 'rong' AND 
             CASE @column
                WHEN 'IdStaff' THEN IdStaff
                WHEN 'Email' THEN Email
                WHEN 'FullName' THEN FullName
                WHEN 'RoleStaff' THEN CAST(RoleStaff AS NVARCHAR(50)) -- Adjust size if needed
             END LIKE '%' + @value + '%')
        );

    -- Calculate total pages
    SET @totalPages = CEILING(CAST(@totalRows AS FLOAT) / @pageSize);

    -- Get paginated data
    SELECT IdStaff, Email, FullName, RoleStaff, StatusStaff, ImageStaff
    FROM Staff
    WHERE 
        -- Ensure that StatusStaff is filtered correctly
        StatusStaff = @status AND
        (   -- Apply search condition based on the column parameter
            (@column = 'rong' AND 
             (IdStaff LIKE '%' + @value + '%' OR
              Email LIKE '%' + @value + '%' OR
              FullName LIKE '%' + @value + '%' OR
              RoleStaff LIKE '%' + @value + '%'))
            OR
            (@column <> 'rong' AND 
             CASE @column
                WHEN 'IdStaff' THEN IdStaff
                WHEN 'Email' THEN Email
                WHEN 'FullName' THEN FullName
                WHEN 'RoleStaff' THEN CAST(RoleStaff AS NVARCHAR(50)) -- Adjust size if needed
             END LIKE '%' + @value + '%')
        )
    ORDER BY IdStaff -- Adjust this as needed
    OFFSET @offset ROWS
    FETCH NEXT @fetch ROWS ONLY;
END

-- Danh sách sản phẩm
create or alter proc GetProduct
as 
  begin 
      select IdProduct, NameProduct, Price, ImageProduct, StatusProduct, IdPT from Product
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
alter proc UpdateProduct (@idProduct nvarchar(20),
                            @nameProduct nvarchar(100),
							@price float,
							@imageProduct nvarchar(500),
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


-- Tìm kiếm sản phẩm
create proc SearchPr

-- Xử lý phân trang sản phẩm <Thanh>
-- Lấy trang
create proc GetPagedProduct
@PageIndex int,
@PageSize int
as
	begin
		select * from Product order by IdProduct offset(@PageIndex - 1) * @PageSize Rows Fetch next @PageSize Rows only;
	end

EXEC GetPagedProduct @PageIndex = 1, @PageSize = 10;

-- Lấy tổng số sản phẩm 
create proc GetTotalProductCount as select count(*) from Product

SELECT TOP 10 * FROM Product;

--Thêm bill--
CREATE OR ALTER PROCEDURE AddingBill(
    @IdTable NVARCHAR(10),
    @IdStaff NVARCHAR(10)
)
AS
BEGIN
    DECLARE @IdBill INT;

    -- Lấy giá trị lớn nhất của IdBill từ bảng Bill
    SELECT @IdBill = MAX(CAST(SUBSTRING(IdBill, 5, LEN(IdBill) - 4) AS INT))
    FROM Bill;

    -- Nếu không có bản ghi nào trong bảng Bill, đặt giá trị ban đầu cho @IdBill
    IF @IdBill IS NULL
    BEGIN
        SET @IdBill = 0;
    END

    -- Tăng giá trị của @IdBill lên 1
    SET @IdBill = @IdBill + 1;

    -- Thêm bản ghi mới vào bảng Bill
    INSERT INTO Bill (IdBill, IdPayment, IdTable, IdStaff, IdVoucher, StatusBill)
    VALUES ('bill' + CAST(@IdBill AS NVARCHAR(10)), NULL, @IdTable, @IdStaff, NULL, 1);

    -- Cập nhật trạng thái của bàn trong bảng TableCF
    UPDATE TableCF
    SET StatusTable = 1
    WHERE IdTable = @IdTable;
END;

--Thêm DetailBill--
create or alter proc AddingDetailBill(
	@IdTable nvarchar(10),
	@IdProduct nvarchar(20),
	@Amount int,
	@TotalPrice float)
as
			DECLARE @ID nvarchar(10)
			set @ID = (select IdBill from Bill where IdTable = @IdTable)
	insert DetailBill (IdBill, IdProduct, Amount, TotalPrice) values (@ID, @IdProduct, @Amount,  @TotalPrice)
