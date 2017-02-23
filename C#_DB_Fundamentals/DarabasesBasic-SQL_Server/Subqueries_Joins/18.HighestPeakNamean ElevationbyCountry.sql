SELECT TOP(5) t.CountryName AS 'Country',
    CASE
        WHEN t.PeakName IS NULL THEN '(no highest peak)'
        ELSE t.PeakName
    END AS 'HighestPeakName',
    CASE
        WHEN t.PeakElevation IS NULL THEN 0
        ELSE t.PeakElevation
    END AS 'HighestPeakElevation',
    CASE
        WHEN t.PeakElevation IS NULL THEN '(no mountain)'
        ELSE t.MountainName
    END AS 'Mountain'
FROM
    (SELECT c.CountryName AS 'CountryName', p.PeakName AS 'PeakName', p.Elevation AS 'PeakElevation', m.MountainRange AS 'MountainName',
        DENSE_RANK() OVER (PARTITION BY c.CountryName ORDER BY p.Elevation DESC) AS 'Ranking'
    FROM Countries AS c
        LEFT OUTER JOIN MountainsCountries AS mc
        ON c.CountryCode = mc.CountryCode
        LEFT OUTER JOIN Mountains AS m
        ON mc.MountainId = m.Id
        LEFT OUTER JOIN Peaks AS p
        ON p.MountainId = m.Id
    ) AS t
WHERE t.Ranking = 1
ORDER BY 'Country', 'HighestPeakName'