CREATE DATABASE MyStudents;

use mystudents;

CREATE TABLE towns
(
	id int primary key auto_increment,
    name varchar(50) unique not null
);

CREATE TABLE students (
    id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(50) NOT NULL,
    town_id INT,
    CONSTRAINT fk_students_towns FOREIGN KEY (town_id)
        REFERENCES towns (id)
);

INSERT into towns(name)
values ('Sofia'),('Plovdiv'),('Varna'),('Ruse'),('Velingrad');

INSERT INTO students(name, town_id) 
values ('John',2),('Jack',NULL),('Alex',NULL),('Jane',1);


SELECT * FROM students AS s
INNER JOIN towns AS t ON t.id=s.town_id;

SELECT * FROM students AS s
LEFT JOIN towns AS t ON t.id=s.town_id;

SELECT * FROM students AS s
RIGHT JOIN towns AS t ON t.id=s.town_id;

SELECT * FROM students AS s
JOIN towns AS t ON t.id=s.town_id;

(SELECT * FROM students AS s
RIGHT JOIN towns AS t ON t.id=s.town_id)
UNION
(SELECT * FROM students AS s
LEFT JOIN towns AS t ON t.id=s.town_id);

SELECT * FROM students AS s
CROSS JOIN towns;
