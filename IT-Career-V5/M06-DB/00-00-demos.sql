/*

DROP DATABASE Students;

CREATE DATABASE Students;

USE Students;
*/

CREATE TABLE Students
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    first_name NVARCHAR(50) NOT NULL,
    last_name NVARCHAR(50) NOT NULL
);

ALTER TABLE Students
ADD Town NVARCHAR(20);

INSERT INTO Students(first_name,last_name)
VALUES 
	('Ivan','Ivanov'),
	('Ivan','Petrov'),
    ('ALex','Ivanov'); 
    
SET sql_safe_updates=0;
    
UPDATE Students
SET Town='Velingrad';

ALTER TABLE Students
MODIFY Town NVARCHAR(20) NOT NULL;

INSERT INTO Students(first_name,last_name,town)
VALUES 
	('Ivan','Ivanov','Ruse');

SELECT * FROM Students;

TRUNCATE Students;

DROP TABLE Students;
