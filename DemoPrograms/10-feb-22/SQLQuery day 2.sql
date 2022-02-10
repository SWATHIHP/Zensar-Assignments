insert into Employee
values(222,'Nayeon','nayeon@gmail.com','Female',25000,4),
(225,'Rosie','rosie@gmail.com','Female',15000,1)
insert into Employee values(229,'Taehyung','taetae@gmail.com','Male',5000,null)
select * from Depatment

select distinct(dept),empname from employee
--to remove all duplicate info in the qury
select distinct(dept) from employee 

--Aggregates
select max(salary) from employee
select min(salary) from employee
select avg(salary) from employee
select count(distinct(dept)) from employee where dept=2
select sum(salary) from employee
select count(*) from employee
sp_help employee
--cannot use functions on RHS
select * from employee
where salary>avg(Salary)

create table dummy
(empid int,
ename varchar(30),
sal float,
primary key(empid,ename))
--in composite PK, the system checks for unique combination
--101 namjoon
--101 yoongi
--102 namjoon
--101 namjoon --duplicate

--to sort the output on one or more columns
select * from employee order by EmpName,
Salary desc

--you can order/sort on multiple colums
--you can use an alias column in the order by clause
select gender as Race, salary as Earnings
from Employee order by Race, Earnings desc
--you can sort on a column which is not being selected or which is not in the select list

/*select list
  from clause
  where clause
  group by
  having clause
  order by*/

/*group by(is like giving a summary report)
RULES
1. You can group a column only when it is in the select list
2. You can't group an alias column
3. All columns in the select list except aggregates have to be included in the group by clause
*/
select dept,count(*) as 'Number of Employees'
from Employee
group by dept

update employee set dept=3 where empid=101

--return the names of each dept and the max sal in the dept
select DeptName, max(Salary) from Depatment, Employee
where employee.dept = Depatment.deptId
group by DeptName

--number of male and female in each dept
select count(case when gender='Male'then 1 end) as MaleCount,
count( case when gender='Female'then 1 end ) as FemaleCount  
from employee group by Dept
--or
select distinct(gender) as category,Dept,count(gender) as 'no. of employees' 
from employee group by dept, gender

--no. of employees in each dept name
select count(gender), deptname from employee E,Depatment D
where E.Dept=D.DeptId group by DeptName

--when we want to restrict the no. of groups on some condition, we use having clause
--list of depts whose salary is greater than the minimum salary
select dept,min(salary) 'Lowest salary'  from employee 
group by Dept
having min(salary)>5500

select count(gender) from employee where dept=2
group by Gender

--select the anagers who have more then 5 employees
select mgrId, count(empid) from employee
group by mgrId
having count(empid)>5

/* JOINS
-Equi join
-Natural join
-Self join = joining a table with itself by giving alias names to them
-Cross/cartesian join
-Inner join
-left join aka left outer join
-right join aka right outer join
-Full join aka full outer join
*/
select * from employee cross join Depatment

select * from employee, Depatment where Employee.dept=Depatment.DeptId
--the above can be written as
select * from Employee inner join Depatment on Employee.dept=Depatment.DeptId

--use left join or left outer join
select * from Employee left join Depatment on Employee.dept=Depatment.DeptId
--use right join or right outer join
select * from Employee right join Depatment on Employee.dept=Depatment.DeptId

--full outer join
select * from Employee full outer join Depatment on Employee.dept=Depatment.DeptId

--self join
select e1.empname as employee,e2.empname as Manager
from employee e1 inner join employee e2 
on e1.mgrid=e2.EmpId
