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
	(1,'Kevin',22,1),
	(2,'Bob',15,3),
	(3,'Steward',NULL,2);

SELECT * FROM Towns
SELECT * FROM Minions
--Problem 5.   Truncate Table Minions
TRUNCATE TABLE Minions;
DELETE FROM Minions;
--Problem 6.	Drop All Tables
DROP TABLE Minions;
DROP TABLE Towns;
--Problem 7.	Create Table People
CREATE TABLE People
(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(200) NOT NULL,
	Picture BINARY,
	Height DECIMAL(15,2),
	Weight DECIMAL(15,2),
	Gender CHAR(1)NOT NULL,
	Birthdate DATETIME2,
	Biography NVARCHAR(MAX)
);
INSERT INTO People([Name],Gender)
VALUES
	('Petar','m'),
	('Ivan','m'),
	('Dimitar','m'),
	('Anelia','f'),
	('Stefani','f');
SELECT * FROM People
--Problem 8.	Create Table Users
CREATE TABLE Users
(
	Id INT IDENTITY,
	Username VARCHAR(30)  NOT NULL,
	Password VARCHAR(26) NOT NULL,
	ProfilePicture BINARY,
	LastLoginTime DATETIME2,
	IsDeleted BIT
	CONSTRAINT pk_users PRIMARY KEY(Id)
);
INSERT INTO Users(Username,[Password])
VALUES	
	('PETAR','GGopta'),
	('KRASIBG','KRASIE'),
	('SAMUIll','traktor'),
	('saMURAI','pasWORDD'),
	('UTOPIA','PLATON');
	SELECT * FROM Users
--Problem 9.	Change Primary Key
ALTER TABLE Users
DROP CONSTRAINT pk_users;
ALTER TABLE Users
ADD CONSTRAINT pk_users PRIMARY KEY(Id,Username); 
--Problem 10.	Add Check Constraint
ALTER TABLE Users
ADD CONSTRAINT check_password CHECK(LEN([Password])>=5 )
	--TEST PROBLEM 10.
INSERT INTO Users(Username,[Password])
VALUES	
	('PETAR','GptaT');
--Problem 11.	Set Default Value of a Field
ALTER TABLE Users
ADD CONSTRAINT df_last_login_time
DEFAULT GETDATE() FOR LastLoginTime;
--Problem 12.	Set Unique Field
ALTER TABLE Users
ADD CONSTRAINT unique_username
UNIQUE (UserName);
--Problem 13.	Movies Database
CREATE DATABASE Movies;
CREATE TABLE Directors
(
	Id INT PRIMARY KEY IDENTITY,
	DirectorName NVARCHAR(20) NOT NULL,
	Notes NVARCHAR(MAX)
);
CREATE TABLE Genres 
(
	Id INT PRIMARY KEY IDENTITY,
	GenreName NVARCHAR(20) NOT NULL,
	Notes NVARCHAR(MAX)
);
CREATE TABLE Categories
(
	Id INT PRIMARY KEY IDENTITY,
	CategoryName NVARCHAR(20) NOT NULL,
	Notes NVARCHAR(MAX)
);
CREATE TABLE Movies
(
	Id INT PRIMARY KEY IDENTITY,
	Title NVARCHAR(50) NOT NULL,
	DirectorId INT NOT NULL,
	CopyrightYear INT,
	Lenght INT,
	GenreId INT,
	CategoryId INT,
	Rating DECIMAL(15,2),
	Notes NVARCHAR(MAX)
	CONSTRAINT fk_movies_directors
		FOREIGN KEY(DirectorId)
		REFERENCES Directors(Id),
	CONSTRAINT fk_movies_genres
		FOREIGN KEY(GenreId)
		REFERENCES Genres(Id),
	CONSTRAINT fk_movies_categories
		FOREIGN KEY(CategoryId)
		REFERENCES Categories(Id)
);
INSERT INTO Genres(GenreName)
VALUES
	('Action'),
	('Adventure'),
	('Animation'),
	('Comedy'),
	('Crime');
INSERT INTO Directors (DirectorName)
VALUES
	('Christopher Nolan'),
	('Kiranraj K'),
	('Hayao Miyazaki'),
	('Francis Ford Coppola'),
	('Frank Darabont');
INSERT INTO Categories(CategoryName)
VALUES
	('PG-13'),
	('Approved'),
	('PG'),
	('R'),
	('G');
INSERT INTO Movies (Title,DirectorId,CopyrightYear,Lenght,GenreId,CategoryId,Rating)
VALUES 
	('The Dark Knight',1,2008,150,1,1,9.0),
	('777 Charlie',2,2022,160,2,2,9.0),
	('Spirited Away',3,2001,120,3,3,8.6),
	('The Godfather',4,1972,180,4,4,9.2),
	('The Shawshank Redemption',4,1994,140,4,4,9.3);

SELECT*FROM Genres
SELECT*FROM Directors
SELECT*FROM Categories
--PROBLEM 14 CarRentalDB
CREATE DATABASE CarRental;
USE CarRental;
CREATE TABLE Categories
(
	Id INT PRIMARY KEY IDENTITY,
	CategoryName NVARCHAR(25) NOT NULL,
	DailyRate DECIMAL NOT NULL,
	WeeklyRate DECIMAL NOT NULL,
	MonthlyRate DECIMAL NOT NULL,
	WeekendRate DECIMAL NOT NULL
);
CREATE TABLE Cars
(
	Id INT PRIMARY KEY IDENTITY,
	PlateNumber NVARCHAR(8) NOT NULL,
	Manufacturer NVARCHAR(25) NOT NULL,
	Model NVARCHAR(25) NOT NULL,
	CarYear INT NOT NULL,
	CategoryId INT NOT NULL,
	Doors INT NOT NULL,
	Picture BINARY,
	Condition NVARCHAR(15) NOT NULL,
	Available BIT NOT NULL
	CONSTRAINT fk_cars_categories
		FOREIGN KEY(CategoryId)
		REFERENCES Categories(Id)
);
CREATE TABLE Employees 
(
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(25) NOT NULL,
	LastName NVARCHAR(25) NOT NULL,
	Title NVARCHAR(20) NOT NULL,
	NOTES NVARCHAR(MAX)
);
CREATE TABLE Customers
(
	Id INT PRIMARY KEY IDENTITY,
	DriverLicenceNumber NVARCHAR(8) NOT NULL,
	FullName NVARCHAR(50) NOT NULL,
	Address NVARCHAR(30) NOT NULL,
	City NVARCHAR(30) NOT NULL,
	ZIPCode INT NOT NULL,
	NOTES NVARCHAR(MAX)
)
CREATE TABLE RentalOrders
(
	Id INT PRIMARY KEY IDENTITY,
	EmployeeId INT NOT NULL,
	CustomerId INT NOT NULL,
	CarId INT NOT NULL,
	TankLevel DECIMAL NOT NULL,
	KilometrageStart INT NOT NULL,
	KilometrageEnd INT NOT NULL,
	TotalKilometrage INT NOT NULL,
	StartDate DATETIME2 DEFAULT(GETDATE()),
	EndDate DATETIME2,
	TotalDays INT,
	RateApplied DECIMAL,
	TaxRate DECIMAL,
	OrderStatus BIT,
	Notes NVARCHAR(MAX)
	CONSTRAINT fk_rentalOrder_employee
		FOREIGN KEY(EmployeeId)
		REFERENCES Employees(Id),
	CONSTRAINT fk_rentalOrder_cars
		FOREIGN KEY(CarId)
		REFERENCES Cars(Id),
	CONSTRAINT fk_rentalOrder_customers
		FOREIGN KEY(CustomerId)
		REFERENCES Customers(Id)
);
INSERT INTO Categories(CategoryName,DailyRate,WeeklyRate,MonthlyRate,WeekendRate)
VALUES
	('Car',20,120,550,15),
	('Bus',25,140,600,20),
	('Truck',30,160,650,25);
INSERT INTO Cars(PlateNumber,Manufacturer,Model,CarYear,CategoryId,Doors,Condition,Available)
VALUES
	('PA3231KT', 'Reno','Clio',2014,1,5,'Good',1),
	('PA3232KT', 'Fiat','Punto',2015,1,5,'Good',1),
	('PA3233KT', 'Ford','Fiesta',2017,1,5,'Good',1);
INSERT INTO Employees(FirstName,LastName,Title)
VALUES
	('Hasan','Saidov','NPC1'),
	('Nikolai','Puhalev','NPC2'),
	('Nikolai','Gagov','NPC3')
INSERT INTO Customers(DriverLicenceNumber,FullName,[Address],City,ZIPCode)
VALUES
	('PA3231KT','Rusi Alendarov','Iskra 2','Murzelgrad',4642),
	('PA3232KT','Krasimir Perov','Krivolak 20','HateCity',4600),
	('PA3233KT','Mario Drums','Mahlenec 2','HateCity',4600);