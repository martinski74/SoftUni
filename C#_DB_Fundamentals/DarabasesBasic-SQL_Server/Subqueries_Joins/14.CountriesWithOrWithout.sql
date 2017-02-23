SELECT TOP 5
 c.CountryName,
r.RiverName
 FROM Countries AS c
left JOIN CountriesRivers AS cr ON cr.CountryCode = c.CountryCode
left JOIN Rivers AS r ON r.Id = cr.RiverId
WHERE c.ContinentCode = 'AF'
ORDER BY c.CountryName