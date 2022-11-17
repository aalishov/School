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

--Problem 5.	 Таблица поръчки

SELECT DATEADD(DAY,3,'1-1-2022')
