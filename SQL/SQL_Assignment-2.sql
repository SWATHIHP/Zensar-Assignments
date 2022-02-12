use Assignment1

select * from emp
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

--1. Retrieve a list of MANAGERS. 
select count(*)'Total Managers'from emp where job='Manager'
/*
Total Managers
3
*/

--2. Find out salary of both MILLER and SMITH. 
select ename,sal from emp where ename in ('Miller','Smith')
/*
ENAME	SAL

Smith	800
Miller	1300
*/

--3. Find out the names and salaries of all employees earning more than 1000 per month. 
select ename,sal from emp where sal>1000
/*
ENAME	SAL

Allen	1600
Ward	1250
Jones	2975
Martin	1250
Blake	2850
Clark	2450
Scott	3000
King	5000
Turner	1500
Adams	1100
Ford	3000
Miller	1300
*/

--4. Display the names and salaries of all employees except JAMES. 
select ename,sal from emp where ename!='James'
/*
ENAME	SAL

Smith	800
Allen	1600
Ward	1250
Jones	2975
Martin	1250
Blake	2850
Clark	2450
Scott	3000
King	5000
Turner	1500
Adams	1100
Ford	3000
Miller	1300
*/

--5. Find out the details of employees whose names begin with ‘S’. 
select * from EMP where ename like 'S%'
/*
EMPNO	ENAME	JOB			MGR		HIREDATE	SAL		COMM	DEPTNUM

7369	Smith	Clerk		7902	1980-12-17	800		NULL	20
7788	Scott	Analyst		7566	1987-04-19	3000	NULL	20
*/

--6. Find out the names of all employees that have ‘A’ anywhere in their name. 
select ename from emp where ename like '%A%'
/*
ENAME

Allen
Ward
Martin
Blake
Clark
Adams
James
*/

--7. Find out the names of all employees that have ‘L’ as their third character in their name. 
select ename from emp where ename like '__L%'
/*
ENAME

Allen
Miller
*/

--8. Find out the names of the employees whose name begin with ‘A’ or ‘M’. 
select ename from emp where ename like 'A%' or ename like 'M%'group by ename
/*
ENAME

Adams
Allen
Martin
Miller
*/

--9. Compute yearly salary of SMITH. 
select ename,sal*12'Yearly Salary'from emp where ename='jones'
/*
ENAME	Yearly Salary

Smith	9600
*/

--10. Compute daily salary of JONES. 
select ename,sal/30'Monthly Salary'from emp where ename='Jones'
/*
ENAME	Monthly Salary

Jones	99.1666666666667
*/

--11. Calculate the total monthly salary of all employees. 
select sum(sal)'Total Monthly Salary' from emp 
/*
Total Monthly Salary

29025
*/

--12. Print the average annual salary. 
select avg(sal*12)'Average Annual Salary' from emp
/*
Average Annual Salary

24878.5714285714
*/

--13. Select the name, job, salary, department number of all employees except SALESMAN from department number 30. 
select ename,job,sal,deptnum from emp where job!='Salesman'
/*
ENAME	JOB			SAL		DEPTNUM

Smith	Clerk		800		20
Jones	Manager		2975	20
Blake	Manager		2850	30
Clark	Manager		2450	10
Scott	Analyst		3000	20
King	President	5000	10
Adams	Clerk		1100	20
James	Clerk		950		30
Ford	Analyst		3000	20
Miller	Clerk		1300	10
*/

--14. List unique departments of the EMP table. 
select distinct(deptnum) from EMP
/*
DEPTNUM

10
20
30
*/

--15. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively.
select ename Employee,sal 'Monthly Salary' from emp where sal>1500 and deptnum in (10,30)
/*
Employee	Monthly Salary

Allen		1600
Blake		2850
Clark		2450
King		5000
*/