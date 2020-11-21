-- Part I – Заявки към БД SoftUni
use soft_uni;

-- Problem 2.	Намерете цялата информация за отделите
select * from departments;

-- Problem 3.	Намерете всички имена на отдели
select name from departments;

-- Problem 4.	Намерете заплатата на всеки служител
select first_name, last_name, salary from	employees;

-- Problem 5.	Намерете пълното име на всеки служител
select first_name, middle_name, last_name from	employees;

-- Problem 6.	Намерете имейл адреса на всеки служител
select concat(first_name,'.',last_name,'@softuni.bg') as 'full_email_address' from employees;

-- Problem 7.	Намерете всички различни работни заплати
select distinct(salary) from employees 
order by salary;

-- Problem 8.	Намерете цялата информация за служители
select employee_id as 'id',
	first_name as 'First Name',
    last_name as 'Last Name',
    middle_name as 'Middle Name',
    job_title as 'Job Title',
    department_id as 'Dept Id',
    manager_id  as 'MngrID',
    hire_date as 'Hire Date',
    salary as 'Salary',
    address_id as 'Address'
from employees;

-- Problem 9.	Намерете имената на всички служители със заплата в диапазон
select first_name, last_name, job_title as 'JobTitle'
from employees
where salary between 20000 and 30000;

-- Problem 10.	 Намерете имената на всички служители
select concat(first_name,' ',middle_name,' ',last_name) as 'full_name'
from employees
where salary in (25000,14000, 12500, 23600);

-- Problem 11.	 Намерете всички служители без мениджър
select first_name, last_name 
from employees
where manager_id is null;

-- Problem 12.	 Намерете всички служители със заплата повече от 50000
select   first_name, last_name , salary 
from employees
where salary>50000
order by salary desc;

-- Problem 13.	 Намете 5 най-добре платени служителя
select first_name, last_name
from employees
order by salary desc
limit 5;

-- Problem 14.	Намерете всички служители, които не са от отдел Marketing 
select first_name, last_name
from employees
where department_id not in(select department_id from departments where name='Marketing');

-- Problem 15.	Различни длъжности
select distinct(job_title) from employees
order by job_title;

-- Problem 16.	Намерете първите 10 започнати проекти
select * from projects
order by start_date asc, name asc
limit 10;

-- Problem 17.	 Последните 7 наети служители
select first_name, last_name, hire_date from employees
order by hire_date desc
limit 7;

-- Problem 18.	Увеличаване на заплати
update employees as e
set e.salary=e.salary*1.12
where department_id in (
		select department_id 
        from departments 
        where name in('Engineering','Tool Design','Marketing','Information Services')
);

select first_name, salary, department_id from employees
where department_id in (
		select department_id 
        from departments 
        where name in('Engineering','Tool Design','Marketing','Information Services'))
order by salary ;




