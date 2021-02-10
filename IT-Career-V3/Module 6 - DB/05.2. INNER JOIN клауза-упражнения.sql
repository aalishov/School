use soft_uni;

-- Problem 1.	Адреси с градове
select first_name, last_name, t.name as town, a.address_text 
from employees as e
join addresses as a on a.address_id=e.address_id
join towns as t on a.town_id=t.town_id
order by first_name, last_name
limit 5;

-- Problem 2.	Служители, наети по-късно
select first_name, last_name, hire_date, d.name
from employees as e
join departments as d on d.department_id=e.department_id
where hire_date>1/1/1999 and d.name in('Finance','Sales')
order by hire_date;

-- Problem 3.	Служители с проект
select e.employee_id, first_name, p.name 
from employees as e
join employees_projects as ep on ep.employee_id=e.employee_id
join projects as p on p.project_id=ep.project_id
where p.start_date>13/08/2002 and end_date is null
order by first_name,p.name
limit 5;

-- Problem 4.	Резюме на служителите
select e.employee_id,
	concat(e.first_name,' ',e.last_name) as 'employee_name',
	m.first_name as 'manager_name',
    d.name  as 'department_name'
from employees as e
join employees as m on e.manager_id=m.employee_id
join departments as d on d.department_id=e.department_id
order by e.employee_id
limit 5;

use geography;

-- Problem 5.	Най-високи върхове в България
select c.country_code, m.mountain_range,p.peak_name,p.elevation
from countries as c
join mountains_countries as mc on mc.country_code=c.country_code
join mountains as m on m.id=mc.mountain_id
join peaks as p on p.mountain_id=m.id
where c.country_code ='BG' and p.elevation>2835
order by elevation DESC;

-- Problem 6.	Планински вериги

select c.country_code,c.country_name, m.mountain_range
from countries as c
join mountains_countries as mc on mc.country_code=c.country_code
join mountains as m on m.id=mc.mountain_id
where c.country_code in ('BG','RU','US') 
order by country_code, mountain_range;

