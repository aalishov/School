CREATE DATABASE Airport;
USE Airport;

CREATE TABLE Passengers 
(
	Id INT PRIMARY KEY IDENTITY,
	FullName VARCHAR(100) UNIQUE NOT NULL,
	Email VARCHAR(50) UNIQUE NOT NULL
);

CREATE TABLE Pilots 
(
	Id INT PRIMARY KEY IDENTITY,
	FirstName VARCHAR(30) UNIQUE NOT NULL,
	LastName VARCHAR(30) UNIQUE NOT NULL,
	Age TINYINT NOT NULL CHECK (Age BETWEEN 21 AND 62),	
	Rating FLOAT NOT NULL CHECK (Rating BETWEEN 0.0 AND 10.0)	
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
	Condition VARCHAR(1) NOT NULL CHECK (LEN(Condition)=1),
	TypeId INT NOT NULL
	CONSTRAINT fk_aircraft_aircrafttypes
	FOREIGN KEY (TypeId)
	REFERENCES AircraftTypes(Id)
);

CREATE TABLE PilotsAircraft 
(
	AircraftId INT NOT NULL,
	PilotId INT NOT NULL
	CONSTRAINT pk_pilotsaicraft
	PRIMARY KEY(AircraftId,PilotId),
	CONSTRAINT fk_pilotsaicraft_aircraft
		FOREIGN KEY (AircraftId)
		REFERENCES Aircraft(Id),
	CONSTRAINT fk_pilotsaicraft_pilot
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
	Start DateTime2 NOT NULL,
	AircraftId INT NOT NULL,
	PassengerId INT NOT NULL,
	TicketPrice DECIMAL(18,2) DEFAULT 15 NOT NULL
	CONSTRAINT fk_flightdestinations_airport
		FOREIGN KEY (AirportId)
		REFERENCES Airports(Id),
	CONSTRAINT fk_flightdestinations_aircraft
		FOREIGN KEY (AircraftId)
		REFERENCES Aircraft(Id),
	CONSTRAINT fk_flightdestinations_passenger
		FOREIGN KEY (PassengerId)
		REFERENCES Passengers(Id)
);

--2.Insert
INSERT INTO Passengers(FullName,Email)
	SELECT CONCAT_WS(' ',FirstName,LastName) AS FullName, CONCAT(FirstName,LastName,'@gmail.com') AS Email 
	FROM Pilots
	WHERE Id BETWEEN 5 AND 15;
--3.Update
UPDATE Aircraft
SET Condition = 'A'
WHERE Condition IN('C','B') AND (FlightHours IS NULL OR FlightHours <=100) AND YEAR >= 2013
--4.Delete
DELETE FROM Passengers
WHERE LEN(FullName) <=10
--5.Aircraft
SELECT Manufacturer,Model,FlightHours,Condition FROM Aircraft
ORDER BY FlightHours DESC
--6.Pilots and Aircraft
SELECT FirstName,LastName,Manufacturer,Model,FlightHours FROM Pilots AS p
JOIN PilotsAircraft AS pa ON P.Id=pa.PilotId
JOIN Aircraft AS a ON pa.AircraftId=a.Id
WHERE FlightHours<=304
ORDER BY FlightHours DESC , FirstName ASC
--7.Top 20 Flight Destinations
SELECT TOP(20) f.Id AS DestinationId,Start, P.FullName,a.AirportName, TicketPrice FROM FlightDestinations AS f
JOIN Passengers AS p ON f.PassengerId=P.Id
JOIN Airports AS a ON A.Id=f.AirportId
WHERE DATEPART(DAY,START) % 2 = 0
ORDER BY TicketPrice DESC, AirportName ASC
--8.Number of Flights for Each Aircraft
SELECT a.Id as AircraftId, 
	(SELECT Manufacturer FROM Aircraft AS air WHERE a.Id=air.Id) as Manufacturer,
	(SELECT FlightHours FROM Aircraft AS air WHERE a.Id=air.Id) as FlightHours,
	COUNT(f.AircraftId) as FlightDestinationsCount,
	ROUND(AVG(f.TicketPrice),2) as AvgPrice 
FROM Aircraft AS a
JOIN FlightDestinations AS f ON f.AircraftId=a.Id
GROUP BY a.Id
HAVING COUNT(f.AircraftId)>=2
ORDER BY FlightDestinationsCount DESC, a.Id asc
--9.Regular Passengers
SELECT FullName,COUNT(a.Id) AS CountOfAircraft, SUM(TicketPrice) AS TotalPayed FROM Passengers AS p
JOIN FlightDestinations AS f ON f.PassengerId=p.Id
JOIN Aircraft AS a ON f.AircraftId=a.Id
WHERE FullName LIKE'_a%'
GROUP BY FullName
HAVING COUNT(a.Id)>=2
ORDER BY FullName
--10.Full Info for Flight Destinations
SELECT a.AirportName, Start AS DayTime, TicketPrice, p.FullName, air.Manufacturer, air.Model FROM FlightDestinations AS f
JOIN Airports AS a ON a.Id=f.AirportId
JOIN Passengers AS p ON p.Id=f.PassengerId
JOIN Aircraft AS air ON f.AircraftId=air.Id
WHERE DATEPART(HOUR,Start) BETWEEN 6 AND 20 AND TicketPrice>2500
ORDER BY Model ASC