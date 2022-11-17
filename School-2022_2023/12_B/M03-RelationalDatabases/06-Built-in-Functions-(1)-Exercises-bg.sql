--Problem 1.	�������� ����� �� ��������� �� ���
USE SoftUni;
SELECT FirstName,LastName
FROM Employees
WHERE FirstName LIKE 'SA%'
--Problem 2.	�������� ����� �� ��������� �� �������
SELECT FirstName,LastName
FROM Employees
WHERE LastName LIKE '%ei%'
--Problem 3.	�������� ������� �� ������ ���������
SELECT FirstName
FROM Employees
WHERE DepartmentID = 3 OR DepartmentID=10 AND DATEPART(YEAR,HireDate) >= '1995' AND DATEPART(YEAR,HireDate) <= '2005'
--Problem 4.	�������� ������ ��������� ��� ����������
SELECT FirstName,LastName
FROM Employees
WHERE JobTitle NOT LIKE '%engineer%'
--Problem 5.	�������� ������� � ��������� ������� �� �����
SELECT [Name]
FROM Towns
WHERE LEN([NAME]) = 5 OR  LEN([NAME]) = 6
ORDER BY [NAME]
--Problem 6.	 �������� �������, ��������� � �
SELECT [Name]
FROM Towns
WHERE [Name] LIKE 'M%' OR [Name] LIKE 'K%' OR [Name] LIKE 'B%' OR [Name] LIKE 'E%'
ORDER BY [NAME]
--Problem 7.	 �������� �������, ����� �� �������� � �
SELECT [Name]
FROM Towns
WHERE [Name] NOT LIKE 'R%' AND [Name] NOT LIKE 'B%' AND [Name] NOT LIKE 'D%'
ORDER BY [NAME]
--Problem 8.	�������� ������ Employees Hired After 2000 Year
CREATE VIEW V_EmployeesHiredAfter2000 
AS  
SELECT FirstName,LastName
FROM Employees
WHERE DATEPART(YEAR,HireDate) > '2000'
--Problem 9.	������� �� �������
SELECT FirstName,LastName
FROM Employees
WHERE LEN(LastName) = 5
--Problem 10.	��������� �� ��������� �� �������
SELECT EmployeeID,FirstName,LastName,Salary,
DENSE_RANK () OVER
(PARTITION BY Salary ORDER BY EmployeeID) AS Rank
FROM Employees
WHERE Salary >=10000 AND Salary<=50000
ORDER BY Salary DESC