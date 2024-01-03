CREATE DATABASE RailwaysDb;

USE RailwaysDb;

CREATE TABLE Passengers
(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(80) NOT NULL
);

CREATE TABLE Towns
(
	Id INT PRIMARY KEY IDENTITY,
	Name VARCHAR(30) NOT NULL
);

CREATE TABLE RailwayStations
(
	Id INT PRIMARY KEY IDENTITY,
	Name VARCHAR(50) NOT NULL,
	TownId INT NOT NULL,
		CONSTRAINT fk_RailwayStations_Towns
			FOREIGN KEY (TownId)
			REFERENCES Towns(Id)
);

CREATE TABLE Trains
(
	Id INT PRIMARY KEY IDENTITY,
	HourOfDeparture VARCHAR(5) NOT NULL,
	HourOfArrival VARCHAR(5) NOT NULL,
	DepartureTownId INT NOT NULL,
	ArrivalTownId INT NOT NULL,
		CONSTRAINT fk_Trains_TownsDeparture
			FOREIGN KEY (DepartureTownId)
			REFERENCES Towns(Id),
		CONSTRAINT fk_Trains_TownsArrival
			FOREIGN KEY (ArrivalTownId)
			REFERENCES Towns(Id),
);

CREATE TABLE TrainsRailwayStations
(
	TrainId INT NOT NULL,
	RailwayStationId INT NOT NULL,
		CONSTRAINT pk_TrainsRailwayStations
			PRIMARY KEY (TrainId,RailwayStationId),
		CONSTRAINT fk_TrainsRailwayStations_Trains
			FOREIGN KEY (TrainId)
			REFERENCES Trains(Id),
		CONSTRAINT fk_TrainsRailwayStations_RailwayStations
			FOREIGN KEY (RailwayStationId)
			REFERENCES RailwayStations(Id)
);

CREATE TABLE MaintenanceRecords
(
	Id INT PRIMARY KEY IDENTITY,
	DateOfMaintenance DATE NOT NULL,
	Details VARCHAR(2000) NOT NULL,
	TrainId INT NOT NULL,
		CONSTRAINT fk_MaintenanceRecords_Trains
			FOREIGN KEY (TrainId)
			REFERENCES Trains(Id),
);

CREATE TABLE Tickets
(
	Id INT PRIMARY KEY IDENTITY,
	Price DECIMAl(18,2) NOT NULL,
	DateOfDeparture DATE NOT NULL,
	DateOfArrival DATE NOT NULL,
	TrainId INT NOT NULL,
	PassengerId INT NOT NULL,
		CONSTRAINT fk_Tickets_Trains
			FOREIGN KEY (TrainId)
			REFERENCES Trains(Id),
		CONSTRAINT fk_Tickets_Passengers
			FOREIGN KEY (PassengerId)
			REFERENCES Passengers(Id),
);

-- INSERT

INSERT INTO Trains(HourOfDeparture,HourOfArrival,DepartureTownId,ArrivalTownId)
VALUES
('07:00','19:00',1	,3),
('08:30','20:30',5	,6),
('09:00','21:00',4	,8),
('06:45','03:55',27	,7),
('10:15','12:15',15	,5);

INSERT INTO TrainsRailwayStations(TrainId, RailwayStationId)
VALUES
(36,	1	),(37	,60	),(39	,3  ),
(36,	4	),(37	,16	),(39	,31	),
(36,	31	),(38	,10	),(39	,19	),
(36,	57	),(38	,50	),(40	,41	),
(36,	7	),(38	,52	),(40	,7	),
(37,	13	),(38	,22	),(40	,52	),
(37,	54	),(39	,68	),(40	,13	);


INSERT INTO Tickets(Price,	DateOfDeparture,	DateOfArrival,	TrainId,	PassengerId)
VALUES 
(90.00	,'2023-12-01'	,'2023-12-01'	,36	,1 ),
(115.00	,'2023-08-02'	,'2023-08-02'	,37	,2 ),
(160.00	,'2023-08-03'	,'2023-08-03'	,38	,3 ),
(255.00	,'2023-09-01'	,'2023-09-02'	,39	,21),
(95.00	,'2023-09-02'	,'2023-09-03'	,40	,22)

--UPDATE

UPDATE Tickets
SET DateOfDeparture = DATEADD(day,7,DateOfDeparture),
	DateOfArrival= DATEADD(DAY,7,DateOfArrival)
WHERE MONTH(DateOfDeparture)>10;

--DELETE


DELETE FROM Tickets
WHERE TrainId IN 
(SELECT Id FROM Trains 
WHERE DepartureTownId IN (SELECT Id From Towns WHERE Name='Berlin'));

DELETE FROM MaintenanceRecords
WHERE TrainId IN 
(SELECT Id FROM Trains 
WHERE DepartureTownId IN (SELECT Id From Towns WHERE Name='Berlin'));


DELETE FROM TrainsRailwayStations
WHERE TrainId IN 
(SELECT Id FROM Trains 
WHERE DepartureTownId IN (SELECT Id From Towns WHERE Name='Berlin'));

DELETE FROM Trains
WHERE id IN 
(SELECT Id FROM Trains 
WHERE DepartureTownId IN (SELECT Id From Towns WHERE Name='Berlin'));


--5. Tickets by Price and Date of Departure
SELECT DateOfDeparture,Price AS 'TicketPrice' FROM Tickets
ORDER BY Price ASC, DateOfDeparture DESC

--6. Passengers with their Tickets

SELECT p.Name AS 'PassengerName', t.Price AS 'TicketPrice',t.DateOfDeparture,t.TrainId FROM Tickets AS t
JOIN Passengers AS p ON t.PassengerId=p.Id
ORDER BY t.Price DESC,p.Name ASC

--7. Railway Stations without Passing Trains

SELECT t.Name AS'TownName',rs.Name AS 'RailwayStation' FROM Towns AS t
JOIN RailwayStations AS rs ON t.Id=rs.TownId
FULL JOIN TrainsRailwayStations AS trs ON rs.Id=trs.RailwayStationId
WHERE trs.TrainId IS NULL
ORDER BY t.Name ASC, rs.Name ASC
--
--8. First 3 Trains Between 8:00 and 8:59
SELECT TOP(3) t.Id AS 'TrainId',t.HourOfDeparture,tkts.Price AS'TicketPrice',twn.Name AS 'Destination' FROM Tickets AS tkts
FULL JOIN Trains AS t ON t.Id=tkts.TrainId
FULL JOIN Towns AS twn ON t.ArrivalTownId=twn.Id
WHERE tkts.Price>50.00 
AND CAST(LEFT(t.HourOfDeparture,2)AS INT)=8
ORDER BY tkts.Price ASC,t.Id ASC

--9. Count of Passengers Paid More Than Average With Arrival Towns

SELECT twn.Name AS 'TownName', COUNT(*) AS 'PassengerCount' FROM Passengers AS p
JOIN Tickets AS t ON p.Id=t.PassengerId
JOIN Trains AS trns ON  t.TrainId = trns.Id
JOIN Towns AS twn ON trns.ArrivalTownId=twn.Id
WHERE t.Price >'76.99'
GROUP BY twn.Name

--10. Maintenance Inspection with Town

SELECT t.Id AS 'TrainId',twns.Name AS 'DepartureTown',mr.Details 
FROM MaintenanceRecords AS mr
JOIN Trains AS t ON t.Id = mr.TrainId
JOIN Towns AS twns ON t.DepartureTownId=twns.Id
WHERE mr.Details LIKE ('%inspection%')
ORDER BY t.Id