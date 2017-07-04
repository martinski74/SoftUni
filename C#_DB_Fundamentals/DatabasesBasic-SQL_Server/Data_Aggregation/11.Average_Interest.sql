SELECT DepositGroup,IsDepositExpired,AVG(DepositInterest) AS [Averageinterst] FROM WizzardDeposits
where DATEPART(YEAR,DepositStartDate) >= 1985
GROUP BY DepositGroup,IsDepositExpired
	ORDER BY DepositGroup DESC,IsDepositExpired