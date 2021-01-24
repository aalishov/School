CREATE DATABASE OneToOne;

USE OneToOne;

CREATE TABLE Passports
(
	id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    passport_number VARCHAR(8)
);

CREATE TABLE Persons
(
	id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    first_name NVARCHAR(50) NOT NULL,
    salary DECIMAL(20,5) NOT NULL,
    passport_id INT UNIQUE,
    CONSTRAINT FK_persons_passporst
    FOREIGN KEY (passport_id)
    REFERENCES passports(id)
);

INSERT INTO passports (passport_number)
VALUES
	('N34FG21B'),
	('K65LO4R7'),
	('ZE657QP2');

INSERT INTO Persons(first_name,salary,passport_id) VALUES('Roberto',43300.00,1);
INSERT INTO Persons(first_name,salary,passport_id) VALUES('Tom',56100.00,2);
INSERT INTO Persons(first_name,salary,passport_id) VALUES('Yana',60200.00,3);

SELECT  * FROM Persons;