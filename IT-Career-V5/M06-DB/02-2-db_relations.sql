CREATE DATABASE Relations;

USE Relations;

CREATE TABLE Passports
(
	passport_id INT PRIMARY KEY AUTO_INCREMENT ,
    passport_number VARCHAR(20)
);

CREATE TABLE Persons
(
	person_id INT PRIMARY KEY AUTO_INCREMENT,
    first_name NVARCHAR(50) NOT NULL,
    salary DECIMAL(12,2) NOT NULL,
    passport_id INT NOT NULL UNIQUE,
    CONSTRAINT fk_persons_passports
		FOREIGN KEY (passport_id)
        REFERENCES passports(passport_id)
);

INSERT INTO Passports(passport_number)
VALUES
	('N34FG21B'),
    ('K65LO4R7'),
    ('ZE657QP2');
    
INSERT INTO Persons(first_name,salary,passport_id)
VALUES 
	('Roberto',433000,2), 
    ('Tom',56100,3),
    ('Yana',60200,1);
    
CREATE TABLE Manufacturers
(
	manufacturer_id INT PRIMARY KEY AUTO_INCREMENT,
    name NVARCHAR(50) NOT NULL,
	established_on DATETIME 
);

CREATE TABLE Models
(
	model_id INT PRIMARY KEY,
    name NVARCHAR(50) NOT NULL,
    manufacturer_id INT NOT NULL ,
    CONSTRAINT fk_models_manufacturers
		FOREIGN KEY (manufacturer_id)
        REFERENCES Manufacturers(manufacturer_id)
) AUTO_INCREMENT = 101;

-- Many-to-many
CREATE TABLE Students
(
	student_id INT PRIMARY KEY AUTO_INCREMENT,
    name NVARCHAR(50) NOT NULL
);

CREATE TABLE Exams
(
	exam_id INT PRIMARY KEY AUTO_INCREMENT,
    name NVARCHAR(50) NOT NULL
);

CREATE TABLE Students_exams
(
	student_id INT,
    exam_id INT,
    CONSTRAINT pk_students_exams
		PRIMARY KEY (student_id, exam_id),
	CONSTRAINT fk_students_exams_students
		FOREIGN KEY (student_id)
        REFERENCES Students(student_id),
	CONSTRAINT fk_students_exams_exams
		FOREIGN KEY (exam_id)
        REFERENCES Exams(exam_id)
);

INSERT INTO Students (name)
VALUES
	('Mila'),
    ('Toni'),
    ('Ron');

SELECT * FROM Students;

INSERT INTO Exams (name)
VALUES 
	('Spring MVC'),
    ('Neo4j'),
    ('Oracle 11g');
    
SELECT * FROM Exams;

INSERT INTO Students_exams(student_id,exam_id)
VALUES 
	(1,1),
    (1,2),
    (2,1),
    (3,3),
    (2,2),
    (2,3);
    
SELECT * FROM Students_exams;

-- Self-reference
CREATE TABLE Teachers
(
	teacher_id INT PRIMARY KEY AUTO_INCREMENT,
    name NVARCHAR(50) NOT NULL,
    manager_id INT,
    CONSTRAINT fk_teachers_teachers
		FOREIGN KEY (manager_id)
        REFERENCES Teachers(teacher_id)
) AUTO_INCREMENT = 101;
 

    