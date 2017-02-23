SELECT mc.CountryCode,COUNT(c.CountryCode) as [MountainRanges] FROM Countries AS c
JOIN MountainsCountries AS mc ON mc.CountryCode = c.CountryCode
JOIN Mountains as m ON m.Id = mc.MountainId
WHERE mc.CountryCode IN('US','BG','RU')
GROUP BY mc.CountryCode