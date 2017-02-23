SELECT DepositGroup,SUM(DepositAmount) AS TotalSum 
FROM WizzardDeposits WHERE WizzardDeposits.MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup