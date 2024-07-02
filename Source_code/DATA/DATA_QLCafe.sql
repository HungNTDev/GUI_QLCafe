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
('NV1',N'Lý Bảo Hoàng','C:\Users\ADMIN\Pictures\hinh-nen-anime-chill-full-hd_012439279.png','hungntps38090@gmail.com','123',1,0),
('NV2',N'Nguyễn Tuấn Hùng','C:\Users\ADMIN\Pictures\hinh-nen-anime-chill-full-hd_012439279.png','nguyenhunghocmon02@gmail.com','123',0,0)

create proc DangNhap (@email nvarchar(50), @password nvarchar(50))
as
begin
select * from staff where email = @Email and PasswordStaff = @password
end

create proc VaiTro (@email nvarchar(50))
as
begin
	select RoleStaff from staff where email = @email
end

create proc KiemTraEmail(@email nvarchar(50))
as
begin
	SELECT COUNT(email) FROM nhanvien WHERE email = @Email
end
