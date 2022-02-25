create database ITfirm

use ITfirm

create table Clients(Client_ID int primary key,
Cname varchar(40) not null, Addresss varchar(30),
Email varchar(30) unique, Phone varchar(10),
Business varchar(20) not null)

insert into Clients
values (1001,'ACME Utilities','Noida','contact@acmeutil.com',9567880032,'Manufacturing'),
(1002,'Trackon Consultants','Mumbai','consult@trackon.com',8734210090,'Consultant'),
(1003,'MoneySaver Distributors','Bangalore','save@moneysaver.com',7799886655,'Reseller'),
(1004,'Lawful Corp','Chennai','justice@lawful.com',9210342219,'Professional')

--+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

create table Departments(Deptno int primary key,
Dname varchar(15) not null, Loc varchar(20))

insert into Departments
values(10,'Design','Pune'),
(20,'Development','Pune'),
(30,'Testing','Mumbai'),
(40,'Document','Mumbai')

--++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

create table Employees(Empno int primary key,
Ename varchar(20) not null,
Job varchar(15),
Salary int check (Salary>0),
Deptno int foreign key references Departments(Deptno))

insert into Employees values 
(7001,'Sandeep','Analyst',25000,10),
(7002,'Rajesh','Designer',30000,10),
(7003,'Madhav','Developer',40000,20),
(7004,'Manoj','Developer',40000,20),
(7005,'Abhay','Designer',35000,10),
(7006,'Uma','Tester',30000,30),
(7007,'Gita','Tech. Writer',30000,40),
(7008,'Priya','Tester',35000,30),
(7009,'Nutan','Developer',45000,20),
(7010,'Smita','Analyst',20000,10),
(7011,'Anand','Project Mgr',65000,10)

--++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

create table Projects(Project_ID int primary key,
Descr varchar(20) not null,
StartDate date, Planned_End_Date date,
Actual_End_Date date,
Budget float check(Budget >0),
Client_ID int foreign key references Clients(Client_ID))

insert into Projects values 
(401,'Inventory','01-APR-11','01-OCT-11','31-OCT-11',150000,1001),
(402,'Accounting','01-AUG-11','01-JAN-12',null,500000,1002),
(403,'Payroll','01-OCT-11','31-DEC-11',null,75000,1003),
(404,'Contact Mgmt','01-NOV-11','31-DEC-11',null,50000,1004)

--+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

create table EmpProjectTasks
(Project_ID int foreign key references Projects(Project_ID),
Empno int foreign key references Employees(Empno),
StartDate date, End_Date date,
Task varchar(25) not null,
statuss varchar(15) not null,
primary key(Project_ID,Empno))

Insert into EmpProjectTasks 
values (401,7001,'01-APR-11','20-APR-11','System Analysis','Completed'),
(401,7002,'21-APR-11','30-MAY-11','System Design','Completed'),
(401,7003,'01-JUN-11','15-JUL-11','Coding','Completed'),
(401,7004,'18-JUL-11','01-SEP-11','Coding','Completed'),
(401,7006,'03-SEP-11','15-SEP-11','Testing','Completed'),
(401,7009,'18-SEP-11','05-OCT-11','Code Change','Completed'),
(401,7008,'06-OCT-11','16-OCT-11','Testing','Completed'),
(401,7007,'06-OCT-11','22-OCT-11','Documentation','Completed'),
(401,7011,'22-OCT-11','31-OCT-11','Sign of','Completed'),
(402,7010,'01-AUG-11','20-AUG-11','System Analysis','Completed'),
(402,7002,'22-AUG-11','30-SEP-11','System Design','Completed'),
(402,7004,'01-OCT-11',null,'Coding','In Progress')

--++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

select * from Clients
select * from Departments
select * from Employees
select * from Projects
select * from EmpProjectTasks
