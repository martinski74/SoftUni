CREATE TABLE Passports(
PassportID INT NOT NULL,
PassportNumber NVARCHAR(10) NOT NULL
)

CREATE TABLE Persons(
PersonID INT NOT NULL,
FirstName NVARCHAR(20) NOT NULL,
Salary DECIMAL(10,2),
PassportID INT NOT NULL)

INSERT INTO Passports (PassportID, PassportNumber)
VALUES
(101, 'N34FG21B'),
(102, 'K65LO4R7'),
(103, 'ZE657QP2')

INSERT INTO Persons (PersonID, FirstName, Salary, PassportID)
VALUES
(1, 'Roberto', 43300.00, 102),
(2, 'Tom', 56100.00, 103),
(3, 'Yana', 60200.00, 101)

ALTER TABLE Persons
ADD PRIMARY KEY (PersonID)

ALTER TABLE Passports
ADD PRIMARY KEY (PassportID)

ALTER TABLE Persons
ADD CONSTRAINT FK_Persons_Passports
FOREIGN KEY (PassportID)
REFERENCES Passports(PassportID)