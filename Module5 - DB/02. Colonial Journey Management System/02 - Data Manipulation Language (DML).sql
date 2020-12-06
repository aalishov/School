-- 2.   Data Manipulation Language (DML) – 30 pts
use colonial_journey_management_system_db;

-- 3.    Вмъкване на данни
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (96, '1994191458', 'Pilot', 96, 1);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (97, '1981222886', 'Engineer', 97, 2);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (98, '1970090435', 'Pilot', 98, 9);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (99, '1963018580', 'Cook', 99, 5);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (100, '1967015685', 'Pilot', 100, 1);

-- 4.    Обновяване на данни
select * from journeys
where id mod 2 =  0;

update journeys 
set purpose = 'Medical'
where id mod 2 =  0;