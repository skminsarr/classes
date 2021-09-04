create table india
(
  state nvarchar(50),
  dist nvarchar(50)
)

insert into india values('kerala','kozhikode')

select dist from india where state='wb'


create table userdata
(
  uid nvarchar(20),
  pwd varbinary(max)
)
select * from userdata
create proc procinsert @uid nvarchar(20),@pwd nvarchar(20)
as
begin
  insert into userdata values(@uid,HASHBYTES('SHA',@pwd))
end


create proc userlogin @uid nvarchar(20), @pwd nvarchar(20)
as
begin
   declare @n int
   set @n=(select COUNT(*) from userdata where uid=@uid and pwd=HASHBYTES('SHA',@pwd))
   if(@n=0)
    begin
      print 'Login Failed Wrong password'
    end
   else
    begin
      print 'Welcome'
    end 
end

exec procinsert 'u001','123456'

exec userlogin 'u002','123456'
