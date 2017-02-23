USE MinionsDB

SELECT Name,Age FROM Minions AS m
JOIN VillainsMinions AS vm ON vm.MinionId = m.Id
WHERE vm.VillainId = @villainId
