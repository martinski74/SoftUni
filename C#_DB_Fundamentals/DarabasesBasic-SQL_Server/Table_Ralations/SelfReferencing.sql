CREATE TABLE Teachers(
TeacherID INT not null,
Name varchar(20) not null,
ManagerID INT
)

INSERT INTO Teachers(TeacherID,Name,ManagerID) VALUES (101,'John',null),
(102,'Maya',106),(103,'Silvia',106),(104,'Ted',105),(105,'Mark',101),(106,'Greta',101);

ALTER TABLE Teachers 
ADD CONSTRAINT PK_Teachers_ PRIMARY KEY(TeacherID);

ALTER TABLE Teachers 
ADD CONSTRAINT FK_Teachers_Managers FOREIGN KEY(ManagerID) REFERENCES Teachers (TeacherID)
