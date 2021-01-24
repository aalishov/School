use colonial_journey_management_system_db;

-- 05. Извлечете всички карти за пътуване
select card_number, job_during_journey
from travel_cards
order by card_number;

-- 06. Извлечете всички колонисти
select id, concat(first_name,' ', last_name) as 'full_name', ucn
from colonists
order by first_name, last_name, id;

-- 07. Извлечете всички военни пътувания
select id, journey_start, journey_end from journeys
where purpose='Military'
order by journey_start;

-- 08. Извлечете всички пилоти
select c.id, concat(first_name,' ', last_name) as 'full_name' from colonists as  c
join travel_cards as tc
	on tc.colonist_id=c.id
where job_during_journey='Pilot'
order by c.id;

-- 09. Изтеглете най-бързия космически кораб
select s.name as 'spaceship_name',sp.name as 'spaceport_name' from spaceships as s
join journeys as j
	on j.spaceship_id=s.id
join spaceports as sp
	on sp.id=j.destination_spaceport_id
order by s.light_speed_rate desc
limit 1;

-- 10. Извлечете всички образователни мисии и космически кораби
select p.name as 'planet_name', sp.name as 'spaceport_name' from planets  as p
join spaceports as sp
	on p.id=sp.planet_id
join journeys as j
	on j.destination_spaceport_id=sp.id
where purpose='Educational'
order by sp.name desc;

-- 11. Извлечете всички планети и тяхното пътуване
select p.name as 'planet_name', count(p.id ) as 'journeys_count'  from planets  as p
join spaceports as sp
	on p.id=sp.planet_id
join journeys as j
	on j.destination_spaceport_id=sp.id
group by sp.planet_id
order by count(p.id ) desc