SELECT CountryName,CountryCode, CASE WHEN CurrencyCode != 'EUR' OR  CurrencyCode  IS NULL THEN 'Not Euro' ELSE 'Euro' END
 AS [Curency]  FROM Countries ORDER BY CountryName;