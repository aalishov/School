CREATE DATABASE OneToMany;

USE OneToMany;

CREATE TABLE Manufacturers
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(50) UNIQUE NOT NULL,
	EstablishedOn DATETIME2 NOT NULL
);

CREATE TABLE Models
(
	Id INT PRIMARY KEY IDENTITY(100,1),
	[Name] NVARCHAR(50) UNIQUE NOT NULL,
	ManufacturerId INT NOT NULL,
	CONSTRAINT Fk_Models_Manufacturers
	FOREIGN KEY (ManufacturerId)
	REFERENCES Manufacturers(Id)
); 

INSERT INTO Manufacturers([Name],EstablishedOn)
VALUES
	('BMW','07/03/1916'),
	('Tesla','01/01/2003'),
	('Lada','01/05/1966');

SELECT * FROM Manufacturers;

INSERT INTO Models([Name],ManufacturerId)
VALUES
	('X1',1),
	('i6',1),
	('Model S',2),
	('Model X',2),
	('Model 3',2),
	('Nova',3);

SELECT * FROM Models;