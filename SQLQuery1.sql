Create table Adminn(
user_namee varchar(100) primary key,
pass varchar(100),
);
insert into Adminn(user_namee , pass)
values
('Abdullah' , 'A333'),
('Mohamed' , '444k');
select*from Adminn;
---------------------------------------------
create table Userr(
id int identity primary key,
namee varchar(100),
gender varchar(100),
Age int,
Addresss varchar(100),
Department varchar(100),
);
insert into Userr( namee , gender , Age , Addresss , Department)
values
('Ahmed' , 'Male' , 20 , 'Cairo' , 'SW'),
('Ali' , 'Male' , 40 , 'Giza' , 'SW'),
('Nada' , 'Female' , 20 , 'Giza' , 'Ai'),
('Sama' , 'Female' , 17 , 'Cairo' , 'Network');
select *from Userr;
-----------------------------------------------------------
create table user_login(
user_namee varchar (100)primary key,
passwordd varchar(100),
);
insert into user_login(user_namee , passwordd)
values
('Ahmed99' , '123'),
('Ali345' , '345');
select*from user_login;