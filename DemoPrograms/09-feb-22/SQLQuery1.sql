-- single line comment
/* multiline command
to create new database */
create database ZensarDB

--either thru the connect window symbol or issue the below command to connect to a particular database
use ZensarDB

--to create table <tablename>(col_name col_type constraints)
create table Depatment
(DeptId int primary key,
DeptName varchar(20) not null,
Budget float null)

create table Employee
(EmpId int primary key,
EmpName varchar(40),
Email nvarchar(20) unique,
Gender char(7),
Salary float ,
Dept int foreign key references Depatment(DeptId))

--to drop a table from the database schema
drop table Employee

--Query the table
select * from Depatment
select * from Employee

-- to get help on the table
sp_help Depatment
sp_help Employee

--to insert some data into few columns of the table
insert into Depatment(DeptId,DeptName)
values (1,'IT')

----to insert some data into all the columns of the table
insert into Depatment
values (2,'HR',null)

--to insert more than one values
insert into Depatment
values(3,'Ademin',45000),
(4,'Accounts',40000)

--to add a column to the already existing Department
alter table Depatment
add Loc varchar(20) 

--to remove a column from the table
alter table Depatment
drop column Loc

--to give values to the newly added column Loc
--use-> update<tablename> set<columnname>=value
update Depatment
set Loc ='Banglore'
where DeptId=1
--or
update Depatment set Loc='Pune' where DeptName='Admin'

--to add a constraint to the already existing table
--you have to alter and give a constraint name to the type of constraint using a keywod
alter table Employee
add constraint ChkSalary check(Salary >=5000)

--to drop a constraint
alter table Employee
drop constraint ChkSalary check(Salary>=5000)

--to insert a record/tuple/row into employee
insert into Employee
values(101,'Namjoon','namjoon@zensar.com','Male',55000,2)

insert into Employee
values(102,'Yoongi','yoongi@zensar.com','Male',60000,1)

insert into Employee
values(105,'Jimin','jiminie@zensar.com','Male',80000,3),
(104 ,'Jin','jinnie@zensar.com','Male',35000,2),
(103,'Jhope','hoeseok@zensar.com','Male',45000,3)
insert into employee
values(108,'Youngjae','youngjae@zensar.com','Male',5000,4),
(111,'Marktuan','marktuan@zensar.com','Male',10000,3)


--to delete one row from the employee table
delete from Employee
where EmpId=101

--projection
select EmpId, Gender, Salary from Employee

--alias names are meant for the purpose of display or some reference purpose
select EmpId 'Employee Id' from employee

--to retrieve top record
select top 2 * from employee
select top 30 percent EmpName,Salary from employee

--operators(arihmetic,relational,logical,bitwise,comparision,compound +=)
select salary,Salary*12 'Annual Salary' from employee
where dept=3

select EmpName from Employee where Salary>40000 and salary<55000

--to check for null values
select empname,dept from employee where dept is null
select empname,dept from employee where dept is not null

--wildcard pattern matching(%, _, [], ^)
select * from employee where empname like 'J%'
select * from employee where empname like '%n'
select * from employee where empname like 'J%n'
select * from employee where empname like 'J__%'
select * from employee where empname like 'y__n%'
select * from employee where empname like 'y[on]%'
select * from employee where empname like 'j[^in]%'--no name should contain 'in' which starts with J

--in operator(acts as 'or')
select * from employee where salary in (30000,45000,55000)







