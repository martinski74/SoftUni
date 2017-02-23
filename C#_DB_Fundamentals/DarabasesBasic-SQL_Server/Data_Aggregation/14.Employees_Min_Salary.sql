SELECT DepartmentID,min(Salary) AS MinimumSalary FROM Employees
	WHERE DepartmentID IN(2,5,7) AND DATEPART(YEAR,HireDate) >= 2000
	GROUP BY DepartmentID