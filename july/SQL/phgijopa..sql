--create database db1

--create table tab1(Id int,Name varchar(20),Address nvarchar(100),Age int,Mark int)  --To create a table

--insert into tab1 values(1,'John','Vellikulangara',23,101)
--insert into tab1 values(2,'Jer','Madanpilly',20,10)
--insert into tab1 values(3,'jeese','chiyaram',26,76),(4,'chris','kodaly',21,87)

--select * from tab1

--select Name,Address from tab1

--select * from tab1 where Id = 1

--select Name,Age from tab1 where Id=2

--select Name,Age from tab1 where name='Jeese'

--select Name,Age from tab1 where Name = 'John' and age = 23

--select Name,Age from tab1 where Name = 'Chris' or Age = 23

--select * from tab1

--select distinct * from tab1

--delete from tab1 where id = 2

--drop table tab1

--update tab1 set Age = 33,Address = 'hoohohhoh' where Id = 1      --It updates all rows

--Scalar Functions or aggregate functions in sql

--select max(Mark) as Max_Mark from tab1
--select min(Mark) as Min_Mark from tab1
--select count(Id) as Count from tab1
--select avg(Mark) as Average_Mark from tab1
--select sum(Mark) as Sum from tab1

--select * from tab1 order by name
--select * from tab1 order by name asc
--select * from tab1 order by name desc

-- like -- Search using a string pattern

--select * from tab1 where Name like '%n'
--select * from tab1 where Name Like 'j%'
--select * from tab1 where Name Like '%e%'
--select * from tab1 where Name like '_e%'    --second letter should be e,

select * from tab1 where mark=(select max(mark) from tab1)