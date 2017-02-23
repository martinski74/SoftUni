CREATE VIEW V_EmployeeNameJobTitle AS 
SELECT FirstName +' '+ CASE WHEN MiddleName IS NULL THEN '' ELSE MiddleName END +' '+ LastName AS [Full Name] ,JobTitle
FROM Employees;