SELECT e.EmployeeID,
e.FirstName,
CASE 
WHEN p.StartDate < '2005-01-01' THEN p.Name
ELSE NULL
END AS ProjectName
FROM Employees AS e
JOIN EmployeesProjects AS ep ON ep.EmployeeID = e.EmployeeID
JOIN Projects as p ON p.ProjectID = ep.ProjectID
WHERE e.EmployeeID = 24