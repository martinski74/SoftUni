SELECT G.Name,
    CASE
        WHEN (DATEPART(HOUR, G.Start)) BETWEEN 0 AND 11 THEN 'Morning'
        WHEN (DATEPART(HOUR, G.Start)) BETWEEN 12 AND 17 THEN 'Afternoon'
        WHEN (DATEPART(HOUR, G.Start)) BETWEEN 18 AND 23 THEN 'Evening'
    END AS [Part of Day],
    CASE
        WHEN G.Duration <= 3 THEN 'Extra Short'
        WHEN G.Duration BETWEEN 4 AND 6 THEN 'Short'
        WHEN G.Duration IS NULL THEN 'Extra Long'
        ELSE 'Long'
    END AS [Duration]
FROM Games AS G
ORDER BY G.Name ASC,
    [Duration],
    [Part of Day]