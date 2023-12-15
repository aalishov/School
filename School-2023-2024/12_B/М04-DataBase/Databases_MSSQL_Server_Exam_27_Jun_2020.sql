	CREATE DATABASE WashingMachineService;

	USE WashingMachineService;

	CREATE TABLE Clients
	(
		ClientId INT PRIMARY KEY IDENTITY,
		FirstName VARCHAR(50) NOT NULL,
		LastName VARCHAR(50) NOT NULL,
		Phone VARCHAR(12) NOT NULL,
		CHECK(LEN(Phone)=12)
	);

	CREATE TABLE Mechanics
	(
		MechanicId INT PRIMARY KEY IDENTITY,
		FirstName VARCHAR(50) NOT NULL,
		LastName VARCHAR(50) NOT NULL,
		Address VARCHAR(255) NOT NULL
	);
	CREATE TABLE Models
	(
		ModelId INT PRIMARY KEY IDENTITY,
		Name VARCHAR(50) UNIQUE
	);

	CREATE TABLE Jobs
	(
		JobId INT PRIMARY KEY IDENTITY,
		ModelId INT NOT NULL,
		Status VARCHAR(11) DEFAULT 'Pending'
		CHECK(Status IN ('Pending', 'In Progress', 'Finished')),
		ClientId INT NOT NULL,
		MechanicId INT,
		IssueDate DATETIME2 NOT NULL,
		FinishDate DATETIME2
		CONSTRAINT fk_jobs_models
			FOREIGN KEY(ModelId)
			REFERENCES Models(ModelId),
		CONSTRAINT fk_jobs_clients
			FOREIGN KEY(ClientId)
			REFERENCES Clients(ClientId),
		CONSTRAINT fk_jobs_mechanics
			FOREIGN KEY(MechanicId)
			REFERENCES Mechanics(MechanicId)
	);
	CREATE TABLE Orders
	(
		OrderId INT PRIMARY KEY IDENTITY,
		JobId INT NOT NULL,
		IssueDate DATETIME2,
		Delivered TINYINT DEFAULT 0
		CONSTRAINT fk_orders_jobs
			FOREIGN KEY(JobId)
			REFERENCES Jobs(JobId)
	);
	CREATE TABLE Vendors
	(
		VendorId INT PRIMARY KEY IDENTITY,
		Name VARCHAR(50) NOT NULL UNIQUE
	);
	CREATE TABLE Parts
	(
		PartId INT PRIMARY KEY IDENTITY,
		SerialNumber VARCHAR(50) NOT NULL UNIQUE,
		Description VARCHAR(255),
		Price DECIMAL(6,2) NOT NULL,
		CHECK(PRICE>0 AND Price<=9999.99),
		VendorId INT NOT NULL,
		StockQty INT NOT NULL DEFAULT 0
		CONSTRAINT fk_parts_vendors
			FOREIGN KEY(VendorId)
			REFERENCES Vendors(VendorId)
	);
	CREATE TABLE OrderParts
	(
		OrderId INT NOT NULL,
		PartId INT NOT NULL,
		Quantity INT NOT NULL DEFAULT 1,
		CHECK(Quantity>=0),
		CONSTRAINT pk_orderid_partid
			PRIMARY KEY(OrderId,PartId),
		CONSTRAINT fk_orderparts_orders
			FOREIGN KEY(OrderId)
			REFERENCES Orders(OrderId),
		CONSTRAINT fk_orderparts_parts
			FOREIGN KEY(PartId)
			REFERENCES Parts(PartId)
	);
	CREATE TABLE PartsNeeded
	(
		JobId INT NOT NULL,
		PartId INT NOT NULL,
		Quantity INT NOT NULL DEFAULT 1,
		CHECK(Quantity>=0),
		CONSTRAINT pk_jobid_partid
			PRIMARY KEY(JobId,PartId),
		CONSTRAINT fk_partsneeded_jobs
			FOREIGN KEY(JobId)
			REFERENCES Jobs(JobId),
		CONSTRAINT fk_partsneeded_parts
			FOREIGN KEY(PartId)
			REFERENCES Parts(PartId)
	);

	INSERT INTO Clients(FirstName,LastName,Phone)
	VALUES
	('Teri','Ennaco','570-889-5187'),
	('Merlyn','Lawler','201-588-7810'),
	('Georgene','Montezuma','925-615-5185'),
	('Jettie','Mconnell','908-802-3564'),
	('Lemuel','Latzke','631-748-6479'),
	('Melodie','Knipp','805-690-1682'),
	('Candida','Corbley','908-275-8357');

	INSERT INTO Parts(SerialNumber,Description,Price,VendorId)
	VALUES
	('WP8182119','Door Boot Seal',117.86,2),
	('W10780048','Suspension Rod',42.81,1),
	('W10841140','Silicone Adhesive',6.77,4),
	('WPY055980','High Temperature Adhesive',13.94,3);
	
UPDATE Jobs 
SET Status='In Progress', MechanicId=(SELECT MechanicId FROM Mechanics
where FirstName='Ryan' AND LastName='Harnos')
where Status='Pending';



 DELETE FROM OrderParts
 WHERE OrderId=19;
 DELETE FROM Orders
 WHERE OrderId=19;

--5.Mechanic Assignments
SELECT FirstName+' '+ LastName AS 'Mechanic',j.Status,j.IssueDate
FROM Mechanics as m
JOIN Jobs as j on m.MechanicId=j.MechanicId
ORDER BY m.MechanicId asc,j.IssueDate asc,j.JobId asc

Select * from jobs
--6.Current Clients
SELECT FirstName + ' ' + LastName as Client, DATEDIFF(day,j.IssueDate,'2017-04-24') as 'Days going',j.Status 
FROM Clients AS c
JOIN Jobs as j on c.ClientId=j.ClientId
where j.Status='In Progress'

--7.Mechanic Performance
SELECT CONCAT(FirstName,' ',LastName) as 'Mechanic', AVG(DATEDIFF(day,j.IssueDate,j.FinishDate)) as 'Average Days'
FROM Mechanics as m
JOIN Jobs AS j on m.MechanicId=j.MechanicId
GROUP BY m.FirstName,LastName,m.MechanicId
ORDER BY m.MechanicId asc

--8.
SELECT (CONCAT(FirstName, ' ', LastName)) FROM Mechanics as m
WHERE MechanicId NOT IN(SELECT DISTINCT(MechanicId) FROM Jobs
WHERE Status='In progress')
GROUP BY m.FirstName,m.LastName,m.MechanicId
ORDER BY m.MechanicId asc


--9.
SELECT j.JobId,SUM(PN.Quantity*P.Price) AS 'Total'
FROM Jobs AS j
JOIN PartsNeeded AS pn ON j.JobId=pn.JobId
JOIN Parts as p ON pn.PartId=p.PartId
WHERE j.Status='Finished'
GROUP BY j.JobId
ORDER BY SUM(PN.Quantity*P.Price) desc,j.JobId asc

--10
SELECT * FROM JOBS AS j
JOIN PartsNeeded AS pn ON j.JobId=pn.JobId
JOIN Parts AS p ON pn.PartId=p.PartId
JOIN OrderParts AS op on op.PartId=p.PartId
where j.Status not in('Finished') 

--11 
SELECT p.PartId,p.Description,
	(
		CASE
			WHEN (
					SELECT  SUM(Quantity) 
					FROM PartsNeeded AS pn2
					JOIN Jobs as j2 ON j2.JobId=pn2.JobId
					WHERE PartId=p.PartId AND j2.Status<>'Finished'
					GROUP BY PartId
				) IS NULL THEN 0
			ELSE 
				(
					SELECT  SUM(Quantity) 
					FROM PartsNeeded AS pn2
					JOIN Jobs as j2 ON j2.JobId=pn2.JobId
					WHERE PartId=p.PartId AND j2.Status<>'Finished'
					GROUP BY PartId
				)
		END
	) AS [Required],
	p.StockQty AS 'In Stock',
	(
	CASE 
		WHEN (
						SELECT SUM(Quantity) FROM OrderParts AS op2
						JOIN Orders AS o2 ON o2.OrderId=op2.OrderId
						WHERE PartId=p.PartId AND Delivered=0
						GROUP BY PartId
				) IS NULL THEN 0
		ELSE (
					SELECT SUM(Quantity) FROM OrderParts AS op2
					JOIN Orders AS o2 ON o2.OrderId=op2.OrderId
					WHERE PartId=p.PartId AND Delivered=0
					GROUP BY PartId
		)
	END
	) AS 'Ordered'
FROM Parts AS p
WHERE (CASE
			WHEN (
					SELECT  SUM(Quantity) 
					FROM PartsNeeded AS pn2
					JOIN Jobs as j2 ON j2.JobId=pn2.JobId
					WHERE PartId=p.PartId AND j2.Status<>'Finished'
					GROUP BY PartId
				) IS NULL THEN 0
			ELSE (
					SELECT  SUM(Quantity) 
					FROM PartsNeeded AS pn2
					JOIN Jobs as j2 ON j2.JobId=pn2.JobId
					WHERE PartId=p.PartId AND j2.Status<>'Finished'
					GROUP BY PartId
				)
				
		END)>p.StockQty +
							CASE WHEN (
										SELECT SUM(Quantity) FROM OrderParts AS op2
										JOIN Orders AS o2 ON o2.OrderId=op2.OrderId
										WHERE PartId=p.PartId AND Delivered=0
										GROUP BY PartId
								) IS NULL THEN 0
							ELSE (
										SELECT SUM(Quantity) FROM OrderParts AS op2
										JOIN Orders AS o2 ON o2.OrderId=op2.OrderId
										WHERE PartId=p.PartId AND Delivered=0
										GROUP BY PartId
							)
							END
ORDER BY PartId ASC;



SELECT * FROM Orders

SELECT  PartId,SUM(Quantity) AS 'In Stock'
					FROM PartsNeeded AS pn2
					JOIN Jobs as j2 ON j2.JobId=pn2.JobId
					WHERE  j2.Status<>'Finished'
					GROUP BY PartId


SELECT PartId, SUM(Quantity) AS 'Ordered'
FROM OrderParts AS op2
						JOIN Orders AS o2 ON o2.OrderId=op2.OrderId
						WHERE  Delivered=0
						GROUP BY PartId