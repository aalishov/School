-- Query for soft_uni
use soft_uni;

-- Problem 1.	Адрес на служител
select e.employee_id, e.job_title, a.address_id,a.address_text
from employees as e
join addresses as a on e.address_id=a.address_id;

-- Problem 2.	Служител по продажбите
select e.employee_id, e.first_name, e.last_name, d.name
from employees as e
join departments as d on e.department_id=d.department_id
where d.name='Sales'
order by e.employee_id desc;

-- Problem 3.	Служебни отдели
select e.employee_id, e.first_name, e.salary, d.name
from employees as e
join departments as d 
	on e.department_id=d.department_id
where e.salary>15000
order by d.department_id desc
limit	5;

-- Problem 4.	Служители без проект

select e.employee_id, e.first_name 
from employees as e
where  employee_id not in 
	(
		select employee_id from employees_projects
	)
order by employee_id desc
limit 3;
    
-- Problem 5.	Мениджър на служителите
select e.employee_id,e.first_name,e.manager_id,m.first_name 
from employees as e
join employees as m on m.employee_id=e.manager_id
where e.manager_id in (3,7);

-- Problem 6.	Минимална заплата
select e.salary, d.name 
from employees as e
join departments as d 
	on e.department_id=d.department_id
order by salary asc 
limit 1;

-- Query for geography
use geography;

-- Problem 7.	Държави без планини
select country_name from countries
where country_code not in
	(
		select distinct(country_code) 
		from mountains_countries
    );

