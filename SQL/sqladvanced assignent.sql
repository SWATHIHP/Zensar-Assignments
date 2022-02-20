
begin
declare @salary float=33000
declare @HRA float, @DA float, @PF float, @IT float,@Deduction float,@Gross_salary float
declare @Net_salary float,@sum float
set @HRA=@salary*0.1
print '---Salary Slip---'

print 'HRA is'
print @HRA
set @DA=@salary*0.2
print 'DA is'
print @DA
set @PF=@salary*0.08
print 'PF is'
print @PF
set @IT=@salary*0.05
set @Deduction=@Pf+@IT
set @sum=@salary-(@hra+@Da+@Deduction)
set @Gross_salary=@sum+(@hra+@Da+@Deduction)
print 'Gross Salary is:'
print @Gross_salary
set @Net_salary=@Gross_salary-@Deduction
print 'Net salary is:'
print @Net_salary
end
--+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

begin
declare @SNo int,@SName varchar(20),@Maths int,@Phy int,@Comp int
declare @Total int,@Percentage float
declare @Resultss varchar(20)
set @SNo=101
set @SName='Swathi'
set @Maths=90
set @Phy=91
set @Comp=96
set @Total=(@Maths+@Phy+@Comp)
set @Percentage=(@Total*100)/300
print @Percentage
create table Result
(Sno int,Sname varchar(20),Maths int,Physics int,Computer int,Total int,Percentage int)
insert into Result
values(@SNo,@SName,@Maths,@Phy,@Comp,@Total,@Percentage)
select *from Result
end
drop table Result


--+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

declare @fact int=1,@given_num int = 6		
while @given_num > 0
begin
set @fact = @given_num*@fact		
set @given_num=@given_num-1		
end 		
select @fact as 'Factorial'

--+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
create procedure multi  @num int
as
begin
declare @i int = 1;
declare @j int = 1;
print 'Multipliction tables upto ' + convert(varchar, @num) + ':'
while (@j <= @num)
begin
while (@i <= 10)
begin
print convert(varchar, @j) + ' x ' + convert(varchar,@i) + '= ' + convert(varchar, @i*@j);
set @i = @i + 1;
end
print '------------------'
set @i = 1
set @j = @j + 1;
end
end

exec multi 5



--+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
create table EMP (Empid int,Empname varchar(20),Salary float,Dept int)

insert into EMP values
(101,'SHAMSHUDDIN',12000,10),
(102,'SIMI',9000,30),
(103,'PRAJWAL',11000,20),
(104,'GEETHA',55000,10),
(105,'SAHIR',7500,40),
(106,'SHRIKANT',11000,20),
(107,'SWATHI',15000,10),
(108,'HEMANT',7200,20),
(109,'AMAAN',8300,30),
(110,'ARMAN',8990,20)

select * from EMP


create or alter function Emp_bonus1 (@deptid int)
returns @EmpBonus table (Empid int,Empname varchar(20),Salary float,bonus float,Dept int)
as begin
if @deptid = 10
begin
insert into @EmpBonus
select Empid, Empname, Salary,Salary/100*15 as Bonus,Dept from EMP where Dept = @deptid
end
else if @deptid = 20
begin
insert into @EmpBonus
select Empid, Empname, Salary,Salary/100*20 as Bonus,Dept from EMP where Dept = @deptid
end
else
begin
insert into @EmpBonus
select Empid, Empname, Salary,Salary/100*5 as Bonus,Dept from EMP where Dept = @deptid
end
return
end

select * from Emp_bonus1(10)
select * from Emp_bonus1(20)
select * from Emp_bonus1(30)
select * from Emp_bonus1(40)




