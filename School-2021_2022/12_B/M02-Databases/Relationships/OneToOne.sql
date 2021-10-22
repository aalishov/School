CREATE DATABASE OneToOne;

USE OneToOne;

CREATE TABLE Passports
(
	PassportId INT PRIMARY KEY IDENTITY,
	PassportNumber VARCHAR(10) UNIQUE NOT NULL
);

CREATE TABLE Persons
(
	PersonId INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(50) NOT NULL,
	Salary DECIMAL(12,2) NOT NULL,
	PassportId INT UNIQUE NOT NULL
	CONSTRAINT Fk_persons_passports
	FOREIGN KEY (PassportId)
	REFERENCES Passports(PassportId)
);

INSERT INTO Passports(PassportNumber)
VALUES 
	('001'),
	('002'),
	('003'),
	('004');

SELECT * FROM Passports;

INSERT INTO Persons(FirstName,Salary,PassportId)
VALUES 
	('Alex',1899,1),
	('John',1899,4);

SELECT * FROM Persons;
