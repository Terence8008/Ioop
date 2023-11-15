Create database IOOPAssignment

use IOOPAssignment;

Drop table Accounts;
Create Table Accounts(
UserID int primary key identity(1,1),
Username varchar(100),
Password varchar(100),
Role varchar(100))

select * from Accounts

insert into Accounts values
('Terence','Terence123','Customer'),
('Jun','Jun123','Manager'),
('Angelina','Angelina123','Worker'),
('Sam','Sam123','Admin');

Create table Request(
RequestID int primary key identity(1,1) Not NUll,
ServiceID int Foreign Key References Services(ServiceID),
Requester varchar(100),
RequestStatues varchar (10),
UrgentStatues bit NULL,
RequestQuantity int,
Worker varchar(100))

Select * from Request;
Select * from Request where Requester = 'Terence';
UPDATE Request
SET Worker = '2'
WHERE RequestID = 1;
Drop table Request;
DBCC CHECKIDENT (Request, RESEED)
Delete From Request where RequestID = 6;

insert into Request values
(1,'Terence','Completed',1,12,NUll);


Create table Services(
ServiceID int primary key identity(1,1),
ServiceName varchar(100),
ServicePrice decimal(5,2));

Select * from Services;
Select * from Services where ServiceID = 1;
Delete From Services;
Drop table Services;

insert into Services values
('Printing A4 - Black and White', 0.80),
('Printing A4 - Color', 2.50),
('Binding - Comb Binding', 5.00),
('Binding - Think Cover', 15.00),
('Poster printing(A0 - A3)', 3.00),
('Banner', 10.00);

ALTER TABLE users
RENAME COLUMN WorkerName TO Worker;
