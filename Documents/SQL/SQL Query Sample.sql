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

SELECT BaseRate FROM [DimEmployee]
ORDER BY BaseRate desc
OFFSET     2 ROWS       --skip 2 rows
FETCH NEXT 1 ROWS ONLY; -- take 1 rows

----------------------------------------------------
--Problem Statement - Top 5 sum of marks
----------------------------------------------------

select sum(ParentEmployeeKey) FROM 
(select top 5 ParentEmployeeKey from [AdventureWorksDW2012].[dbo].[DimEmployee])as t

----------------------------------------------------
--Problem Statement - Find Duplicate Records
----------------------------------------------------

SELECT *, COUNT(*)
FROM employee
GROUP BY column1, column2, column3, ...  -- list all columns
HAVING COUNT(*) > 1;

----------------------------------------------------
--Problem Statement - Delete Duplicate Records
----------------------------------------------------

--This approach can be used when all the columns are to be referred for identifyin duolicate records.
WITH ranked AS (
  SELECT *, ROW_NUMBER() OVER (PARTITION BY email, name, department ORDER BY id) AS rn
  FROM employee
)
DELETE FROM ranked WHERE rn > 1;

--this approach can be used when duplicated records are to be identified by few columns and not all
DELETE FROM employee
WHERE id NOT IN (
  SELECT MIN(id)
  FROM employee
  GROUP BY name, email
);

----------------------------------------------------
--Problem Statement - Find first and last record
----------------------------------------------------

 SELECT * FROM table_name ORDER BY id ASC LIMIT 1;-- First record
 SELECT * FROM table_name ORDER BY id DESC LIMIT 1;-- Last record
