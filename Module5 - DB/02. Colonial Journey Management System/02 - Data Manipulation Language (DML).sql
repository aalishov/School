-- 2.   Data Manipulation Language (DML) – 30 pts
use colonial_journey_management_system_db;

-- 3.    Вмъкване на данни
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (96, '1994191458', 'Pilot', 96, 1);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (97, '1981222886', 'Engineer', 97, 2);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (98, '1970090435', 'Pilot', 98, 9);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (99, '1963018580', 'Cook', 99, 5);
insert into travel_cards (id, card_number, job_during_journey, colonist_id, journey_id) values (100, '1967015685', 'Pilot', 100, 1);

-- 3.    Вмъкване на данни v2
INSERT INTO travel_cards(card_number, job_during_journey, colonist_id, journey_id)
    SELECT
      (
        CASE
          WHEN c.birth_date > '1980-01-01' THEN concat_ws('', year(c.birth_date), day(c.birth_date), substr(c.ucn, 1, 4))
          ELSE concat_ws('', year(c.birth_date), month(c.birth_date), substr(c.ucn, 7, 10))
        END
      ) AS card_number,
      (
        CASE
          WHEN c.id % 2 = 0 THEN 'Pilot'
          WHEN c.id % 3 = 0 THEN 'Cook'
          ELSE 'Engineer'
        END
      ) AS job_during_journey,
      c.id,
      (
        substr(c.ucn, 1,1)
      ) AS journey_id
    FROM colonists c
    WHERE c.id between 96 AND 100;

-- 4.    Обновяване на данни
UPDATE journeys
  SET purpose = (
      CASE
          WHEN id % 2 = 0 THEN 'Medical'
          WHEN id % 3 = 0 THEN 'Technical'
          WHEN id % 5 = 0 THEN 'Educational'
          WHEN id % 7 = 0 THEN 'Military'
          ELSE purpose
      END
  );

-- 4.    Обновяване на данни v2

-- Ако id-то на пътуването е делим на 2 без остатък – ‘Medical’.
select * from journeys
where id mod 2 =  0;

update journeys 
set purpose = 'Medical'
where id mod 2 =  0;
-- Ако id-то на пътуването е делим на 3 без остатък – ‘Technical’.
select * from journeys
where id mod 3 =  0;

update journeys 
set purpose = 'Technical'
where id mod 3 =  0;
-- Ако id-то на пътуването е делим на 5 без остатък – ‘Educational’.
select * from journeys
where id mod 5 =  0;

update journeys 
set purpose = 'Educational'
where id mod 5 =  0;
-- Ако id-то на пътуването е делим на 7 без остатък – ‘Military’.
select * from journeys
where id mod 7 =  0;

update journeys 
set purpose = 'Military'
where id mod 7 =  0;

-- 5.    Изтриване на данни
delete from colonists
where id not in(select colonist_id from travel_cards);



