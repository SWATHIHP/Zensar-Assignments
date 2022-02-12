create database Assignment1

use Assignment1

--creating DEPT table
create table DEPT(deptno int primary key,
deptname varchar(20) not null,
loc varchar(20))

--creating EMP table
create table EMP(empno int primary key,
ename varchar(35),job varchar(25),mgr int,
hiredate date,sal float,
comm float,deptnum int foreign key references dept(deptno))

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

select * from DEPT
/*
DEPTNO	DEPTNAME	LOC

10		Accounting	New York
20		Research	Dallas
30		Sales		Chicago
40		Operations	Boston
*/

select * from EMP
/*
EMPNO	ENAME	JOB			MGR		HIREDATE	SAL		COMM	DEPTNUM

7369	Smith	Clerk		7902	1980-12-17	800		NULL	20
7499	Allen	Salesman	7698	1981-02-20	1600	300		30
7521	Ward	Salesman	7698	1981-02-22	1250	500		30
7566	Jones	Manager		7839	1981-04-02	2975	NULL	20
7654	Martin	Salesman	7698	1981-09-28	1250	1400	30
7698	Blake	Manager		7839	1981-05-01	2850	NULL	30
7782	Clark	Manager		7839	1981-06-09	2450	NULL	10
7788	Scott	Analyst		7566	1987-04-19	3000	NULL	20
7839	King	President	NULL	1981-11-17	5000	NULL	10
7844	Turner	Salesman	7698	1981-09-08	1500	0		30
7876	Adams	Clerk		7788	1987-05-23	1100	NULL	20
7900	James	Clerk		7698	1981-12-03	950		NULL	30
7902	Ford	Analyst		7566	1981-12-03	3000	NULL	20
7934	Miller	Clerk		7782	1982-01-23	1300	NULL	10
*/

--+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

--1. List all employees whose name begins with 'A'. 
select * from emp where ename like 'A%'
/*
EMPNO	ENAME	JOB			MGR		HIREDATE	SAL		COMM	DEPTNUM

7499	Allen	Salesman	7698	1981-02-20	1600	300	    30
7876	Adams	Clerk	    7788	1987-05-23	1100	NULL	20
*/

--2. Select all those employees who don't have a manager. 
select * from emp where Empno not in (select distinct mgr from Emp where mgr is not null)
/*
EMPNO	ENAME	JOB			MGR		HIREDATE	SAL		COMM	DEPTNUM

7369	Smith	Clerk		7902	1980-12-17	800		NULL	20
7499	Allen	Salesman	7698	1981-02-20	1600	300		30
7521	Ward	Salesman	7698	1981-02-22	1250	500		30
7654	Martin	Salesman	7698	1981-09-28	1250	1400	30
7844	Turner	Salesman	7698	1981-09-08	1500	0		30
7876	Adams	Clerk		7788	1987-05-23	1100	NULL	20
7900	James	Clerk		7698	1981-12-03	950		NULL	30
7934	Miller	Clerk		7782	1982-01-23	1300	NULL	10
*/

--3. List employee name, number and salary for those employees who earn in the range 1200 to 1400. 
select ename,empno,sal from emp where sal between 1200 and 1400
/*
ENAME	EMPNO	SAL

Ward	7521	1250
Martin	7654	1250
Miller	7934	1300
*/

--4. Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has been done by listing all their details before and after the rise. 
select sal as 'Before Rise',sal+(sal*10/100) as 'After Rise' 
from emp,dept where deptname='Research'
/*
Before Rise		After Rise

800				880
1600			1760
1250			1375
2975			3272.5
1250			1375
2850			3135
2450			2695
3000			3300
5000			5500
1500			1650
1100			1210
950				1045
3000			3300
1300			1430
*/

--5. Find the number of CLERKS employed. Give it a descriptive heading. 
select count(*) as 'Total no. of Clerks'
from emp where job='Clerk'
/*
Total no. of Clerks
4
*/

--6. Find the average salary for each job type and the number of people employed in each job. 
select count(*) 'Total no.of emps in each job',
avg(sal) 'AvgSal of each job type',deptnum,job
from emp group by deptnum,job
/*
Total no.of emps in each job	AvgSal of each job type		DEPTNUM		JOB		

2								3000						20			Analyst
1								1300						10			Clerk
2								950							20			Clerk
1								950							30			Clerk
1								2450						10			Manager
1								2975						20			Manager
1								2850						30			Manager
1								5000						10			President
4								1400						30			Salesman
*/

--7. List the employees with the lowest and highest salary. 
select min(sal) 'Employee with Least Sal',max(sal) 'Employee with Higest Salary'from emp
/*
Employee with Least Sal		Employee with Higest Salary
800							5000
*/

--8. List full details of departments that don't have any employees. 
select * from dept where deptno not in (select deptno from emp)
/*
DEPTNO	DEPTNAME	LOC
40		Operations	Boston
*/

--9. Get the names and salaries of all the analysts earning more than 1200 who are based in department 20. Sort the answer by ascending order of name. 
select ename,sal from emp where job='Analyst' and sal>1200 and deptnum=20 order by ename
/*
ENAME	SAL

Ford	3000
Scott	3000
*/

--10. For each department, list its name and number together with the total salary paid to employees in that department. 
select 	deptnum ,sum(sal)'TOTAL SALARY' from emp group by deptnum
/*
DEPTNUM	TOTAL SALARY

10		8750
20		10875
30		9400
*/

--11. Find out salary of both MILLER and SMITH.
select ename,sal from emp where ename in ('Miller','Smith')
/*
ENAME	SAL

Smith	800
Miller	1300
*/

--12. Find out the names of the employees whose name begin with ‘A’ or ‘M’. 
select ename from emp where ename like 'A%' or ename like 'M%' order by ename
/*
ENAME

Adams
Allen
Martin
Miller
*/
--13. Compute yearly salary of SMITH. 
select ename,sal*12 as 'Yearly Salary' from emp where ename='Smith'
/*
ENAME	Yearly Salary

Smith	9600
*/

--14. List the name and salary for all employees whose salary is not in the range of 1500 and 2850. 
select ename,sal from emp where sal not between 1500 and 2850
/*
ENAME	SAL

Smith	800
Ward	1250
Jones	2975
Martin	1250
Scott	3000
King	5000
Adams	1100
James	950
Ford	3000
Miller	1300
*/