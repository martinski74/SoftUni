-- 01. Employees with Salary Above 35000
CREATE PROCEDURE usp_GetEmployeesSalaryAbove35000
AS
BEGIN
	SELECT FirstName AS 'First Name', LastName AS 'Last Name'
	FROM Employees
	WHERE Salary > 35000
END

EXEC usp_GetEmployeesSalaryAbove35000

-- 02. Employees with Salary Above Number
CREATE PROCEDURE usp_GetEmployeesSalaryAboveNumber (@number Money)
AS
BEGIN
	SELECT FirstName AS 'First Name', LastName AS 'Last Name'
	FROM Employees
	WHERE Salary >= @number
END

EXEC usp_GetEmployeesSalaryAboveNumber 48100

-- 03. Town Names Starting With
CREATE PROCEDURE usp_GetTownsStartingWith (@parameter NVARCHAR(30))
AS
BEGIN
	SELECT Name AS Town FROM Towns
	WHERE Name LIKE @parameter + '%'
END

EXEC usp_GetTownsStartingWith b

-- 04. Employees from Town
CREATE PROCEDURE usp_GetEmployeesFromTown (@townName NVARCHAR(30))
AS
BEGIN
	SELECT e.FirstName AS 'First Name', e.LastName AS 'Last Name'
	FROM Employees e
	JOIN Addresses a
	ON e.AddressID = a.AddressID
	JOIN Towns t
	ON t.TownID = a.TownID
	WHERE t.Name = @townName
END

EXEC usp_GetEmployeesFromTown Sofia

-- 05. Salary Level Function
CREATE FUNCTION ufn_GetSalaryLevel(@salary MONEY)
RETURNS NVARCHAR(10)
AS
BEGIN
	RETURN
		CASE 
			WHEN @salary < 30000 THEN 'Low'
			WHEN @salary BETWEEN 30000 AND 50000 THEN 'Average'
			WHEN @salary > 50000 THEN 'High'
		END
END

SELECT Salary, dbo.ufn_GetSalaryLevel(Salary) AS 'Salary Level'
FROM Employees

-- 06. Employees by Salary Level
CREATE PROCEDURE usp_EmployeesBySalaryLevel (@level NVARCHAR(10))
AS 
BEGIN
	SELECT 
		s.FirstName AS 'First Name',
		s.LastName AS 'Last Name'
	FROM (SELECT FirstName, LastName, Salary, 
				dbo.ufn_GetSalaryLevel(Salary) AS sLevel
			FROM Employees) s
	WHERE s.sLevel = @level
END
 
EXEC usp_EmployeesBySalaryLevel Low

-- 07. Define Function
CREATE FUNCTION ufn_IsWordComprised (@setOfLetters NVARCHAR(20), @word NVARCHAR(20))
RETURNS BIT
AS
BEGIN
	DECLARE @comprised BIT = 1
	DECLARE @index INT = 1
 	WHILE (@comprised = 1) AND (@index <= len(@word))
	BEGIN
		IF(CHARINDEX(LOWER(SUBSTRING(@word, @index, 1)), LOWER(@setOfLetters)) NOT BETWEEN 1 AND LEN(@setOfLetters))
			BEGIN
				SET @comprised = 0	
			END
		ELSE SET @index += 1
	END
	RETURN @comprised
END

SELECT dbo.ufn_IsWordComprised('pppp', 'Guy')

-- 08. Delete Employees and Departments

BEGIN TRANSACTION 
ALTER TABLE EmployeesProjects
DROP CONSTRAINT FK_EmployeesProjects_Employees
ALTER TABLE Departments
DROP CONSTRAINT FK_Departments_Employees
ALTER TABLE Employees
DROP CONSTRAINT FK_Employees_Employees
DELETE FROM Employees
WHERE DepartmentID IN (7,8)
DELETE FROM Departments
WHERE DepartmentID IN (7,8)

ROLLBACK

-- 09. Employees with Three Projects
CREATE PROCEDURE usp_AssignProject(@emloyeeId INT, @projectID INT)
AS
BEGIN
	BEGIN TRANSACTION
		INSERT INTO EmployeesProjects
			(EmployeeID, ProjectID)
		VALUES
			(@emloyeeId, @projectID)
		IF (SELECT COUNT(EmployeeID) FROM EmployeesProjects
			WHERE EmployeeID = @emloyeeId) > 3
		BEGIN
			RAISERROR('The employee has too many projects!', 16, 1)
			ROLLBACK
		END
	COMMIT
END

EXEC usp_AssignProject 1, 6

-- 10. Find Full Name
CREATE PROCEDURE usp_GetHoldersFullName
AS
BEGIN
	SELECT FirstName + ' ' + LastName AS 'Full Name'
	FROM AccountHolders
END

EXEC usp_GetHoldersFullName

-- 11. People with Balance Higher Than
CREATE PROCEDURE usp_GetHoldersWithBalanceHigherThan(@number MONEY)
AS
BEGIN
	SELECT FirstName AS 'First Name', LastName AS 'Last Name' 
	FROM (SELECT FirstName, LastName,
				SUM(a.Balance) AS TotalBalance 
			FROM AccountHolders AS ah
			JOIN Accounts AS a
			ON a.AccountHolderId = ah.Id
			GROUP BY ah.FirstName, ah.LastName
		) AS tb
	WHERE tb.TotalBalance > @number
END

EXEC dbo.usp_GetHoldersWithBalanceHigherThan 2 

-- 12. Future Value Function
CREATE FUNCTION ufn_CalculateFutureValue(@sum MONEY, @yir FLOAT, @ny INT)
RETURNS MONEY
AS
BEGIN
	DECLARE @i INT = 1 
	WHILE (@i <= @ny)
	BEGIN
		SET @sum = @sum + @sum*@yir
		SET @i += 1
	END
	RETURN @sum
END

SELECT dbo.ufn_CalculateFutureValue(1000, 0.1, 5)

-- 13. Calculating Interest
CREATE PROCEDURE usp_CalculateFutureValueForAccount(@accId INT, @rate FLOAT)
AS
BEGIN
	SELECT ah.Id AS [Account Id], 
		ah.FirstName AS [First Name],
		ah.LastName AS [LastName],
		a.Balance AS [Current Balanse], 
		dbo.ufn_CalculateFutureValue(a.Balance, @rate, 5)
	FROM AccountHolders ah
	RIGHT JOIN Accounts a
	ON ah.Id = a.AccountHolderId
	WHERE a.Id = @accId
END

EXEC usp_CalculateFutureValueForAccount 1, 0.1

-- 14. Deposit Money Procedure
CREATE PROCEDURE usp_DepositMoney (@accountId INT, @moneyAmount MONEY)
AS
BEGIN
	BEGIN TRANSACTION
	UPDATE Accounts
	SET Balance = Balance + @moneyAmount
	WHERE Accounts.Id = @AccountId
	COMMIT 
END 

EXEC usp_DepositMoney 1, 10000

-- 15. Withdraw Money Procedure
CREATE PROCEDURE usp_WithdrawMoney (@accountId INT, @moneyAmount MONEY)
AS
BEGIN
	BEGIN TRANSACTION
	UPDATE Accounts
	SET Balance = Balance - @moneyAmount
	WHERE Accounts.Id = @AccountId
	COMMIT 
END 

EXEC usp_WithdrawMoney 1, 10000

-- 16. Money Transfer
CREATE PROCEDURE usp_TransferMoney(@senderId INT, @receiverId INT, @amount MONEY)
AS
BEGIN
	BEGIN TRANSACTION
	UPDATE Accounts
	SET Balance = Balance - @amount
	WHERE Accounts.Id = @senderId
	UPDATE Accounts
	SET Balance = Balance + @amount
	WHERE Accounts.Id = @receiverId
	IF (SELECT Balance FROM Accounts WHERE Accounts.Id = @senderId) < 0
		ROLLBACK
	ELSE COMMIT 
END

EXEC usp_TransferMoney 1, 2, 10000

-- 17. Create Table Logs

CREATE TRIGGER T_Accounts_After_Update ON Accounts AFTER UPDATE
AS 
BEGIN
	INSERT INTO Logs (AccountId,OldSum,NewSum)
	SELECT i.Id,d.Balance,i.Balance FROM inserted AS i
	JOIN deleted AS d ON d.Id = i.Id
END

--18.Create Table Emails

CREATE TRIGGER tr_LogToEmail ON Logs AFTER INSERT
AS
BEGIN
	INSERT INTO NotificationEmails
		(Recipient, Subject, Body)
	SELECT AccountId,
		'Balance change for account: ' 
		+ CONVERT(varchar(10), AccountId),
		'On ' + CONVERT(varchar(30), GETDATE()) + ' your balance was changed from '
		+ CONVERT(varchar(30), OldSum) + ' to ' 
		+ CONVERT(varchar(30), NewSum) 
	  FROM Logs
END

--19*Scalar Function: Cash in User Games Odd Rows
CREATE FUNCTION ufn_CashInUsersGames(@gameName nvarchar(50))
RETURNS @Output TABLE(SumCash money)
AS
BEGIN
	INSERT INTO @Output
	SELECT SUM(sc.Cash) as SumCash FROM 
	(SELECT Cash,ROW_NUMBER() OVER(ORDER BY Cash DESC) AS RowNumber FROM UsersGames ug 
	RIGHT JOIN Games g ON ug.GameId = g.Id 
	WHERE g.Name = @gameName) sc
	WHERE RowNumber % 2 <> 0
	RETURN
END

-- Problem 20. Trigger
--TODO..
-- Problem 21. Massive Shopping
BEGIN TRAN
DECLARE @totalItemSum MONEY = (SELECT SUM(Price) AS TotalPrice FROM Items AS i 
		WHERE i.MinLevel BETWEEN 11 AND 12)

DECLARE @currentBalance MONEY = (SELECT ug.Cash FROM Users AS u 
		LEFT JOIN UsersGames AS ug ON ug.UserId = u.Id
		LEFT JOIN Games AS g ON g.Id = ug.GameId
		WHERE u.FirstName = 'Stamat' AND g.Name = 'Safflower')

BEGIN TRY 
	UPDATE UsersGames SET
	Cash -= @totalItemSum
	WHERE UserId = (SELECT Id FROM Users WHERE FirstName = 'Stamat') AND
	 GameId = (SELECT Id FROM Games WHERE Name = 'Safflower')

	INSERT INTO UserGameItems SELECT i.Id, ug.Id FROM UsersGames AS ug CROSS JOIN Items AS i 
		LEFT JOIN Games AS g ON g.Id = ug.GameId
		LEFT JOIN Users AS u ON u.Id = ug.UserId
		WHERE i.MinLevel BETWEEN 11 AND 12 AND u.FirstName = 'Stamat' AND g.Name = 'Safflower'

	COMMIT
END TRY
BEGIN CATCH
	ROLLBACK
END CATCH

BEGIN TRAN
SET @totalItemSum = (SELECT SUM(Price) AS TotalPrice FROM Items AS i 
		WHERE i.MinLevel BETWEEN 19 AND 21)

SET @currentBalance = (SELECT ug.Cash FROM Users AS u 
		LEFT JOIN UsersGames AS ug ON ug.UserId = u.Id
		LEFT JOIN Games AS g ON g.Id = ug.GameId
		WHERE u.FirstName = 'Stamat' AND g.Name = 'Safflower')

BEGIN TRY 
	UPDATE UsersGames SET
	Cash -= @totalItemSum
	WHERE UserId = (SELECT Id FROM Users WHERE FirstName = 'Stamat') AND
	 GameId = (SELECT Id FROM Games WHERE Name = 'Safflower')

	INSERT INTO UserGameItems SELECT i.Id, ug.Id FROM UsersGames AS ug CROSS JOIN Items AS i 
		LEFT JOIN Games AS g ON g.Id = ug.GameId
		LEFT JOIN Users AS u ON u.Id = ug.UserId
		WHERE i.MinLevel BETWEEN 19 AND 21 AND u.FirstName = 'Stamat' AND g.Name = 'Safflower'
	
	COMMIT
END TRY
BEGIN CATCH
	ROLLBACK
END CATCH

SELECT Name AS 'Item Name' FROM Items 
	WHERE Id IN (
		SELECT ugi.ItemId FROM UserGameItems AS ugi 
			WHERE ugi.UserGameId = (
				SELECT ug.Id FROM UsersGames AS ug 
					LEFT JOIN Games AS g ON g.Id = ug.GameId
					LEFT JOIN Users AS u ON u.Id = ug.UserId
					WHERE u.FirstName = 'Stamat' AND g.Name = 'Safflower'))
	ORDER BY Name ASC

SELECT * FROM UserGameItems AS ugi
	LEFT JOIN Items AS i ON i.Id = ugi.ItemId
	WHERE ugi.UserGameId = (SELECT ug.Id FROM UsersGames AS ug
								LEFT JOIN Games AS g ON g.Id = ug.GameId
								LEFT JOIN Users AS u ON u.Id = ug.UserId
									WHERE u.FirstName = 'Stamat' AND g.Name = 'Safflower')

-- Problem 22. Number of Users for Email Provider
SELECT SUBSTRING(u.Email,CHARINDEX('@', u.Email, 0) + 1, LEN(u.Email)) AS 'Email Provider', COUNT(*) AS 'Number Of Users' FROM Users as u
GROUP BY SUBSTRING(u.Email,CHARINDEX('@', u.Email, 0) + 1, LEN(u.Email))
ORDER BY COUNT(*) DESC, 'Email Provider' ASC
	- Problem 22. All User in Games
SELECT g.Name AS Game, gt.Name AS 'Game Type', u.Username, ug.Level, ug.Cash, c.Name AS Character FROM Users AS u
	INNER JOIN UsersGames AS ug ON ug.UserId = u.Id
	LEFT JOIN Games AS g ON g.Id = ug.GameId
	LEFT JOIN GameTypes AS gt ON gt.Id = g.GameTypeId
	LEFT JOIN Characters AS c ON c.Id = ug.CharacterId
	ORDER BY ug.Level DESC, u.Username ASC, Game ASC

-- Problem 24. Users in Games with Their Items
SELECT u.Username, g.Name AS Game, COUNT(*) AS 'Items Count', SUM(i.Price) AS 'Items Price'
		FROM Users AS u
	INNER JOIN UsersGames AS ug ON ug.UserId = u.Id
	INNER JOIN UserGameItems AS ugi ON ugi.UserGameId = ug.Id
	INNER JOIN Games AS g ON g.Id = ug.GameId
	INNER JOIN Items AS i ON i.Id = ugi.ItemId
	GROUP BY u.Username, g.Name
	HAVING COUNT(*) >= 10
	ORDER BY COUNT(*) DESC, SUM(i.Price) DESC, u.Username ASC

-- Problem 25. * User in Games with Their Statistics
SELECT u.Username, g.Name AS Game,c.Name AS Character,  s.Strength , s.Defence, s.Speed, s.Mind, s.Luck FROM Users AS u
	INNER JOIN UsersGames AS ug ON ug.UserId = u.Id
	LEFT JOIN Games AS g ON g.Id = ug.GameId
	LEFT JOIN Characters AS c ON c.Id = ug.CharacterId
	LEFT JOIN [dbo].[Statistics] AS s ON s.Id = c.StatisticId
	ORDER BY s.Strength DESC, s.Defence DESC, s.Speed DESC, s.Mind DESC, s.Luck DESC

-- Problem 26.	All Items with Greater than Average Statistics
SELECT i.Name, i.Price, i.MinLevel, s.Strength, s.Defence, s.Speed, s.Luck, s.Mind FROM Items AS i
	INNER JOIN [dbo].[Statistics] AS s ON s.Id = i.StatisticId
	WHERE s.Mind > (SELECT AVG(st.Mind) FROM [dbo].[Statistics] AS st) AND
		s.Luck > (SELECT AVG(st.Luck) FROM [dbo].[Statistics] AS st) AND
		s.Speed > (SELECT AVG(st.Speed) FROM [dbo].[Statistics] AS st)
	ORDER BY i.Name

-- Problem 27.	Display All Items with information about Forbidden Game Type
SELECT i.Name, i.Price, i.MinLevel, gt.Name AS 'Forbidden Game Type' FROM Items AS i
	LEFT JOIN GameTypeForbiddenItems AS gtfi ON gtfi.ItemId = i.Id
	LEFT JOIN GameTypes AS gt ON gt.Id = gtfi.GameTypeId
 ORDER BY gt.Name DESC, i.Name ASC

 -- Problem 28. 
DECLARE @alexId INT = (SELECT Id FROM Users WHERE Username = 'Alex')
DECLARE @gameId INT = (SELECT Id FROM Games WHERE Name = 'Edinburgh')
DECLARE @userGameID INT = (SELECT Id FROM UsersGames WHERE UserId = @alexId AND GameId = @gameId)
DECLARE @itemSUM MONEY = (SELECT SUM(p.Price) FROM (SELECT i.Id, i.Price FROM Items AS i
	WHERE i.Name IN ('Blackguard', 'Bottomless Potion of Amplification', 
	'Eye of Etlich (Diablo III)', 'Gem of Efficacious Toxin', 
	'Golden Gorget of Leoric', 'Hellfire Amulet'))
	AS p)

INSERT INTO UserGameItems SELECT p.ItemId, p.UserGameId FROM (SELECT i.Id As ItemId, ug.Id AS UserGameId FROM Items AS i
	CROSS JOIN UsersGames  AS ug
	WHERE ug.Id = @userGameID
	AND i.Name IN ('Blackguard', 'Bottomless Potion of Amplification', 
	'Eye of Etlich (Diablo III)', 'Gem of Efficacious Toxin', 
	'Golden Gorget of Leoric', 'Hellfire Amulet')) AS p

UPDATE UsersGames
SET Cash -= @itemSUM
WHERE Id = @userGameID

SELECT u.Username, g.Name, ug.Cash, i.Name AS 'Item Name' FROM Users AS u
	INNER JOIN UsersGames AS ug ON ug.UserId = u.Id
	LEFT JOIN Games AS g ON g.Id = ug.GameId
	LEFT JOIN UserGameItems AS ugi ON ugi.UserGameId = ug.Id
	LEFT JOIN Items AS i ON i.Id = ugi.ItemId
	WHERE g.Id = 221
	ORDER BY i.Name

-- Problem 29.
SELECT p.PeakName, m.MountainRange, p.Elevation FROM Peaks AS p
	INNER JOIN Mountains AS m ON m.Id = p.MountainId
	ORDER BY p.Elevation DESC, p.PeakName ASC

-- Problem 30.
SELECT p.PeakName, m.MountainRange AS Mountain, c.CountryName, con.ContinentName  FROM Peaks AS p
	INNER JOIN Mountains AS m ON m.Id = p.MountainId
	INNER JOIN MountainsCountries AS mc on mc.MountainId = m.Id
	INNER JOIN Countries AS c ON c.CountryCode = mc.CountryCode
	INNER JOIN Continents AS con ON con.ContinentCode = c.ContinentCode
	ORDER BY p.PeakName ASC, c.CountryName ASC

-- Problem 31.
SELECT co.CountryName, con.ContinentName,
CASE
	WHEN COUNT(r.Id) IS NULL THEN 0
	ELSE COUNT(r.Id)
END
AS RiversCount, 
CASE
	WHEN SUM(r.Length) IS NULL THEN 0
	ELSE SUM(r.Length)
END
AS TotalLength
FROM Countries AS co
	LEFT JOIN CountriesRivers AS cr ON cr.CountryCode = co.CountryCode
	LEFT JOIN Rivers AS r ON r.Id = cr.RiverId
	LEFT JOIN Continents AS con ON con.ContinentCode = co.ContinentCode
	GROUP BY co.CountryName, con.ContinentName
	ORDER BY RiversCount DESC, TotalLength DESC, co.CountryName ASC

-- Problem 32.
SELECT cu.CurrencyCode, cu.Description AS Currency, COUNT(co.CountryName) AS NumberOfCountries FROM Currencies AS cu 
 LEFT JOIN Countries AS co ON co.CurrencyCode = cu.CurrencyCode
 GROUP BY cu.CurrencyCode, cu.Description
 ORDER BY COUNT(co.CountryName) DESC, cu.Description ASC

-- Problem 33.
SELECT con.ContinentName, SUM(cou.AreaInSqKm) AS CountriesArea, SUM(CAST(cou.Population AS BIGINT)) AS CountriesPopulation FROM Continents AS con
	INNER JOIN Countries AS cou ON cou.ContinentCode = con.ContinentCode
	GROUP BY con.ContinentName
	ORDER BY SUM(CAST(cou.Population AS BIGINT)) DESC

-- Problem 34.
CREATE TABLE Monasteries
(
Id INT PRIMARY KEY IDENTITY,
Name VARCHAR(50),
CountryCode CHAR(2),
IsDeleted TINYINT
CONSTRAINT FK_Monasteries_CountryCode FOREIGN KEY (CountryCode) REFERENCES Countries(CountryCode)
)

INSERT INTO Monasteries(Name, CountryCode) VALUES
('Rila Monastery St. Ivan of Rila', 'BG'), 
('Bachkovo Monastery Virgin Mary', 'BG'),
('Troyan Monastery Holy Mother''s Assumption', 'BG'),
('Kopan Monastery', 'NP'),
('Thrangu Tashi Yangtse Monastery', 'NP'),
('Shechen Tennyi Dargyeling Monastery', 'NP'),
('Benchen Monastery', 'NP'),
('Southern Shaolin Monastery', 'CN'),
('Dabei Monastery', 'CN'),
('Wa Sau Toi', 'CN'),
('Lhunshigyia Monastery', 'CN'),
('Rakya Monastery', 'CN'),
('Monasteries of Meteora', 'GR'),
('The Holy Monastery of Stavronikita', 'GR'),
('Taung Kalat Monastery', 'MM'),
('Pa-Auk Forest Monastery', 'MM'),
('Taktsang Palphug Monastery', 'BT'),
('Sümela Monastery', 'TR')

UPDATE Countries
	SET IsDeleted = 0
WHERE CountryCode IN (SELECT cou.CountryCode FROM Countries AS cou 
					LEFT JOIN CountriesRivers AS cr ON cr.CountryCode = cou.CountryCode
					LEFT JOIN Rivers AS r ON r.Id = cr.RiverId 
					GROUP BY cou.CountryCode
					HAVING (COUNT(r.Id)) <= 3)

SELECT m.Name, cou.CountryName FROM [dbo].[Monasteries] AS m 
	LEFT JOIN Countries AS cou ON cou.CountryCode = m.CountryCode
	WHERE m.IsDeleted = 0
	ORDER BY m.Name

ALTER TABLE Countries
ADD IsDeleted TINYINT
CONSTRAINT D_Value DEFAULT 0

-- Problem 35.							