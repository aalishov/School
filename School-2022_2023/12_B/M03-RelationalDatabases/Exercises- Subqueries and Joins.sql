USE SoftUni
--1.	Employee Address
SELECT TOP (5) EmployeeID, JobTitle, a.AddressID, a.AddressText
FROM Employees AS e
JOIN Addresses AS a ON e.AddressID=a.AddressID
ORDER BY AddressID ASC
--2.	Addresses with Towns
SELECT TOP (50) FirstName, LastName, t.[Name] as Town, a.AddressText
FROM Employees AS e
JOIN Addresses AS a ON e.AddressID=a.AddressID
JOIN Towns AS t ON t.TownID=a.TownID
ORDER BY FirstName ASC, LastName