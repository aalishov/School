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
