use soft_uni;

-- Problem 1.	Най-ниско платени служители
select first_name, last_name, salary
from employees
where salary IN 
	(
		select salary
        from employees
        order by salary asc
    )
order by salary asc
limit 3;


-- Problem 2.	Служители с близки до най-ниските заплати
select employee_id, first_name, last_name, salary
from employees
where salary <
	(
		select salary
        from employees
        order by salary asc
        limit 1
    )*1.1
order by salary asc;

-- Problem 3.	Всички мениджъри
select first_name, last_name, job_title 
from employees
where employee_id in 
	(
		select distinct(manager_id)
		from employees 
        where manager_id is not null
    )
order by first_name asc, last_name  asc;

-- Problem 4.	Служителите от San Francisco
select employee_id, concat(first_name,' ',last_name) as 'Full name' 
from employees
where address_id in (
	select address_id from addresses
	where town_id = (
		select town_id from towns
		where name ='San Francisco'
    ));
-- Вариант 2
select employee_id, concat(first_name,' ',last_name) as 'Full name'
from employees as e
join addresses as a on e.address_id=a.address_id
join towns as t on a.town_id=t.town_id
where t.name='San Francisco'


