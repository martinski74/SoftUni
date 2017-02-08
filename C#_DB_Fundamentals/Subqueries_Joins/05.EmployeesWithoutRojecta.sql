SELECT TOP(3) e.EmployeeID, e.FirstName FROM Employees AS e
    left JOIN EmployeesProjects AS ep
    ON e.EmployeeID = ep.EmployeeID where ep.ProjectID is null
ORDER BY e.EmployeeID