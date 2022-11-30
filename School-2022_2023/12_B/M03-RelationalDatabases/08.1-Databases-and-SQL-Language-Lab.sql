--0.1 ��������� ������ ���������� �� �������� 
USE SoftUni;
SELECT * FROM Departments;
--0.2 ��������� ������ ����� �� ������������	 
SELECT [Name] FROM Departments;
--0.3 ������� �� ����� ��������
SELECT FirstName,LastName,Salary FROM Employees;
--0.4 ������ �������� ������� �� ��������� 
SELECT DISTINCT Salary FROM Employees;
--0.5 ����� �� ������ ��������� �� ������� � ����� �������� 
SELECT FirstName, LastName, JobTitle
FROM Employees
WHERE Salary BETWEEN 20000 AND 30000;
--0.6 ������ ��������� ��� �������� 
SELECT FirstName,LastName FROM Employees
WHERE ManagerID IS NULL
--0.7 ������ ��������� ��� ������� ������ �� 50000 
SELECT FirstName, LastName, Salary
FROM Employees
WHERE Salary > 50000
ORDER BY Salary DESC
--0.8 %-�� ��� � ����� ������� ��������� 
SELECT TOP(5) FirstName, LastName
FROM Employees
ORDER BY Salary DESC
--0.9 7-�� �������� ����� ��������� 
SELECT TOP(7) FirstName,LastName,HireDate
FROM Employees
ORDER BY HireDate DESC
--0.10 ���������� �� ������� 
UPDATE Employees
SET Salary = Salary*1.12
WHERE DepartmentID IN 
	(
		SELECT DepartmentID FROM Departments 
		WHERE Name IN ('Engineering', 'Tool Design','Marketing','Information Services')
	)
SELECT SALARY FROM Employees;
--0.11 ����� �� �������� 
SELECT e.EmployeeID,e.JobTitle,a.AddressID,a.AddressText FROM Employees AS e
JOIN Addresses AS a ON a.AddressID = e.AddressID
--0.12 ������ � ������� 
SELECT TOP(50) FirstName,LastName,t.Name AS 'Town',a.AddressText FROM Employees AS e
JOIN Addresses AS a ON a.AddressID = e.AddressID
JOIN Towns AS t ON t.TownID = a.TownID
ORDER BY FirstName ASC, LastName
--0.13 ��������� ����� ��������� 
SELECT EmployeeID,FirstName,LastName, d.Name AS 'DepartmentName'
FROM Employees AS e
JOIN Departments AS d ON d.DepartmentID=e.DepartmentID
WHERE d.Name = 'Sales'
--0.14 ������
SELECT TOP(5) EmployeeID,FirstName,Salary,d.Name AS 'DepartmentName'
FROM Employees AS e
JOIN Departments AS d ON d.DepartmentID=e.DepartmentID
WHERE Salary > 15000
ORDER BY D.DepartmentID ASC
--0.15 ��������� ��� ������� 
SELECT TOP(3) e.EmployeeID, e.FirstName
FROM Employees AS e 
WHERE e.EmployeeID NOT IN (SELECT DISTINCT EmployeeID FROM EmployeesProjects)
--0.16 ��������� ����� ���� ���������� ����
SELECT FirstName, LastName, HireDate, d.Name as 'DeptName' 
FROM Employees AS e
JOIN Departments AS d ON e.DepartmentID=d.DepartmentID
WHERE HireDate>'01.01.1999' AND e.DepartmentID IN 
	(
		SELECT DepartmentID FROM Departments 
		WHERE [Name] IN ('Sales', 'Finance')
	)
ORDER BY HireDate
--0.17 �������� ������ Highest Peak
USE Geography;
CREATE VIEW v_HighestPeak  AS 
SELECT TOP (1) * FROM Peaks
ORDER BY Elevation DESC
--0.18 ������� � ������� 
CREATE DATABASE School;
USE School;

CREATE TABLE Student
(
	StudentID INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(100) NOT NULL
);

CREATE TABLE Class
(
	ClassID INT PRIMARY KEY IDENTITY,
	Course VARCHAR(100) NOT NULL
);

CREATE TABLE StudentClassRelation
(
    StudentID INT NOT NULL,
	ClassID INT NOT NULL,
	CONSTRAINT pk_studentclassrelation
		PRIMARY KEY (StudentID,ClassID),
	CONSTRAINT fk_studentclassrelation_class
		FOREIGN KEY (ClassID)
		REFERENCES Class(ClassID),
	CONSTRAINT fk_studentclassrelation_Student
		FOREIGN KEY (StudentID)
		REFERENCES Student(StudentID)
);

INSERT INTO Student ([Name])
VALUES
	('Olaf Alfonso'),
	('Clark Davis');

INSERT INTO Class(Course)
VALUES
	('Biology'),
	('Chemistry'),
	('Physics'),
	('English'),
	('Computer Science'),
	('History');
INSERT INTO StudentClassRelation(StudentID,ClassID)
VALUES
	(1,2),
	(1,4),
	(1,6),
	(2,1),
	(2,3),
	(2,6);

SELECT s.[Name], c.Course FROM Student AS s
JOIN StudentClassRelation AS scr ON s.StudentID=scr.StudentID
JOIN Class AS c ON c.ClassID=scr.ClassID

--