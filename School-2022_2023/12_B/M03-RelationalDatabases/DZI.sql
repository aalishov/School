CREATE DATABASE School1;
USE School1;

CREATE TABLE students
(
	ID INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(50) NOT NULL,
	BEL INT NOT NULL,
	English INT NOT NULL,
	Math INT NOT NULL,
	Informatics INT NOT NULL,
	IT INT NOT NULL
)
INSERT INTO students(Name,BEL,English,Math,Informatics,IT)
VALUES
('Антония Колева',4,5,6,5,4),
('Асен Ангелов',5,5,6,4,5),
('Борислав Ганев',4,4,5,5,6),
('Бояна Тодорова',5,6,6,6,6),
('Валери Илиев',6,6,6,6,6);

SELECT ID,BEL,English,Math,Informatics,IT
FROM students
WHERE ID = 4

SELECT COUNT(*)
FROM students
WHERE Math=6 AND Informatics = 6 AND IT = 6

SELECT AVG(CAST(BEL AS decimal)),AVG(CAST(Math AS decimal))
FROM students

SELECT Name, SUM(Math + BEL + English + Informatics + IT)/5.0 AS Average
FROM students
GROUP BY Name
ORDER BY Average DESC, Name ASC

--DZI Май месец

CREATE DATABASE MAGAZIN;
USE MAGAZIN;

CREATE TABLE laptops
(
	ID INT PRIMARY KEY IDENTITY,
	Brand varchar(50) not null,
	Model varchar(50) not null,
	Quantity int not null,
	Price DECIMAL NOT NULL
);

INSERT INTO laptops (Brand,model,quantity,price)
VALUES
	('Laptop1','L29KAS',10,1100),
	('Laptop2','15FDR7',14,1350),
	('Laptop1','L29GTA',12,1500),
	('Laptop1','L29DFT',8,1499),
	('Laptop2','15FDM5',11,1600);

DELETE FROM laptops
WHERE Model='15FDR7'

SELECT Brand, model ,Quantity*Price*1.2 AS 'SUM'
FROM laptops

SELECT Brand, SUM(Quantity) AS 'TOTAL_QUANTITY'
FROM laptops
WHERE Brand='Laptop1'
GROUP BY Brand