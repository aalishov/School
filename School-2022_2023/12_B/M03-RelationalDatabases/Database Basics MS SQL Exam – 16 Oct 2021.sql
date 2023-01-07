--CREATE DATABASE CigarShop;
--USE CigarShop;

--Section 1. DDL (30 pts)
CREATE TABLE Sizes
(
		Id INT PRIMARY KEY IDENTITY,
		Length INT NOT NULL CHECK (Length BETWEEN 10 AND 25),
		RingRange DECIMAL(15,2) NOT NULL CHECK (RingRange BETWEEN 1.5 AND 7.5)
);
CREATE TABLE Tastes
(
	Id INT PRIMARY KEY IDENTITY,
	TasteType VARCHAR(20) NOT NULL,
	TasteStrength VARCHAR(15) NOT NULL,
	ImageURL NVARCHAR(100) NOT NULL
);
CREATE TABLE Brands
(
	Id INT PRIMARY KEY IDENTITY,
	BrandName VARCHAR(30) UNIQUE NOT NULL,
	BrandDescription VARCHAR(MAX)
);
CREATE TABLE Cigars
(
	Id INT PRIMARY KEY IDENTITY,
	CigarName VARCHAR(80) NOT NULL,
	BrandId INT NOT NULL,
	TastId INT NOT NULL,
	SizeId INT NOT NULL,
	PriceForSingleCigar DECIMAL(15,2) NOT NULL,
	ImageURL NVARCHAR(100) NOT NULL
	CONSTRAINT fk_cigars_brands
		FOREIGN KEY (BrandId)
		REFERENCES Brands(Id),
	CONSTRAINT fk_cigars_tastes
		FOREIGN KEY (TastId)
		REFERENCES Tastes(Id),
	CONSTRAINT fk_cigars_sizes
		FOREIGN KEY (SizeId)
		REFERENCES Sizes(Id)
);
CREATE TABLE Addresses
(
	Id INT PRIMARY KEY IDENTITY,
	Town VARCHAR(30) NOT NULL,
	Country NVARCHAR(30) NOT NULL,
	Streat NVARCHAR(100) NOT NULL,
	ZIP VARCHAR(20) NOT NULL
);
CREATE TABLE Clients
(
	Id INT PRIMARY KEY IDENTITY,
	FirstName  NVARCHAR(30) NOT NULL,
	LastName NVARCHAR(30) NOT NULL,
	Email NVARCHAR(50) NOT NULL,
	AddressId INT NOT NULL
	CONSTRAINT fk_client_addresses
		FOREIGN KEY(AddressId)
		REFERENCES Addresses(Id)
);
CREATE TABLE ClientsCigars
(
	ClientId INT NOT NULL,
	CigarId INT NOT NULL
	CONSTRAINT pk_clients
		PRIMARY KEY(ClientId,CigarId)
	CONSTRAINT fk_cigars_clients
		FOREIGN KEY(ClientId)
		REFERENCES Clients(Id),
	CONSTRAINT fk_cigars_cigar
		FOREIGN KEY(CigarId)
		REFERENCES Cigars(Id)
);
--Section 2. DML (10 pts)
--2.	Insert
INSERT INTO Cigars(CigarName,BrandId,TastId,SizeId,PriceForSingleCigar,ImageURL)
VALUES
('COHIBA ROBUSTO',9,1,5,15.50,'cohiba-robusto-stick_18.jpg'),
('COHIBA SIGLO I',9,1,10,410,'cohiba-siglo-i-stick_12.jpg'),
('HOYO DE MONTERREY LE HOYO DU MAIRE',14,5,11,7.50,'hoyo-du-maire-stick_17.jpg'),
('HOYO DE MONTERREY LE HOYO DE SAN JUAN',14,4,15,32.00,'hoyo-de-san-juan-stick_20.jpg'),
('TRINIDAD COLONIALES',2,3,8,85.21,'trinidad-coloniales-stick_30.jpg');
INSERT INTO Addresses(Town,Country,Streat,ZIP)
VALUES
('Sofia','Bulgaria','18 Bul. Vasil levski',1000),
('Athens','Greece','4342 McDonald Avenue',10435),
('Zagreb','Croatia','4333 Lauren Drive',10000);
--3.	Update
UPDATE Cigars
SET PriceForSingleCigar = PriceForSingleCigar * 1.2
WHERE TastId = (SELECT Id FROM Tastes WHERE TasteType = 'Spicy')
UPDATE Brands
SET BrandDescription = 'New description'
WHERE BrandDescription IS NULL
--4.	Delete
DELETE FROM ClientsCigars
WHERE ClientId IN (SELECT c.Id FROM Clients AS c
JOIN Addresses AS a ON a.Id=c.AddressId
WHERE Country LIKE 'C%');
DELETE FROM Clients
WHERE Id IN (SELECT c.Id FROM Clients AS c
JOIN Addresses AS a ON a.Id=c.AddressId
WHERE Country LIKE 'C%');
DELETE FROM Addresses
WHERE Country LIKE 'C%';
--Section 3. Querying (40 pts)
--5.	Cigars by Price
SELECT CigarName,PriceForSingleCigar,ImageURL FROM Cigars
ORDER BY PriceForSingleCigar ASC, CigarName DESC
--6.	Cigars by Taste
SELECT c.Id,CigarName,PriceForSingleCigar,TasteType,TasteStrength FROM Cigars AS c
JOIN Tastes AS t ON t.Id=c.TastId
WHERE t.TasteType = 'Earthy' OR t.TasteType = 'Woody'
ORDER BY c.PriceForSingleCigar DESC
--7.	Clients without Cigars
SELECT c.Id,CONCAT(c.FirstName,' ',c.LastName) AS ClientName,c.Email FROM Clients AS c
LEFT JOIN ClientsCigars AS cc ON cc.ClientId=c.Id
WHERE cc.CigarId IS NULL
ORDER BY ClientName ASC
--8.	First 5 Cigars
SELECT TOP(5) c.CigarName,c.PriceForSingleCigar,c.ImageURL FROM Cigars AS c
JOIN Sizes AS s ON s.Id=c.SizeId
WHERE s.Length >= 12 AND (c.CigarName LIKE '%ci%' OR c.PriceForSingleCigar > 50) AND RingRange > 2.55
ORDER BY c.CigarName ASC, PriceForSingleCigar DESC
--9.	Clients with ZIP Codes
SELECT CONCAT(c.FirstName,' ',c.LastName) AS FullName,a.Country,a.ZIP,
(SELECT TOP(1) PriceForSingleCigar FROM Cigars WHERE Id IN (SELECT CigarId FROM ClientsCigars WHERE Id = c.id) ORDER BY PriceForSingleCigar DESC) 
FROM Clients AS c
JOIN Addresses AS a ON a.Id=c.AddressId
WHERE a.ZIP NOT LIKE '%[^0-9]%'
