UPDATE Employees
	SET Salary = Salary + (Salary*12)/100
	 WHERE DepartmentID IN (1,2,4,11);
SELECT Salary FROM Employees;