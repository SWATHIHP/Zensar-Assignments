/*
1.	Write a T-SQL Program to generate complete payslip of a given employee with respect to the following condition
a)	HRA  as 10% Of sal
b)	DA as  20% of sal
c)	PF as 8% of sal
d)	IT as 5% of sal
e)	Deductions as sum of PF and IT
f)	Gross Salary as sum of SAL,HRA,DA and Deductions
g)	Net salary as  Gross salary- Deduction
*/

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
/*Write a T-SQL Program to Display complete result of a given student. 
(Note: Consider 10th standard result sheet and Student table structure as (sno,sname,maths,phy,comp)
*/

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
--Write a T-SQL Program to find the factorial of a given number.


declare @fact int=1,@given_num int = 6		
while @given_num > 0
begin
set @fact = @given_num*@fact		
set @given_num=@given_num-1		
end 		
select @fact as 'Factorial'

--+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
--Create a stored procedure to generate multiplication tables up to a given number.

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
/*
Create a user defined function calculate Bonus for all employees of a  given job using following conditions
a.	       For Deptno10 employees 15% of sal as bonus.
b.	       For Deptno20 employees  20% of sal as bonus
c.	      For Others employees 5%of sal as bonus
*/

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

--+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
/*Create a trigger to restrict data manipulation on EMP table during General holidays. 
Display the error message like “Due to Independence day you cannot manipulate data”
Note: Create holiday table as (holiday_date,Holiday_name) store at least 4 holiday details*/

create table General_Holiday
(Holiday_Date varchar(30),
Holiday_Name varchar(40) primary key)

select * from General_Holiday

insert into General_Holiday
values('15-August','Independence Day'),
('26-January','Republic Day'),
('10-April','Rama Navami'),
('14-April','Ambedkar Jayanti'),
('2-October','Ghandhi Jayanti'),
('25-December','Christmas Day')

create or alter trigger trgRestrict_Data_Manipulation
on General_Holiday
instead of delete,insert,update
as
begin
  raiserror('Due to Public Holiday you cannot Manipulate Data',16,1)
end

insert into General_Holiday
values('5-Sep', 'Teachers Day')

update General_Holiday set Holiday_Date = '4-Aug' where Holiday_Date = '5-Sep'

delete from General_Holiday where Holiday_Date = '15-Aug'

select * from General_Holiday




