SELECT
sal.DepartmentId, sal.Salary
FROM
(
SELECT
e.DepartmentId, e.Salary, DENSE_RANK()
OVER (
PARTITION BY
e.DepartmentID
ORDER BY
e.Salary DESC
) AS SalaryRank
FROM
Employees AS e
) AS sal
WHERE
sal.SalaryRank = 3
GROUP BY
sal.DepartmentID, sal.Salary