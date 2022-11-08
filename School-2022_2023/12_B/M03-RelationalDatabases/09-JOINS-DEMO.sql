USE SoftUni;

SELECT FirstName,LastName,a.AddressText,t.Name
FROM Employees AS e 
JOIN Addresses AS a ON a.AddressID=e.AddressID
JOIN Towns AS t ON t.TownID=a.TownID;


INSERT INTO Employees 
(FirstName, LastName, JobTitle,DepartmentId,ManagerID,HireDate,Salary)
VALUES
('Jae','Pak','Sales',3,273,'3-11-2022',5000)

INSERT INTO Addresses(AddressText,TownID)
VALUES
('1-Address',5),
('2-Address',5),
('3-Address',5);


SELECT FirstName, LastName,a.AddressText
FROM Employees AS e
JOIN Addresses AS a ON a.AddressID=e.AddressID

SELECT * FROM Employees

SELECT FirstName, LastName,a.AddressText
FROM Employees AS e
LEFT JOIN Addresses AS a ON a.AddressID=e.AddressID

SELECT FirstName, LastName,a.AddressText
FROM Employees AS e
RIGHT JOIN Addresses AS a ON a.AddressID=e.AddressID

SELECT FirstName, LastName,a.AddressText
FROM Employees AS e
FULL JOIN Addresses AS a ON a.AddressID=e.AddressID

SELECT FirstName, LastName,a.AddressText
FROM Employees AS e
CROSS JOIN Addresses AS a