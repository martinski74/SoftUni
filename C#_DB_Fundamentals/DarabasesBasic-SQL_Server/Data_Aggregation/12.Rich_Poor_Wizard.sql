SELECT  SUM(HostWizardDeposit - GuestWizardDeposit) AS [SumDifference]
FROM    (
        SELECT  Id,
                FirstName AS HostWizard,
                DepositAmount AS HostWizardDeposit
        FROM    [WizzardDeposits]
        ) AS hw
JOIN    (
        SELECT  Id - 1 AS Id,
                FirstName AS GuestWizard,
                DepositAmount AS GuestWizardDeposit
        FROM    [WizzardDeposits]
        ) AS gw ON hw.Id = gw.Id