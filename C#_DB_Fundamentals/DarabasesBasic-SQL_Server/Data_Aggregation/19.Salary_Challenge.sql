SELECT top 10 [FirstName]
,[LastName]
,[DepartmentID]
FROM [Employees] as e
left join (select DepartmentID as avgDept, avg(Salary) as avgSal from [Employees] group by DepartmentID) as avgTab
on e.[DepartmentID] = avgTab.avgDept where e.Salary > avgTab.avgSal
order by e.DepartmentID