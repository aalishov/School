create database colonial_journey_management_system_db;
use colonial_journey_management_system_db;
CREATE TABLE planets (
    id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(30) NOT NULL
);
CREATE TABLE spaceports (
    id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(50) NOT NULL,
    planet_id INT,
    CONSTRAINT fk_spaceports_planets FOREIGN KEY (planet_id)
        REFERENCES planets (id)
);
-- Има стойност по подразбиране 0.
CREATE TABLE spaceships (
    id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(50) NOT NULL,
    manufacturer VARCHAR(50) NOT NULL,
    light_speed_rate INT default 0
);
-- точно 10 символа.
CREATE TABLE colonists (
    id INT PRIMARY KEY AUTO_INCREMENT,
    first_name VARCHAR(20) NOT NULL,
    last_name VARCHAR(30) NOT NULL,
    ucn VARCHAR(10) NOT NULL UNIQUE,
    birth_date DATE NOT NULL,
    CHECK (LENGTH(ucn) = 10)
);
CREATE TABLE journeys (
    id INT PRIMARY KEY AUTO_INCREMENT,
    journey_start DATETIME NOT NULL, -- ?????
    journey_end DATETIME NOT NULL,   -- ?????
    purpose ENUM('Medical', 'Technical', 'Educational', 'Military'),
    destination_spaceport_id INT,
    CONSTRAINT fk_journeys_spaceports FOREIGN KEY (destination_spaceport_id)
        REFERENCES spaceports (id),
    spaceship_id INT,
    CONSTRAINT fk_journeys_spaceships FOREIGN KEY (spaceship_id)
        REFERENCES spaceships (id)
);
CREATE TABLE travel_cards (
    id INT PRIMARY KEY AUTO_INCREMENT,
    card_number VARCHAR(10) NOT NULL UNIQUE,
    job_during_journey ENUM('Pilot', 'Engineer', 'Trooper', 'Cleaner', 'Cook'),
    colonist_id INT,
    CONSTRAINT fk_travel_cards_colonists FOREIGN KEY (colonist_id)
        REFERENCES colonists (id),
    journey_id INT,
    CONSTRAINT fk_travel_cards_journeys FOREIGN KEY (journey_id)
        REFERENCES journeys (id)
);
-- 05. Извлечете всички карти за пътуване
SELECT 
    card_number, job_during_journey
FROM
    travel_cards
ORDER BY card_number ASC;
-- 06. Извлечете всички колонисти
SELECT 
    id, concat(first_name,' ',last_name)as full_name, ucn
FROM
    colonists
ORDER BY first_name ASC;

-- 07. Извлечете всички военни пътувания
select id, journey_start, journey_end from journeys
where purpose = 'Military'
order by journey_start asc;

-- 08. Извлечете всички пилоти
select c.id, concat(c.first_name,' ',c.last_name)as full_name from colonists as c
join travel_cards as tc on tc.colonist_id = c.id
where tc.job_during_journey = 'Pilot'
order by c.id asc; 

-- 09. Изтеглете най-бързия космически кораб
select ss.id, ss.name, sp.name from spaceships as ss
join journeys as j on j.spaceship_id = ss.id
join spaceports as sp on sp.id = j.destination_spaceport_id
order by ss.light_speed_rate desc
limit 1;

-- 10. Извлечете всички образователни мисии и космически кораби
select p.name as planet_name, s.name as spaceport_name from planets as p
join spaceports as s on s.planet_id = p.id
join journeys as j on j.destination_spaceport_id = s.id
where purpose = 'Educational'
order by s.name desc;

