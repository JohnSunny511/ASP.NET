--insert into tab1 values(6,'Kiran','ckdy',22,78)

--select Name,Age,Address,sum(mark) as Total_Mark from tab1 group by Name,Age,Address

select Name,Age,Address,sum(mark) as Total_Mark from tab1 group by Name,Age,Address having sum(mark) > 100 --selects only the condition satisfied,used with aggregate functions

select * from tab1
