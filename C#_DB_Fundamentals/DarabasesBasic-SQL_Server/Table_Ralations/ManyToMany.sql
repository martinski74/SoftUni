create table Students
(
StudentID int not null,
Name varchar(30) not null,
)
 
create table Exams
(
ExamID int not null,
Name varchar(30) not null
)
 
create table [StudentsExams]
(
StudentID int not null,
ExamID int not null,
)
 
insert into Students(StudentID,Name)
values(1,'Mila'),(2,'Toni'),(3,'Ron')
 
insert into Exams(ExamID,Name)
values(101,'SpringMVC'),(102,'Neo4j'),(103,'Oracle 11g')
 
insert into [StudentsExams](StudentID,ExamID)
values(1,101),(1,102),(2,101),(3,103),(2,102),(2,103)
 
alter table Students
add constraint PK_StudentID
primary key (StudentID)
 
alter table Exams
add constraint PK_ExamID
primary key(ExamID)
 
alter table [StudentsExams]
add constraint PK_Student_Exams
primary key(StudentID,ExamID)
 
alter table [StudentsExams]
add constraint FK_Student_Exam_Students
foreign key(StudentID)
references Students(StudentID)
 
alter table [StudentsExams]
add constraint FK_Student_Exams_Exams
foreign key (ExamID)
references Exams(ExamID)