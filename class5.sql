select count(*) from student
select * from student

create proc proc2 @reg int, @name nvarchar(50),@address nvarchar(50),@num int output 
as
begin
     declare @n int
     insert into student values(@reg,@name,@address)
     set @num=(select count(*) from student)
     set @n=(select count(*) from student)
     if(@n>10)
     begin
       select * from student
       
     end
     else
     begin
        select * from marks
     end
     select * from student
     
end

create proc proc3
as
begin
  select * from student
end


exec proc3 

declare @n int 
exec proc2 10,'adil','mednipur',@num=@n output
select @n


alter proc proc4
as
begin
  declare @num int
  set @num=1
  while(@num<10)
   begin
     insert into student values(@num,'abc','xyz')
     
     set @num=@num+1
   end
end

exec proc4
select * from student

create database dbna
drop database dbna

select * from student where regno is not null
select * from student where regno is null
insert into student(name,address) values('wadil','xyz')

select ROW_NUMBER() over(order by regno) as 'SI NO', regno,name, address  from student
