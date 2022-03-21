create database EmployeManagement

use EmployeManagement

create table Code_Employee(empno int primary key,
empname varchar(50) not null,
empsal numeric(10,2) check(empsal>=25000),
emptype varchar(1) check(emptype in('C','P')))
   

create or alter procedure AddNewEmployee @ename varchar(50), @esal numeric(10,2), @etype varchar(1)
as
 begin 
  declare @eid int = (select max(empno) from Code_Employee)
  if(@eid is null)
  begin
    set @eid = 0;
    declare @empid int = @eid + 1;
    insert into Code_Employee values(@empid, @ename, @esal, @etype)
  end
  else
  begin
   declare @empid1 int = @eid + 1;
   insert into Code_Employee values(@empid1, @ename, @esal, @etype)
  end
end

select * from Code_Employee
