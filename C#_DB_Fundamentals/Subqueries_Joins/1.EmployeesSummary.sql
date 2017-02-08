SELECT TOP 50 e.EmployeeID,e.FirstName +' '+e.LastName AS [EmployeeName],m.FirstName +' '+m.LastName AS [Manager Name],d.Name AS [DepatmentName]
FROM Employees AS e 
JOIN Employees AS m ON e.ManagerID = m.EmployeeID
JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
ORDER BY e.EmployeeID