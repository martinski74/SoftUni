CREATE TABLE Students(
StudentID INT PRIMARY KEY,
StudentNumber INT,
StudentName varchar(30) not null,
MajorID INT not null
)
CREATE TABLE Majors(
MajorID INT PRIMARY KEY,
Name varchar(30) not null
)
CREATE TABLE Agenda(
StudentID INT not null,
SubjectID INT not null
)
CREATE TABLE Payments(
PaymentID INT PRIMARY KEY,
PaymentDate DATE,
PaymentAmount money,
StudentID INT
)
CREATE TABLE Subjects(
SubjectID INT  PRIMARY KEY,
SubjectName varchar(30) not null
)
ALTER TABLE Payments
ADD CONSTRAINT FK_Payment_Student
FOREIGN KEY(StudentID)
REFERENCES Students(StudentID)

ALTER TABLE Students
ADD CONSTRAINT FK_Student_Major
FOREIGN KEY(MajorID)
REFERENCES Majors(MajorID)

ALTER TABLE Agenda
ADD CONSTRAINT PK_Agend
PRIMARY KEY(StudentID,SubjectID)

ALTER TABLE Agenda
ADD CONSTRAINT FK_Agenda_Student
FOREIGN KEY(StudentID)
REFERENCES Students(StudentID)

ALTER TABLE Agenda
ADD CONSTRAINT FK_Agenda_Subject
FOREIGN KEY(SubjectID)
REFERENCES Subjects(SubjectID)