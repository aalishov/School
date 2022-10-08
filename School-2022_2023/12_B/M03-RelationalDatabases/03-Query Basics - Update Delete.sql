--DROP DATABASE Minios
--Problem 1.	Create Database
CREATE DATABASE Minions
USE Minions
--Problem 2+3.	Create Tables
CREATE TABLE Towns
(
	Id INT PRIMARY KEY,
	[Name] VARCHAR(MAX) NOT NULL
)
CREATE TABLE Minions
(
	Id INT PRIMARY KEY,
	[Name] VARCHAR(MAX) NOT NULL,
	Age INT,
	TownId INT NOT NULL
	CONSTRAINT fk_minions_towns
		FOREIGN KEY (TownId)
		REFERENCES Towns(Id)
);
--Problem 4.	Insert Records in Both Tables
INSERT INTO Towns(Id,[Name])
VALUES
	(1,'Sofia'),
	(2,'Plovdiv'),
	(3,'Varna');
INSERT INTO Minions(Id,[Name],Age,TownId)
VALUES
	(1,'Kevin')
SELECT * FROM Towns