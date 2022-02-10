create database Assignment1

use Assignment1

select * from DEPT
select * from EMP

--creating DEPT table
create table DEPT(deptno int primary key,
deptname varchar(20) not null,
loc varchar(20))
--creating EMP table
create table EMP(empno int primary key,
ename varchar(35),job varchar(25),mgr int,
hiredate date,sal float,
comm float,deptno int foreign key references dept(deptno))
--inserting values to the DEPT table
insert into dept values(10,'Accounting','New York'),
(20,'Research','Dallas'),
(30,'Sales','Chicago'),
(40,'Operations','Boston')

--inserting values into the EMP table

insert into emp values(7369,'Smith','Clerk',7902,'17-Dec-80',800,null,20),
(7499,'Allen','Salesman',7698,'20-feb-81',1600,300,30),
(7521,'Ward','Salesman',7698,'22-feb-81',1250,500,30),
(7566,'Jones','Manager',7839,'02-apr-81',2975,null,20),
(7654,'Martin','Salesman',7698,'28-sep-81',1250,1400,30),
(7698,'Blake','Manager',7839,'01-may-81',2850,null,30),
(7782,'Clark','Manager',7839,'09-jun-81',2450,null,10),
(7788,'Scott','Analyst',7566,'19-apr-87',3000,null,20),
(7839,'King','President',null,'17-nov-81',5000,null,10),
(7844,'Turner','Salesman',7698,'08-sep-81',1500,0,30),
(7876,'Adams','Clerk',7788,'23-may-87',1100,null,20),
(7900,'James','Clerk',7698,'03-dec-81',950,null,30),
(7902,'Ford','Analyst',7566,'03-dec-81',3000,null,20),
(7934,'Miller','Clerk',7782,'23-jan-82',1300,null,10)

--++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
--1. List all employees whose name begins with 'A'. 
select * from emp where ename like 'A%'

--2. Select all those employees who don't have a manager. 
select * from emp where Empno not in (select distinct mgr from Emp where mgr is not null)

--3. List employee name, number and salary for those employees who earn in the range 1200 to 1400. 
select ename,empno,sal from emp where sal between 1200 and 1400

--4. Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has been done by listing all their details before and after the rise. 
select sal as 'Before Rise',sal+(sal*10/100) as 'After Rise' 
from emp,dept where deptname='Research'

--5. Find the number of CLERKS employed. Give it a descriptive heading. 
select count(*) as 'Total no. of Clerks'
from emp where job='Clerk'

--6. Find the average salary for each job type and the number of people employed in each job. 
select count(*) 'Total no. of people employed in each job',
avg(sal) 'Avg Sal of each job type',deptno,job
from emp group by deptno,job

--7. List the employees with the lowest and highest salary. 
select min(sal) 'Employee with Least Sal',max(sal) 'Employee with Higest Salary'from emp

--8. List full details of departments that don't have any employees. 
select * from dept where deptno not in (select deptno from emp)

--9. Get the names and salaries of all the analysts earning more than 1200 who are based in department 20. Sort the answer by ascending order of name. 
select ename,sal from emp where job='Analyst' and sal>1200 and deptno=20
order by ename

--10. For each department, list its name and number together with the total salary paid to employees in that department. 
select deptno,sum(sal) from emp group by deptno

--11. Find out salary of both MILLER and SMITH.
select sal from emp where ename in ('Miller','Smith')

--12. Find out the names of the employees whose name begin with ‘A’ or ‘M’. 
select ename from emp where ename like 'A%' or ename like 'M%' order by ename

--13. Compute yearly salary of SMITH. 
select sal*12 as 'Yearly Salary' from emp where ename='Smith'

--14. List the name and salary for all employees whose salary is not in the range of 1500 and 2850. 
select ename,sal from emp where sal not between 1500 and 2850