USE Diablo;
-- Problem 1.	Игри от 2011 и 2012 година
SELECT TOP(50) [Name], FORMAT([Start],'yyyy-MM-dd') AS [Start]
FROM Games
WHERE DATEPART(YEAR,[Start]) BETWEEN 2011 AND 2012 
ORDER BY [START], [Name]
--Problem 2. Доставчици на електронна поща
SELECT Username, SUBSTRING(Email,CHARINDEX('@',Email)+1,LEN(Email)-CHARINDEX('@',Email)) AS 'Email Provider'
FROM Users
ORDER BY [Email Provider] ASC ,Username

SELECT Username, Right(Email,LEN(Email)-CHARINDEX('@',Email)) AS 'Email Provider'
FROM Users
ORDER BY [Email Provider] ASC ,Username

--nakov@softuni.bg
SELECT *
FROM Users
--Problem 3. Извличане на потребители по IPAdress като …
SELECT Username, IpAddress
FROM Users
WHERE IpAddress LIKE '___.1%.%.___'
ORDER BY Username ASC
--Problem 4. Покажете всички игри с продължителност и част от деня
SELECT [Name] AS 'Game',
	CASE 
		WHEN DATEPART(HOUR,[Start]) BETWEEN 0 AND 11 THEN 'Morning'
		WHEN DATEPART(HOUR,[Start]) BETWEEN 12 AND 17 THEN 'Afternoon'	
		ELSE'Evening' 
	END AS 'Part of the Day',
	CASE
		WHEN Duration <= 3 THEN 'Extra Short'
		WHEN Duration BETWEEN 4 AND 6 THEN 'Short'
		WHEN Duration > 6 THEN 'Long'
		ELSE 'Extra Long'
	END AS 'Duration'
FROM Games
ORDER BY [Game] , [Duration]

--Problem 5. Таблица поръчки

SELECT ProductName, OrderDate,  DATEADD(DAY,3,OrderDate) AS 'Pay Due' , DATEADD(MONTH,1,OrderDate) AS 'Deliver Due'
FROM Orders
--Problem 6. Таблица Хора
CREATE DATABASE PPL;
USE PPL;

CREATE TABLE People
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL,
	Birthdate DATETIME2 NOT NULL
);

INSERT INTO People ([Name],Birthdate) 
VALUES
	('Victor','2000-12-07 00:00:00.000'),
	('Steven','1992-09-10 00:00:00.000'),
	('Stephen','1910-09-19 00:00:00.000'),
	('John','2010-01-06 00:00:00.000');

SELECT [Name], 
	DATEDIFF(YEAR,Birthdate,GETDATE()) AS 'Age in Years', 
	DATEDIFF(MONTH,Birthdate,GETDATE()) AS 'Age in Months', 
	DATEDIFF(DAY,Birthdate,GETDATE()) AS 'Age in Days', 
	DATEDIFF(MINUTE,Birthdate,GETDATE()) AS 'Age in Minutes' 
FROM People;
