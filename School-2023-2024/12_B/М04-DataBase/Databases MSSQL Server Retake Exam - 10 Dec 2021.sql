CREATE DATABASE Airport;
USE Airport

CREATE TABLE Passengers
(
	Id INT PRIMARY KEY IDENTITY,
	FullName VARCHAR(100)UNIQUE NOT NULL,
	Email VARCHAR(50) UNIQUE NOT NULL
);
CREATE TABLE Pilots
(
	Id INT PRIMARY KEY IDENTITY,
	FirstName VARCHAR(30) UNIQUE NOT NULL,
	LastName VARCHAR(30) UNIQUE NOT NULL,
	Age TINYINT NOT NULL CHECK(Age Between 21 and 62),
	Rating FLOAT CHECK(Rating between 0.00 AND 10.0)

);
CREATE TABLE AircraftTypes
(
	Id INT PRIMARY KEY IDENTITY,
	TypeName VARCHAR(30) UNIQUE NOT NULL
);
CREATE TABLE Aircraft
(
	Id INT PRIMARY KEY IDENTITY,
	Manufacturer VARCHAR(25) NOT NULL,
	Model VARCHAR(30) NOT NULL,
	Year INT NOT NULL,
	FlightHours INT,
	Condition CHAR NOT NULL,
	TypeId INT NOT NULL,
	CONSTRAINT fk_Aircraft_AircraftTypes
	FOREIGN KEY(TypeId)
	REFERENCES AircraftTypes(Id)
);
CREATE TABLE PilotsAircraft
(
	AircraftId INT NOT NULL,
	PilotId INT NOT NULL,
	CONSTRAINT pk_AircraftId_PilotId
		PRIMARY KEY(AircraftId,PilotId),
	CONSTRAINT fk_PilotsAircraft_Aircraft
		FOREIGN KEY (AircraftId)
		REFERENCES Aircraft(Id),
	CONSTRAINT fk_PilotsAircraft_Pilots
		FOREIGN KEY (PilotId)
		REFERENCES Pilots(Id)
);
CREATE TABLE Airports
(
	Id INT PRIMARY KEY IDENTITY,
	AirportName VARCHAR(70) UNIQUE NOT NULL,
	Country VARCHAR(100) UNIQUE NOT NULL
);
CREATE TABLE FlightDestinations
(
	Id INT PRIMARY KEY IDENTITY,
	AirportId INT NOT NULL,
	Start DATETIME NOT NULL,
	AircraftId INT NOT NULL,
	PassengerId INT NOT NULL,
	TicketPrice DECIMAL(18,2) NOT NULL DEFAULT 15
	CONSTRAINT fk_FlightDestinations_Aircraft
		FOREIGN KEY (AircraftId)
		REFERENCES Aircraft(Id),
	CONSTRAINT fk_FlightDestinations_Airports
		FOREIGN KEY (AirportId)
		REFERENCES Airports(Id),
	CONSTRAINT fk_FlightDestinations_Passengers
		FOREIGN KEY (PassengerId)
		REFERENCES Passengers(Id)
);
--Insert
INSERT INTO Passengers(FullName,Email)
SELECT CONCAT(FirstName,' ',LastName) AS FullName, CONCAT(FirstName,LastName,'@gmail.com') AS 'Email'
FROM Pilots
WHERE Id BETWEEN 5 AND 15

--Update
UPDATE Aircraft
SET Condition = 'A'
WHERE Condition IN ('C' ,'B') AND (FlightHours IS NULL OR FlightHours<=100) AND Year>=2013

--Delete
DELETE FROM FlightDestinations
WHERE PassengerId in(Select Id from Passengers WHERE LEN(FullName)<=10 )

Delete FROM Passengers
WHERE LEN(FullName)<=10

--5
SELECT Manufacturer,Model,FlightHours,Condition FROM Aircraft
ORDER BY FlightHours DESC

--6
SELECT p.FirstName,p.LastName,a.Manufacturer,a.Model,a.FlightHours FROM Pilots AS p
JOIN PilotsAircraft AS pa ON p.Id=pa.PilotId
JOIN Aircraft AS a on a.Id=pa.AircraftId
WHERE FlightHours<304
ORDER BY a.FlightHours DESC,p.FirstName ASC

--7
SELECT TOP(20) fd.id,fd.Start,p.FullName,a.AirportName,fd.TicketPrice FROM FlightDestinations as fd
JOIN Passengers AS p ON fd.PassengerId=p.Id
JOIN Airports AS a ON a.Id=fd.AirportId
WHERE DAY(fd.Start) IN (02,04,06,08,10,12,14,16,18,20,22,24,26,28,30) 
ORDER BY fd.TicketPrice DESC,a.AirportName ASC

--8
SELECT a.Id,a.Manufacturer,a.FlightHours,COUNT(*) AS 'FlightDestinationsCount',	ROUND(AVG(fd.TicketPrice),2) AS 'AvgPrice'
FROM Aircraft AS a
JOIN FlightDestinations AS fd ON a.Id=fd.AircraftId
GROUP BY  a.Id,a.Manufacturer,a.FlightHours
HAVING COUNT(*)>=2
ORDER BY COUNT(*) DESC,a.Id ASC

--9
SELECT p.FullName,COUNT(*) AS 'CountOfAircraft',SUM(fd.TicketPrice) AS 'TotalPayed' FROM Passengers AS p
JOIN FlightDestinations AS fd ON p.Id=fd.PassengerId
JOIN Aircraft AS a ON a.Id=fd.AircraftId
WHERE SUBSTRING(p.FullName,2,1)='a'
GROUP BY p.FullName
HAVING COUNT(*)>1
ORDER BY p.FullName

--10
SELECT air.AirportName,fd.Start AS 'DayTime',fd.TicketPrice,p.FullName,a.Manufacturer,a.Model
FROM FlightDestinations AS fd
JOIN Passengers AS p ON fd.PassengerId=p.Id
JOIN Aircraft AS a ON a.Id=fd.AircraftId
JOIN Airports AS air ON air.Id=fd.AirportId
WHERE (DATEPART(HOUR,fd.Start)>=6 AND DATEPART(HOUR,fd.Start)<20 AND (DATEPART(MINUTE,fd.Start)>=0 OR  DATEPART(HOUR,fd.Start)=20 AND DATEPART(MINUTE,fd.Start)=0))
	AND TicketPrice>2500
ORDER BY a.Model