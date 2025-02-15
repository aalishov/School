USE SoftUni
--2.Find All Information About Departments
SELECT * FROM Departments;
--3.Find all Department Names
SELECT [Name] FROM Departments;
--4.Find Salary of Each Employee
SELECT FirstName,LastName,Salary FROM Employees;
--5.Find Full Name of Each Employee
SELECT FirstName,MiddleName,LastName FROM Employees;
--6.Find Email Address of Each Employee
SELECT FirstName + '.' + LastName + '@softuni.bg' 
	AS 'Full Email Address'
FROM Employees;
--7.Find All Different Employee�s Salaries
SELECT DISTINCT Salary FROM Employees;
--8.Find all Information About Employees
SELECT *  FROM Employees 
WHERE JobTitle = 'Sales Representative';
--9.Find Names of All Employees by Salary in Range
SELECT FirstName, LastName, JobTitle
FROM Employees
WHERE Salary BETWEEN 20000 AND 30000;
--9.Find Names of All Employees by Salary in Range
SELECT FirstName, LastName, JobTitle
FROM Employees
WHERE Salary >= 20000 AND Salary <= 30000;
--10.Find Names of All Employees 
SELECT CONCAT_WS(' ',FirstName,MiddleName,LastName)  AS 'Full Name'
FROM Employees
WHERE Salary IN(25000,14000,12500,23600);
--11.Find All Employees Without Manager
SELECT FirstName,LastName
FROM Employees
WHERE ManagerID IS NULL;
--12.Find All Employees with Salary More Than 50000
SELECT FirstName,LastName, Salary
FROM Employees
WHERE Salary > 50000
ORDER BY Salary DESC;
--13.Find 5 Best Paid Employees.
SELECT TOP 5 FirstName,LastName
FROM Employees
ORDER BY Salary DESC;
--14.Find All Employees Except Marketing
SELECT FirstName,LastName
FROM Employees
WHERE NOT (DepartmentID = 4);
--15.Sort Employees Table
SELECT * FROM Employees
ORDER BY Salary DESC, FirstName ASC, LastName DESC, MiddleName ASC;
--16.Create View Employees with Salaries
CREATE VIEW V_EmployeesSalaries AS
SELECT FirstName, LastName, Salary
FROM Employees;
SELECT * FROM V_EmployeesSalaries
--17.Create View Employees with Job Titles
CREATE VIEW V_EmployeeNameJobTitle AS
SELECT
	CASE WHEN MiddleName IS NULL THEN FirstName+'  '+ LastName
	ELSE FirstName+' '+MiddleName+' '+ LastName
	END AS 'Full Name', JobTitle
FROM Employees;
--18.Distinct Job Titles
SELECT DISTINCT JobTitle FROM Employees;
--19.Find First 10 Started Projects
SELECT TOP 10 * FROM Projects
ORDER BY StartDate, [Name];
--20.Last 7 Hired Employees
SELECT TOP 7 FirstName, LastName, HireDate
FROM Employees
ORDER BY HireDate DESC;

--Part II � Queries for Geography Database
USE Geography
--21.All Mountain Peaks
SELECT PeakName FROM Peaks
ORDER BY PeakName ASC;
--22.Biggest Countries by Population

SELECT TOP 30 CountryName, [Population] 
FROM Countries
WHERE ContinentCode = 
	(
		SELECT ContinentCode FROM Continents
		WHERE ContinentName = 'Europe'
	)
ORDER BY [Population] DESC, CountryName ASC;
--23.*Countries and Currency (Euro / Not Euro)

SELECT CountryName, CountryCode, 
	CASE 
		WHEN CurrencyCode = 'EUR'THEN 'Euro'
		ELSE 'Not Euro'
	END AS Currency
FROM Countries
ORDER BY CountryName;
--Part III � Queries for Diablo Database
USE Diablo
--24.All Diablo Characters
SELECT [Name] FROM Characters
ORDER BY [Name] ASC;