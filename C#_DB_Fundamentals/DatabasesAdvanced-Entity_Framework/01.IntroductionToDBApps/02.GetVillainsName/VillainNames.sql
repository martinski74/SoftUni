USE MinionsDB

SELECT v.Name,COUNT(vm.MinionId) AS MinionCount FROM Villains AS v
INNER JOIN VillainsMinions AS vm ON v.Id = vm.VillainId
GROUP BY v.Name
HAVING COUNT(VM.MinionId) > 3
ORDER BY MinionCount DESC
