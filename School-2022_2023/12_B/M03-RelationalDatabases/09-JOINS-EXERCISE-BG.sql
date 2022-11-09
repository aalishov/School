--1.	Адрес на служител
SELECT TOP(5) EmployeeId, JobTitle, e.AddressId, a.AddressText
FROM Employees AS e
JOIN Addresses as a ON a.AddressID=e.AddressID
ORDER BY e.AddressID ASC;
--2.	Отдели
SELECT TOP(5) EmployeeID,FirstName,Salary, d.Name
FROM Employees AS e
JOIN Departments AS d ON d.DepartmentID=e.DepartmentID
WHERE Salary>15000
ORDER BY d.DepartmentID ASC
--3.	Служители без проекти
SELECT TOP(3) e.EmployeeID,FirstName
FROM Employees AS e
LEFT JOIN EmployeesProjects AS ep ON ep.EmployeeID=e.EmployeeID
WHERE ProjectID IS NULL
--3.	Служители без проекти вариант 2
SELECT TOP(3) EmployeeID, FirstName FROM Employees
WHERE EmployeeID NOT IN(SELECT EmployeeID FROM EmployeesProjects)
--4.	Служители с проекти
SELECT TOP(5) e.EmployeeID,FirstName, p.Name
FROM Employees AS e
JOIN EmployeesProjects AS ep ON ep.EmployeeID=e.EmployeeID
JOIN Projects AS p ON p.ProjectID = ep.ProjectID
WHERE p.StartDate>'08-13-2002' AND p.EndDate IS NULL
ORDER BY e.EmployeeID ASC
--5.	Служител 24
SELECT e.EmployeeID, e.FirstName,
	CASE WHEN p.StartDate>='01-01-2005'THEN NULL 
	ELSE p.[Name]
	END AS 'ProjectName'
FROM Employees AS e
JOIN EmployeesProjects AS ep ON ep.EmployeeID=e.EmployeeID
JOIN Projects AS p ON p.ProjectID= ep.ProjectID
WHERE e.EmployeeID=24
--6.	Мениджър на служител
SELECT e.EmployeeID,e.FirstName,e.ManagerID,em.FirstName
FROM Employees AS e
JOIN Employees AS em on e.ManagerID = em.EmployeeID
WHERE e.ManagerID=3 OR e.ManagerID=7
ORDER BY EmployeeID ASC

--7.	Най – високите върхове в България
USE Geography;

SELECT mc.CountryCode,m.MountainRange,p.PeakName,p.Elevation 
FROM Peaks AS p
JOIN Mountains AS m ON m.Id=p.MountainId
JOIN MountainsCountries AS mc ON mc.MountainId=m.Id
WHERE Elevation>2835 AND mc.CountryCode='BG'
ORDER BY Elevation DESC
--8.	Брой планини
SELECT mc.CountryCode, COUNT (*) AS 'MountainRanges'
FROM Mountains AS m
JOIN MountainsCountries AS mc ON mc.MountainId=m.Id
WHERE mc.CountryCode='BG' OR mc.CountryCode='RU' OR  mc.CountryCode='US'
GROUP BY mc.CountryCode
--9.	Държави с реки
SELECT TOP (5) c.CountryName,r.RiverName
FROM Countries AS c
LEFT JOIN  CountriesRivers AS cr ON cr.CountryCode = c.CountryCode
LEFT JOIN  Rivers AS r ON cr.RiverId=r.Id
WHERE C.ContinentCode='AF'
ORDER BY C.CountryName ASC

