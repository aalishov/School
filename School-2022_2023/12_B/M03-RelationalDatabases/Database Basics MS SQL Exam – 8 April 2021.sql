CREATE DATABASE Services;
USE Services;

CREATE TABLE Users
(
	Id INT PRIMARY KEY IDENTITY,
	Username VARCHAR(30) Unique NOT NULL,
	Password VARCHAR(50) NOT NULL,
	Name VARCHAR(50),
	Birthdate DATETIME2,
	Age INT CHECK (Age BETWEEN 14 AND 110),
	Email VARCHAR(50) NOT NULL
);

CREATE TABLE Departments
(
	Id INT PRIMARY KEY IDENTITY,
	Name VARCHAR(50) NOT NULL,
);

CREATE TABLE Employees
(
	Id INT PRIMARY KEY IDENTITY,
	FirstName VARCHAR(25),
	LastName VARCHAR(25),
	Birthdate DATETIME2,
	Age INT CHECK (Age BETWEEN 18 AND 110),
	DepartmentId INT
	CONSTRAINT fk_employees_departments
	FOREIGN KEY (DepartmentId)
	REFERENCES Departments(Id)
);

CREATE TABLE Categories
(
	Id INT PRIMARY KEY IDENTITY,
	Name VARCHAR(50) NOT NULL,
	DepartmentId INT NOT NULL
	CONSTRAINT fk_categories_departments
	FOREIGN KEY (DepartmentId)
	REFERENCES Departments(Id)
);

CREATE TABLE Status
(
	Id INT PRIMARY KEY IDENTITY,
	Label VARCHAR(30) NOT NULL,
);

CREATE TABLE Reports
(
	Id INT PRIMARY KEY IDENTITY,
	CategoryId INT NOT NULL,
	StatusId INT,
	OpenDate DATETIME2 NOT NULL,
	CloseDate DATETIME2,
	Description VARCHAR(200) NOT NULL,
	UserId INT NOT NULL,
	EmployeeId INT
	CONSTRAINT fk_reports_categories
		FOREIGN KEY (CategoryId)
		REFERENCES Categories(Id),
	CONSTRAINT fk_reports_status
		FOREIGN KEY (StatusId)
		REFERENCES Status(Id),
	CONSTRAINT fk_reports_users
		FOREIGN KEY (UserId)
		REFERENCES Users(Id),
	CONSTRAINT fk_reports_employees
		FOREIGN KEY (EmployeeId)
		REFERENCES Employees(Id)
);

--2.Insert
INSERT INTO Employees(FirstName,LastName,Birthdate, DepartmentId) VALUES 
('Marlo', 'O''Malley', '1958-9-21', 1), 
( 'Niki', 'Stanaghan', '1969-11-26', 4), 
( 'Ayrton', 'Senna', '1960-03-21', 9), 
( 'Ronnie', 'Peterson', '1944-02-14', 9), 
( 'Giovanna', 'Amati', '1959-07-20', 5);

INSERT INTO Reports(CategoryId,StatusId, OpenDate, CloseDate,Description,UserId, EmployeeId) VALUES
(1, 1, '2017-04-13', NULL, 'Stuck Road on Str.133', 6, 2),
(6, 3, '2015-09-05', '2015-12-06', 'Charity trail running', 3, 5),
(14, 2, '2015-09-07', NULL, 'Falling bricks on Str.58', 5, 2),
(4, 3, '2017-07-03','2017-07-06', 'Cut off streetlight on Str.11', 1, 1);

--3.Update
UPDATE Reports SET CloseDate = GETDATE() 
WHERE CloseDate IS NULL;

--4.Delete
DELETE Reports 
WHERE StatusId=4;

--5.Unassigned Reports
SELECT Description,FORMAT(OpenDate,'dd-MM-yyyy') AS 'OpenDate' 
FROM Reports AS r
WHERE EmployeeId IS NULL
ORDER BY r.OpenDate ASC,  Description ASC;

--6.Reports & Categories
SELECT Description,c.Name AS CategoryName FROM Reports AS r
JOIN Categories AS c ON c.Id=r.CategoryId
ORDER BY Description ASC, c.Name ASC;

--7.Most Reported Category
SELECT TOP 5 c.Name as CategoryName,COUNT(CategoryId) AS ReportsNumber FROM Reports AS r
JOIN Categories AS c ON c.Id=r.CategoryId
GROUP BY c.Name
ORDER BY ReportsNumber DESC, CategoryName ASC

--8.Birthday Report
SELECT Username, c.Name AS CategoryName FROM Users AS u
JOIN Reports AS r ON r.UserId=u.Id
JOIN Categories AS c ON c.Id=r.CategoryId
WHERE DATEPART(MONTH,r.OpenDate) =DATEPART(MONTH,U.Birthdate) AND DATEPART(DAY,r.OpenDate) =DATEPART(DAY,U.Birthdate)
ORDER BY Username ASC, CategoryName ASC

--9.Users per Employee
SELECT CONCAT(FirstName,' ',LastName) AS FullName,COUNT(UserId) AS UsersCount FROM REPORTS AS r
JOIN Employees AS e ON r.EmployeeId=e.Id
GROUP BY CONCAT(FirstName,' ',LastName)
ORDER BY UsersCount DESC, FullName ASC

--10.Full Info
SELECT CONCAT(FirstName,' ',LastName) AS Employee, d.Name AS Department,c.Name AS Category,
	Description, FORMAT(OpenDate,'dd.MM.yyyy') AS OpenDate, s.Label AS Status,
	CASE 
		WHEN u.Name IS NULL THEN 'None'
		ELSE u.Name 
	END AS 'User' 
FROM Reports AS r
JOIN Employees AS e ON e.Id=r.EmployeeId
JOIN Departments AS d ON d.Id=e.DepartmentId
JOIN Categories AS c ON c.Id=r.CategoryId
JOIN Status AS s ON s.Id=r.StatusId
JOIN Users AS u ON u.Id=r.UserId
ORDER BY FirstName DESC;
