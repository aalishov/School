CREATE DATABASE Service;
USE Service;
CREATE TABLE Users
(
	Id INT PRIMARY KEY IDENTITY,
	Username VARCHAR(30) NOT NULL UNIQUE,
	Password VARCHAR(50) NOT NULL,
	Name VARCHAR(30),
	Birthdate DATETIME2,
	Age INT CHECK(Age between 14 and 110),
	Email VARCHAR(50) NOT NULL
);

CREATE TABLE Departments
(
	Id INT PRIMARY KEY IDENTITY,
	Name VARCHAR(50) NOT NULL
);

CREATE TABLE Employees
(
	Id INT PRIMARY KEY IDENTITY,
	FirstName VARCHAR(25),
	LastName VARCHAR(25),
	Birthdate DATETIME2,
	Age INT CHECK(Age BETWEEN 18 AND 110),
	DepartmentId INT,
	CONSTRAINT fk_employees_departments
		FOREIGN KEY(DepartmentId)
		REFERENCES Departments(Id)
);

CREATE TABLE Categories
(
	Id INT PRIMARY KEY IDENTITY,
	Name VARCHAR(50) NOT NULL,
	DepartmentId INT NOT NULL,
	CONSTRAINT fk_categories_departments
		FOREIGN KEY(DepartmentId)
		REFERENCES Departments(Id)
);

CREATE TABLE Status
(
	Id INT PRIMARY KEY IDENTITY,
	Label VARCHAR(20) NOT NULL
);

CREATE TABLE Reports
(
	Id INT PRIMARY KEY IDENTITY,
	CategoryId INT NOT NULL,
	StatusId INT NOT NULL,
	OpenDate DATETIME2 NOT NULL,
	CloseDate DATETIME2,
	Description VARCHAR(200) NOT NULL,
	UserId INT NOT NULL,
	EmployeeId INT,
	CONSTRAINT fk_categories_reports
		FOREIGN KEY(CategoryId)
		REFERENCES Categories(Id),
	CONSTRAINT fk_status_reports
		FOREIGN KEY(StatusId)
		REFERENCES Status(Id),
	CONSTRAINT fk_users_reporst
		FOREIGN KEY(UserId)
		REFERENCES Users(Id),
	CONSTRAINT fk_employees_reports
		FOREIGN KEY(EmployeeId)
		REFERENCES Employees(Id)
);
--2.Insert

INSERT INTO Employees(FirstName,LastName,Birthdate,DepartmentId)
VALUES 
		('Marlo',	'O ''Malley',	'1958-9-21',	1),
		('Niki',	'Stanaghan',	'1969-11-26',	4),
		('Ayrton',	'Senna',	'1960-03-21',	9),
		('Ronnie',	'Peterson',	'1944-02-14',	9),
		('Giovanna',	'Amati',	'1959-07-20',	5)	

INSERT INTO Reports(CategoryId,StatusId,OpenDate,CloseDate,Description,UserId,EmployeeId)
VALUES
		(1,1,'2017-04-13',NULL,'Stuck Road on Str.133',6,2),
		(6,3,'2015-09-05','2015-12-06','Charity trail running',3,5),
		(14,2,'2015-09-07',NULL,'Falling bricks on Str.58',5,2),
		(4,3,'2017-07-03','2017-07-06','Cut off streetlight on Str.11',1,1)

--3.Update
UPDATE Reports
SET CloseDate = GETDATE()
WHERE CloseDate IS NULL

--4.Delete
DELETE Reports
WHERE StatusId=4;

--5.Unassigned Reports
SELECT Description,FORMAT(OpenDate,'dd-MM-yyyy') AS 'OpenDate'
FROM Reports AS r
WHERE EmployeeId IS NULL
ORDER BY r.OpenDate ASC,Description ASC

--6.Reports & Categories
SELECT Description, c.Name
FROM Reports AS r
JOIN Categories AS c ON c.id=r.CategoryId
WHERE CategoryId IS NOT NULL
ORDER BY Description ASC, c.Name ASC
--7. Most reported category
SELECT TOP(5) Name,COUNT(r.CategoryId) as ReportsNumber 
FROM Categories as c
JOIN Reports as r ON r.CategoryId = c.Id
group by c.Name,c.Id
order by COUNT(r.CategoryId) desc,c.Name asc

--8. Birthday Report
SELECT  u.Username,  c.Name as 'Category Name'
FROM Reports AS r
JOIN Users AS u ON r.UserId=u.Id
JOIN Categories AS c ON r.CategoryId=c.Id
WHERE DATEPART(day,r.OpenDate) =DATEPART(day,u.Birthdate) and
DATEPART(MONTH,r.OpenDate)=Datepart(month,u.Birthdate)
order by Username asc, c.Name asc


