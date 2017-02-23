SELECT
 (SELECT COUNT(CountryCode) FROM Countries) -(SELECT COUNT(cc.CountryCode) FROM
(SELECT CountryCode FROM MountainsCountries
GROUP BY CountryCode) AS cc)
AS CountryCode