USE Gringotts;
SELECT * FROM WizzardDeposits

SELECT COUNT(*) AS 'Count' 
FROM WizzardDeposits AS wd

SELECT MAX(MagicWandSize) AS 'LongestMagicWand'
FROM WizzardDeposits AS wd

SELECT wd.DepositGroup, MAX(MagicWandSize) AS 'LongestMagicWand'
FROM WizzardDeposits AS wd
GROUP BY wd.DepositGroup

SELECT TOP(2) wd.DepositGroup
FROM WizzardDeposits AS wd
GROUP BY wd.DepositGroup
ORDER BY AVG(wd.MagicWandSize) 

SELECT wd.DepositGroup, SUM(wd.DepositAmount) AS 'TotalSum'
FROM WizzardDeposits AS wd
GROUP BY wd.DepositGroup

SELECT wd.DepositGroup, SUM(wd.DepositAmount) AS 'TotalSum'
FROM WizzardDeposits AS wd
WHERE wd.MagicWandCreator = 'Ollivander family'
GROUP BY wd.DepositGroup

SELECT wd.DepositGroup, SUM(wd.DepositAmount) AS 'TotalSum'
FROM WizzardDeposits AS wd
WHERE wd.MagicWandCreator = 'Ollivander family'
GROUP BY wd.DepositGroup
HAVING SUM(wd.DepositAmount) < 150000
ORDER BY SUM(wd.DepositAmount) DESC

SELECT wd.DepositGroup, wd.MagicWandCreator, MIN(wd.DepositCharge) AS 'MinDepositCharge'
FROM WizzardDeposits AS wd
GROUP BY wd.DepositGroup, wd.MagicWandCreator
ORDER BY wd.MagicWandCreator, wd.DepositGroup


-- 9.	Age Groups
SELECT 
    CASE
        WHEN wd.Age BETWEEN 0 AND 10 THEN '[0-10]'
        WHEN wd.Age BETWEEN 11 AND 20 THEN '[11-20]'
        WHEN wd.Age BETWEEN 21 AND 30 THEN '[21-30]'
        WHEN wd.Age BETWEEN 31 AND 40 THEN '[31-40]'
        WHEN wd.Age BETWEEN 41 AND 50 THEN '[41-50]'
        WHEN wd.Age BETWEEN 51 AND 60 THEN '[51-60]'
        ELSE '[61+]'
    END AS age_group,
    COUNT(*) AS WizardCount
FROM
    WizzardDeposits AS wd
GROUP BY
	CASE
        WHEN wd.Age BETWEEN 0 AND 10 THEN '[0-10]'
        WHEN wd.Age BETWEEN 11 AND 20 THEN '[11-20]'
        WHEN wd.Age BETWEEN 21 AND 30 THEN '[21-30]'
        WHEN wd.Age BETWEEN 31 AND 40 THEN '[31-40]'
        WHEN wd.Age BETWEEN 41 AND 50 THEN '[41-50]'
        WHEN wd.Age BETWEEN 51 AND 60 THEN '[51-60]'
        ELSE '[61+]'
		END
--10.	First Letter
SELECT LEFT (FirstName,1) AS 'FirstLetter' 
FROM WizzardDeposits
WHERE DepositGroup = 'Troll Chest'
GROUP BY LEFT (FirstName,1)
ORDER BY LEFT (FirstName,1)
--11.	Average Interest 
SELECT DepositGroup,IsDepositExpired,AVG(DepositInterest) AS 'AverageInterest' FROM WizzardDeposits
WHERE DepositStartDate > '1985-01-01'
GROUP BY DepositGroup, IsDepositExpired
ORDER BY DepositGroup DESC, IsDepositExpired
--12.	* Rich Wizard, Poor Wizard
SELECT * FROM WizzardDeposits

SELECT SUM(DepositAmount) FROM WizzardDeposits
WHERE ID % 2 = 0

SELECT SUM(DepositAmount) FROM WizzardDeposits
WHERE ID % 2 = 1

SELECT ((SELECT SUM(DepositAmount) FROM WizzardDeposits WHERE ID % 2 = 0 AND ID < 162 )-(SELECT SUM(DepositAmount) FROM WizzardDeposits
WHERE ID % 2 = 1))
--13.	Departments Total Salaries
USE SoftUni;
SELECT DepartmentID, SUM(E.Salary) AS 'TotalSalary'
FROM Employees AS E
GROUP BY DepartmentID
--14.	Employees Minimum Salaries
SELECT * FROM Employees
SELECT DepartmentID, MIN(E.Salary) AS 'MinimumSalary'
FROM Employees AS E
WHERE DepartmentID IN(2,5,7) AND DATEPART(YEAR,HireDate) > 1999
GROUP BY DepartmentID
--15.	Employees Average Salaries

--16.	Employees Maximum Salaries
SELECT DepartmentID, MAX(Salary) AS 'MaxSalary'
FROM Employees 
GROUP BY DepartmentID
HAVING MAX(Salary)< 30000 OR MAX(Salary)> 70000
--17.	Employees Count Salaries
SELECT  COUNT(Salary) AS 'Count'
FROM Employees 
WHERE ManagerID IS NULL
--18.	*3rd Highest Salary




