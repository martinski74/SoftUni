SELECT TOP 1
    AVG(MagicWandSize) AS AverageWandSize
INTO AverageWandSizeResult
FROM WizzardDeposits
GROUP BY DepositGroup
ORDER BY AverageWandSize
 
SELECT DepositGroup FROM
(
    SELECT DepositGroup,
           AVG(MagicWandSize) AS AverageSize
    FROM WizzardDeposits
    GROUP BY DepositGroup
    HAVING AVG(MagicWandSize) = (SELECT AverageWandSize FROM AverageWandSizeResult)
) AS Result