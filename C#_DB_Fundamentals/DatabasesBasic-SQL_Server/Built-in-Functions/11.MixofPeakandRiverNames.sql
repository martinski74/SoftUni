SELECT Peaks.PeakName, Rivers.RiverName ,
LOWER(PeakName+ cast(SUBSTRING(RiverName,2,len(RiverName)-1) as varchar)) as Mix 
FROM Peaks JOIN Rivers ON RIGHT (Peaks.PeakName,1) = LEFT(Rivers.RiverName,1)
ORDER BY Mix