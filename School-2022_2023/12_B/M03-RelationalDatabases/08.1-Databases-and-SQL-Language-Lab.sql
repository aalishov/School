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
JOIN EmployeesProjects AS ep ON ep.EmployeeID=e.EmployeeID
JOIN Projects AS p ON p.ProjectID=ep.ProjectID
WHERE 
