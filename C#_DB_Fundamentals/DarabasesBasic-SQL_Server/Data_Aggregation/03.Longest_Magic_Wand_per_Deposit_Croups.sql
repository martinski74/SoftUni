SELECT DepositGroup,max(MagicWandSize) AS [LongestMagicWand] FROM WizzardDeposits
GROUP BY DepositGroup;