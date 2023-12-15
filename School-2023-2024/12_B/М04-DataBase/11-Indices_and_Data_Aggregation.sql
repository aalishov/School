--1 Records’ Count
SELECT COUNT(*) FROM WizzardDeposits

--2 Longest Magic Wand
SELECT  TOP(1) MagicWandSize AS 'LongestMagicWand'
FROM WizzardDeposits
ORDER BY MagicWandSize DESC

SELECT MAX(MagicWandSize) AS 'LongestMagicWand' 
FROM WizzardDeposits

--3.	Longest Magic Wand Per Deposit Groups
SELECT DepositGroup,Max(MagicWandSize) AS 'LongestMagicWand' 
FROM WizzardDeposits
GROUP BY DepositGroup
ORDER BY LongestMagicWand DESC
--4.	* Smallest Deposit Group Per Magic Wand Size
SELECT TOP(2) DepositGroup 
FROM WizzardDeposits
GROUP BY (DepositGroup)
ORDER BY AVG(MagicWandSize) asc
--5
SELECT DepositGroup,SUM(DepositAmount) AS 'TotalSum'
FROM WizzardDeposits
GROUP BY (DepositGroup)
--6
SELECT DepositGroup,SUM(DepositAmount) AS 'TotalSum'
FROM WizzardDeposits
WHERE MagicWandCreator='Ollivander family'
GROUP BY (DepositGroup)

--7
SELECT DepositGroup,SUM(DepositAmount) AS 'TotalSum'
FROM WizzardDeposits
WHERE MagicWandCreator='Ollivander family' 
GROUP BY (DepositGroup)
HAVING SUM(DepositAmount)<=150000
ORDER BY SUM(DepositAmount) DESC

--8
SELECT DepositGroup,MagicWandCreator,MIN(DepositCharge) AS 'MinDepositChange' 
FROM WizzardDeposits
GROUP BY DepositGroup,MagicWandCreator

ORDER BY MagicWandCreator ASC
,DepositGroup ASC
--9
SELECT 
CASE 
	WHEN Age BETWEEN 0 AND 10 THEN '[0-10]' 
	WHEN AGE BETWEEN 11 AND 20 THEN '[11-20]'
	WHEN AGE BETWEEN 21 AND 30 THEN '[21-30]'
	WHEN AGE BETWEEN 31 AND 40 THEN '[31-40]'
	WHEN AGE BETWEEN 41 AND 50 THEN '[41-50]'
	WHEN AGE BETWEEN 51 AND 60 THEN '[51-60]'
	WHEN AGE >=61 THEN '[61+]' 
END AS 'AgeGroup' , COUNT(*) AS 'WizardCount'
FROM WizzardDeposits
GROUP BY 
CASE 
	WHEN Age BETWEEN 0 AND 10 THEN '[0-10]' 
	WHEN AGE BETWEEN 11 AND 20 THEN '[11-20]'
	WHEN AGE BETWEEN 21 AND 30 THEN '[21-30]'
	WHEN AGE BETWEEN 31 AND 40 THEN '[31-40]'
	WHEN AGE BETWEEN 41 AND 50 THEN '[41-50]'
	WHEN AGE BETWEEN 51 AND 60 THEN '[51-60]'
	WHEN AGE >=61 THEN '[61+]' 
END

--10
SELECT LEFT(FirstName,1) FROM WizzardDeposits
WHERE DepositGroup = 'Troll Chest' 
GROUP BY LEFT(FirstName,1)

--11
SELECT DepositGroup, IsDepositExpired,AVG(DepositInterest) AS 'AverageInterest'
FROM WizzardDeposits
WHERE DepositStartDate >= '1985-01-01'
GROUP BY DepositGroup, IsDepositExpired
ORDER BY DepositGroup desc, IsDepositExpired asc








