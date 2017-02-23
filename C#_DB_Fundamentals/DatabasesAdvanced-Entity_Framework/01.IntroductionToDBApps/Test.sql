USE MinionsDB

CREATE TABLE Minions(
Id INT IDENTITY,
Name varchar(20),
Age INT,
TownId VARCHAR(30),
constraint PK_Minions PRIMARY KEY(Id)
)
CREATE TABLE Towns(
Id INT IDENTITY,
TownName VARCHAR(35),
CountryName  VARCHAR(35),
CONSTRAINT PK_Towns PRIMARY KEY(Id)
)
CREATE TABLE Villains(
Id INT IDENTITY,
Name VARCHAR(20),
EvilnessFactor VARCHAR(10),
constraint PK_Vilains PRIMARY KEY(Id),
CONSTRAINT CH_EvFactor CHECK(EvilnessFactor IN('good','bad','evil','super evil'))
)

CREATE TABLE VillainsMinions(
VillainId INT,
MinionId INT,
CONSTRAINT PK_Vill_Min PRIMARY KEY(VillainId,MinionId)
)

INSERT INTO Towns (TownName,CountryName) VALUES 
('Sofia','Bulgaria'),
('Plovdiv','Bulgaria'),
('Berlin','Germany'),
('Paris','France'),
('Liverpool','England')

INSERT INTO Minions(Name,Age,TownId) VALUES
('Kev',11,1),
('Bobb',12,2),
('Stew',5,3),
('Malk',3,5),
('Tosh',1,4)

INSERT INTO Villains(Name,EvilnessFactor) VALUES 
('Gosho','bad'),
('Tosho','good'),
('Misho','evil'),
('Gogo','super evil'),
('Tiho','bad')

INSERT INTO VillainsMinions(VillainId,MinionId) VALUES
(1,1),
(1,2),
(1,3),
(1,4),
(1,5),
(2,2),
(3,1),
(3,2),
(3,3),
(3,4),
(3,5),
(4,4),
(5,5)
