SELECT TOP(5) EmployeeID,JobTitle,Addresses.AddressID,Addresses.AddressText FROM Employees 
JOIN Addresses ON Employees.AddressID = Addresses.AddressID ORDER BY Employees.AddressID