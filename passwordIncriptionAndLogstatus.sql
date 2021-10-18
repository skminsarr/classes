create table userdata
(
 id nvarchar(20) primary key,
 pwd varbinary(100)
 
)


create table sesdata
(
 sesid int,
 useid nvarchar(20) references userdata(id),
 logstat bit default 0
  
)

select * from userdata
select * from sesdata
create proc newuserid @id nvarchar(20),@pwd nvarchar(50), @n int out
as
begin
   declare @count int
   set @count=(select COUNT(*) from userdata where id=@id)
   if(@count >0)
   begin
     set @n =-1
   end
   else
   begin
     insert into userdata values(@id,HASHBYTES('SHA',@pwd))
     insert into sesdata values(0,@id,0)
     set @n=0
   end
end

declare @num int
exec newuserid '2','123456',@n =@num out
select @num

alter proc newuserlogin @id nvarchar(20),@pwd nvarchar(50), @sesno int out
as
begin
  declare @count int=-1
  set @count=(select COUNT(*) from userdata where id=@id and pwd=HASHBYTES('SHA',@pwd))
  if(@count>0)
  begin
    
    update sesdata set sesid=sesid+1, logstat=1 where useid = @id
    set @sesno=(select sesid from sesdata where useid=@id)
  end
  else
  begin
    set @sesno=-1
  end
  
end

declare @num int
exec newuserlogin '2','123456', @sesno=@num out
select @num
