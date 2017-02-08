SELECT ContinentCode, CurrencyCode, CurrencyUsage FROM
(SELECT ContinentCode, CurrencyCode, CurrencyUsage, DENSE_RANK() OVER (PARTITION BY ContinentCode ORDER BY CurrencyUsage DESC) AS [Rank] FROM
(SELECT ContinentCode, CurrencyCode, COUNT(CountryCode) AS CurrencyUsage FROM Countries
GROUP BY ContinentCode, CurrencyCode
HAVING COUNT(CountryCode) > 1) AS cudata) as rankedcudata
WHERE [Rank] = 1