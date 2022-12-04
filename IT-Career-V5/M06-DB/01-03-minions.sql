-- Problem 1.	Създаване на база данни
CREATE DATABASE Minions;

USE Minions;

-- Problem 2.	Създаване на таблици
CREATE TABLE Minions
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    name NVARCHAR(50) NOT NULL,
    age INT NOT NULL
);

CREATE TABLE Towns
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    name NVARCHAR(50) NOT NULL
);

-- Problem 3.	Променяне на таблицата Minions
ALTER TABLE Minions
ADD COLUMN town_id INT NOT NULL;

ALTER TABLE Minions
ADD CONSTRAINT fk_minions_towns
FOREIGN KEY (town_id)
REFERENCES towns (id);

-- Problem 4.	Направете записи в двете таблици
INSERT INTO Towns (name)
VALUES ('Sofia'),('Plovdiv'),('Varna'),('Velingrad');

INSERT INTO Minions(name, age, town_id)
VALUES 
	('Kevin',22,1),
    ('Bob',22,4),
    ('Steward',18,4);
    
-- Problem 5.	Изтрийте всички данни от таблица Minions
TRUNCATE TABLE Minions;

-- Problem 6.	Премахнете всички таблици
DROP TABLE Minions;
DROP TABLE Towns;


