----------------------------------------------------
--Database - AdventureWorksDW2012
----------------------------------------------------
--Problem Statement - Nth Largest BaseRate
----------------------------------------------------

-- Method 1 - Using Max & operator

select max(BaseRate) from DimEmployee 
where BaseRate  < (select max(BaseRate) from DimEmployee)

-- Method 2 - Using Max & NOT IN

select max(BaseRate) from DimEmployee 
where BaseRate  
NOT IN (select max(BaseRate) from DimEmployee)

-- Method 3 - Using top 

Select top 1 BaseRate 
from (Select top 6 BaseRate from DimEmployee order by BaseRate desc) 
as tbl order by BaseRate asc

--Method using Distinct which is acccurate

Declare @number as nvarchar(max) = 6
SELECT top 1 BaseRate
FROM DimEmployee Emp1
WHERE (@number-1) = 
(
SELECT COUNT(DISTINCT(Emp2.BaseRate))
FROM DimEmployee Emp2
WHERE Emp2.BaseRate > Emp1.BaseRate
)

--Method using Dense Rank and CTE

with CTE_e(dr,br,fn,ln) AS
(
select DENSE_RANK() over(order by BaseRate desc), BaseRate, FirstName, LastName 
from DimEmployee
)
select * from CTE_e where dr = 6

----------------------------------------------------
--Problem Statement - Top 3rd salary
----------------------------------------------------

SELECT BaseRate FROM [DimEmployee]ORDER BY BaseRate descOFFSET     2 ROWS       --skip 2 rowsFETCH NEXT 1 ROWS ONLY; -- take 1 rows

----------------------------------------------------
--Problem Statement - Top 5 sum of marks
----------------------------------------------------

select sum(ParentEmployeeKey) FROM 
(select top 5 ParentEmployeeKey from [AdventureWorksDW2012].[dbo].[DimEmployee])as t


