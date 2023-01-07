CREATE DATABASE CJMS;

-- SET SQL_SAFE_UPDATES=0;

USE CJMS;

-- 1.   Data Definition Language (DDL) – 30pts
-- planets
CREATE TABLE planets
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    `name` VARCHAR(30) NOT NULL
);
-- spaceports
CREATE TABLE spaceports
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    `name` VARCHAR(50) NOT NULL,
    planet_id INT NOT NULL,
	CONSTRAINT fk_spaceporsts_planets
		FOREIGN KEY (planet_id)
        REFERENCES planets(id)
);
-- spaceships
CREATE TABLE spaceships
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    `name` VARCHAR(50) NOT NULL,
    manufacturer VARCHAR(30) NOT NULL,
    light_speed_rate INT DEFAULT 0
);
-- colonists, -- CHECK (LEN(ucn)=10)
CREATE TABLE colonists
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    first_name VARCHAR(20) NOT NULL,
    last_name VARCHAR(20) NOT NULL,
    ucn CHAR(10) UNIQUE NOT NULL,
    birth_date DATE NOT NULL
);
-- journeys
CREATE TABLE journeys
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    journey_start DATETIME NOT NULL,
    journey_end DATETIME NOT NULL,
    purpose ENUM('Medical','Technical','Educational','Military'),
    destination_spaceport_id INT NOT NULL,
    spaceship_id INT NOT NULL,
    CONSTRAINT fk_journeys_spaceports
		FOREIGN KEY (destination_spaceport_id)
        REFERENCES spaceports(id),
	CONSTRAINT fk_journeys_spaceships
		FOREIGN KEY (spaceship_id)
        REFERENCES spaceships(id)
);
-- travel_cards
CREATE TABLE travel_cards
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    card_number CHAR(10) UNIQUE NOT NULL,
    job_during_journey ENUM('Pilot','Engineer','Trooper','Cleaner','Cook'),
    colonist_id INT NOT NULL,
    journey_id INT NOT NULL,
    CONSTRAINT fk_travel_cards_colonists
		FOREIGN KEY (colonist_id)
        REFERENCES colonists(id),
	CONSTRAINT fk_travel_cards_journeys
		FOREIGN KEY (journey_id)
        REFERENCES journeys(id)
);
-- 2.   Data Manipulation Language (DML) – 30 pts
-- 3.    Вмъкване на данни
INSERT INTO travel_cards (card_number,job_during_journey,colonist_id,journey_id)
SELECT CASE 
			WHEN c.birth_date>'1980-01-01' 
				THEN CONCAT(YEAR(c.birth_date),DAY(c.birth_date),LEFT(c.ucn,4))
			ELSE CONCAT(YEAR(c.birth_date),MONTH(c.birth_date),RIGHT(c.ucn,4))
		END as card_number,
        CASE
			WHEN c.id % 2 = 0 THEN 'Pilot'
            WHEN c.id % 3 = 0 THEN 'Cook'
            ELSE 'Engineer'
        END as job_during_journey,
        c.id  as colonist_id,
        LEFT(c.ucn,1) as journey_id
FROM colonists as c
WHERE c.id BETWEEN 96 AND 100;

-- 4.    Обновяване на данни
UPDATE journeys as j
SET  j.purpose='Medical' 
WHERE j.id%2=0;
UPDATE journeys as j
SET  j.purpose='Technical' 
WHERE j.id%3=0;
UPDATE journeys as j
SET  j.purpose='Educational' 
WHERE j.id%5=0;
UPDATE journeys as j
SET  j.purpose='Military' 
WHERE j.id%7=0;

-- 5.    Изтриване на данни
DELETE FROM colonists
WHERE id NOT IN (SELECT colonist_id FROM travel_cards);

-- 05. Извлечете всички карти за пътуване
SELECT card_number, job_during_journey 
FROM travel_cards
ORDER BY card_number;

-- 06. Извлечете всички колонисти
SELECT id, CONCAT(first_name,' ',last_name) AS 'full_name',ucn
FROM colonists
ORDER BY first_name, last_name, id;

-- 07. Извлечете всички военни пътувания
SELECT id, journey_start, journey_end 
FROM journeys
WHERE purpose='Military'
ORDER BY journey_start;

-- 08. Извлечете всички пилоти
SELECT id, CONCAT(first_name,' ',last_name) AS 'full_name'
FROM colonists
WHERE id IN 
	(
		SELECT colonist_id 
        FROM travel_cards
        WHERE job_during_journey='Pilot'
	)
ORDER BY id ASC;

-- 09. Изтеглете най-бързия космически кораб
SELECT s.name as spaceship_name, sp.name as spaceport_name
FROM spaceships AS s
JOIN journeys AS j ON j.spaceship_id=s.id
JOIN spaceports AS sp ON sp.id=j.destination_spaceport_id
ORDER BY light_speed_rate DESC 
LIMIT 1;

-- 10. Извлечете всички образователни мисии и космически кораби
SELECT p.name as planet_name, s.name as spaceport_name
FROM planets as p
JOIN spaceports as s ON s.planet_id=p.id
JOIN journeys as j ON j.destination_spaceport_id=s.id
WHERE purpose='Educational'
ORDER BY s.name DESC;

-- 11. Извлечете всички планети и тяхното пътуване
SELECT p.name as planet_name,COUNT(*) as journeys_count
FROM planets as p
JOIN spaceports as s ON s.planet_id=p.id
JOIN journeys as j ON j.destination_spaceport_id=s.id
GROUP BY p.name
ORDER BY journeys_count DESC
