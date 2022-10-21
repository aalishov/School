--1.	Релация едно-към-едно
CREATE DATABASE Persons;
USE Persons;
CREATE TABLE Passports
(
	PassportID INT PRIMARY KEY IDENTITY(101,1) ,
	PassportNumber VARCHAR(8) NOT NULL
);
CREATE TABLE Persons
(
	PersonID INT PRIMARY KEY IDENTITY,
	FirstName VARCHAR(15) NOT NULL,
	Salary DECIMAL(15,2) NOT NULL,
	PassportID INT UNIQUE NOT NULL,
	CONSTRAINT fk_persons_passports
	FOREIGN KEY (PassportID)
	REFERENCES Passports(PassportID)
);

INSERT INTO Passports(PassportNumber)
VALUES
	('N34FG21B'),
	('K65LO4R7'),
	('ZE657QP2');
INSERT INTO Persons(FirstName,Salary,PassportID) 
VALUES
('Roberto',43300.00,102),
('Tom',56100.00,103),
('Yana',60200.00,101);
--2. Релация едно-към-много
CREATE DATABASE Cars;
USE Cars;
CREATE TABLE Manufacturers
(
	ManufacturerID INT PRIMARY KEY IDENTITY,
	Name VARCHAR(30) NOT NULL,
	EstablishedOn DATETIME2 NOT NULL
);
CREATE TABLE Models
(
	ModelID  INT PRIMARY KEY IDENTITY(101,1),
	Name VARCHAR(30) NOT NULL,
	ManufacturerID INT NOT NULL,
	CONSTRAINT fk_models_manufacturers
	FOREIGN KEY (ManufacturerID)
	REFERENCES Manufacturers(ManufacturerID)
);
INSERT INTO Manufacturers([Name],EstablishedOn)
VALUES
	('BMW','07/03/1916'),
	('Tesla','01/01/2003'),
	('Lada','01/05/1966');
INSERT INTO Models([Name],ManufacturerID)
VALUES
	('X1',1),
	('i6',1),
	('Model S',2),
	('Model X',2),
	('Model 3',2),
	('Nova',3);
--3.	Релация много-към-много
CREATE DATABASE Exams;
USE Exams;

CREATE TABLE Students
(
	StudentID INT PRIMARY KEY IDENTITY,
	Name VARCHAR(15) NOT NULL
);

CREATE TABLE Exams
(
	ExamID INT PRIMARY KEY IDENTITY(101,1),
	Name VARCHAR(15) NOT NULL
);

CREATE TABLE StudentsExams
(
	StudentID INT,
	ExamID INT,
	CONSTRAINT pk_studentsexams
		PRIMARY KEY(StudentID,ExamID),
	CONSTRAINT fk_studentexams_students
		FOREIGN KEY (StudentID)
		REFERENCES Students(StudentID),
	CONSTRAINT fk_studentexams_exams
		FOREIGN KEY (ExamID)
		REFERENCES Exams(ExamID)
);

INSERT INTO Students ([Name])
VALUES
	('Mila'),
	('Toni'),
	('Ron');
INSERT INTO Exams([Name])
VALUES
	('SpringMVC'),
	('Neo4j'),
	('Oracle 11g');
INSERT INTO StudentsExams(StudentID,ExamID)
VALUES
	(1,101),
	(1,102),
	(2,101),
	(3,103),
	(2,102),
	(2,103);

--4. Self-Referencing
CREATE DATABASE Teachers;
USE Teachers;

CREATE TABLE Teachers
(
	TeachersID INT PRIMARY KEY IDENTITY(101,1),
	Name VARCHAR(20) NOT NULL,
	ManagerID INT
	CONSTRAINT fk_teachers_teachers
		FOREIGN KEY(ManagerID)
		REFERENCES Teachers(TeachersID)
);
INSERT INTO Teachers([Name])
VALUES
	('John'),
	('Maya'),
	('Silvia'),
	('Ted'),
	('Mark'),
	('Greta');
UPDATE Teachers SET ManagerID = 106 
WHERE TeachersID = 102;
UPDATE Teachers SET ManagerID = 106 
WHERE TeachersID = 103;
UPDATE Teachers SET ManagerID = 105 
WHERE TeachersID = 104;
UPDATE Teachers SET ManagerID = 101 
WHERE TeachersID = 105;
UPDATE Teachers SET ManagerID = 101 
WHERE TeachersID = 106;
--5.	БД Онлайн магазин
CREATE DATABASE Shops;
USE Shops;

CREATE TABLE Cities
(
	CityID INT PRIMARY KEY IDENTITY,
	Name VARCHAR(50) NOT NULL
);

CREATE TABLE ItemTypes
(
	ItemTypeID INT PRIMARY KEY IDENTITY,
	Name VARCHAR(50) NOT NULL
);

CREATE TABLE Customers
(
	CustomerID INT PRIMARY KEY IDENTITY,
	Name VARCHAR(50) NOT NULL,
	Birthday DATETIME2 NOT NULL,
	CityID INT
	CONSTRAINT fk_customers_cities
		FOREIGN KEY (CityID)
		REFERENCES Cities(CityID)
);

CREATE TABLE Items
(
	ItemID INT PRIMARY KEY IDENTITY,
	Name VARCHAR(50) NOT NULL,
	ItemTypeID INT
	CONSTRAINT fk_items_itemtypes
		FOREIGN KEY (ItemTypeID)
		REFERENCES ItemTypes(ItemTypeID)
);

CREATE TABLE Orders
(
	OrderID INT PRIMARY KEY IDENTITY,
	CustomerID INT
	CONSTRAINT fk_orderitems_customers
		FOREIGN KEY (CustomerID)
		REFERENCES Customers(CustomerID)
);

CREATE TABLE OrderItems
(
	OrderID INT,
	ItemID INT
	CONSTRAINT pk_orderitems
		PRIMARY KEY (OrderID,ItemID),
	CONSTRAINT fk_orderitems_items
		FOREIGN KEY (ItemID)
		REFERENCES Items(ItemID),
	CONSTRAINT fk_orderitems_orders
		FOREIGN KEY (OrderID)
		REFERENCES Orders(OrderID)
);
--6.	БД Университет
CREATE DATABASE Uni;
USE Uni;

CREATE TABLE Majors
(
	MajorID INT PRIMARY KEY IDENTITY,
	Name VARCHAR(50) NOT NULL,
);
CREATE TABLE Students
(
	StudentID INT PRIMARY KEY IDENTITY,
	StudentNumber INT NOT NULL,
	StudentName VARCHAR(50) NOT NULL,
	MajorID INT NOT NULL
	CONSTRAINT fk_students_majors
		FOREIGN KEY(MajorID)
		REFERENCES Majors(MajorID)
);
CREATE TABLE Subjects
(
	SubjectID INT PRIMARY KEY IDENTITY,
	SubjectName VARCHAR(50) NOT NULL
);
CREATE TABLE Agenda
(
	StudentID INT,
	SubjectID INT,
	CONSTRAINT pk_agenda
	PRIMARY KEY(StudentID,SubjectID),
	CONSTRAINT fk_agenda_students
		FOREIGN KEY(StudentID)
		REFERENCES Students(StudentID),
	CONSTRAINT fk_agenda_subjects
		FOREIGN KEY(SubjectID)
		REFERENCES Subjects(SubjectID)
);
CREATE TABLE Payments
(
	PaymentID INT PRIMARY KEY IDENTITY,
	PaymentDate DATETIME2 NOT NULL,
	PaymentAmount DECIMAL(15,2) NOT NULL,
	StudentID INT
	CONSTRAINT fk_payments_students
		FOREIGN KEY (StudentID)
		REFERENCES Students(StudentID)
);

--dzi
CREATE DATABASE Laptops;
USE Laptops;

CREATE TABLE Laptops
(
	ID INT PRIMARY KEY IDENTITY,
	Make VARCHAR(50) NOT NULL,
	Model VARCHAR(50) NOT NULL,
	[Count] INT NOT NULL,
	Price DECIMAL(10,2) NOT NULL
);
INSERT INTO Laptops(Make,Model,[Count],Price)
VALUES
	('Laptop1','L29KAS',10,1100),
	('Laptop2','15FDR7',14,1350),
	('Laptop1','L29GTA',12,1500),
	('Laptop1','L29DFT',8,1499),
	('Laptop2','15FDM5',11,1600);