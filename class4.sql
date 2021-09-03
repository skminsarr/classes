create table booking
(
 bookid int ,
 bookdate date,
 noofpt int,
 constraint pk_booking primary key(bookid,bookdate)
 
)

create table bookstatus
(
 bookst bit,
 bookid int,
 bookdate date,
 
 --foreign key(bookid,bookdate) references booking(bookid,bookdate)
 
)
drop table booking
alter table bookstatus add constraint fk_bookstatus foreign key(bookid,bookdate) references booking(bookid,bookdate)
drop table bookstatus

alter table booking alter column bookid int not null
alter table booking alter column bookdate date not null
alter table booking add constraint pk_booking primary key(bookid,bookdate)

alter table bookstatus drop constraint fk_bookstatus
alter table booking drop constraint PK_booking_C33FEC8B7226EDCC

alter table booking drop column noofpt
alter table booking add noofpt int
select * from booking

insert into booking values(1,'2021-08-17',500)


create table orderdetails
(
 orderid int,
 dtoford date,
 itm nvarchar(20),
 sellingprice float
)
select SUM(sellingprice) from orderdetails where dtoford>='2021-07-01' and dtoford<='2021-07-31'
drop table orderdetails
insert into orderdetails values(4,'2021-08-16','item5')
select top 20 percent * from orderdetails  order by orderid desc
select count(*)  from orderdetails
select * from student
select  count(address) from student where address='dinajpur'
insert into student values(7,'diamond','Dinajpur')
select * from student where address like '[a-f]%'

select regno as 'Registration No' , name as 'Name', address as 'ADD' from student


create table marks
(
 examst nvarchar(10),
 regno int,
 
)

insert into marks values('pass',3)
select * from student
select * from marks

select regno,name,address from student where regno in(select regno from marks where examst='fail')
select s.regno, s.name,s.address, m.examst from student s , marks m where s.regno=m.regno and m.examst='fail'
select student.regno, student.name,student.address,marks.examst from student right join marks on student.regno=marks.regno






alter proc proc1
as 
begin
  select regno,name,address from student where regno in(select regno from marks where examst='fail')
end  

drop proc proc1

exec proc1

insert into student values(9,'xyz','kolkata')

create proc procstudata @regno int, @name nvarchar(50), @address nvarchar(100)
as
begin
  insert into student(regno,name,address) values(@regno,@name,@address)
end 

exec procstudata 11,'kkkk','malda'

select * from student
