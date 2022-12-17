--CREATE DATABASE ZOO;
--USE ZOO;
--язгдюбюме мю рюакхжю OWNERS
CREATE TABLE Owners
(
	Id INT PRIMARY KEY IDENTITY,
	Name VARCHAR(50) NOT NULL,
	PhoneNumber VARCHAR(15) NOT NULL,
	Address  VARCHAR(50)
);
--язгдюбюме мю рюакхжю ANIMALTYPES
CREATE TABLE AnimalTypes
(
	Id INT PRIMARY KEY IDENTITY,
	AnimalType VARCHAR(30) NOT NULL,
);
--язгдюбюме мю рюакхжю Cages
CREATE TABLE Cages
(
	Id INT PRIMARY KEY IDENTITY,
	AnimalTypeId INT NOT NULL,
	CONSTRAINT fk_cages_animaltype
	FOREIGN KEY (AnimalTypeId)
	REFERENCES AnimalTypes(Id)
);
--язгдюбюме мю рюакхжю Animals
CREATE TABLE Animals
(
	Id INT PRIMARY KEY IDENTITY,
	Name VARCHAR(30) NOT NULL,
	BirthDate DATE NOT NULL,
	OwnerId INT,
	AnimalTypeId INT NOT NULL,
	CONSTRAINT fk_animals_owners
		FOREIGN KEY(OwnerId) 
		REFERENCES Owners(Id),
	CONSTRAINT fk_animaltypes_animals
		FOREIGN KEY (AnimalTypeId)
		REFERENCES AnimalTypes(Id)
);
--язгдюбюме мю рюакхжю AnimalsCages
CREATE TABLE AnimalsCages
(
	CageId INT NOT NULL,
	AnimalId INT NOT NULL,
	CONSTRAINT pk_animalscages
		PRIMARY KEY(CageId,AnimalId),
	CONSTRAINT fk_animalscages_cages
		FOREIGN KEY (CageId)
		REFERENCES Cages(Id),
	CONSTRAINT fk_animalscages_animals
		FOREIGN KEY (AnimalId)
		REFERENCES Animals(Id)
);
--язгдюбюме мю рюакхжю VolunteersDepartments
CREATE TABLE VolunteersDepartments
(
	Id INT PRIMARY KEY IDENTITY,
	DepartmentName VARCHAR(30) NOT NULL
);
--язгдюбюме мю рюакхжю Volunteers
CREATE TABLE Volunteers
(
	Id INT PRIMARY KEY IDENTITY,
	Name VARCHAR(50) NOT NULL,
	PhoneNumber VARCHAR(15) NOT NULL,
	Address VARCHAR(50),
	AnimalId INT,
	DepartmentId INT NOT NULL,
	CONSTRAINT fk_volunteers_animals
		FOREIGN KEY (AnimalId)
		REFERENCES Animals(Id),
	CONSTRAINT fk_volunteers_volunteersdp
		FOREIGN KEY (DepartmentId)
		REFERENCES VolunteersDepartments(Id)
);
--2.Insert
INSERT INTO Volunteers(NAME,PhoneNumber,Address,AnimalId,DepartmentId)
VALUES
('Anita Kostova','0896365412','Sofia, 5 Rosa str.',15,1),
('Dimitur Stoev','0877564223',NULL,42,4),
('Kalina Evtimova','0896321112','Silistra, 21 Breza str.',9,7),
('Stoyan Tomov','0898564100','Montana, 1 Bor str.',18,8),
('Boryana Mileva','0888112233',NULL,31,5);

INSERT INTO Animals(NAME,BirthDate,OwnerId,AnimalTypeId)
VALUES
('Giraffe','2018-09-21',21,1),
('Harpy Eagle','2015-04-17',15,3),
('Hamadryas Baboon','2017-11-02',NULL,1),
('Tuatara','2021-06-30',2,4);
--3.Update
SELECT Id FROM Owners
WHERE NAME='Kaloqn Stoqnov'

UPDATE Animals
SET OwnerId = (SELECT Id FROM Owners WHERE NAME='Kaloqn Stoqnov')
WHERE OwnerId IS NULL
--4.Delete
DELETE FROM VolunteersDepartments
WHERE DepartmentName='Education program assistant';
--5.Volunteers
--DROP DATABASE ZOO;
SELECT Name,PhoneNumber,Address, AnimalId, DepartmentId FROM Volunteers
ORDER BY Name ASC, AnimalId ASC, DepartmentId ASC
--6.Animals data
SELECT Name, AT.AnimalType,FORMAT( BirthDate,'dd.MM.yyyy') AS BirthDate FROM Animals AS A
JOIN AnimalTypes AS AT ON A.AnimalTypeId=AT.Id
ORDER BY NAME ASC
