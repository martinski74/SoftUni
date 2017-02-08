SELECT TOP 1 AVG(Salary)
FROM Employees
GROUP BY DepartmentID
ORDER BY AVG(Salary) ASC