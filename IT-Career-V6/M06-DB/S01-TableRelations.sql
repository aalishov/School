-- Създаване на БД с име TableRelations.
CREATE DATABASE TableRelations;

-- Задаване на работна БД
USE TableRelations;

-- Създаване на връзка 1:1
-- Създаване на таблица Passports
CREATE TABLE Passports
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    number VARCHAR(8) NOT NULL
);

CREATE TABLE People
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    name NVARCHAR(50) NOT NULL,
    salary DECIMAL(12,2) NOT NULL,
    passport_id INT UNIQUE NOT NULL,
    CONSTRAINT fk_people_passports
		FOREIGN KEY (passport_id)
        REFERENCES Passports(id)
);

SELECT * FROM Passports;

INSERT INTO Passports(number)
VALUES 
	('N34FG21B'),
    ('K65LO4R7'),
    ('ZE657QP2');

INSERT INTO People(name,salary,passport_id)
VALUES
	('Roberto',43300,2),
    ('Tom',56100,3),
    ('Yana',60200,1);
    
SELECT * FROM People;

-- Създаване на връзка 1:M
CREATE TABLE Manufacturers
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(50) NOT NULL,
    established_on DATE
);

CREATE TABLE Models
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(50) NOT NULL,
    manufacturer_id INT NOT NULL,
    CONSTRAINT fk_models_manufacturers
		FOREIGN KEY (manufacturer_id)
        REFERENCES Manufacturers(id)
);

INSERT INTO Manufacturers(name,established_on)
VALUES
	('BMW','1916-03-01'),
    ('Tesla','2003-01-01'),
    ('Lada','1966-05-01'),
    ('Ford',null),
    ('Opel',null);

SELECT * FROM Manufacturers;

INSERT INTO Models(name, manufacturer_id)
VALUES
	('X1',1),('i6',1),('Models S',2),
    ('Model X',2),('Model 3',2),('Nova',3),
    ('Corsa',5),('Fiesta',4),('Astra',5);
    
USE tablerelations;

SELECT * FROM Models;


-- Създаване на връзка M:N
CREATE TABLE Students
(
	Id INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(50) NOT NULL
 );
 
 CREATE TABLE Exams
 (
	Id INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(50)  NOT NULL
 );
 
 CREATE TABLE StudentsExams
 (
	StudentId INT NOT NULL,
    ExamId INT NOT NULL,
    CONSTRAINT pk_students_exams
		PRIMARY KEY (StudentId, ExamId),
    CONSTRAINT fk_studentsExams_students
		FOREIGN KEY (StudentID)
        REFERENCES Students(Id),
	CONSTRAINT fk_studentsExams_exams
		FOREIGN KEY (ExamId)
        REFERENCES Exams(Id)
 );
 
 INSERT INTO Students(Name)
 VALUES
	('Mila'),
    ('Toni'),
    ('Ron');

INSERT INTO Exams(Name)
VALUES
	('Spring MVC'),
    ('Neo4j'),
    ('Oracle 11g');

INSERT INTO StudentsExams(StudentId,ExamId)
VALUES
	(1,1),
    (1,2),
    (2,1),
    (3,3),
    (2,2),
    (2,3);

SELECT * FROM Students;
SELECT * FROM Exams;
SELECT * FROM StudentsExams;

-- Създаване на връзка - самообръщаша (self-reference)
CREATE TABLE Teachers
(
	Id INT PRIMARY KEY AUTO_INCREMENT
    Name NVARCHAR(50) NOT NULL,
    managerId INT NULL,
    CONSTRAINT fk_teachers_teachers
		FOREIGN KEY (managerId)
        REFERENCES Teachers(Id)
);

INSERT INTO Teachers(Name)
VALUES 
	('John'),
    ('Maya'),
    ('Silvia'),
    ('Ted'),
    ('Mark'),
    ('Greta');
    
SELECT * FROM Teachers;

UPDATE Teachers
	SET ManagerId=6
    WHERE Id IN(2,3);

UPDATE Teachers
	SET ManagerId=5
    WHERE Id=4;

UPDATE Teachers
	SET ManagerId=1
    WHERE Id=5 OR Id=6;
    
SELECT * FROM Manufacturers;
SELECT * FROM Models;

DELETE FROM MODELS WHERE manufacturer_id=1;
DELETE FROM Manufacturers WHERE Id=1;
