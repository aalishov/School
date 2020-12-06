-- Създайте база с името 
create database colonial_journey_management_system_db;

use colonial_journey_management_system_db;

-- 1.   Data Definition Language (DDL) – 30pts

-- planets
create table planets
(
	id int primary key auto_increment,
    name varchar(30) not null
);

-- spaceports
create table spaceports
(
	id int primary key auto_increment,
    name varchar(50) not null,
    planet_id int not null,
    constraint fk_spaceports_planets
		foreign key (planet_id)
		references planets (id)
);

-- spaceships

create table spaceships
(
	id int primary key auto_increment,
    name varchar(50) not null,
    manufacturer varchar(30) not null,
    light_speed_rate int default 0
);

-- colonists
create table colonists
(
	id int primary key auto_increment,
    first_name varchar(20) not null,
    last_name varchar(30) not null,
    ucn varchar(10) not null unique, 
    birth_date date not null,
    constraint check_ucn 
		check (length(ucn)=10)
);

-- journeys
create table journeys
(
	id int primary key auto_increment,
    journey_start datetime not null,
    journey_end datetime not null,
    purpose varchar(11) not null,
    destination_spaceport_id int not null,
    spaceship_id int not null,
    constraint check_purpose
		check(purpose in ('Medical', 'Technical', 'Educational', 'Military')),
    constraint fk_journeys_spaceports
		foreign key(destination_spaceport_id)
        references spaceports (id),
	constraint fk_journeys_spaceships
		foreign key (spaceship_id)
        references spaceships (id)
);

-- travel_cards
create table travel_cards
(
	id int primary key auto_increment,
    card_number varchar(10) not null unique,
    job_during_journey varchar(8) not null,
    colonist_id int not null,
    journey_id int not null,
    constraint check_card_number
		check (length(card_number)=10),
	constraint check_job_during_journey
		check (job_during_journey in ('Pilot', 'Engineer', 'Trooper', 'Cleaner', 'Cook')),
    constraint fk_travel_cards_colonists
		foreign key (colonist_id)
        references colonists(id),
	constraint fk_travel_cards_journeys
		foreign key (journey_id)
        references journeys(id)
);

