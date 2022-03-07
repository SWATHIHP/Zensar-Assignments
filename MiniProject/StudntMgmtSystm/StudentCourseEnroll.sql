create database Student_Course_Enroll

use Student_Course_Enroll

create table StudentEnroll(s_id int primary key,
s_name varchar(20) not null,
s_dob date)

create table CourseEnroll(c_id int primary key,
c_name varchar(20) not null,
c_duration float(10),
c_fee float)

create table EnrollmentInfo(stid int primary key,
crid int, dt date)

insert into StudentEnroll values(111,'Namjoon','12-03-1994'),
(222,'Yoongi','06-22-1993'),
(333,'Seokjin','04-10-1992'),
(444,'Hoseok','02-18-1994')

insert into CourseEnroll values(101,'Java Full Stack',4,30000),
(102,'Python Full Stack',3,28000),
(103,'Mern Stack',4,25000)

select * from StudentEnroll
select * from CourseEnroll

update CourseEnroll
set c_duration = 2
where c_id = 101



