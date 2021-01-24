CREATE DATABASE ManyToMany;

USE ManyToMany;

CREATE TABLE students
(
	id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	name VARCHAR(30) NOT NULL
);

CREATE TABLE exams
(
	id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	name VARCHAR(10) NOT NULL
)AUTO_INCREMENT=101;


CREATE TABLE students_exams
(
	student_id INT NOT NULL ,
	exam_id INT NOT NULL,
	PRIMARY KEY(student_id, exam_id),
    CONSTRAINT FK_students_students_exam 
		FOREIGN KEY(student_id) 
		REFERENCES students(id),
    CONSTRAINT FK_exams_students_exam
		FOREIGN KEY(exam_id) 
		REFERENCES exams(id)
);

 

INSERT INTO Students(name)
VALUES
('Mila'),
('Toni'),
('Ron');

INSERT INTO Exams(name)
VALUES
('Spring MVC'),
('Neo4j'),
('Oracle 11g');

INSERT INTO students_exams(student_id,exam_id)
VALUES
(1,101),
(1,102),
(2,101),
(3,103),
(2,102),
(2,103);


SELECT * FROM students;
SELECT * FROM exams;
SELECT * FROM students_exams;

SELECT s.name as 'Student name', e.name as 'Exam name' FROM students as s
JOIN students_exams as se ON s.id=se.student_id
JOIN exams as e ON e.id=se.exam_id
